// Backend Reconstruction Notes:
// - Original evidence: ResourceData, BuildingData, JobData, SaveLoadUtility, DayNightController
// - Confidence: HIGH (Classes exist in IL2CPP dump)
// - Fallback logic: Task execution and specific balance numbers are fallback.
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;
using TheBonwater.Rebuild.Diagnostics;

namespace TheBonwater.Rebuild {
    public class LocalGameBackend : IGameBackend {
        private GameSnapshot state;
        private string savePath;
        private const int MaxVillagerHp = 100;
        private const int WellFedHealAmount = 5;

        public event Action<GameSnapshot> OnStateChanged;
        public Data.DataRepository repo { get; private set; }

        public static string NormalizeBuildingId(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return raw;

            var key = raw.Replace(" ", "")
                         .Replace("_", "")
                         .Replace("-", "")
                         .ToLowerInvariant();

            switch (key)
            {
                case "hut":
                case "buildhut": return "hut";
                case "storage":
                case "buildstorage": return "storage";
                case "guardtower":
                case "buildguardtower":
                case "tower": return "guardTower";
                case "bonfire":
                case "campfire": return "bonfire";
                default: return raw;
            }
        }

        public LocalGameBackend() {
            savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            RuntimeTrace.Log("SAVE_PATH", $"path={savePath}");
            repo = new Data.DataRepository();
            repo.LoadAll();

            if (File.Exists(savePath)) {
                try {
                    string json = File.ReadAllText(savePath);
                    state = JsonUtility.FromJson<GameSnapshot>(json);
                    RuntimeTrace.Log("SAVE_READ", $"exists=true bytes={json.Length}");
                } catch (Exception e) {
                    RuntimeTrace.Log("ERROR", $"Failed to load save: {e.Message}");
                    NewGame();
                }
            } else {
                RuntimeTrace.Log("SAVE_READ", $"exists=false bytes=0");
                NewGame();
            }
        }

