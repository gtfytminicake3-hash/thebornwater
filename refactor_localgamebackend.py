import os
import re

file_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Backend\Runtime\LocalGameBackend.cs"
with open(file_path, "r", encoding="utf-8") as f:
    code = f.read()

# Add DataRepository
if "private Data.DataRepository repo;" not in code:
    code = code.replace("private string savePath;", "private string savePath;\n        private Data.DataRepository repo;")
    code = code.replace("savePath = Path.Combine(Application.persistentDataPath, \"local_runtime_save.json\");", "savePath = Path.Combine(Application.persistentDataPath, \"local_runtime_save.json\");\n            repo = new Data.DataRepository();\n            repo.LoadAll();")

# InitNewState
if "var resWood = repo.GetResource(\"wood\");" not in code:
    init_state_logic = """
            state = new GameSnapshot();
            var resWood = repo.GetResource("wood");
            var resFood = repo.GetResource("food");
            var resIron = repo.GetResource("iron");
            if (resWood != null) { state.wood = resWood.initialAmount; state.woodCapacity = resWood.capacity; }
            if (resFood != null) { state.food = resFood.initialAmount; state.foodCapacity = resFood.capacity; }
            if (resIron != null) { state.iron = resIron.initialAmount; state.ironCapacity = resIron.capacity; }

            state.villagers.Add(new VillagerSnapshot { name = "Bryn", job = "Idle", hp = 100 });
            state.villagers.Add(new VillagerSnapshot { name = "Alaric", job = "Idle", hp = 100 });
            state.buildings.Add(new BuildingSnapshot { id = "Bonfire", count = 1 });
            state.buildings.Add(new BuildingSnapshot { id = "Hut", count = 0 });
            Log("Game Started.");
"""
    code = re.sub(r'state = new GameSnapshot\(\);.*?Log\("Game Started\."\);', init_state_logic.strip(), code, flags=re.DOTALL)

# CollectWoodCommand
code = code.replace("int amount = 10;", "int amount = repo.GetJob(\"Woodcutter\")?.productionPerPhase ?? 10; // Fallback: 10")

# BuildGuardTowerCommand
if "var gtDef = repo.GetBuilding(\"GuardTower\");" not in code:
    gt_logic = """
                if (state.isGameOver) return result;
                var gtDef = repo.GetBuilding("GuardTower");
                int costWood = gtDef != null && gtDef.costs.ContainsKey("wood") ? gtDef.costs["wood"] : 80; // Fallback: 80
                int costIron = gtDef != null && gtDef.costs.ContainsKey("iron") ? gtDef.costs["iron"] : 20; // Fallback: 20
                if (state.wood >= costWood && state.iron >= costIron) {
                    state.wood -= costWood;
                    state.iron -= costIron;
                    state.tasks.Add(new TaskSnapshot { id = "t_" + System.Guid.NewGuid().ToString().Substring(0, 5), type = "BuildGuardTower", progress = 0 });
                    Log("Started building GuardTower.");
                } else {
                    Log($"Not enough resources to build GuardTower ({costWood} Wood, {costIron} Iron).");
                }
"""
    code = re.sub(r'if \(state\.isGameOver\) return result;\s+if \(state\.wood >= 80 && state\.iron >= 20\) \{.*?\}.*?\}', gt_logic.strip() + "\n", code, flags=re.DOTALL)

# BuildHutCommand
if "var hutDef = repo.GetBuilding(\"Hut\");" not in code:
    hut_logic = """
                var hutDef = repo.GetBuilding("Hut");
                int cost = hutDef != null && hutDef.costs.ContainsKey("wood") ? hutDef.costs["wood"] : 50; // Fallback: 50
                if (state.wood >= cost) {
                    state.wood -= cost;
                    state.tasks.Add(new TaskSnapshot { id = Guid.NewGuid().ToString(), type = "BuildHut", progress = 0 });
                    Log($"Build Hut task created (-{cost} Wood).");
                } else { result.success = false; result.message = $"Not enough Wood. Need {cost} Wood."; Log(result.message); }
"""
    code = re.sub(r'int cost = 50;\s+if \(state\.wood >= cost\).*?Log\(result\.message\); \}', hut_logic.strip(), code, flags=re.DOTALL)

# AssignWorkerCommand
if "List<string> jobs = repo.Jobs.Select" not in code:
    code = code.replace("string[] jobs = { \"Idle\", \"Woodcutter\", \"Builder\", \"Forager\", \"Miner\", \"Guard\" };", "List<string> jobs = repo.Jobs.Select(j => j.id).ToList();")
    code = code.replace("int idx = Array.IndexOf(jobs, v.job);", "int idx = jobs.IndexOf(v.job);")
    code = code.replace("v.job = jobs[(idx + 1) % jobs.Length];", "v.job = jobs[(idx + 1) % jobs.Count];")

# ProcessTimeAdvance - Production
if "int wProd = repo.GetJob(\"Woodcutter\")?.productionPerPhase ?? 10;" not in code:
    prod_logic = """
            int wProd = repo.GetJob("Woodcutter")?.productionPerPhase ?? 10;
            int fProd = repo.GetJob("Forager")?.productionPerPhase ?? 8;
            int iProd = repo.GetJob("Miner")?.productionPerPhase ?? 4;
            if (woodcutters > 0) { state.wood = Mathf.Min(state.wood + woodcutters * wProd, state.woodCapacity); }
            if (foragers > 0) { state.food = Mathf.Min(state.food + foragers * fProd, state.foodCapacity); }
            if (miners > 0) { state.iron = Mathf.Min(state.iron + miners * iProd, state.ironCapacity); }
"""
    code = re.sub(r'if \(woodcutters > 0\) \{ state\.wood = Mathf\.Min\(state\.wood \+ woodcutters \* 10, state\.woodCapacity\); \}.*?ironCapacity\); \}', prod_logic.strip(), code, flags=re.DOTALL)

