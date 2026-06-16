#if UNITY_EDITOR
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
            int p = 0;
            int f = 0;

            void CheckLocal(string condition, bool result) {
                report.AppendLine($"[{(result ? "PASS" : "FAIL")}] {condition}");
                if (result) p++; else f++;
            }

            string dataDir = "Assets/_Project/Data/Definitions";
            
            bool resExists = File.Exists($"{dataDir}/resources.json");
            bool bldExists = File.Exists($"{dataDir}/buildings.json");
            bool jobExists = File.Exists($"{dataDir}/jobs.json");
            bool eneExists = File.Exists($"{dataDir}/enemies.json");
            bool balExists = File.Exists($"{dataDir}/balance.json");
            bool objExists = File.Exists($"{dataDir}/objectives.json");

            CheckLocal("resources.json exists", resExists);
            CheckLocal("buildings.json exists", bldExists);
            CheckLocal("jobs.json exists", jobExists);
            CheckLocal("enemies.json exists", eneExists);
            CheckLocal("balance.json exists", balExists);
            CheckLocal("objectives.json exists", objExists);

            var repo = new DataRepository();
            repo.LoadAll();

            bool allHaveSource = true;
            foreach(var r in repo.Resources) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.symbolEvidence)) allHaveSource = false;
            foreach(var r in repo.Jobs) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.symbolEvidence)) allHaveSource = false;
            foreach(var r in repo.Buildings) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.symbolEvidence)) allHaveSource = false;
            foreach(var r in repo.Enemies) if (string.IsNullOrEmpty(r.source) || string.IsNullOrEmpty(r.confidence) || string.IsNullOrEmpty(r.symbolEvidence)) allHaveSource = false;
            
            CheckLocal("all records have source/confidence/symbolEvidence", allHaveSource);

            bool bldCostsValid = true;
            foreach(var b in repo.Buildings) {
                foreach(var c in b.costs) {
                    if (repo.GetResource(c.Key) == null) bldCostsValid = false;
                }
            }
            CheckLocal("all building costs reference valid resources", bldCostsValid);

            bool jobProdValid = true;
            foreach(var j in repo.Jobs) {
                if (!string.IsNullOrEmpty(j.productionResourceId) && repo.GetResource(j.productionResourceId) == null) jobProdValid = false;
            }
            CheckLocal("all job production resources reference valid resources", jobProdValid);

            bool enemyValid = true;
            foreach(var e in repo.Enemies) {
                if (e.hp <= 0 || e.attack <= 0) enemyValid = false;
            }
            CheckLocal("enemy definitions have hp/attack", enemyValid);

            bool balanceValid = repo.Balance != null && repo.Balance.foodConsumptionPerVillagerPerDay > 0;
            CheckLocal("balance fields exist", balanceValid);

            pass += p;
            fail += f;
        }
    }
}
#endif
