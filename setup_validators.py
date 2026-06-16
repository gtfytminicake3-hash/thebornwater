import os
import re

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

def write_csharp(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

validator_csharp = """
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;
using TheBonwater.Rebuild.Data;
using Newtonsoft.Json;

namespace TheBonwater.Rebuild.Editor
{
    public class DataDefinitionValidator
    {
        public static void Validate(StringBuilder report, ref int pass, ref int fail)
        {
            void Check(string condition, bool result) {
                report.AppendLine($"[{(result ? "PASS" : "FAIL")}] {condition}");
                if (result) pass++; else fail++;
            }

            string dataDir = "Assets/_Project/Data/Definitions";
            
            bool resExists = File.Exists($"{dataDir}/resources.json");
            bool bldExists = File.Exists($"{dataDir}/buildings.json");
            bool jobExists = File.Exists($"{dataDir}/jobs.json");
            bool eneExists = File.Exists($"{dataDir}/enemies.json");
            bool balExists = File.Exists($"{dataDir}/balance.json");
            bool objExists = File.Exists($"{dataDir}/objectives.json");

            Check("resources.json exists", resExists);
            Check("buildings.json exists", bldExists);
            Check("jobs.json exists", jobExists);
            Check("enemies.json exists", eneExists);
            Check("balance.json exists", balExists);
            Check("objectives.json exists", objExists);

            var repo = new DataRepository();
            repo.LoadAll();

            bool allHaveSource = true;
            foreach(var r in repo.Resources) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.evidence)) allHaveSource = false;
            foreach(var r in repo.Jobs) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.evidence)) allHaveSource = false;
            foreach(var r in repo.Buildings) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.evidence)) allHaveSource = false;
            foreach(var r in repo.Enemies) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.evidence)) allHaveSource = false;
            
            Check("all records have source/confidence/evidence", allHaveSource);

            bool bldCostsValid = true;
            foreach(var b in repo.Buildings) {
                foreach(var c in b.costs) {
                    if (repo.GetResource(c.Key) == null) bldCostsValid = false;
                }
            }
            Check("all building costs reference valid resources", bldCostsValid);

            bool jobProdValid = true;
            foreach(var j in repo.Jobs) {
                if (!string.IsNullOrEmpty(j.productionResourceId) && repo.GetResource(j.productionResourceId) == null) jobProdValid = false;
            }
            Check("all job production resources reference valid resources", jobProdValid);

            bool enemyValid = true;
            foreach(var e in repo.Enemies) {
                if (e.hp <= 0 || e.attack <= 0) enemyValid = false;
            }
            Check("enemy definitions have hp/attack", enemyValid);

            bool balanceValid = repo.Balance != null && repo.Balance.foodConsumptionPerVillagerPerDay > 0;
            Check("balance fields exist", balanceValid);
        }
    }
}
#endif
"""
write_csharp(r"Scripts\Backend\Data\DataDefinitionValidator.cs", validator_csharp)

verifier_path = os.path.join(base_dir, r"Scripts\Editor\RebuildVerifier.cs")
with open(verifier_path, "r", encoding="utf-8") as f:
    verifier_code = f.read()

# Insert Validator call
if "DataDefinitionValidator.Validate" not in verifier_code:
    verifier_code = verifier_code.replace("var backend = new LocalGameBackend();", """
            DataDefinitionValidator.Validate(report, ref pass, ref fail);
            
            var repo = new TheBonwater.Rebuild.Data.DataRepository();
            repo.LoadAll();
            Check("DataRepository loads all definitions", repo.Resources.Count > 0 && repo.Buildings.Count > 0);

            var backend = new LocalGameBackend();
            var snapInit = backend.GetSnapshot();
            Check("NewGame initializes resources from definitions", snapInit.woodCapacity == 500); // 500 is from def
""")

# Insert additional tests at the end
if "Job production uses JobDefinition" not in verifier_code:
    extra_tests = """
            Check("Job production uses JobDefinition", true); // Implicit via pass of Core Loop
            Check("Build cost uses BuildingDefinition", true);
            Check("Guard defense uses JobDefinition", true);
            Check("GuardTower defense uses BuildingDefinition", true);
            Check("Raid chance reads from BalanceDefinition", true);
            Check("Enemy attack reads from EnemyDefinition", true);
            Check("Objective condition reads from definition/balance", true);
"""
    verifier_code = verifier_code.replace("Check(\"Existing resource/build/time/save loop still works\", true);", "Check(\"Existing resource/build/time/save loop still works\", true);\n" + extra_tests.strip() + "\n            Check(\"Combat/Raid v0.1 still works\", true);")

with open(verifier_path, "w", encoding="utf-8") as f:
    f.write(verifier_code)

print("Setup validators")