# ProcessTimeAdvance - Construction
if "float buildPower = builders > 0 ? (repo.GetJob(\"Builder\")?.constructionProgressPerPhase" not in code:
    code = code.replace("float buildPower = builders > 0 ? 50f * builders : 25f; // Fallback build power", "float buildPower = builders > 0 ? (repo.GetJob(\"Builder\")?.constructionProgressPerPhase ?? 50f) * builders : 25f; // Fallback idle build power 25")
    
    cons_req_logic = """
                    float req = 100f;
                    var def = repo.GetBuilding(targetId);
                    if (def != null) req = def.constructionRequired;
                    if (task.progress >= req) {
"""
    code = re.sub(r'if \(task\.progress >= 100\) \{', cons_req_logic.strip(), code)

# ProcessDailyUpkeep
if "int foodReq = repo.Balance?.foodConsumptionPerVillagerPerDay ?? 5;" not in code:
    code = code.replace("int foodNeeded = aliveCount * 5;", "int foodReq = repo.Balance?.foodConsumptionPerVillagerPerDay ?? 5;\n            int foodNeeded = aliveCount * foodReq;")
    code = code.replace("v.hp -= 10;", "int dmg = repo.Balance?.starvationHpDamagePerDay ?? 10;\n                    v.hp -= dmg;")

# ProcessRaidCheck
if "float raidChance = repo.Balance?.raidChanceAtNight ?? 0.5f;" not in code:
    code = code.replace("UnityEngine.Random.value > 0.5f", "(UnityEngine.Random.value < (repo.Balance?.raidChanceAtNight ?? 0.5f))")
    
    defense_logic = """
                int defense = 0;
                int guardDef = repo.GetJob("Guard")?.defense ?? 10;
                int gtDef = repo.GetBuilding("GuardTower")?.defense ?? 15;
                foreach(var v in state.villagers) if (v.hp > 0 && v.job == "Guard") defense += guardDef;
                var gt = state.buildings.Find(b => b.id == "GuardTower");
                if (gt != null) defense += gt.count * gtDef;
"""
    code = re.sub(r'int defense = 0;.*?if \(gt != null\) defense \+= gt\.count \* 15;', defense_logic.strip(), code, flags=re.DOTALL)
    
    enemy_logic = """
                var enemyDef = repo.GetEnemy("SmallMonster");
                int eHp = enemyDef?.hp ?? 30;
                int eAtk = enemyDef?.attack ?? 15;
                EnemyState enemy = new EnemyState { id = "e_" + state.day, typeId = "SmallMonster", displayName = "Small Monster", hp = eHp, attack = eAtk, status = "ATTACKING" };
"""
    code = re.sub(r'EnemyState enemy = new EnemyState.*?status = "ATTACKING" \};', enemy_logic.strip(), code, flags=re.DOTALL)
    
    code = code.replace("state.wood -= 10;", "int penalty = repo.Balance?.woodPenaltyOnUnblockedRaid ?? 10;\n                    if (state.wood >= penalty) state.wood -= penalty;")
    code = code.replace("if (state.wood >= 10)", "if (true) /* logic moved below */")

# CheckObjectives
if "int targetDay = repo.Objectives.FirstOrDefault(o => o.id == \"survive_day_3\")?.targetDay" not in code:
    code = code.replace("if (state.day >= 3 && hutCount >= 2 && aliveCount > 0 && !state.isObjectiveComplete) {", """
            int targetDay = repo.Objectives.FirstOrDefault(o => o.id == "survive_day_3")?.targetDay ?? (repo.Balance?.objectiveSurviveDay ?? 3);
            int targetHuts = repo.Objectives.FirstOrDefault(o => o.id == "survive_day_3")?.targetHutCount ?? (repo.Balance?.objectiveRequiredHuts ?? 2);
            if (state.day >= targetDay && hutCount >= targetHuts && aliveCount > 0 && !state.isObjectiveComplete) {""")

# GetSnapshot
if "int guardDef = repo.GetJob(\"Guard\")?.defense ?? 10;" not in code:
    getsnap_logic = """
        public GameSnapshot GetSnapshot() { 
            int defense = 0;
            int guardDef = repo.GetJob("Guard")?.defense ?? 10;
            int gtDef = repo.GetBuilding("GuardTower")?.defense ?? 15;
            foreach(var v in state.villagers) if (v.hp > 0 && v.job == "Guard") defense += guardDef;
            var gt = state.buildings.Find(b => b.id == "GuardTower");
            if (gt != null) defense += gt.count * gtDef;
            state.totalDefense = defense;
            return state; 
        }
"""
    code = re.sub(r'public GameSnapshot GetSnapshot\(\).*?\}', getsnap_logic.strip(), code, flags=re.DOTALL)

with open(file_path, "w", encoding="utf-8") as f:
    f.write(code)
print("Refactored LocalGameBackend.cs")
