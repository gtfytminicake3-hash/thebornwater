import os

# Update GameSnapshot.cs
gs_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Contracts\GameSnapshot.cs"
with open(gs_path, "r", encoding="utf-8") as f:
    gs_code = f.read()

# I need to ensure TaskSnapshot has the right fields.
# In a previous step I added requiredResources, depositedResources etc., but let's make sure it perfectly matches the new rules.
# Since the class structure might have old prototype math, let me just rewrite the entire GameSnapshot.cs file carefully.
new_gs_code = """using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    [Serializable]
    public class GameSnapshot {
        public int day = 1;
        public string timeOfDay = "Morning";
        public int wood;
        public int iron;
        public int food;
        public int woodCapacity = 250;
        public int ironCapacity = 250;
        public int foodCapacity = 100;
        
        public List<VillagerSnapshot> villagers = new List<VillagerSnapshot>();
        public List<BuildingSnapshot> buildings = new List<BuildingSnapshot>();
        public List<EnemyState> enemies = new List<EnemyState>();
        public List<TaskSnapshot> tasks = new List<TaskSnapshot>();
        
        public int totalDefense;
        public int consecutiveDaysWithoutFood;
        public bool isGameOver;
        public bool isObjectiveComplete;
        public string lastAction = "";
        public List<string> taskLogs = new List<string>();
        public int lastRaidDay = -1;
    }

    [Serializable]
    public class ResourceAmount {
        public string resourceId;
        public int amount;
    }

    [Serializable]
    public class TaskSnapshot {
        public string id;
        public string type;
        public string targetBuildingId;
        
        // Construction fields
        public string status; // "AwaitingResources", "UnderConstruction", "Completed"
        public List<ResourceAmount> requiredResources = new List<ResourceAmount>();
        public List<ResourceAmount> depositedResources = new List<ResourceAmount>();
        public bool isResourcesComplete;
        public int currentCompletion;
        public int finalCompletion;
        
        // Evidence classification
        public string fidelityClassification;
        public string finalCompletionEvidence = "UNKNOWN_OR_MISSING";
        public string finalCompletionSource = "UNKNOWN_OR_MISSING";
        public string depositSequenceEvidence = "UNKNOWN_DEPOSIT_SEQUENCE";
    }

    [Serializable]
    public class VillagerSnapshot {
        public string id;
        public string name;
        public string job;
        public int hp = 100;
    }

    [Serializable]
    public class BuildingSnapshot {
        public string id;
        public int count;
    }

    [Serializable]
    public class EnemyState {
        public string id;
        public string typeId;
        public string displayName;
        public int hp;
        public int attack;
        public string status;
    }
}
"""

with open(gs_path, "w", encoding="utf-8") as f:
    f.write(new_gs_code)


# Update LocalGameBackend.cs
lb_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Backend\Runtime\LocalGameBackend.cs"
with open(lb_path, "r", encoding="utf-8") as f:
    lb_code = f.read()

import re