        private void NewGame() {
            state = new GameSnapshot();
            state.villagers.Add(new VillagerSnapshot { id = "v1", name = "Bryn", job = "Idle" });
            state.villagers.Add(new VillagerSnapshot { id = "v2", name = "Alaric", job = "Idle" });
            state.wood = repo.GetResource("wood")?.initialAmount ?? 50;
            state.food = repo.GetResource("food")?.initialAmount ?? 50;
            state.iron = repo.GetResource("iron")?.initialAmount ?? 0;
            
            // Core Structure - Decode blueprint partial
            state.buildings.Add(new BuildingSnapshot { id = NormalizeBuildingId("bonfire"), count = 1 });
            
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
                if (!HasEnoughResourcesToStartConstruction("hut", out string failReason)) Log($"Not enough resources for Hut");
                else StartConstruction("hut", "Build_Hut", 100);
            }
            else if (command is BuildStorageCommand) {
                if (!HasEnoughResourcesToStartConstruction("storage", out string failReason)) Log($"Not enough resources for Storage");
                else StartConstruction("storage", "Build_Storage", 100);
            }
            else if (command is BuildGuardTowerCommand) {
                if (!HasEnoughResourcesToStartConstruction("guardTower", out string failReason)) Log($"Not enough resources for Guard Tower");
                else StartConstruction("guardTower", "Build_GuardTower", 100);
            }
            else if (command is AssignWorkerCommand) {
                // TEMPORARY_DEV_UI / PROTOTYPE_FALLBACK_JOB_UI
                if (state.villagers.Count > 0 && state.selectedVillagerIndex >= 0 && state.selectedVillagerIndex < state.villagers.Count) {
                    var v = state.villagers[state.selectedVillagerIndex];
                    if (v.hp > 0) {
                        string oldJob = v.job;
                        if (v.job == "Idle") v.job = "Woodcutter";
                        else if (v.job == "Woodcutter") v.job = "Builder";
                        else if (v.job == "Builder") v.job = "Guard";
                        else v.job = "Idle";
                        Log($"{v.name} changed job: {oldJob} -> {v.job}");
                    }
                }
            }
            else if (command is SelectNextVillagerCommand) {
                if (state.villagers.Count > 0) {
                    state.selectedVillagerIndex = (state.selectedVillagerIndex + 1) % state.villagers.Count;
                    state.selectedVillagerId = state.villagers[state.selectedVillagerIndex].id;
                    Log($"Selected villager: {state.villagers[state.selectedVillagerIndex].name}");
                }
            }
            else if (command is SelectVillagerCommand cmdSel) {
                var v = state.villagers.Find(x => x.id == cmdSel.villagerId);
                if (v != null) {
                    state.selectedVillagerId = v.id;
                    state.selectedVillagerIndex = state.villagers.IndexOf(v);
                    UnityEngine.Debug.Log($"[VILLAGER_SELECTED] id={v.id} name={v.name}");
                }
            }
            else if (command is AssignVillagerJobCommand cmdJob) {
                var v = state.villagers.Find(x => x.id == cmdJob.villagerId);
                if (v != null && v.hp > 0) {
                    string old = v.job;
                    v.job = cmdJob.jobId;
                    UnityEngine.Debug.Log($"[JOB_ASSIGNED] villager={v.id} old={old} new={v.job}");
                }
            }
            else if (command is AdvanceTimeCommand) {
                ProcessTimeAdvance();
            }
            else if (command is ForceRaidCommand) {
                ProcessRaidCheck();
            }
            else if (command is SpawnVillagerCommand) {
                string vId = "v" + (state.villagers.Count + 1);
                state.villagers.Add(new VillagerSnapshot { id = vId, name = "Villager " + (state.villagers.Count + 1), job = "Idle" });
                Log($"A new villager joined the village!");
            }
            else if (command is SaveGameCommand) {
                try {
                    string json = JsonUtility.ToJson(state, true);
                    File.WriteAllText(savePath, json);
                    RuntimeTrace.Log("SAVE_WRITE", $"success=true bytes={json.Length}");
                    Log("Game Saved (PROTOTYPE_FALLBACK).");
                } catch (Exception e) {
                    RuntimeTrace.Log("SAVE_WRITE", $"success=false error={e.Message}");
                    Log("Save Failed: " + e.Message);
                }
            }
            else if (command is LoadGameCommand) {
                if (File.Exists(savePath)) {
                    try {
                        string json = File.ReadAllText(savePath);
                        state = JsonUtility.FromJson<GameSnapshot>(json);
                        RuntimeTrace.Log("LOAD_RESULT", $"success=true snapshotSummary=Wood:{state.wood},Tasks:{state.tasks.Count}");
                        Log("Game Loaded (PROTOTYPE_FALLBACK).");
                    } catch (Exception e) {
                        RuntimeTrace.Log("LOAD_RESULT", $"success=false error={e.Message}");
                        Log("Load Failed: " + e.Message);
                    }
                } else {
                    RuntimeTrace.Log("LOAD_RESULT", $"success=false error=FileNotFound");
                    Log("Load Failed: Save file not found.");
                }
            }
            return result;
        }

        
        public bool HasEnoughResourcesToStartConstruction(string bId, out string failReason) {
            bId = NormalizeBuildingId(bId);
            failReason = "";
            var bdef = repo.GetBuilding(bId);
            int wCost = bdef != null && bdef.costs.TryGetValue("wood", out int w) ? w : 0;
            int iCost = bdef != null && bdef.costs.TryGetValue("iron", out int i) ? i : 0;
            RuntimeTrace.Log("BUILD_ATTEMPT", $"building={bId} cost=Wood:{wCost},Iron:{iCost} have=Wood:{state.wood},Iron:{state.iron}");
            if (state.wood < wCost || state.iron < iCost) {
                failReason = $"Not enough Wood/Iron";
                RuntimeTrace.Log("BUILD_FAILED", failReason);
                return false;
            }
            return true;
        }
        
