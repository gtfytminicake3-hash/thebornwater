import os
import json

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

def write_json(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        json.dump(content, f, indent=2)

def write_csharp(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

# 1. Create Data Definitions
resources = [
    {"id": "wood", "displayName": "Wood", "initialAmount": 100, "capacity": 500, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "ResourceData / ResourceInstance"},
    {"id": "food", "displayName": "Food", "initialAmount": 80, "capacity": 200, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "ResourceData / ResourceInstance"},
    {"id": "iron", "displayName": "Iron", "initialAmount": 0, "capacity": 100, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "ResourceData / ResourceInstance"}
]
write_json(r"Data\Definitions\resources.json", resources)

jobs = [
    {"id": "Idle", "displayName": "Idle", "productionResourceId": "", "productionPerPhase": 0, "constructionProgressPerPhase": 0, "defense": 0, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "JobData"},
    {"id": "Woodcutter", "displayName": "Woodcutter", "productionResourceId": "wood", "productionPerPhase": 10, "constructionProgressPerPhase": 0, "defense": 0, "source": "il2cpp_dump", "confidence": "MEDIUM", "evidence": "JobData / CharacterManager / ResourceProductionBuilding"},
    {"id": "Forager", "displayName": "Forager", "productionResourceId": "food", "productionPerPhase": 8, "constructionProgressPerPhase": 0, "defense": 0, "source": "il2cpp_dump", "confidence": "MEDIUM", "evidence": "JobData / CharacterManager"},
    {"id": "Miner", "displayName": "Miner", "productionResourceId": "iron", "productionPerPhase": 4, "constructionProgressPerPhase": 0, "defense": 0, "source": "il2cpp_dump", "confidence": "MEDIUM", "evidence": "JobData / CharacterManager"},
    {"id": "Builder", "displayName": "Builder", "productionResourceId": "", "productionPerPhase": 0, "constructionProgressPerPhase": 50, "defense": 0, "source": "il2cpp_dump", "confidence": "MEDIUM", "evidence": "JobData / OccupantsBuildingUI"},
    {"id": "Guard", "displayName": "Guard", "productionResourceId": "", "productionPerPhase": 0, "constructionProgressPerPhase": 0, "defense": 10, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "JobData / GuardTower logic"}
]
write_json(r"Data\Definitions\jobs.json", jobs)

buildings = [
    {"id": "Bonfire", "displayName": "Bonfire", "costs": {"wood": 0}, "constructionRequired": 0, "housingBonus": 0, "capacityBonus": 0, "defense": 0, "countsForObjective": False, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "BonfireBuilding"},
    {"id": "Hut", "displayName": "Hut", "costs": {"wood": 50}, "constructionRequired": 100, "housingBonus": 3, "capacityBonus": 0, "defense": 0, "countsForObjective": True, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "HutBuilding"},
    {"id": "Storage", "displayName": "Storage", "costs": {"wood": 20}, "constructionRequired": 50, "housingBonus": 0, "capacityBonus": 100, "defense": 0, "countsForObjective": False, "source": "il2cpp_dump", "confidence": "MEDIUM", "evidence": "Storage / ResourceInstance"},
    {"id": "GuardTower", "displayName": "Guard Tower", "costs": {"wood": 80, "iron": 20}, "constructionRequired": 100, "housingBonus": 0, "capacityBonus": 0, "defense": 15, "countsForObjective": False, "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "GuardTower"}
]
write_json(r"Data\Definitions\buildings.json", buildings)

enemies = [
    {"id": "SmallMonster", "displayName": "Small Monster", "hp": 30, "attack": 15, "raidWeight": 1, "source": "il2cpp_dump", "confidence": "MEDIUM", "evidence": "MonsterManager / SpawnTitan"}
]
write_json(r"Data\Definitions\enemies.json", enemies)

balance = {
    "foodConsumptionPerVillagerPerDay": 5,
    "starvationHpDamagePerDay": 10,
    "raidChanceAtNight": 0.5,
    "woodPenaltyOnUnblockedRaid": 10,
    "objectiveSurviveDay": 3,
    "objectiveRequiredHuts": 2,
    "source": "prototype_fallback",
    "confidence": "LOW",
    "evidence": "Manually balanced based on prototype gameplay loop since ScriptableObjects are not extracted yet."
}
write_json(r"Data\Definitions\balance.json", balance)

objectives = [
    {"id": "survive_day_3", "displayName": "Survive Day 3 and build 2 huts", "targetDay": 3, "targetHutCount": 2, "source": "prototype_fallback", "confidence": "LOW", "evidence": "Objective defined in early prototype"}
]
write_json(r"Data\Definitions\objectives.json", objectives)


# 2. C# Classes for DataRepository

models_csharp = """
using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild.Data
{
    [Serializable]
    public class DefinitionBase {
        public string id;
        public string displayName;
        public string source;
        public string confidence;
        public string evidence;
    }

    [Serializable]
    public class ResourceDefinition : DefinitionBase {
        public int initialAmount;
        public int capacity;
    }

    [Serializable]
    public class JobDefinition : DefinitionBase {
        public string productionResourceId;
        public int productionPerPhase;
        public int constructionProgressPerPhase;
        public int defense;
    }

    [Serializable]
    public class BuildingCost {
        public string resourceId;
        public int amount;
    }

    [Serializable]
    public class BuildingDefinition : DefinitionBase {
        public Dictionary<string, int> costs = new Dictionary<string, int>();
        public int constructionRequired;
        public int housingBonus;
        public int capacityBonus;
        public int defense;
        public bool countsForObjective;
    }

    [Serializable]
    public class EnemyDefinition : DefinitionBase {
        public int hp;
        public int attack;
        public float raidWeight;
    }

    [Serializable]
    public class BalanceDefinition {
        public int foodConsumptionPerVillagerPerDay;
        public int starvationHpDamagePerDay;
        public float raidChanceAtNight;
        public int woodPenaltyOnUnblockedRaid;
        public int objectiveSurviveDay;
        public int objectiveRequiredHuts;
        public string source;
        public string confidence;
        public string evidence;
    }

    [Serializable]
    public class ObjectiveDefinition : DefinitionBase {
        public int targetDay;
        public int targetHutCount;
    }
}
"""
write_csharp(r"Scripts\Backend\Data\Definitions.cs", models_csharp)

repository_csharp = """
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;
using Newtonsoft.Json;

namespace TheBonwater.Rebuild.Data
{
    public class DataRepository
    {
        public List<ResourceDefinition> Resources { get; private set; } = new List<ResourceDefinition>();
        public List<JobDefinition> Jobs { get; private set; } = new List<JobDefinition>();
        public List<BuildingDefinition> Buildings { get; private set; } = new List<BuildingDefinition>();
        public List<EnemyDefinition> Enemies { get; private set; } = new List<EnemyDefinition>();
        public BalanceDefinition Balance { get; private set; }
        public List<ObjectiveDefinition> Objectives { get; private set; } = new List<ObjectiveDefinition>();

        private string LoadJson(string filename)
        {
            string path = Path.Combine(Application.dataPath, "_Project/Data/Definitions", filename);
            if (File.Exists(path)) return File.ReadAllText(path);
            return null;
        }

        public void LoadAll()
        {
            string resJson = LoadJson("resources.json");
            if (resJson != null) Resources = JsonConvert.DeserializeObject<List<ResourceDefinition>>(resJson);

            string jobsJson = LoadJson("jobs.json");
            if (jobsJson != null) Jobs = JsonConvert.DeserializeObject<List<JobDefinition>>(jobsJson);

            string bldJson = LoadJson("buildings.json");
            if (bldJson != null) Buildings = JsonConvert.DeserializeObject<List<BuildingDefinition>>(bldJson);

            string eneJson = LoadJson("enemies.json");
            if (eneJson != null) Enemies = JsonConvert.DeserializeObject<List<EnemyDefinition>>(eneJson);

            string balJson = LoadJson("balance.json");
            if (balJson != null) Balance = JsonConvert.DeserializeObject<BalanceDefinition>(balJson);

            string objJson = LoadJson("objectives.json");
            if (objJson != null) Objectives = JsonConvert.DeserializeObject<List<ObjectiveDefinition>>(objJson);
        }

        public ResourceDefinition GetResource(string id) => Resources.FirstOrDefault(r => r.id == id);
        public JobDefinition GetJob(string id) => Jobs.FirstOrDefault(j => j.id == id);
        public BuildingDefinition GetBuilding(string id) => Buildings.FirstOrDefault(b => b.id == id);
        public EnemyDefinition GetEnemy(string id) => Enemies.FirstOrDefault(e => e.id == id);
    }
}
"""
write_csharp(r"Scripts\Backend\Data\DataRepository.cs", repository_csharp)

print("Scaffolded definitions and DataRepository")