# I will replace the ProcessCommand block. Wait, instead of fragile regex, I can rewrite the commands.
# Let's replace the Execute method for BuildHutCommand to NOT use ProcessTimeAdvance for auto-completion.
new_lb_code = """// Backend Reconstruction Notes:
// - Original evidence: ResourceData, BuildingData, JobData, SaveLoadUtility, DayNightController
// - Confidence: HIGH (Classes exist in IL2CPP dump)
// - Fallback logic: Task execution and specific balance numbers are fallback.
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class LocalGameBackend : IGameBackend {
        private GameSnapshot state;
        private string savePath;
        public Data.DataRepository repo { get; private set; }

        public LocalGameBackend() {
            savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            repo = new Data.DataRepository();
            repo.LoadAll();

            if (File.Exists(savePath)) {
                string json = File.ReadAllText(savePath);
                state = JsonUtility.FromJson<GameSnapshot>(json);
            } else {
                NewGame();
            }
        }

        private void NewGame() {
            state = new GameSnapshot();
            state.villagers.Add(new VillagerSnapshot { id = "v1", name = "Bryn", job = "Idle" });
            state.villagers.Add(new VillagerSnapshot { id = "v2", name = "Alaric", job = "Idle" });
            state.wood = repo.Balance?.startWood ?? 50;
            state.food = repo.Balance?.startFood ?? 50;
            state.iron = repo.Balance?.startIron ?? 0;
            Log("Game started.");
        }

        public CommandResult Execute(GameCommand command) {
            CommandResult result = new CommandResult { success = true };
            if (state.isGameOver) {
                result.success = false; result.message = "Game Over.";
                return result;
            }

            if (command is CollectWoodCommand) {
                state.wood += 10;
                if (state.wood > state.woodCapacity) state.wood = state.woodCapacity;
                Log("Collected 10 Wood. (DEBUG_ONLY)");
            }
            else if (command is BuildHutCommand) {
                StartConstruction("Hut", "Build_Hut", 50, 0, 100);
            }
            else if (command is BuildStorageCommand) {
                StartConstruction("Storage", "Build_Storage", 100, 0, 100);
            }
            else if (command is BuildGuardTowerCommand) {
                StartConstruction("GuardTower", "Build_GuardTower", 150, 50, 100);
            }
            else if (command is AssignWorkerCommand) {
                // UNKNOWN_JOB_UI_FLOW
                var idle = state.villagers.FirstOrDefault(v => v.job == "Idle" && v.hp > 0);
                if (idle != null) { idle.job = "Woodcutter"; Log($"{idle.name} assigned to Woodcutter."); }
            }
            else if (command is AdvanceTimeCommand) {
                ProcessTimeAdvance();
            }
            else if (command is ForceRaidCommand) {
                ProcessRaidCheck();
            }
            else if (command is SaveGameCommand) {
                File.WriteAllText(savePath, JsonUtility.ToJson(state, true));
                Log("Game Saved (PROTOTYPE_FALLBACK).");
            }
            else if (command is LoadGameCommand) {
                if (File.Exists(savePath)) {
                    state = JsonUtility.FromJson<GameSnapshot>(File.ReadAllText(savePath));
                    Log("Game Loaded (PROTOTYPE_FALLBACK).");
                }
            }
            return result;
        }

        private void StartConstruction(string bId, string taskType, int woodReq, int ironReq, int fallbackCompletion) {
            var task = new TaskSnapshot {
                id = System.Guid.NewGuid().ToString(),
                type = taskType,
                targetBuildingId = bId,
                status = "AwaitingResources",
                fidelityClassification = "DECODE_EVIDENCE_PARTIAL",
                currentCompletion = 0,
                finalCompletion = fallbackCompletion
            };
            if (woodReq > 0) task.requiredResources.Add(new ResourceAmount { resourceId = "wood", amount = woodReq });
            if (ironReq > 0) task.requiredResources.Add(new ResourceAmount { resourceId = "iron", amount = ironReq });
            
            // Do NOT deduct global resources here. Resources must be deposited by agents.
            state.tasks.Add(task);
            Log($"Started construction site for {bId}. Awaiting resources.");
        }

        // --- EDITOR TEST TOOL HELPERS ---
        // These methods must ONLY be called from TheBonwaterTestToolsWindow or RebuildVerifier!
        public void Test_DepositResourcesIntoConstruction(string taskId) {
            var task = state.tasks.FirstOrDefault(t => t.id == taskId);
            if (task == null) return;
            
            bool allComplete = true;
            foreach (var req in task.requiredResources) {
                var dep = task.depositedResources.FirstOrDefault(d => d.resourceId == req.resourceId);
                if (dep == null) { dep = new ResourceAmount { resourceId = req.resourceId, amount = 0 }; task.depositedResources.Add(dep); }
                
                int needed = req.amount - dep.amount;
                if (needed > 0) {
                    dep.amount += needed;
                    // Abstractly deducting from state for testing
                    if (req.resourceId == "wood") state.wood = Mathf.Max(0, state.wood - needed);
                    if (req.resourceId == "iron") state.iron = Mathf.Max(0, state.iron - needed);
                }
                if (dep.amount < req.amount) allComplete = false;
            }
            task.isResourcesComplete = allComplete;
            if (allComplete) task.status = "UnderConstruction";
            Log($"TEST_TOOL: Deposited resources into {task.targetBuildingId}. isResourcesComplete: {allComplete}");
        }

        public void Test_ProgressConstruction(string taskId, int addedLabour) {
            var task = state.tasks.FirstOrDefault(t => t.id == taskId);
            if (task == null) return;
            if (!task.isResourcesComplete) return;

            task.currentCompletion += addedLabour;
            Log($"TEST_TOOL: Added {addedLabour} labour to {task.targetBuildingId}. ({task.currentCompletion}/{task.finalCompletion})");
            
            if (task.currentCompletion >= task.finalCompletion) {
                Test_CompleteConstruction(taskId);
            }
        }

        public void Test_CompleteConstruction(string taskId) {
            var task = state.tasks.FirstOrDefault(t => t.id == taskId);
            if (task == null) return;

            var bld = state.buildings.Find(b => b.id == task.targetBuildingId);
            if (bld == null) { bld = new BuildingSnapshot { id = task.targetBuildingId, count = 0 }; state.buildings.Add(bld); }
            bld.count++;
            state.tasks.Remove(task);
            Log($"TEST_TOOL: Completed {task.targetBuildingId}.");
        }
        // --------------------------------

        private void ProcessTimeAdvance() {
            // NOTE: Auto-deposit and auto-progress construction has been REMOVED.
            // In FidelityMode, construction tasks stay idle until actual AIAgent pathfinding and DepositResource commands are fully integrated.
            
            // Time Shift
            if (state.timeOfDay == "Morning") state.timeOfDay = "Afternoon";
            else if (state.timeOfDay == "Afternoon") state.timeOfDay = "Evening";
            else if (state.timeOfDay == "Evening") { 
                state.timeOfDay = "Night"; 
                ProcessRaidCheck();
            }
            else if (state.timeOfDay == "Night") { 
                state.timeOfDay = "Morning"; 
                state.day++; 
                ProcessDailyUpkeep();
            }

            Log($"Time advanced: Day {state.day} - {state.timeOfDay}");
            CheckObjectives();
        }

        private void ProcessDailyUpkeep() {
            int aliveCount = state.villagers.Count(v => v.hp > 0);
            int foodReq = repo.Balance?.foodConsumptionPerVillagerPerDay ?? 5;
            int foodNeeded = aliveCount * foodReq;
            
            if (state.food >= foodNeeded) {
                state.food -= foodNeeded;
                state.consecutiveDaysWithoutFood = 0;
            } else {
                state.food = 0;
                state.consecutiveDaysWithoutFood++;
                foreach(var v in state.villagers.Where(v => v.hp > 0)) {
                    int dmg = repo.Balance?.starvationHpDamagePerDay ?? 10;
                    v.hp -= dmg;
                    if (v.hp < 0) v.hp = 0;
                }
                Log("Not enough food. Villagers are starving!");
            }
        }

        private void ProcessRaidCheck() {
            if (state.isObjectiveComplete || state.isGameOver) return;
            
            if (state.lastRaidDay != state.day && (UnityEngine.Random.value < (repo.Balance?.raidChanceAtNight ?? 0.5f))) {
                state.lastRaidDay = state.day;
                Log("Night falls. Raid check triggered. A small monster raid approaches!");
                
                int defense = 0;
                int guardDef = repo.GetJob("Guard")?.defense ?? 10;
                int gtDef = repo.GetBuilding("GuardTower")?.defense ?? 15;
                foreach(var v in state.villagers) if (v.hp > 0 && v.job == "Guard") defense += guardDef;
                var gt = state.buildings.Find(b => b.id == "GuardTower");
                if (gt != null) defense += gt.count * gtDef;
                state.totalDefense = defense; // Cache for UI
                
                var enemyDef = repo.GetEnemy("SmallMonster");
                int eHp = enemyDef?.hp ?? 30;
                int eAtk = enemyDef?.attack ?? 15;
                EnemyState enemy = new EnemyState { id = "e_" + state.day, typeId = "SmallMonster", displayName = "Small Monster", hp = eHp, attack = eAtk, status = "ATTACKING" };
                state.enemies.Add(enemy);
                
                int dmg = UnityEngine.Mathf.Max(0, enemy.attack - defense);
                if (dmg > 0) {
                    foreach(var v in state.villagers) {
                        if (v.hp > 0) {
                            v.hp -= dmg;
                            Log($"Night Raid! SmallMonster attacked. Defense: {defense}. Damage: {dmg}. {v.name} HP -{dmg}.");
                            break; 
                        }
                    }
                    int penalty = repo.Balance?.woodPenaltyOnUnblockedRaid ?? 10;
                    if (state.wood >= penalty) state.wood -= penalty;
                } else {
                    Log($"Night Raid repelled by guards. Defense: {defense}. Damage: 0.");
                }
                state.enemies.Remove(enemy);
            }
        }

        private void CheckObjectives() {
            if (state.isGameOver) return;

            int aliveCount = state.villagers.Count(v => v.hp > 0);
            if (aliveCount == 0) {
                state.isGameOver = true;
                Log("GAME OVER - All villagers died.");
            }
            else if (state.consecutiveDaysWithoutFood >= 2) {
                Log("WARNING: Food shortage.");
            }

            int hutCount = state.buildings.Find(b => b.id == "Hut")?.count ?? 0;
            int targetDay = repo.Objectives.FirstOrDefault(o => o.id == "survive_day_3")?.targetDay ?? (repo.Balance?.objectiveSurviveDay ?? 3);
            int targetHuts = repo.Objectives.FirstOrDefault(o => o.id == "survive_day_3")?.targetHutCount ?? (repo.Balance?.objectiveRequiredHuts ?? 2);
            
            if (state.day >= targetDay && hutCount >= targetHuts && aliveCount > 0 && !state.isObjectiveComplete) {
                state.isObjectiveComplete = true;
                Log("Objective complete: Village survived 3 days and built 2 huts.");
            }
        }

        private void Log(string msg) {
            state.lastAction = msg;
            state.taskLogs.Insert(0, msg);
            if (state.taskLogs.Count > 5) state.taskLogs.RemoveAt(state.taskLogs.Count - 1);
        }

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
    }
}
"""

with open(lb_path, "w", encoding="utf-8") as f:
    f.write(new_lb_code)

print("Backend files updated.")