        public void StartConstruction(string bId, string taskType, int fallbackCompletion) {
            bId = NormalizeBuildingId(bId);
            var bdef = repo.GetBuilding(bId);
            int wCost = bdef != null && bdef.costs.TryGetValue("wood", out int w) ? w : 0;
            int iCost = bdef != null && bdef.costs.TryGetValue("iron", out int i) ? i : 0;
            var task = new TaskSnapshot {
                id = System.Guid.NewGuid().ToString(),
                type = taskType,
                targetBuildingId = bId,
                status = "UnderConstruction",
                fidelityClassification = "DECODE_EVIDENCE_PARTIAL",
                currentCompletion = 0,
                finalCompletion = fallbackCompletion,
                isResourcesComplete = true
            };
            int wBefore = state.wood;
            int iBefore = state.iron;
            if (wCost > 0) {
                task.requiredResources.Add(new ResourceAmount { resourceId = "wood", amount = wCost });
                task.depositedResources.Add(new ResourceAmount { resourceId = "wood", amount = wCost });
                state.wood = Math.Max(0, state.wood - wCost);
            }
            if (iCost > 0) {
                task.requiredResources.Add(new ResourceAmount { resourceId = "iron", amount = iCost });
                task.depositedResources.Add(new ResourceAmount { resourceId = "iron", amount = iCost });
                state.iron = Math.Max(0, state.iron - iCost);
            }
            RuntimeTrace.Log("RESOURCE_SPENT", $"Wood {wBefore} -> {state.wood}, Iron {iBefore} -> {state.iron}");
            RuntimeTrace.Log("CONSTRUCTION_TASK_CREATED", $"TaskId={task.id}");
            RuntimeTrace.Log("SNAPSHOT_TASK", $"targetBuildingId={task.targetBuildingId} progress={task.currentCompletion}/{task.finalCompletion}");
            
            state.tasks.Add(task);
            Log($"Started construction for {bdef?.displayName ?? bId}. Resources auto-deposited (-{wCost}W, -{iCost}I).");
        }

        // --- EDITOR TEST TOOL HELPERS ---
        // These methods must ONLY be called from TheBonwaterTestToolsWindow or RebuildVerifier!
        public void DepositResource(string taskId) {
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

        public void UpdateConstruction(string taskId, int addedLabour) {
            var task = state.tasks.FirstOrDefault(t => t.id == taskId);
            if (task == null) return;
            if (!task.isResourcesComplete) return;

            task.currentCompletion += addedLabour;
            Log($"TEST_TOOL: Added {addedLabour} labour to {task.targetBuildingId}. ({task.currentCompletion}/{task.finalCompletion})");
            
            if (task.currentCompletion >= task.finalCompletion) {
                FinishConstruction(taskId);
            }
        }

        public void FinishConstruction(string taskId) {
            var task = state.tasks.FirstOrDefault(t => t.id == taskId);
            if (task == null) return;

            var bld = state.buildings.Find(b => b.id == task.targetBuildingId);
            if (bld == null) { bld = new BuildingSnapshot { id = task.targetBuildingId, count = 0 }; state.buildings.Add(bld); }
            bld.count++;
            state.tasks.Remove(task);
            var bdef = repo.GetBuilding(task.targetBuildingId);
            Log($"TEST_TOOL: Completed {bdef?.displayName ?? task.targetBuildingId}.");
        }
        // --------------------------------

        private void ProcessTimeAdvance() {
            RuntimeTrace.Log("TIME_ADVANCE", $"Day {state.day} - {state.timeOfDay}");
            
            // Job Production & Auto-Deposit (PROTOTYPE_FALLBACK - NO_PATHFINDING_AI_YET)
            int beforeWood = state.wood;
            int productionWood = 0;
            int buildCostWood = 0;
            int upkeepWood = 0;

            foreach (var v in state.villagers.Where(v => v.hp > 0)) {
                if (v.job == "Woodcutter") {
                    int prod = repo.GetJob("Woodcutter")?.productionPerPhase ?? 10;
                    if (prod <= 0) prod = 10;
                    productionWood += prod;
                    state.wood = Mathf.Min(state.woodCapacity, state.wood + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Woodcutter woodDelta=+{prod} wood={state.wood}/{state.woodCapacity}");
                    Log($"{v.name} gathered wood +{prod}.");
                }
                else if (v.job == "Forager") {
                    int prod = repo.GetJob("Forager")?.productionPerPhase ?? 2;
                    if (prod <= 0) prod = 2;
                    state.food = Mathf.Min(state.foodCapacity, state.food + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Forager foodDelta=+{prod} food={state.food}/{state.foodCapacity}");
                    Log($"{v.name} gathered food +{prod}.");
                }
            }

            int builders = state.villagers.Count(v => v.job == "Builder" && v.hp > 0);
            if (builders > 0 && state.tasks.Count > 0) {
                var task = state.tasks.FirstOrDefault(t => t.status == "AwaitingResources" || t.status == "UnderConstruction");
                if (task != null) {
                    if (!task.isResourcesComplete) {
                        bool allComplete = true;
                        foreach (var req in task.requiredResources) {
                            var dep = task.depositedResources.FirstOrDefault(d => d.resourceId == req.resourceId);
                            if (dep == null) { dep = new ResourceAmount { resourceId = req.resourceId, amount = 0 }; task.depositedResources.Add(dep); }
                            
                            int needed = req.amount - dep.amount;
                            if (needed > 0) {
                                int available = 0;
                                if (req.resourceId == "wood") available = state.wood;
                                if (req.resourceId == "iron") available = state.iron;
                                
                                int toDeposit = Mathf.Min(needed, available);
                                dep.amount += toDeposit;
                                
                                if (req.resourceId == "wood") { state.wood -= toDeposit; buildCostWood += toDeposit; }
                                if (req.resourceId == "iron") state.iron -= toDeposit;
                                
                                if (toDeposit > 0) {
                                    RuntimeTrace.Log("BUILDER_AUTO_DEPOSIT", $"TaskId={task.id} Resource={req.resourceId} Amount={toDeposit}");
                                    Log($"Builder deposited {toDeposit} {req.resourceId} into {task.targetBuildingId}.");
                                }
                            }
                            if (dep.amount < req.amount) allComplete = false;
                        }
                        task.isResourcesComplete = allComplete;
                        if (allComplete) task.status = "UnderConstruction";
                    }

                    if (task.isResourcesComplete) {
                        int labour = builders * 25; // Fallback labour per tick
                        task.currentCompletion += labour;
                        RuntimeTrace.Log("CONSTRUCTION_PROGRESS", $"TaskId={task.id} AddedLabour={labour}");
                        Log($"Builder added {labour} labour to {task.targetBuildingId}. ({task.currentCompletion}/{task.finalCompletion})");
                        
                        if (task.currentCompletion >= task.finalCompletion) {
                            var bld = state.buildings.Find(b => b.id == task.targetBuildingId);
                            if (bld == null) { bld = new BuildingSnapshot { id = task.targetBuildingId, count = 0 }; state.buildings.Add(bld); }
                            bld.count++;
                            state.tasks.Remove(task);
                            var bdef = repo.GetBuilding(task.targetBuildingId);
                            RuntimeTrace.Log("CONSTRUCTION_COMPLETED", $"TaskId={task.id} Building={task.targetBuildingId}");
                            Log($"Builder completed {bdef?.displayName ?? task.targetBuildingId}!");
                        }
                    }
                }
            }

            RuntimeTrace.Log("RESOURCE_DELTA", $"beforeWood={beforeWood} productionWood={productionWood} buildCostWood={buildCostWood} upkeepWood={upkeepWood} afterWood={state.wood}");

            // Time Shift
            // Clear enemies from previous phase
            state.enemies.RemoveAll(e => e.removePending);
            
            string oldPhase = state.timeOfDay;
            int oldDay = state.day;

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

            if (oldDay != state.day) Log($"Time advanced: Night -> Day {state.day} Morning");
            else Log($"Time advanced: {oldPhase} -> {state.timeOfDay}");
            
            CheckObjectives();
        }

        private void ProcessDailyUpkeep() {
            int aliveCount = state.villagers.Count(v => v.hp > 0);
            int foodReq = repo.Balance?.foodConsumptionPerVillagerPerDay ?? 5;
            int foodNeeded = aliveCount * foodReq;
            
            int foodBefore = state.food;

            if (state.food >= foodNeeded) {
                state.food -= foodNeeded;
                state.consecutiveDaysWithoutFood = 0;
                Log($"Consumed {foodNeeded} food for villagers.");

                bool anyHealed = false;
                foreach(var v in state.villagers.Where(v => v.hp > 0)) {
                    if (v.hp < MaxVillagerHp) {
                        int oldHp = v.hp;
                        v.hp = UnityEngine.Mathf.Min(MaxVillagerHp, v.hp + WellFedHealAmount);
                        Log($"Villagers ate well. {v.name} recovered {v.hp - oldHp} HP.");
                        RuntimeTrace.Log("HEALTH_RECOVERY", $"villager={v.id} hpBefore={oldHp} hpAfter={v.hp} reason=well_fed");
                        anyHealed = true;
                    } else {
                        RuntimeTrace.Log("HEALTH_RECOVERY_SKIP", $"villager={v.id} reason=full_hp");
                    }
                }
                
                // We log dead skipped as well
                foreach(var v in state.villagers.Where(v => v.hp <= 0)) {
                    RuntimeTrace.Log("HEALTH_RECOVERY_SKIP", $"villager={v.id} reason=dead");
                }

                if (anyHealed) {
                    Log("Villagers ate well and recovered health.");
                }

            } else {
                state.food = 0;
                state.consecutiveDaysWithoutFood++;
                Log($"Consumed {foodBefore} food. Food shortage!");
                foreach(var v in state.villagers.Where(v => v.hp > 0)) {
                    int dmg = repo.Balance?.starvationHpDamagePerDay ?? 10;
                    v.hp -= dmg;
                    if (v.hp < 0) v.hp = 0;
                    Log($"Food shortage! {v.name} lost {dmg} HP.");
                    RuntimeTrace.Log("STARVATION", $"villager={v.id} hpDelta=-{dmg} hp={v.hp}");
                    
                    if (v.hp <= 0) {
                        v.job = "Idle";
                        v.state = "Dead";
                        Log($"{v.name} has starved to death.");
                    }
                }
            }
            RuntimeTrace.Log("FOOD_UPKEEP", $"population={aliveCount} foodBefore={foodBefore} foodAfter={state.food}");
        }

        private void ProcessRaidCheck() {
            if (state.isGameOver || state.objectiveState.status == "FAILED" || state.objectiveState.status == "COMPLETED") return;
            RuntimeTrace.Log("RAID_CHECK", $"Day={state.day}");
            
            if (state.lastRaidDay != state.day && (UnityEngine.Random.value < (repo.Balance?.raidChanceAtNight ?? 0.5f))) {
                state.lastRaidDay = state.day;
                Log("Night falls. Raid check triggered. A small monster raid approaches!");
                
                int defense = 0;
                int guardDef = repo.GetJob("Guard")?.defense ?? 10;
                int gtDef = repo.GetBuilding("guardTower")?.defense ?? 15;
                foreach(var v in state.villagers) if (v.hp > 0 && v.job == "Guard") defense += guardDef;
                var gt = state.buildings.Find(b => b.id == NormalizeBuildingId("guardTower"));
                if (gt != null) defense += gt.count * gtDef;
                state.totalDefense = defense; // Cache for UI
                
                var enemyDef = repo.GetEnemy("SmallMonster");
                int eHp = enemyDef?.hp ?? 30;
                int eAtk = enemyDef?.attack ?? 15;
                EnemyState enemy = new EnemyState { id = "e_" + state.day, typeId = "SmallMonster", displayName = "Small Monster", hp = eHp, attack = eAtk, status = "Active", spawnPhase = state.day, clearAtNextPhase = true, removePending = false };
                state.enemies.Add(enemy);
                
                int dmg = UnityEngine.Mathf.Max(0, enemy.attack - defense);
                if (dmg > 0) {
                    var aliveVillagers = state.villagers.Where(v => v.hp > 0).ToList();
                    var guards = aliveVillagers.Where(v => IsGuardJob(v.job)).ToList();
                    
                    VillagerSnapshot victim = null;
                    if (guards.Count > 0) {
                        victim = SelectRaidDamageTarget(guards);
                        RuntimeTrace.Log("COMBAT_TARGETING", $"mode=guard_intercept target={victim.id} job={victim.job} damage={dmg}");
                        Log($"Guard {victim.name} intercepted the monster and lost {dmg} HP.");
                    } else if (aliveVillagers.Count > 0) {
                        victim = SelectRaidDamageTarget(aliveVillagers);
                        RuntimeTrace.Log("COMBAT_TARGETING", $"mode=no_guard_random target={victim.id} job={victim.job} damage={dmg}");
                        Log($"No guard intercepted the raid. {victim.name} was wounded for {dmg} HP.");
                    }

                    if (victim != null) {
                        int hpBefore = victim.hp;
                        victim.hp -= dmg;
                        if (victim.hp < 0) victim.hp = 0;
                        RuntimeTrace.Log("COMBAT_DAMAGE", $"target={victim.id} hpBefore={hpBefore} hpAfter={victim.hp}");
                        
                        if (victim.hp <= 0) {
                            victim.job = "Idle";
                            victim.state = "Dead";
                            Log($"{victim.name} has died in combat.");
                        }
                    }

                    int penalty = repo.Balance?.woodPenaltyOnUnblockedRaid ?? 10;
                    if (state.wood >= penalty) state.wood -= penalty;
                } else {
                    RuntimeTrace.Log("COMBAT_TARGETING", "mode=blocked_by_defense damage=0");
                    Log($"The guard defense blocked the raid damage.");
                    RuntimeTrace.Log("RAID_RESULT", $"Damage=0");
                }
                
                enemy.hp = 0;
                enemy.status = "Defeated";
                enemy.removePending = true;
            }
        }

        private void CheckObjectives() {
            if (state.isGameOver || state.objectiveState.status == "COMPLETED" || state.objectiveState.status == "FAILED") return;

            int aliveCount = state.villagers.Count(v => v.hp > 0);
            if (aliveCount == 0) {
                state.isGameOver = true;
                state.objectiveState.status = "FAILED";
                RuntimeTrace.Log("OBJECTIVE_FAILED", "All villagers died.");
                Log("GAME OVER - All villagers died.");
                return;
            }

            if (state.objectiveState.surviveToDay > 0 && state.day >= state.objectiveState.surviveToDay) {
                int hutCount = state.buildings.Find(b => b.id == "hut")?.count ?? 0;
                if (hutCount >= state.objectiveState.requiredHuts) {
                    state.isGameOver = true;
                    state.isObjectiveComplete = true;
                    state.objectiveState.status = "COMPLETED";
                    RuntimeTrace.Log("OBJECTIVE_COMPLETED", $"Day {state.day}, Huts {hutCount}");
                    Log("VICTORY - You have survived and built the village.");
                }
            }
        }

        private System.Random rng = new System.Random();

        private static bool IsGuardJob(string job)
        {
            return string.Equals(job, "Guard", StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "guard", StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "guardTower", StringComparison.OrdinalIgnoreCase);
        }

        private VillagerSnapshot SelectRaidDamageTarget(List<VillagerSnapshot> candidates)
        {
            if (candidates == null || candidates.Count == 0) return null;
            if (candidates.Count == 1) return candidates[0];
            int index = rng.Next(candidates.Count);
            return candidates[index];
        }

        private void Log(string msg) {
            state.lastAction = msg;
            state.taskLogs.Insert(0, msg);
            if (state.taskLogs.Count > 5) state.taskLogs.RemoveAt(state.taskLogs.Count - 1);
        }

        public GameSnapshot GetSnapshot() { 
            int defense = 0;
            int guardDef = repo.GetJob("Guard")?.defense ?? 10;
            int gtDef = repo.GetBuilding("guardTower")?.defense ?? 15;
            foreach(var v in state.villagers) if (v.hp > 0 && v.job == "Guard") defense += guardDef;
            var gt = state.buildings.Find(b => b.id == NormalizeBuildingId("guardTower"));
            if (gt != null) defense += gt.count * gtDef;
            state.totalDefense = defense;
            return state; 
        }
    }
}
