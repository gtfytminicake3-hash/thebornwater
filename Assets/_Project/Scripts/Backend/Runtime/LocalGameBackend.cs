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
using TheBonwater.Rebuild.Backend.Runtime;

namespace TheBonwater.Rebuild {
    public class LocalGameBackend : IGameBackend {
        private GameSnapshot state;
        private string savePath;
        private const int MaxVillagerHp = 100;
        private const int WellFedHealAmount = 5;
        public bool skipMorningHealAfterRaid = false;
        
        private int lastLoggedEnemyHp = -1;
        private Dictionary<string, int> lastLoggedVillagerHp = new Dictionary<string, int>();

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

            // Trigger static constructor of TradeOffers to log loaded offers
            var _dummyOffers = TradeOffers.Offers;

            if (File.Exists(savePath)) {
                try {
                    string json = File.ReadAllText(savePath);
                    state = JsonUtility.FromJson<GameSnapshot>(json);
                    RuntimeTrace.Log("SAVE_READ", $"exists=true bytes={json.Length}");
                    SanitizeLoadedState();
                    CheckObjectives();
                } catch (Exception e) {
                    RuntimeTrace.Log("ERROR", $"Failed to load save: {e.Message}");
                    NewGame();
                }
            } else {
                RuntimeTrace.Log("SAVE_READ", $"exists=false bytes=0");
                NewGame();
            }
        }

        private void SanitizeLoadedState() {
            if (state == null) return;
            if (state.titanState == null) {
                state.titanState = new TitanState();
            }
            if (state.titanState.maxHp <= 0) {
                state.titanState.maxHp = 500;
            }
            if (state.titanState.isDefeated) {
                state.titanState.hp = 0;
            } else {
                if (state.titanState.hp < 0) state.titanState.hp = 0;
                if (state.titanState.hp > state.titanState.maxHp) state.titanState.hp = state.titanState.maxHp;
            }

            if (state.objectiveState == null) {
                state.objectiveState = new ObjectiveState();
            }
            if (state.objectiveState.currentMilestoneIndex <= 0) {
                state.objectiveState.currentMilestoneIndex = 1;
            }
            if (state.objectiveState.currentMilestoneIndex > 5) {
                state.objectiveState.currentMilestoneIndex = 5;
            }
            if (state.questState == null) {
                state.questState = new QuestState();
            }
            if (state.questState.completedQuestIds == null) {
                state.questState.completedQuestIds = new List<string>();
            }
            if (state.questState.unlockedAchievementIds == null) {
                state.questState.unlockedAchievementIds = new List<string>();
            }
            if (state.questState.pendingQuestNotifications == null) {
                state.questState.pendingQuestNotifications = new List<string>();
            }
            if (state.questState.pendingAchievementNotifications == null) {
                state.questState.pendingAchievementNotifications = new List<string>();
            }
            state.questState.completedQuestIds = state.questState.completedQuestIds.Distinct().ToList();
            state.questState.unlockedAchievementIds = state.questState.unlockedAchievementIds.Distinct().ToList();
            if (state.questState.completedExpeditionCountForQuest < 0) {
                state.questState.completedExpeditionCountForQuest = 0;
            }
            if (state.questState.completedTradeCountForQuest < 0) {
                state.questState.completedTradeCountForQuest = 0;
            }
            if (state.villagers != null) {
                foreach (var v in state.villagers) {
                    if (v.weaponId == null) v.weaponId = "";
                    if (v.armorId == null) v.armorId = "";
                    if (v.toolId == null) v.toolId = "";
                }
            }
            if (state.equipmentStock == null) {
                state.equipmentStock = new List<EquipmentStack>();
            }
            if (state.userPlacements != null) {
                foreach (var place in state.userPlacements) {
                    if (place != null && place.level <= 0) {
                        place.level = 1;
                    }
                }
            }

            if (state.pendingExpeditionReports == null) {
                state.pendingExpeditionReports = new List<string>();
                UnityEngine.Debug.Log("[WorldMap] Repaired null pendingExpeditionReports.");
            }

            if (state.tradeState == null) {
                state.tradeState = new TradeState {
                    isMerchantPresent = false,
                    daysUntilNextMerchant = 2,
                    merchantDaysRemaining = 0
                };
                UnityEngine.Debug.Log("[Trade 16B] Repaired null tradeState.");
            } else {
                if (state.tradeState.daysUntilNextMerchant < 0) {
                    state.tradeState.daysUntilNextMerchant = 2;
                    UnityEngine.Debug.Log("[Trade 16B] Repaired negative daysUntilNextMerchant to 2.");
                }
                if (state.tradeState.merchantDaysRemaining < 0) {
                    state.tradeState.merchantDaysRemaining = 0;
                    UnityEngine.Debug.Log("[Trade 16B] Repaired negative merchantDaysRemaining to 0.");
                }
                if (state.tradeState.isMerchantPresent && state.tradeState.merchantDaysRemaining <= 0) {
                    state.tradeState.isMerchantPresent = false;
                    state.tradeState.daysUntilNextMerchant = 2;
                    state.tradeState.merchantDaysRemaining = 0;
                    UnityEngine.Debug.Log("[Trade 16B] Repaired invalid present state (merchantDaysRemaining <= 0).");
                }
                if (!state.tradeState.isMerchantPresent && state.tradeState.daysUntilNextMerchant <= 0) {
                    state.tradeState.daysUntilNextMerchant = 2;
                    state.tradeState.merchantDaysRemaining = 0;
                    UnityEngine.Debug.Log("[Trade 16B] Repaired invalid absent state (daysUntilNextMerchant <= 0).");
                }
            }

            // Sanitize World Map State
            if (state.worldMapState == null) {
                state.worldMapState = new WorldMapState();
                UnityEngine.Debug.Log("[WorldMap] Repaired null worldMapState.");
            }
            if (state.worldMapState.locations == null) {
                state.worldMapState.locations = new List<WorldMapLocationState>();
                UnityEngine.Debug.Log("[WorldMap] Repaired null worldMapState.locations.");
            }

            var existingLocations = new List<WorldMapLocationState>();
            var seenIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            
            foreach (var loc in state.worldMapState.locations) {
                if (loc == null || string.IsNullOrEmpty(loc.id)) continue;
                if (!seenIds.Contains(loc.id)) {
                    seenIds.Add(loc.id);
                    existingLocations.Add(loc);
                } else {
                    UnityEngine.Debug.LogWarning($"[WorldMap] Removed duplicate saved location id: {loc.id}");
                }
            }
            state.worldMapState.locations = existingLocations;

            var definitionIds = new HashSet<string>(repo.WorldMapLocations.Select(d => d.id), StringComparer.OrdinalIgnoreCase);
            foreach (var loc in state.worldMapState.locations) {
                if (!definitionIds.Contains(loc.id)) {
                    UnityEngine.Debug.LogWarning($"[WorldMap] Preserving unknown saved location id: {loc.id}");
                }
            }

            bool mergedAny = false;
            foreach (var locDef in repo.WorldMapLocations) {
                var existing = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals(locDef.id, StringComparison.OrdinalIgnoreCase));
                if (existing == null) {
                    state.worldMapState.locations.Add(new WorldMapLocationState {
                        id = locDef.id,
                        displayName = locDef.displayName,
                        type = locDef.type,
                        x = locDef.x,
                        y = locDef.y,
                        spritePath = locDef.spritePath,
                        isDiscovered = locDef.discoveredAtStart,
                        isMajorLocation = locDef.isMajorLocation,
                        dangerLevel = locDef.dangerLevel,
                        rewardType = locDef.rewardType,
                        rewardAmount = locDef.rewardAmount,
                        unlockRequirement = locDef.unlockRequirement,
                        notes = locDef.notes
                    });
                    mergedAny = true;
                } else {
                    existing.displayName = locDef.displayName;
                    existing.type = locDef.type;
                    existing.x = locDef.x;
                    existing.y = locDef.y;
                    existing.spritePath = locDef.spritePath;
                    existing.isMajorLocation = locDef.isMajorLocation;
                    existing.dangerLevel = locDef.dangerLevel;
                    existing.rewardType = locDef.rewardType;
                    existing.rewardAmount = locDef.rewardAmount;
                    existing.unlockRequirement = locDef.unlockRequirement;
                    existing.notes = locDef.notes;
                }
            }
            if (mergedAny) {
                UnityEngine.Debug.Log("[WorldMap] Merging missing definitions into world map state.");
            }

            var homeLocState = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals("home", StringComparison.OrdinalIgnoreCase));
            if (homeLocState != null && !homeLocState.isDiscovered) {
                homeLocState.isDiscovered = true;
                UnityEngine.Debug.Log("[WorldMap] Forced home location to be discovered.");
            }

            // Sanitize active expeditions
            if (state.worldMapState == null) {
                state.worldMapState = new WorldMapState();
            }
            if (state.worldMapState.locations == null) {
                state.worldMapState.locations = new List<WorldMapLocationState>();
            }
            if (state.worldMapState.activeExpeditions == null) {
                state.worldMapState.activeExpeditions = new List<ExpeditionState>();
            }

            var invalidExpeditions = new List<ExpeditionState>();
            var villagerToExpeditionMap = new Dictionary<string, List<ExpeditionState>>();

            foreach (var exp in state.worldMapState.activeExpeditions) {
                bool isExpValid = true;

                // Validate basic expedition identity/data
                if (exp == null || string.IsNullOrEmpty(exp.id)) {
                    isExpValid = false;
                } else if (string.IsNullOrEmpty(exp.status) || !exp.status.Equals("Active", StringComparison.OrdinalIgnoreCase)) {
                    isExpValid = false;
                } else if (exp.phasesRemaining < 0) {
                    isExpValid = false;
                } else if (exp.rewardAmount < 0) {
                    isExpValid = false;
                } else if (exp.villagerIds == null || exp.villagerIds.Count == 0) {
                    isExpValid = false;
                }

                // Validate rewardType
                if (isExpValid && !string.IsNullOrEmpty(exp.rewardType)) {
                    string rt = exp.rewardType.ToLowerInvariant();
                    if (rt != "wood" && rt != "food" && rt != "iron" && rt != "steel" && rt != "coal") {
                        isExpValid = false;
                    }
                }

                // Validate target location
                if (isExpValid) {
                    if (string.IsNullOrEmpty(exp.targetLocationId)) {
                        isExpValid = false;
                    } else {
                        var def = repo.WorldMapLocations.FirstOrDefault(l => l.id.Equals(exp.targetLocationId, StringComparison.OrdinalIgnoreCase));
                        if (def == null) {
                            isExpValid = false;
                        } else {
                            var locState = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals(exp.targetLocationId, StringComparison.OrdinalIgnoreCase));
                            if (locState == null) {
                                // Try to repair location state from definition
                                locState = new WorldMapLocationState {
                                    id = def.id,
                                    displayName = def.displayName,
                                    type = def.type,
                                    x = def.x,
                                    y = def.y,
                                    spritePath = def.spritePath,
                                    isDiscovered = def.discoveredAtStart,
                                    isMajorLocation = def.isMajorLocation,
                                    dangerLevel = def.dangerLevel,
                                    rewardType = def.rewardType,
                                    rewardAmount = def.rewardAmount,
                                    unlockRequirement = def.unlockRequirement,
                                    notes = def.notes
                                };
                                state.worldMapState.locations.Add(locState);
                            }
                        }
                    }
                }

                // Validate villager assignments inside the expedition
                if (isExpValid) {
                    var uniqueVillagerIds = new HashSet<string>();
                    foreach (var vId in exp.villagerIds) {
                        if (string.IsNullOrEmpty(vId)) {
                            isExpValid = false;
                            break;
                        }
                        if (uniqueVillagerIds.Contains(vId)) {
                            isExpValid = false; // duplicate villager ids in expedition
                            break;
                        }
                        uniqueVillagerIds.Add(vId);

                        var v = state.villagers.FirstOrDefault(vl => vl.id == vId);
                        if (v == null || v.hp <= 0) {
                            isExpValid = false; // villager dead or missing
                            break;
                        }

                        // Map villager to this expedition for conflict checks
                        if (!villagerToExpeditionMap.ContainsKey(vId)) {
                            villagerToExpeditionMap[vId] = new List<ExpeditionState>();
                        }
                        villagerToExpeditionMap[vId].Add(exp);
                    }
                }

                if (!isExpValid) {
                    if (exp != null) invalidExpeditions.Add(exp);
                }
            }

            // Find villagers in multiple expeditions and invalidate all those expeditions (ambiguity handling)
            foreach (var kvp in villagerToExpeditionMap) {
                if (kvp.Value.Count > 1) {
                    foreach (var exp in kvp.Value) {
                        if (!invalidExpeditions.Contains(exp)) {
                            invalidExpeditions.Add(exp);
                        }
                    }
                }
            }

            // Validate consistency of villager flags with the remaining potentially valid expeditions
            var validExpeditions = state.worldMapState.activeExpeditions.Except(invalidExpeditions).ToList();
            var validExpeditionsMap = validExpeditions.ToDictionary(e => e.id);

            foreach (var exp in validExpeditions) {
                foreach (var vId in exp.villagerIds) {
                    var v = state.villagers.FirstOrDefault(vl => vl.id == vId);
                    if (v != null) {
                        // villager.isOnExpedition is false but expedition says they are away
                        if (!v.isOnExpedition) {
                            if (!invalidExpeditions.Contains(exp)) {
                                invalidExpeditions.Add(exp);
                            }
                        }
                        // villager.expeditionId points to a different active expedition
                        else if (v.expeditionId != exp.id) {
                            if (!invalidExpeditions.Contains(exp)) {
                                invalidExpeditions.Add(exp);
                            }
                        }
                    }
                }
            }

            // Re-evaluate valid expeditions after secondary invalidation
            validExpeditions = state.worldMapState.activeExpeditions.Except(invalidExpeditions).ToList();
            validExpeditionsMap = validExpeditions.ToDictionary(e => e.id);

            // 3. Process the repair / removal
            bool didRepair = false;

            if (invalidExpeditions.Count > 0) {
                didRepair = true;
                foreach (var exp in invalidExpeditions) {
                    state.worldMapState.activeExpeditions.Remove(exp);
                    
                    // Return valid living villagers from invalid expedition safely
                    if (exp.villagerIds != null) {
                        foreach (var vId in exp.villagerIds) {
                            if (string.IsNullOrEmpty(vId)) continue;
                            var v = state.villagers.FirstOrDefault(vl => vl.id == vId);
                            if (v != null && v.hp > 0) {
                                // Clear expedition flags if they were pointing to this invalid expedition
                                if (v.expeditionId == exp.id || string.IsNullOrEmpty(v.expeditionId)) {
                                    v.isOnExpedition = false;
                                    v.expeditionId = "";
                                    
                                    // Restore previous job or fallback
                                    var prevJob = exp.previousJobs?.FirstOrDefault(pj => pj.villagerId == v.id)?.jobId;
                                    string targetJob = prevJob ?? "Builder";
                                    
                                    // Validate job exists and capacity
                                    bool jobExists = repo.GetJob(targetJob) != null;
                                    bool capacityAvailable = true;
                                    if (targetJob == "Blacksmith") {
                                        int forges = state.buildings.FirstOrDefault(b => b.id == "blacksmithsForge")?.count ?? 0;
                                        if (forges <= 0) {
                                            jobExists = false;
                                        } else {
                                            int activeBlacksmiths = state.villagers.Count(v2 => v2.job == "Blacksmith" && v2.hp > 0);
                                            if (activeBlacksmiths >= forges * 2) {
                                                capacityAvailable = false;
                                            }
                                        }
                                    } else if (targetJob == "towerGuard") {
                                        int towers = state.buildings.FirstOrDefault(b => b.id == NormalizeBuildingId("guardTower"))?.count ?? 0;
                                        if (towers <= 0) {
                                            jobExists = false;
                                        }
                                    }

                                    if (!jobExists || !capacityAvailable) {
                                        targetJob = "Builder";
                                    }
                                    v.job = targetJob;
                                }
                            }
                        }
                    }
                }
            }

            // 4. Repair villagers whose flags say they are on expedition, but they are not in any valid active expedition
            if (state.villagers != null) {
                foreach (var v in state.villagers) {
                    if (v.hp > 0) {
                        if (v.isOnExpedition) {
                            if (string.IsNullOrEmpty(v.expeditionId) || !validExpeditionsMap.ContainsKey(v.expeditionId)) {
                                didRepair = true;
                                v.isOnExpedition = false;
                                v.expeditionId = "";
                                v.job = "Builder";
                            }
                        } else {
                            if (!string.IsNullOrEmpty(v.expeditionId)) {
                                v.expeditionId = "";
                            }
                        }
                    }
                }
            }

            if (didRepair) {
                Log("[World] Expedition state repaired on load.");
            }
        }

        private void NewGame() {
            state = new GameSnapshot();
            state.villagers.Add(new VillagerSnapshot { id = "v1", name = "Bryn", job = "Builder" });
            state.villagers.Add(new VillagerSnapshot { id = "v2", name = "Alaric", job = "Builder" });
            state.villagers.Add(new VillagerSnapshot { id = "v3", name = "Caelum", job = "Builder" });
            state.villagers.Add(new VillagerSnapshot { id = "v4", name = "Darius", job = "Builder" });
            state.wood = repo.GetResource("wood")?.initialAmount ?? 50;
            state.food = repo.GetResource("food")?.initialAmount ?? 50;
            state.iron = repo.GetResource("iron")?.initialAmount ?? 0;
            state.steel = repo.GetResource("steel")?.initialAmount ?? 0;
            state.coal = repo.GetResource("coal")?.initialAmount ?? 0;
            
            // Core Structure - Decode blueprint partial
            state.buildings.Add(new BuildingSnapshot { id = NormalizeBuildingId("bonfire"), count = 1 });
            
            // Initialize World Map State
            state.worldMapState = new WorldMapState();
            foreach (var locDef in repo.WorldMapLocations) {
                state.worldMapState.locations.Add(new WorldMapLocationState {
                    id = locDef.id,
                    displayName = locDef.displayName,
                    type = locDef.type,
                    x = locDef.x,
                    y = locDef.y,
                    spritePath = locDef.spritePath,
                    isDiscovered = locDef.discoveredAtStart,
                    isMajorLocation = locDef.isMajorLocation,
                    dangerLevel = locDef.dangerLevel,
                    rewardType = locDef.rewardType,
                    rewardAmount = locDef.rewardAmount,
                    unlockRequirement = locDef.unlockRequirement,
                    notes = locDef.notes
                });
            }
            // Ensure home is always discovered
            var homeLoc = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals("home", StringComparison.OrdinalIgnoreCase));
            if (homeLoc != null) {
                homeLoc.isDiscovered = true;
            }
            UnityEngine.Debug.Log($"[WorldMap] Initialized game world map with {state.worldMapState.locations.Count} locations.");
            
            Log("Game started.");
            CheckObjectives();
        }

        public CommandResult Execute(GameCommand command) {
            CommandResult result = ExecuteInternal(command);
            QuestEvaluator.Evaluate(state);
            return result;
        }

        private CommandResult ExecuteInternal(GameCommand command) {
            CommandResult result = new CommandResult { success = true };
            if (state == null) {
                result.success = false; result.message = "Game not initialized"; return result;
            }

            if (state.isGameOver) {
                result.success = false; result.message = "Game Over.";
                return result;
            }

            if (command is CollectWoodCommand) {
                state.wood += 10;
                if (state.wood > state.woodCapacity) state.wood = state.woodCapacity;
                Log("Collected 10 Wood. (DEBUG_ONLY)");
            }
            else if (command is BuildHutCommand bHut) {
                if (!HasEnoughResourcesToStartConstruction("hut", out string failReason)) Log($"Not enough resources for Hut");
                else StartConstruction("hut", "Build_Hut", 100, bHut.x, bHut.y);
            }
            else if (command is BuildStorageCommand bStore) {
                if (!HasEnoughResourcesToStartConstruction("storage", out string failReason)) Log($"Not enough resources for Storage");
                else StartConstruction("storage", "Build_Storage", 100, bStore.x, bStore.y);
            }
            else if (command is BuildGuardTowerCommand bTower) {
                if (!HasEnoughResourcesToStartConstruction("guardTower", out string failReason)) Log($"Not enough resources for Guard Tower");
                else StartConstruction("guardTower", "Build_GuardTower", 100, bTower.x, bTower.y);
            }
            else if (command is BuildBlacksmithsForgeCommand bForge) {
                if (!HasEnoughResourcesToStartConstruction("blacksmithsForge", out string failReason)) Log($"Not enough resources for Blacksmith's Forge");
                else StartConstruction("blacksmithsForge", "Build_BlacksmithsForge", 100, bForge.x, bForge.y);
            }
            else if (command is AssignWorkerCommand) {
                // TEMPORARY_DEV_UI / PROTOTYPE_FALLBACK_JOB_UI
                if (state.villagers.Count > 0 && state.selectedVillagerIndex >= 0 && state.selectedVillagerIndex < state.villagers.Count) {
                    var v = state.villagers[state.selectedVillagerIndex];
                    if (v.hp > 0) {
                        string oldJob = v.job;
                        if (v.job == "Builder") v.job = "Woodcutter";
                        else if (v.job == "Woodcutter") v.job = "Miner";
                        else if (v.job == "Miner") v.job = "coalMiner";
                        else if (v.job == "coalMiner") v.job = "Forager";
                        else if (v.job == "Forager") v.job = "Guard";
                        else if (v.job == "Guard") v.job = "towerGuard";
                        else if (v.job == "towerGuard") v.job = "Blacksmith";
                        else v.job = "Builder";
                        AutoEquipForJob(v);
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
                    AutoEquipForJob(v);
                    UnityEngine.Debug.Log($"[JOB_ASSIGNED] villager={v.id} old={old} new={v.job}");
                    Log($"[Job] {v.name} assigned to {v.job}.");
                }
            }
            else if (command is UpgradeBuildingCommand cmdUpgrade) {
                return HandleUpgradeBuilding(cmdUpgrade);
            }
            else if (command is DiscoverWorldMapLocationCommand cmdDiscover) {
                return HandleDiscoverWorldMapLocation(cmdDiscover);
            }
            else if (command is DispatchExpeditionCommand cmdDispatch) {
                return HandleDispatchExpedition(cmdDispatch);
            }
            else if (command is AttackTitanCommand cmdAttack) {
                return HandleAttackTitan(cmdAttack);
            }
            else if (command is AdvanceTimeCommand) {
                ProcessTimeAdvance();
            }
            else if (command is ForceRaidCommand) {
                ProcessRaidCheck(true);
            }
            else if (command is SpawnVillagerCommand) {
                string vId = "v" + (state.villagers.Count + 1);
                state.villagers.Add(new VillagerSnapshot { id = vId, name = "Villager " + (state.villagers.Count + 1), job = "Builder" });
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
                        
                        SanitizeLoadedState();
                        CheckObjectives();

                        // Clean up defeated/retreated enemies on load
                        state.enemies.RemoveAll(e => e.status == "Retreated" || e.status == "Defeated" || e.removePending);
                        
                        RuntimeTrace.Log("LOAD_RESULT", $"success=true snapshotSummary=Wood:{state.wood},Tasks:{state.tasks.Count}");
                        Log("Game Loaded.");
                    } catch (Exception e) {
                        RuntimeTrace.Log("LOAD_RESULT", $"success=false error={e.Message}");
                        Log("Load Failed: " + e.Message);
                    }
                } else {
                    RuntimeTrace.Log("LOAD_RESULT", $"success=false error=FileNotFound");
                    Log("Load Failed: Save file not found.");
                }
            }
            else if (command is DismissExpeditionReportCommand) {
                if (state.pendingExpeditionReports != null && state.pendingExpeditionReports.Count > 0) {
                    state.pendingExpeditionReports.RemoveAt(0);
                    Log("Expedition report dismissed.");
                }
            }
            else if (command is DismissQuestNotificationCommand) {
                if (state.questState != null && state.questState.pendingQuestNotifications != null && state.questState.pendingQuestNotifications.Count > 0) {
                    state.questState.pendingQuestNotifications.RemoveAt(0);
                }
            }
            else if (command is DismissAchievementNotificationCommand) {
                if (state.questState != null && state.questState.pendingAchievementNotifications != null && state.questState.pendingAchievementNotifications.Count > 0) {
                    state.questState.pendingAchievementNotifications.RemoveAt(0);
                }
            }
            else if (command is ResolveRaidCombatHitCommand hitCmd) {
                result = HandleResolveRaidCombatHit(hitCmd);
            }
            else if (command is CraftEquipmentCommand cmdCraft) {
                var forgeCount = state.buildings.FirstOrDefault(b => b.id == "blacksmithsForge")?.count ?? 0;
                if (forgeCount <= 0) {
                    result.success = false;
                    result.message = "Blacksmith's Forge is not built.";
                    return result;
                }
                
                var def = repo.GetEquipment(cmdCraft.equipmentId);
                if (def == null) {
                    result.success = false;
                    result.message = $"Unknown equipment ID: {cmdCraft.equipmentId}";
                    return result;
                }

                foreach (var cost in def.costs) {
                    int amountNeeded = cost.Value * cmdCraft.count;
                    if (cost.Key == "wood" && state.wood < amountNeeded) {
                        result.success = false; result.message = "Not enough Wood."; return result;
                    }
                    if (cost.Key == "iron" && state.iron < amountNeeded) {
                        result.success = false; result.message = "Not enough Iron."; return result;
                    }
                    if (cost.Key == "food" && state.food < amountNeeded) {
                        result.success = false; result.message = "Not enough Food."; return result;
                    }
                    if (cost.Key == "steel" && state.steel < amountNeeded) {
                        result.success = false; result.message = "Not enough Steel."; return result;
                    }
                    if (cost.Key == "coal" && state.coal < amountNeeded) {
                        result.success = false; result.message = "Not enough Coal."; return result;
                    }
                }

                foreach (var cost in def.costs) {
                    int amount = cost.Value * cmdCraft.count;
                    if (cost.Key == "wood") state.wood -= amount;
                    else if (cost.Key == "iron") state.iron -= amount;
                    else if (cost.Key == "food") state.food -= amount;
                    else if (cost.Key == "steel") state.steel -= amount;
                    else if (cost.Key == "coal") state.coal -= amount;
                }

                AddEquipmentToStock(cmdCraft.equipmentId, cmdCraft.count);
                Log($"[Craft] Crafted {cmdCraft.count}x {def.displayName}.");
            }
            else if (command is EquipVillagerEquipmentCommand cmdEquip) {
                var v = state.villagers.Find(x => x.id == cmdEquip.villagerId);
                if (v == null) {
                    result.success = false; result.message = "Villager not found."; return result;
                }
                if (v.hp <= 0) {
                    result.success = false; result.message = "Villager is dead."; return result;
                }

                if (string.IsNullOrEmpty(cmdEquip.equipmentId)) {
                    if (string.Equals(cmdEquip.slot, "Weapon", StringComparison.OrdinalIgnoreCase)) {
                        if (!string.IsNullOrEmpty(v.weaponId)) {
                            AddEquipmentToStock(v.weaponId, 1);
                            v.weaponId = "";
                        }
                    }
                    else if (string.Equals(cmdEquip.slot, "Armor", StringComparison.OrdinalIgnoreCase)) {
                        if (!string.IsNullOrEmpty(v.armorId)) {
                            AddEquipmentToStock(v.armorId, 1);
                            v.armorId = "";
                        }
                    }
                    else if (string.Equals(cmdEquip.slot, "Tool", StringComparison.OrdinalIgnoreCase)) {
                        if (!string.IsNullOrEmpty(v.toolId)) {
                            AddEquipmentToStock(v.toolId, 1);
                            v.toolId = "";
                        }
                    }
                    Log($"[Equipment] Unequipped item from {v.name}.");
                    return result;
                }

                var def = repo.GetEquipment(cmdEquip.equipmentId);
                if (def == null) {
                    result.success = false; result.message = $"Unknown equipment ID: {cmdEquip.equipmentId}"; return result;
                }

                if (string.Equals(cmdEquip.slot, "Weapon", StringComparison.OrdinalIgnoreCase)) {
                    if (!string.Equals(def.slot, "Weapon", StringComparison.OrdinalIgnoreCase)) {
                        result.success = false; result.message = "Item is not a Weapon."; return result;
                    }
                    if (!IsWeaponCompatible(cmdEquip.equipmentId, v.job)) {
                        result.success = false; result.message = $"Weapon {def.displayName} is incompatible with job {v.job}."; return result;
                    }
                }
                else if (string.Equals(cmdEquip.slot, "Tool", StringComparison.OrdinalIgnoreCase)) {
                    if (!string.Equals(def.slot, "Tool", StringComparison.OrdinalIgnoreCase)) {
                        result.success = false; result.message = "Item is not a Tool."; return result;
                    }
                    if (!IsToolCompatible(cmdEquip.equipmentId, v.job)) {
                        result.success = false; result.message = $"Tool {def.displayName} is incompatible with job {v.job}."; return result;
                    }
                }
                else if (string.Equals(cmdEquip.slot, "Armor", StringComparison.OrdinalIgnoreCase)) {
                    if (!string.Equals(def.slot, "Armor", StringComparison.OrdinalIgnoreCase)) {
                        result.success = false; result.message = "Item is not Armor."; return result;
                    }
                }
                else {
                    result.success = false; result.message = "Unknown equipment slot."; return result;
                }

                string currentEquipped = "";
                if (string.Equals(cmdEquip.slot, "Weapon", StringComparison.OrdinalIgnoreCase)) currentEquipped = v.weaponId;
                else if (string.Equals(cmdEquip.slot, "Armor", StringComparison.OrdinalIgnoreCase)) currentEquipped = v.armorId;
                else if (string.Equals(cmdEquip.slot, "Tool", StringComparison.OrdinalIgnoreCase)) currentEquipped = v.toolId;

                if (string.Equals(currentEquipped, cmdEquip.equipmentId, StringComparison.OrdinalIgnoreCase)) {
                    return result;
                }

                int stockCount = GetEquipmentStockCount(cmdEquip.equipmentId);
                if (stockCount <= 0) {
                    result.success = false; result.message = $"Item {def.displayName} is not in stock."; return result;
                }

                if (!string.IsNullOrEmpty(currentEquipped)) {
                    AddEquipmentToStock(currentEquipped, 1);
                }

                RemoveEquipmentFromStock(cmdEquip.equipmentId, 1);

                if (string.Equals(cmdEquip.slot, "Weapon", StringComparison.OrdinalIgnoreCase)) v.weaponId = cmdEquip.equipmentId;
                else if (string.Equals(cmdEquip.slot, "Armor", StringComparison.OrdinalIgnoreCase)) v.armorId = cmdEquip.equipmentId;
                else if (string.Equals(cmdEquip.slot, "Tool", StringComparison.OrdinalIgnoreCase)) v.toolId = cmdEquip.equipmentId;

                Log($"[Equipment] Equipped {def.displayName} on {v.name}.");
            }
            else if (command is TradeCommand cmdTrade) {
                result = HandleTrade(cmdTrade);
            }

            // Always evaluate quests and achievements after a command
            QuestEvaluator.Evaluate(state);

            return result;
        }

        private Vector2 GetGuardTowerPosition() {
            var towerPlacement = state.userPlacements.FirstOrDefault(p => p.id.StartsWith("building:guardTower:", StringComparison.OrdinalIgnoreCase));
            if (towerPlacement != null) {
                return new Vector2(towerPlacement.x, towerPlacement.y);
            }
            var constrPlacement = state.userPlacements.FirstOrDefault(p => p.id.StartsWith("construction:guardTower:", StringComparison.OrdinalIgnoreCase));
            if (constrPlacement != null) {
                return new Vector2(constrPlacement.x, constrPlacement.y);
            }
            return Vector2.zero;
        }

        private CommandResult HandleResolveRaidCombatHit(ResolveRaidCombatHitCommand hitCmd) {
            CommandResult result = new CommandResult { success = true };
            var enemy = state.enemies.Find(e => e.id == hitCmd.enemyId);
            
            bool isTowerGuard = false;
            if (!string.IsNullOrEmpty(hitCmd.guardVillagerId)) {
                var v = state.villagers.Find(x => x.id == hitCmd.guardVillagerId);
                if (v != null && v.job == "towerGuard" && v.hp > 0) {
                    isTowerGuard = true;
                }
            }

            if (isTowerGuard) {
                var activeEnemiesList = state.enemies.Where(e => e.hp > 0 && e.status == "Active" && !e.removePending).ToList();
                if (activeEnemiesList.Count == 0) return result;

                Vector2 towerPos = GetGuardTowerPosition();
                EnemyState nearestEnemy = null;
                float minDistance = float.MaxValue;
                foreach (var activeEnemy in activeEnemiesList) {
                    float dist = Vector2.Distance(towerPos, new Vector2(activeEnemy.x, activeEnemy.y));
                    if (dist < minDistance) {
                        minDistance = dist;
                        nearestEnemy = activeEnemy;
                    }
                }
                if (nearestEnemy != null) {
                    enemy = nearestEnemy;
                } else {
                    return result;
                }
            } else {
                if (enemy == null || enemy.hp <= 0) return result;
            }

            // Monster attacks target
            if (!string.IsNullOrEmpty(hitCmd.targetVillagerId)) {
                var target = state.villagers.Find(v => v.id == hitCmd.targetVillagerId);
                if (target != null && target.hp > 0) {
                    int dmgToTarget = UnityEngine.Mathf.Max(1, enemy.attack - GetVillagerDefense(target));
                    target.hp -= dmgToTarget;
                    if (target.hp < 0) target.hp = 0;
                    
                    if (target.hp <= 0) {
                        target.job = "Idle";
                        target.state = "Dead";
                        Log($"[Raid] Guard {target.name} has fallen.");
                    } else {
                        if (!lastLoggedVillagerHp.ContainsKey(target.id) || (lastLoggedVillagerHp[target.id] - target.hp) >= 15) {
                            Log($"[Raid] Monster strikes {target.name} for {dmgToTarget} damage.");
                            lastLoggedVillagerHp[target.id] = target.hp;
                        }
                    }
                }
            }

            // Guard/TowerGuard attacks monster
            if (!string.IsNullOrEmpty(hitCmd.guardVillagerId) && enemy.hp > 0) {
                var guard = state.villagers.Find(v => v.id == hitCmd.guardVillagerId);
                if (guard != null && guard.hp > 0) {
                    int guardAttack = GetVillagerAttack(guard);
                    
                    enemy.hp -= guardAttack;
                    if (enemy.hp <= 0) {
                        enemy.hp = 0;
                        enemy.status = "Defeated";
                        enemy.removePending = true;

                        // Grant Food reward based on typeId / monsterId
                        int reward = 15;
                        if (string.Equals(enemy.monsterId, "Fast", StringComparison.OrdinalIgnoreCase)) reward = 20;
                        else if (string.Equals(enemy.monsterId, "Tank", StringComparison.OrdinalIgnoreCase)) reward = 40;

                        state.food += reward;
                        if (state.food > state.foodCapacity) state.food = state.foodCapacity;

                        Log($"[Raid] Monster defeated by {guard.name}!");
                        Log($"Defeated {enemy.displayName}. Gained {reward} Food.");
                        lastLoggedEnemyHp = -1; // Reset
                    } else {
                        if (lastLoggedEnemyHp == -1 || (lastLoggedEnemyHp - enemy.hp) >= 20) {
                            Log($"[Raid] {guard.name} struck the monster! (Monster HP: {enemy.hp})");
                            lastLoggedEnemyHp = enemy.hp;
                        }
                    }
                }
            }
            return result;
        }

        private CommandResult HandleUpgradeBuilding(UpgradeBuildingCommand cmdUpgrade) {
            CommandResult result = new CommandResult { success = true };
            if (string.IsNullOrEmpty(cmdUpgrade.buildingPlacementId)) {
                result.success = false;
                result.message = "Target building placement ID is empty.";
                return result;
            }

            var placedObj = state.userPlacements.Find(p => p.id == cmdUpgrade.buildingPlacementId);
            if (placedObj == null) {
                result.success = false;
                result.message = "Target building placement not found.";
                Log("Upgrade failed: Building placement not found.");
                return result;
            }

            // Explicitly validate building identity structure
            string[] parts = placedObj.id.Split(':');
            if (parts.Length < 3 || parts[0] != "building") {
                result.success = false;
                result.message = "Target placement is not a completed building.";
                Log($"Upgrade failed: {placedObj.id} is not a completed building placement.");
                return result;
            }

            string bId = parts[1];
            if (bId != "hut" && bId != "storage") {
                result.success = false;
                result.message = "Target building is not a Hut or Storage.";
                Log($"Upgrade failed: {placedObj.id} is not a Hut or Storage.");
                return result;
            }

            if (!int.TryParse(parts[2], out int buildingIndex) || buildingIndex < 0) {
                result.success = false;
                result.message = "Invalid building index in placement ID.";
                Log($"Upgrade failed: {placedObj.id} has invalid building index.");
                return result;
            }

            var bldSnapshot = state.buildings.FirstOrDefault(b => b.id == bId);
            if (bldSnapshot == null || buildingIndex >= bldSnapshot.count) {
                result.success = false;
                result.message = "Target building does not exist in state registry.";
                Log($"Upgrade failed: {placedObj.id} count mismatch or building snapshot missing.");
                return result;
            }

            if (placedObj.level != 1) {
                result.success = false;
                result.message = "Target building is already at max level.";
                Log($"Upgrade failed: {placedObj.id} is already at Level {placedObj.level}.");
                return result;
            }

            // Check if there is already an active upgrade task for this placement
            if (state.tasks.Any(t => t.type == "UpgradeBuilding" && t.targetPlacementId == placedObj.id)) {
                result.success = false;
                result.message = "An upgrade is already in progress for this building.";
                Log($"Upgrade failed: An upgrade is already in progress for {placedObj.id}.");
                return result;
            }

            var bdef = repo.GetBuilding(bId);
            if (bdef == null) {
                result.success = false;
                result.message = "Building definition not found.";
                return result;
            }

            int woodCost = 0;
            int ironCost = 0;
            if (bdef.costs.TryGetValue("wood", out int w)) woodCost = w * 2;
            if (bdef.costs.TryGetValue("iron", out int i)) ironCost = i * 2;

            if (state.wood < woodCost || state.iron < ironCost) {
                result.success = false;
                result.message = "Not enough resources.";
                Log($"Upgrade failed: Not enough resources. Need Wood:{woodCost}, Iron:{ironCost}.");
                return result;
            }

            // Deduct resources
            state.wood = Math.Max(0, state.wood - woodCost);
            state.iron = Math.Max(0, state.iron - ironCost);

            // Create upgrade task
            string taskId = System.Guid.NewGuid().ToString();
            var task = new TaskSnapshot {
                id = taskId,
                type = "UpgradeBuilding",
                targetBuildingId = bId,
                targetPlacementId = placedObj.id,
                status = "UnderConstruction",
                fidelityClassification = "DECODE_EVIDENCE_PARTIAL",
                currentCompletion = 0,
                finalCompletion = bdef.constructionRequired,
                isResourcesComplete = true
            };
            state.tasks.Add(task);
            Log($"[Upgrade] Started upgrading {bdef.displayName} ({placedObj.id}) to Level 2. Resources spent: Wood {woodCost}, Iron {ironCost}.");
            return result;
        }

        public int GetVillagerBaseDefense(VillagerSnapshot villager) {
            return 10;
        }

        public int GetVillagerDefense(VillagerSnapshot villager) {
            if (villager == null) return 10;
            int def = GetVillagerBaseDefense(villager);
            if (!string.IsNullOrEmpty(villager.armorId)) {
                var equip = repo.GetEquipment(villager.armorId);
                if (equip != null && string.Equals(equip.category, "Armor", StringComparison.OrdinalIgnoreCase)) {
                    def += equip.defenseBonus;
                }
            }
            return def;
        }

        public int GetVillagerBaseAttack(VillagerSnapshot villager) {
            if (villager == null) return 10;
            var jobDef = repo.GetJob(villager.job);
            int jobAttack = (jobDef != null && jobDef.defense > 0) ? jobDef.defense : 10;
            return jobAttack;
        }

        public int GetVillagerAttack(VillagerSnapshot villager) {
            if (villager == null) return 10;
            int attack = GetVillagerBaseAttack(villager);
            if (!string.IsNullOrEmpty(villager.weaponId)) {
                var equip = repo.GetEquipment(villager.weaponId);
                if (equip != null && string.Equals(equip.category, "Weapon", StringComparison.OrdinalIgnoreCase)) {
                    attack += equip.attackBonus;
                }
            }
            return attack;
        }

        public int GetVillagerToolBonus(VillagerSnapshot villager, string jobId) {
            if (villager == null || string.IsNullOrEmpty(villager.toolId)) return 0;
            var equip = repo.GetEquipment(villager.toolId);
            if (equip != null && string.Equals(equip.category, "Tool", StringComparison.OrdinalIgnoreCase)) {
                if (string.Equals(jobId, "Woodcutter", StringComparison.OrdinalIgnoreCase) && string.Equals(equip.id, "woodAxe", StringComparison.OrdinalIgnoreCase)) {
                    return equip.jobBonus;
                }
                if ((string.Equals(jobId, "Miner", StringComparison.OrdinalIgnoreCase) || string.Equals(jobId, "coalMiner", StringComparison.OrdinalIgnoreCase)) 
                     && string.Equals(equip.id, "pickaxe", StringComparison.OrdinalIgnoreCase)) {
                    return equip.jobBonus;
                }
                if ((string.Equals(jobId, "Builder", StringComparison.OrdinalIgnoreCase) || string.Equals(jobId, "Blacksmith", StringComparison.OrdinalIgnoreCase)) 
                     && string.Equals(equip.id, "hammer", StringComparison.OrdinalIgnoreCase)) {
                    return equip.jobBonus;
                }
            }
            return 0;
        }

        public int GetVillagerAttackForDisplay(VillagerSnapshot villager) {
            return GetVillagerAttack(villager);
        }

        public int GetVillagerDefenseForDisplay(VillagerSnapshot villager) {
            return GetVillagerDefense(villager);
        }

        public int GetVillagerToolBonusForDisplay(VillagerSnapshot villager, string jobId) {
            return GetVillagerToolBonus(villager, jobId);
        }

        public int GetVillagerWorkOutputForDisplay(VillagerSnapshot villager) {
            if (villager == null) return 0;
            if (string.Equals(villager.job, "Builder", StringComparison.OrdinalIgnoreCase)) {
                return 25 + GetVillagerToolBonus(villager, "Builder");
            }
            if (string.Equals(villager.job, "Woodcutter", StringComparison.OrdinalIgnoreCase)) {
                int baseProd = repo.GetJob("Woodcutter")?.productionPerPhase ?? 10;
                if (baseProd <= 0) baseProd = 10;
                return baseProd + GetVillagerToolBonus(villager, "Woodcutter");
            }
            if (string.Equals(villager.job, "Miner", StringComparison.OrdinalIgnoreCase)) {
                int baseProd = repo.GetJob("Miner")?.productionPerPhase ?? 3;
                if (baseProd <= 0) baseProd = 3;
                return baseProd + GetVillagerToolBonus(villager, "Miner");
            }
            if (string.Equals(villager.job, "coalMiner", StringComparison.OrdinalIgnoreCase)) {
                int baseProd = repo.GetJob("coalMiner")?.productionPerPhase ?? 1;
                if (baseProd <= 0) baseProd = 1;
                return baseProd + GetVillagerToolBonus(villager, "coalMiner");
            }
            if (string.Equals(villager.job, "Forager", StringComparison.OrdinalIgnoreCase)) {
                int baseProd = repo.GetJob("Forager")?.productionPerPhase ?? 4;
                if (baseProd <= 0) baseProd = 4;
                return baseProd;
            }
            if (string.Equals(villager.job, "farmer", StringComparison.OrdinalIgnoreCase) || string.Equals(villager.job, "Farmer", StringComparison.OrdinalIgnoreCase)) {
                int baseProd = repo.GetJob("farmer")?.productionPerPhase ?? 6;
                if (baseProd <= 0) baseProd = 6;
                return baseProd;
            }
            return 0;
        }

        private bool IsWeaponCompatible(string weaponId, string job) {
            if (string.IsNullOrEmpty(weaponId)) return true;
            if (string.Equals(weaponId, "sword", StringComparison.OrdinalIgnoreCase)) {
                return string.Equals(job, "Guard", StringComparison.OrdinalIgnoreCase);
            }
            if (string.Equals(weaponId, "bow", StringComparison.OrdinalIgnoreCase)) {
                return string.Equals(job, "towerGuard", StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        private bool IsToolCompatible(string toolId, string job) {
            if (string.IsNullOrEmpty(toolId)) return true;
            if (string.Equals(toolId, "pickaxe", StringComparison.OrdinalIgnoreCase)) {
                return string.Equals(job, "Miner", StringComparison.OrdinalIgnoreCase) || string.Equals(job, "coalMiner", StringComparison.OrdinalIgnoreCase);
            }
            if (string.Equals(toolId, "hammer", StringComparison.OrdinalIgnoreCase)) {
                return string.Equals(job, "Builder", StringComparison.OrdinalIgnoreCase) || string.Equals(job, "Blacksmith", StringComparison.OrdinalIgnoreCase);
            }
            if (string.Equals(toolId, "woodAxe", StringComparison.OrdinalIgnoreCase)) {
                return string.Equals(job, "Woodcutter", StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        private int GetEquipmentStockCount(string equipmentId) {
            if (state.equipmentStock == null) state.equipmentStock = new List<EquipmentStack>();
            var stack = state.equipmentStock.FirstOrDefault(s => s.equipmentId.Equals(equipmentId, StringComparison.OrdinalIgnoreCase));
            return stack != null ? stack.count : 0;
        }

        private void AddEquipmentToStock(string equipmentId, int count) {
            if (state.equipmentStock == null) state.equipmentStock = new List<EquipmentStack>();
            var stack = state.equipmentStock.FirstOrDefault(s => s.equipmentId.Equals(equipmentId, StringComparison.OrdinalIgnoreCase));
            if (stack == null) {
                stack = new EquipmentStack { equipmentId = equipmentId, count = 0 };
                state.equipmentStock.Add(stack);
            }
            stack.count += count;
        }

        private void RemoveEquipmentFromStock(string equipmentId, int count) {
            if (state.equipmentStock == null) state.equipmentStock = new List<EquipmentStack>();
            var stack = state.equipmentStock.FirstOrDefault(s => s.equipmentId.Equals(equipmentId, StringComparison.OrdinalIgnoreCase));
            if (stack != null) {
                stack.count = Math.Max(0, stack.count - count);
            }
        }

        public void AutoEquipForJob(VillagerSnapshot v) {
            if (v == null) return;
            
            // Unequip weapon if incompatible
            if (!IsWeaponCompatible(v.weaponId, v.job)) {
                if (!string.IsNullOrEmpty(v.weaponId)) {
                    AddEquipmentToStock(v.weaponId, 1);
                }
                v.weaponId = "";
            }
            
            // Unequip tool if incompatible
            if (!IsToolCompatible(v.toolId, v.job)) {
                if (!string.IsNullOrEmpty(v.toolId)) {
                    AddEquipmentToStock(v.toolId, 1);
                }
                v.toolId = "";
            }
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
        
        public void StartConstruction(string bId, string taskType, int fallbackCompletion, float x = 0, float y = 0) {
            bId = NormalizeBuildingId(bId);
            var bdef = repo.GetBuilding(bId);
            int wCost = bdef != null && bdef.costs.TryGetValue("wood", out int w) ? w : 0;
            int iCost = bdef != null && bdef.costs.TryGetValue("iron", out int i) ? i : 0;
            
            string taskId = System.Guid.NewGuid().ToString();
            
            if (Math.Abs(x) > 0.001f || Math.Abs(y) > 0.001f) {
                state.userPlacements.Add(new PlacedObject { id = "construction:" + bId + ":" + taskId, x = x, y = y });
            }
            
            var task = new TaskSnapshot {
                id = taskId,
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
            Log($"[Build] Started construction of {bdef?.displayName ?? bId}.");
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
            string constrId = "construction:" + task.targetBuildingId + ":" + task.id;
            var place = state.userPlacements.Find(p => p.id == constrId);
            if (place != null) {
                place.id = "building:" + task.targetBuildingId + ":" + (bld.count - 1);
            }
            var bdef = repo.GetBuilding(task.targetBuildingId);
            Log($"TEST_TOOL: Completed {bdef?.displayName ?? task.targetBuildingId}.");
        }
        // --------------------------------

        private void ProcessTimeAdvance() {
            // Milestone progression check: transition to next milestone on time advance command
            if (state.objectiveState.status == "COMPLETED" && state.isObjectiveComplete && !state.isGameOver) {
                if (state.objectiveState.currentMilestoneIndex >= 1 && state.objectiveState.currentMilestoneIndex < 5) {
                    state.objectiveState.currentMilestoneIndex++;
                    state.objectiveState.status = "IN_PROGRESS";
                    state.isObjectiveComplete = false;
                    Log($"Advancing to Milestone {state.objectiveState.currentMilestoneIndex}!");
                    CheckObjectives();
                }
            }

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
                    prod += GetVillagerToolBonus(v, "Woodcutter");
                    productionWood += prod;
                    state.wood = Mathf.Min(state.woodCapacity, state.wood + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Woodcutter woodDelta=+{prod} wood={state.wood}/{state.woodCapacity}");
                }
                else if (v.job == "Forager") {
                    int prod = repo.GetJob("Forager")?.productionPerPhase ?? 4;
                    if (prod <= 0) prod = 4;
                    state.food = Mathf.Min(state.foodCapacity, state.food + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Forager foodDelta=+{prod} food={state.food}/{state.foodCapacity} worksite=fallback_or_visual_forage");
                }
                else if (v.job == "Farmer") {
                    int prod = repo.GetJob("farmer")?.productionPerPhase ?? 6;
                    if (prod <= 0) prod = 6;
                    state.food = Mathf.Min(state.foodCapacity, state.food + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Farmer foodDelta=+{prod} food={state.food}/{state.foodCapacity} worksite=farm_1");
                }
                else if (v.job == "Miner") {
                    int prod = repo.GetJob("Miner")?.productionPerPhase ?? 3;
                    if (prod <= 0) prod = 3;
                    prod += GetVillagerToolBonus(v, "Miner");
                    state.iron = Mathf.Min(state.ironCapacity, state.iron + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Miner ironDelta=+{prod} iron={state.iron}/{state.ironCapacity} worksite=fallback_or_visual_mine");
                }
                else if (v.job == "coalMiner") {
                    int prod = repo.GetJob("coalMiner")?.productionPerPhase ?? 1;
                    if (prod <= 0) prod = 1;
                    prod += GetVillagerToolBonus(v, "coalMiner");
                    state.coal = Mathf.Min(state.coalCapacity, state.coal + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=coalMiner coalDelta=+{prod} coal={state.coal}/{state.coalCapacity}");
                }
                else if (v.job == "Blacksmith") {
                    int forges = state.buildings.FirstOrDefault(b => b.id == "blacksmithsForge")?.count ?? 0;
                    if (forges > 0) {
                        var blacksmiths = state.villagers
                            .Where(v2 => v2.job == "Blacksmith" && v2.hp > 0)
                            .OrderBy(v2 => v2.id)
                            .ToList();
                        int idx = blacksmiths.IndexOf(v);
                        if (idx >= 0 && idx < forges * 2) {
                            // Primary: Coal + Iron -> Steel
                            if (state.coal >= 1 && state.iron >= 1 && state.steel < state.steelCapacity) {
                                state.coal -= 1;
                                state.iron -= 1;
                                state.steel += 1;
                                Log($"[Production] {v.name} made 1 Steel from Coal + Iron.");
                                RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Blacksmith steelDelta=+1 steel={state.steel}/{state.steelCapacity} via=coal");
                            }
                            // Fallback: Wood + Iron -> Steel (safe migration, no coal yet)
                            else if (state.iron >= 1 && state.wood >= 1 && state.steel < state.steelCapacity) {
                                state.iron -= 1;
                                state.wood -= 1;
                                state.steel += 1;
                                Log($"[Production] {v.name} made 1 Steel from Wood + Iron (fallback).");
                                RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Blacksmith steelDelta=+1 steel={state.steel}/{state.steelCapacity} via=wood_fallback");
                            }
                        } else {
                            Log($"[Production] Blacksmith {v.name} is overflow (Forge capacity reached).");
                        }
                    }
                }
            }

            int builders = state.villagers.Count(v => v.job == "Builder" && v.hp > 0);
            if (builders > 0 && state.tasks.Count > 0) {
                var task = state.tasks.FirstOrDefault(t => t.status == "AwaitingResources" || t.status == "UnderConstruction");
                if (task != null) {
                    // Task Safety Check: Verify target building placement still exists
                    bool isTaskTargetValid = true;
                    if (task.type == "UpgradeBuilding") {
                        var place = state.userPlacements.Find(p => p.id == task.targetPlacementId);
                        if (place == null) {
                            isTaskTargetValid = false;
                            Log($"[Upgrade] Upgrade task cancelled: Target building placement {task.targetPlacementId} no longer exists.");
                        }
                    } else if (task.type.StartsWith("Build") || task.type == "BuildHut" || task.type == "BuildStorage" || task.type == "BuildGuardTower" || task.type == "BuildBlacksmithsForge") {
                        string constrId = "construction:" + task.targetBuildingId + ":" + task.id;
                        if (state.userPlacements.Any(p => p.id.StartsWith("construction:" + task.targetBuildingId + ":"))) {
                            var hasConstrPlacement = state.userPlacements.Any(p => p.id == constrId);
                            if (!hasConstrPlacement) {
                                isTaskTargetValid = false;
                                Log($"[Build] Construction task cancelled: Target placement {constrId} no longer exists.");
                            }
                        }
                    }

                    if (!isTaskTargetValid) {
                        state.tasks.Remove(task);
                    } else {
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
                            int labour = 0;
                            foreach (var v in state.villagers.Where(v => v.job == "Builder" && v.hp > 0)) {
                                int baseLabour = 25;
                                int bonus = GetVillagerToolBonus(v, "Builder");
                                labour += (baseLabour + bonus);
                            }
                            task.currentCompletion += labour;
                            RuntimeTrace.Log("CONSTRUCTION_PROGRESS", $"TaskId={task.id} AddedLabour={labour}");
                            Log($"Builder added {labour} labour to {task.targetBuildingId}. ({task.currentCompletion}/{task.finalCompletion})");
                            
                            if (task.currentCompletion >= task.finalCompletion) {
                                var bdef = repo.GetBuilding(task.targetBuildingId);
                                if (task.type == "UpgradeBuilding") {
                                    var place = state.userPlacements.Find(p => p.id == task.targetPlacementId);
                                    if (place != null) {
                                        place.level = 2;
                                        Log($"[Upgrade] Upgraded {bdef?.displayName ?? task.targetBuildingId} to Level 2.");
                                        RuntimeTrace.Log("UPGRADE_COMPLETED", $"PlacementId={place.id} Level=2");
                                    }
                                    state.tasks.Remove(task);
                                } else {
                                    var bld = state.buildings.Find(b => b.id == task.targetBuildingId);
                                    if (bld == null) { bld = new BuildingSnapshot { id = task.targetBuildingId, count = 0 }; state.buildings.Add(bld); }
                                    bld.count++;
                                    state.tasks.Remove(task);
                                    
                                    // Transfer placement from construction to completed building
                                    string constrId = "construction:" + task.targetBuildingId + ":" + task.id;
                                    var place = state.userPlacements.Find(p => p.id == constrId);
                                    if (place != null) {
                                        place.id = "building:" + task.targetBuildingId + ":" + (bld.count - 1);
                                    }

                                    RuntimeTrace.Log("CONSTRUCTION_COMPLETED", $"TaskId={task.id} Building={task.targetBuildingId}");
                                    
                                    string buildMsg = $"[Build] {bdef?.displayName ?? task.targetBuildingId} built.";
                                    if (task.targetBuildingId.ToLower().Contains("hut")) buildMsg += " Population capacity increased.";
                                    else if (task.targetBuildingId.ToLower().Contains("storage")) buildMsg += " Resource capacity increased.";
                                    else if (task.targetBuildingId.ToLower().Contains("tower") || task.targetBuildingId.ToLower().Contains("post")) buildMsg += " DEF increased.";
                                    
                                    Log(buildMsg);
                                }
                            }
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
            else if (state.timeOfDay == "Afternoon") { 
                state.timeOfDay = "Evening"; 
                // Pre-roll night raid warning
                if (state.lastRaidDay != state.day && !state.isRaidImminentToday) {
                    float roll = (float)rng.NextDouble();
                    if (roll < NightRaidChance) {
                        state.isRaidImminentToday = true;
                        Log("[Raid Warning] A raid is imminent tonight!");
                    }
                }
            }
            else if (state.timeOfDay == "Evening") { 
                state.timeOfDay = "Night"; 
                ProcessRaidCheck(false);
            }
            else if (state.timeOfDay == "Night") { 
                state.timeOfDay = "Morning"; 
                state.day++; 
                ProcessDailyUpkeep();

                // Merchant schedule tick
                if (state.tradeState == null) {
                    state.tradeState = new TradeState {
                        isMerchantPresent = false,
                        daysUntilNextMerchant = 2,
                        merchantDaysRemaining = 0
                    };
                }
                if (state.tradeState.isMerchantPresent) {
                    state.tradeState.merchantDaysRemaining--;
                    if (state.tradeState.merchantDaysRemaining <= 0) {
                        state.tradeState.isMerchantPresent = false;
                        state.tradeState.daysUntilNextMerchant = 3;
                        state.tradeState.merchantDaysRemaining = 0;
                        Log("[Trade 16B] Merchant departed. Next arrival in 3 days.");
                    }
                } else {
                    state.tradeState.daysUntilNextMerchant--;
                    if (state.tradeState.daysUntilNextMerchant <= 0) {
                        state.tradeState.isMerchantPresent = true;
                        state.tradeState.daysUntilNextMerchant = 0;
                        state.tradeState.merchantDaysRemaining = 1;
                        Log("[Trade 16B] Merchant arrived!");
                    }
                }
            }

            if (oldDay != state.day) Log($"Time advanced: Night -> Day {state.day} Morning");
            else Log($"Time advanced: {oldPhase} -> {state.timeOfDay}");
            
            ProcessExpeditions();
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
                        if (skipMorningHealAfterRaid) {
                            RuntimeTrace.Log("HEALTH_RECOVERY_SKIP", $"villager={v.id} reason=raid_healing_paused");
                        } else {
                            int oldHp = v.hp;
                            v.hp = UnityEngine.Mathf.Min(MaxVillagerHp, v.hp + WellFedHealAmount);
                            Log($"Villagers ate well. {v.name} recovered {v.hp - oldHp} HP.");
                            RuntimeTrace.Log("HEALTH_RECOVERY", $"villager={v.id} hpBefore={oldHp} hpAfter={v.hp} reason=well_fed");
                            anyHealed = true;
                        }
                    } else {
                        RuntimeTrace.Log("HEALTH_RECOVERY_SKIP", $"villager={v.id} reason=full_hp");
                    }
                }
                
                // Consume the skip flag after we used it this morning
                skipMorningHealAfterRaid = false;
                
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

            // Recruitment Check
            if (state.gameStatus == "Playing") {
                int recruitFoodThreshold = 10;
                int recruitFoodCost = 5;
                if (state.villagers.Count < state.maxPopulation) {
                    if (state.food >= recruitFoodThreshold) {
                        state.food -= recruitFoodCost;
                        string newId = "v" + (state.villagers.Count + 1);
                        state.villagers.Add(new VillagerSnapshot {
                            id = newId,
                            name = "Villager " + (state.villagers.Count + 1),
                            job = "Idle",
                            hp = MaxVillagerHp,
                            state = "Alive"
                        });
                        Log("A new villager arrived.");
                        RuntimeTrace.Log("RECRUITMENT_SUCCESS", $"villager={newId} foodAfter={state.food}");
                    } else {
                        Log("Not enough food to attract new villagers.");
                        RuntimeTrace.Log("RECRUITMENT_SKIP", "reason=food_low");
                    }
                } else {
                    Log("Population capacity full.");
                    RuntimeTrace.Log("RECRUITMENT_SKIP", "reason=cap_full");
                }
            }
        }

        private const float NightRaidChance = 0.50f;

        private void ProcessRaidCheck(bool forced = false) {
            if (state.isGameOver) return;
            if (state.objectiveState.status == "FAILED" || (state.objectiveState.status == "COMPLETED" && state.objectiveState.currentMilestoneIndex == 5)) return;
            RuntimeTrace.Log("RAID_CHECK", $"Day={state.day}");
            
            bool triggerRaid = false;
            if (forced) {
                triggerRaid = true;
            } else if (state.isRaidImminentToday) {
                triggerRaid = true;
                state.isRaidImminentToday = false; // clear warning flag
            }

            if (triggerRaid && state.lastRaidDay != state.day) {
                state.lastRaidDay = state.day;
                Log("[Raid] Monster appeared.");
                
                state.totalDefense = 10; // Cache for UI: baseline villager defense is 10
                
                int targetMonsterCount = 1;
                string allowedTypesStr = "SmallMonster";
                System.Collections.Generic.List<string> allowedTypes = new System.Collections.Generic.List<string> { "SmallMonster" };
                
                if (state.day < 10) {
                    targetMonsterCount = 1;
                    allowedTypesStr = "SmallMonster";
                    allowedTypes = new System.Collections.Generic.List<string> { "SmallMonster" };
                } else {
                    targetMonsterCount = UnityEngine.Mathf.Min(4, 2 + ((state.day - 10) / 10));
                    allowedTypesStr = "SmallMonster,Basic,Fast,Tank";
                    allowedTypes = new System.Collections.Generic.List<string> { "SmallMonster", "Basic", "Fast", "Tank" };
                }
                
                int activeBefore = state.enemies.Count(e => e.hp > 0 && e.status == "Active" && !e.removePending);
                int spawnCountNeeded = targetMonsterCount - activeBefore;
                int activeAfter = activeBefore;
                
                if (spawnCountNeeded <= 0) {
                    UnityEngine.Debug.Log($"[Monster Spawn Audit] day={state.day} targetCount={targetMonsterCount} activeBefore={activeBefore} activeAfter={activeAfter}");
                    UnityEngine.Debug.Log($"[Monster Spawn Audit] allowedTypes={allowedTypesStr}");
                    UnityEngine.Debug.Log("[Monster Spawn Audit] skipped reason=active_monster_cap");
                    
                    // Activate the heal skip flag for the next morning
                    skipMorningHealAfterRaid = true;
                    UnityEngine.Debug.Log($"[RaidCheck] imminent={state.isRaidImminentToday} forced={forced} triggered={triggerRaid}");
                    return;
                }
                
                var availablePoints = SpawnPointProvider.GetSpawnPoints();
                var usedPointsInThisWave = new System.Collections.Generic.HashSet<string>();
                int spawnedThisWave = 0;
                
                var auditLogs = new System.Collections.Generic.List<string>();
                
                for (int i = 0; i < spawnCountNeeded; i++) {
                    double typeRoll = rng.NextDouble();
                    string selectedType = "SmallMonster"; // Default
                    if (state.day >= 10) {
                        if (typeRoll < 0.25) selectedType = "SmallMonster";
                        else if (typeRoll < 0.50) selectedType = "Basic";
                        else if (typeRoll < 0.75) selectedType = "Fast";
                        else selectedType = "Tank";
                    }
                    
                    SpawnPointProvider.SpawnPoint chosenPoint = null;
                    
                    // 1. Prefer type-specific
                    if (selectedType != "SmallMonster") {
                        chosenPoint = availablePoints.FirstOrDefault(p => 
                            !usedPointsInThisWave.Contains(p.name) && 
                            p.enemyType.Equals(selectedType, System.StringComparison.OrdinalIgnoreCase)
                        );
                    }
                    
                    // 2. Fallback to general raid spawn point (enemyType is empty)
                    if (chosenPoint == null) {
                        chosenPoint = availablePoints.FirstOrDefault(p => 
                            !usedPointsInThisWave.Contains(p.name) && 
                            string.IsNullOrEmpty(p.enemyType)
                        );
                    }
                    
                    // 3. Fallback to any unused point
                    if (chosenPoint == null) {
                        chosenPoint = availablePoints.FirstOrDefault(p => 
                            !usedPointsInThisWave.Contains(p.name)
                        );
                    }
                    
                    if (chosenPoint == null) {
                        auditLogs.Add("[Monster Spawn Audit] skipped reason=no_valid_spawn_point");
                        continue;
                    }
                    
                    usedPointsInThisWave.Add(chosenPoint.name);
                    
                    var enemyDef = repo.GetEnemy(selectedType);
                    int eHp = enemyDef?.hp ?? (selectedType == "Tank" ? 120 : selectedType == "Fast" ? 40 : selectedType == "SmallMonster" ? 30 : 60);
                    int eAtk = enemyDef?.attack ?? (selectedType == "Tank" ? 25 : selectedType == "Fast" ? 10 : selectedType == "SmallMonster" ? 15 : 15);
                    string displayName = enemyDef?.displayName ?? (selectedType == "Tank" ? "Orc Titan" : selectedType == "Fast" ? "Feral Wolf" : selectedType == "SmallMonster" ? "Small Monster" : "Goblin Raider");
                    
                    EnemyState enemy = new EnemyState { 
                        id = "e_" + state.day + "_" + i + "_" + System.Guid.NewGuid().ToString().Substring(0, 4), 
                        typeId = selectedType, 
                        monsterId = selectedType,
                        displayName = displayName, 
                        hp = eHp, 
                        maxHp = eHp,
                        attack = eAtk, 
                        status = "Active", 
                        spawnPhase = state.day, 
                        clearAtNextPhase = true, 
                        removePending = false,
                        nx = chosenPoint.position.x,
                        ny = chosenPoint.position.y,
                        x = chosenPoint.position.x, 
                        y = chosenPoint.position.y  
                    };
                    
                    state.enemies.Add(enemy);
                    spawnedThisWave++;
                    
                    auditLogs.Add($"[Monster Spawn Audit] spawned type={selectedType} spawnPoint={chosenPoint.name}");
                    RuntimeTrace.Log("RAID_SPAWN", $"Spawn enemy state id={enemy.id} monsterId={enemy.monsterId} hp={enemy.hp} atk={enemy.attack} pos=({enemy.nx},{enemy.ny})");
                }
                
                activeAfter = activeBefore + spawnedThisWave;
                
                UnityEngine.Debug.Log($"[Monster Spawn Audit] day={state.day} targetCount={targetMonsterCount} activeBefore={activeBefore} activeAfter={activeAfter}");
                UnityEngine.Debug.Log($"[Monster Spawn Audit] allowedTypes={allowedTypesStr}");
                foreach (var logLine in auditLogs) {
                    UnityEngine.Debug.Log(logLine);
                }
                
                RuntimeTrace.Log("RAID_SPAWN", $"Snapshot enemy count={state.enemies.Count}");
                
                // Activate the heal skip flag for the next morning
                skipMorningHealAfterRaid = true;
            }
            UnityEngine.Debug.Log($"[RaidCheck] imminent={state.isRaidImminentToday} forced={forced} triggered={triggerRaid}");
        }

        private int GetBuildingCount(string rawId) {
            if (state == null || state.buildings == null) return 0;
            string normId = NormalizeBuildingId(rawId);
            return state.buildings.FirstOrDefault(b => NormalizeBuildingId(b.id) == normId)?.count ?? 0;
        }

        private void CheckObjectives() {
            if (state.isGameOver) return;
            QuestEvaluator.Evaluate(state);

            int aliveCount = state.villagers.Count(v => v.hp > 0);
            if (aliveCount == 0) {
                state.isGameOver = true;
                state.gameStatus = "GameOver";
                RuntimeTrace.Log("GAME_OVER", "reason=all_villagers_dead");
                Log("All villagers have fallen. Game Over.");
                return;
            }

            int milestone = state.objectiveState.currentMilestoneIndex;
            if (milestone <= 0) milestone = state.objectiveState.currentMilestoneIndex = 1;
            if (milestone > 5) milestone = state.objectiveState.currentMilestoneIndex = 5;

            if (milestone == 1) {
                int hutCount = GetBuildingCount("hut");
                state.objectiveState.surviveToDay = 3;
                state.objectiveState.requiredHuts = 2;
                state.objectiveText = $"Survive to Day 3 and build 2 Huts\nDay {state.day}/3 | Huts {hutCount}/2";

                if (state.day >= 3 && hutCount >= 2) {
                    state.objectiveState.status = "COMPLETED";
                    state.isObjectiveComplete = true;
                    // Do NOT set state.isGameOver = true here.
                    RuntimeTrace.Log("OBJECTIVE_MILESTONE_COMPLETE", $"Milestone 1 Complete: Day {state.day}, Huts {hutCount}");
                    Log("Milestone 1 Complete: Survival early goals met!");
                } else {
                    state.objectiveState.status = "IN_PROGRESS";
                    state.isObjectiveComplete = false;
                }
            }
            else if (milestone == 2) {
                int storageCount = GetBuildingCount("storage");
                state.objectiveText = $"Build 1 Storage\nStorage {storageCount}/1";

                if (storageCount >= 1) {
                    state.objectiveState.status = "COMPLETED";
                    state.isObjectiveComplete = true;
                    RuntimeTrace.Log("OBJECTIVE_MILESTONE_COMPLETE", $"Milestone 2 Complete: Storage {storageCount}");
                    Log("Milestone 2 Complete: Storage built!");
                } else {
                    state.objectiveState.status = "IN_PROGRESS";
                    state.isObjectiveComplete = false;
                }
            }
            else if (milestone == 3) {
                int forgeCount = GetBuildingCount("blacksmithsForge");
                state.objectiveText = $"Build Blacksmith's Forge\nForge {forgeCount}/1";

                if (forgeCount >= 1) {
                    state.objectiveState.status = "COMPLETED";
                    state.isObjectiveComplete = true;
                    RuntimeTrace.Log("OBJECTIVE_MILESTONE_COMPLETE", $"Milestone 3 Complete: Forge {forgeCount}");
                    Log("Milestone 3 Complete: Blacksmith's Forge built!");
                } else {
                    state.objectiveState.status = "IN_PROGRESS";
                    state.isObjectiveComplete = false;
                }
            }
            else if (milestone == 4) {
                int armedGuards = state.villagers.Count(v => v.hp > 0 && IsGuardJob(v.job) && !string.IsNullOrEmpty(v.weaponId));
                state.objectiveText = $"Equip 1 Guard with a weapon\nArmed Guard {armedGuards}/1";

                if (armedGuards >= 1) {
                    state.objectiveState.status = "COMPLETED";
                    state.isObjectiveComplete = true;
                    RuntimeTrace.Log("OBJECTIVE_MILESTONE_COMPLETE", $"Milestone 4 Complete: Armed Guards {armedGuards}");
                    Log("Milestone 4 Complete: Guard equipped!");
                } else {
                    state.objectiveState.status = "IN_PROGRESS";
                    state.isObjectiveComplete = false;
                }
            }
            else if (milestone == 5) {
                state.objectiveText = $"Survive to Day 10\nDay {state.day}/10";

                if (state.day >= 10) {
                    state.isGameOver = true;
                    state.isObjectiveComplete = true;
                    state.objectiveState.status = "COMPLETED";
                    state.gameStatus = "Victory";
                    RuntimeTrace.Log("OBJECTIVE_MILESTONE_COMPLETE", $"Milestone 5 Complete: Day {state.day}");
                    Log("Objective complete! Your settlement survives Day 10 and achieves final Victory.");
                } else {
                    state.objectiveState.status = "IN_PROGRESS";
                    state.isObjectiveComplete = false;
                }
            }

            // Check if finalCastle is discovered
            if (state.worldMapState != null && state.worldMapState.locations != null) {
                var finalCastleLoc = state.worldMapState.locations.FirstOrDefault(l => l.id == "finalCastle");
                if (finalCastleLoc != null && finalCastleLoc.isDiscovered) {
                    if (state.titanState == null) {
                        state.titanState = new TitanState();
                    }
                    if (!state.titanState.isAwakened) {
                        state.titanState.isAwakened = true;
                        if (state.titanState.hp <= 0 && !state.titanState.isDefeated) {
                            state.titanState.hp = 500;
                            state.titanState.maxHp = 500;
                        }
                        Log("The final castle has been discovered! The Fallen Titan awakens...");
                    }
                    if (!state.titanState.isDefeated) {
                        state.objectiveText = "Endgame: Defeat the Fallen Titan at the Castle.";
                    }
                }
            }
        }

        private System.Random rng = new System.Random();

        private static bool IsGuardJob(string job)
        {
            if (string.IsNullOrEmpty(job)) return false;
            return string.Equals(job, "Guard", System.StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "guard", System.StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "guardTower", System.StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "towerGuard", System.StringComparison.OrdinalIgnoreCase);
        }

        private VillagerSnapshot SelectRaidDamageTarget(List<VillagerSnapshot> candidates)
        {
            if (candidates == null || candidates.Count == 0) return null;
            if (candidates.Count == 1) return candidates[0];
            int index = rng.Next(candidates.Count);
            return candidates[index];
        }

        private Vector2 GetRandomPlayableSpawn() {
            int edge = rng.Next(0, 4);
            switch(edge) {
                case 0: return new Vector2(UnityEngine.Random.Range(0.30f, 0.88f), UnityEngine.Random.Range(0.12f, 0.20f));
                case 1: return new Vector2(UnityEngine.Random.Range(0.30f, 0.88f), UnityEngine.Random.Range(0.80f, 0.88f));
                case 2: return new Vector2(UnityEngine.Random.Range(0.30f, 0.38f), UnityEngine.Random.Range(0.12f, 0.88f));
                default:return new Vector2(UnityEngine.Random.Range(0.80f, 0.88f), UnityEngine.Random.Range(0.12f, 0.88f));
            }
        }

        private void Log(string msg) {
            state.lastAction = msg;
            state.taskLogs.Insert(0, msg);
            if (state.taskLogs.Count > 5) state.taskLogs.RemoveAt(state.taskLogs.Count - 1);
        }

        private CommandResult HandleAttackTitan(AttackTitanCommand cmd) {
            CommandResult result = new CommandResult { success = true };
            
            if (state.titanState == null) {
                state.titanState = new TitanState();
            }

            if (!state.titanState.isAwakened) {
                result.success = false;
                result.message = "Fallen Titan is not awakened yet.";
                return result;
            }

            if (state.titanState.isDefeated) {
                result.success = false;
                result.message = "Fallen Titan has already been defeated.";
                return result;
            }

            if (cmd.attackerVillagerIds == null || cmd.attackerVillagerIds.Count == 0) {
                result.success = false;
                result.message = "No guards assigned to attack.";
                return result;
            }

            List<VillagerSnapshot> validAttackers = new List<VillagerSnapshot>();
            foreach (var id in cmd.attackerVillagerIds) {
                if (string.IsNullOrEmpty(id)) continue;
                var v = state.villagers.FirstOrDefault(x => x.id == id);
                if (v == null) {
                    result.success = false;
                    result.message = $"Villager {id} does not exist.";
                    return result;
                }
                if (v.hp <= 0) {
                    result.success = false;
                    result.message = $"Villager {v.name} is not alive.";
                    return result;
                }
                if (v.isOnExpedition) {
                    result.success = false;
                    result.message = $"Villager {v.name} is currently on an expedition.";
                    return result;
                }
                if (!IsGuardJob(v.job)) {
                    result.success = false;
                    result.message = $"Villager {v.name} is not a Guard.";
                    return result;
                }
                validAttackers.Add(v);
            }

            if (validAttackers.Count == 0) {
                result.success = false;
                result.message = "No valid combat-capable guards assigned.";
                return result;
            }

            // Calculations
            int squadDamage = 0;
            int squadDefenseMitigation = 0;
            foreach (var v in validAttackers) {
                squadDamage += GetVillagerAttack(v);
                squadDefenseMitigation += GetVillagerDefense(v);
            }

            int titanBaseAttack = 35;
            int titanReturnDamage = Math.Max(1, titanBaseAttack - squadDefenseMitigation);

            // Deal damage to Titan
            state.titanState.hp = Math.Max(0, state.titanState.hp - squadDamage);

            // Deal damage to guards (distributed)
            int dmgPerAttacker = titanReturnDamage / validAttackers.Count;
            int remainder = titanReturnDamage % validAttackers.Count;
            for (int i = 0; i < validAttackers.Count; i++) {
                int damage = dmgPerAttacker + (i < remainder ? 1 : 0);
                validAttackers[i].hp = Math.Max(0, validAttackers[i].hp - damage);
            }

            string battleLog = $"Attacked with {validAttackers.Count} Guards. Dealt {squadDamage} damage. Titan returned {dmgPerAttacker} damage to each Guard. Titan HP: {state.titanState.hp}/{state.titanState.maxHp}.";
            state.titanState.lastBattleResult = battleLog;
            Log(battleLog);

            if (state.titanState.hp <= 0) {
                state.titanState.hp = 0;
                state.titanState.isDefeated = true;
                state.titanState.endgameVictoryAchieved = true;
                state.isGameOver = true;
                state.gameStatus = "Victory";
                Log("Victory! The Fallen Titan has been defeated!");
            }

            CheckObjectives();
            return result;
        }

        private CommandResult HandleDiscoverWorldMapLocation(DiscoverWorldMapLocationCommand command) {
            CommandResult result = new CommandResult { success = true };
            
            if (state.worldMapState == null || state.worldMapState.locations == null) {
                SanitizeLoadedState();
            }

            if (string.IsNullOrEmpty(command.locationId)) {
                result.success = false;
                result.message = "Location ID cannot be empty.";
                Log("[World] Cannot discover missing location.");
                return result;
            }

            var target = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals(command.locationId, StringComparison.OrdinalIgnoreCase));
            if (target == null) {
                result.success = false;
                result.message = "Location not found on map.";
                Log("[World] Cannot discover missing location.");
                return result;
            }

            if (target.isDiscovered) {
                result.success = false;
                result.message = "Location already discovered.";
                Log("[World] Location already discovered.");
                return result;
            }

            bool isReachable = false;
            foreach (var discovered in state.worldMapState.locations) {
                if (!discovered.isDiscovered) continue;
                if (discovered.id.Equals(target.id, StringComparison.OrdinalIgnoreCase)) continue;
                
                int dx = Math.Abs(target.x - discovered.x);
                int dy = Math.Abs(target.y - discovered.y);
                if (dx <= 1 && dy <= 1) {
                    isReachable = true;
                    break;
                }
            }

            if (!isReachable) {
                result.success = false;
                result.message = "Location is not adjacent to discovered territory.";
                Log("[World] Location is not adjacent to discovered territory.");
                return result;
            }

            target.isDiscovered = true;
            Log($"[World] Discovered {target.displayName}");
            CheckObjectives();
            
            return result;
        }

        private CommandResult HandleDispatchExpedition(DispatchExpeditionCommand command) {
            CommandResult result = new CommandResult { success = true };
            
            if (state.worldMapState == null || state.worldMapState.locations == null) {
                SanitizeLoadedState();
            }

            if (string.IsNullOrEmpty(command.targetLocationId)) {
                result.success = false;
                result.message = "Target location ID is empty.";
                Log("[World] Cannot dispatch expedition: location is not discovered.");
                return result;
            }

            var target = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals(command.targetLocationId, StringComparison.OrdinalIgnoreCase));
            if (target == null || !target.isDiscovered) {
                result.success = false;
                result.message = "Target location is not discovered.";
                Log("[World] Cannot dispatch expedition: location is not discovered.");
                return result;
            }

            if (command.villagerIds == null || command.villagerIds.Count == 0) {
                result.success = false;
                result.message = "No villagers selected for expedition.";
                Log("[World] Cannot dispatch expedition: no valid villagers.");
                return result;
            }

            var seenVillagerIds = new HashSet<string>();
            foreach (var vId in command.villagerIds) {
                if (string.IsNullOrEmpty(vId)) {
                    result.success = false;
                    result.message = "Invalid villager ID.";
                    Log("[World] Cannot dispatch expedition: no valid villagers.");
                    return result;
                }
                if (seenVillagerIds.Contains(vId)) {
                    result.success = false;
                    result.message = "Duplicate villager in dispatch command.";
                    Log("[World] Cannot dispatch expedition: no valid villagers.");
                    return result;
                }
                seenVillagerIds.Add(vId);

                var villager = state.villagers.FirstOrDefault(v => v.id == vId);
                if (villager == null || villager.hp <= 0) {
                    result.success = false;
                    result.message = "Villager is missing or dead.";
                    Log("[World] Cannot dispatch expedition: no valid villagers.");
                    return result;
                }

                if (villager.isOnExpedition) {
                    result.success = false;
                    result.message = "Villager is already on an expedition.";
                    Log("[World] Cannot dispatch expedition: villager unavailable.");
                    return result;
                }
            }

            // Validation passed! Build the ExpeditionState
            string expId = "exp_" + Guid.NewGuid().ToString().Substring(0, 8);
            var expedition = new ExpeditionState {
                id = expId,
                targetLocationId = target.id,
                villagerIds = command.villagerIds.ToList(),
                previousJobs = new List<VillagerPreviousJob>(),
                phasesRemaining = 2, // Safe default duration
                rewardType = target.rewardType,
                rewardAmount = target.rewardAmount,
                injuryChance = target.dangerLevel * 0.15f,
                status = "Active"
            };

            foreach (var vId in command.villagerIds) {
                var villager = state.villagers.First(v => v.id == vId);
                
                expedition.previousJobs.Add(new VillagerPreviousJob {
                    villagerId = vId,
                    jobId = villager.job
                });
                
                villager.isOnExpedition = true;
                villager.expeditionId = expId;
                villager.job = "Expedition";
            }

            if (state.worldMapState.activeExpeditions == null) {
                state.worldMapState.activeExpeditions = new List<ExpeditionState>();
            }
            state.worldMapState.activeExpeditions.Add(expedition);

            Log($"[World] Expedition dispatched to {target.displayName}");
            return result;
        }

        private void ProcessExpeditions() {
            if (state.worldMapState == null || state.worldMapState.activeExpeditions == null) return;
            
            var completedExpeditions = new List<ExpeditionState>();
            for (int i = 0; i < state.worldMapState.activeExpeditions.Count; i++) {
                var exp = state.worldMapState.activeExpeditions[i];
                if (exp == null) continue;
                exp.phasesRemaining--;
                if (exp.phasesRemaining <= 0) {
                    completedExpeditions.Add(exp);
                }
            }

            foreach (var exp in completedExpeditions) {
                ResolveExpedition(exp);
                state.worldMapState.activeExpeditions.Remove(exp);
            }
        }

        private void ResolveExpedition(ExpeditionState exp) {
            if (state.questState == null) {
                state.questState = new QuestState();
            }
            state.questState.completedExpeditionCountForQuest++;
            var target = state.worldMapState.locations.FirstOrDefault(l => l.id.Equals(exp.targetLocationId, StringComparison.OrdinalIgnoreCase));
            string locName = target != null ? target.displayName : exp.targetLocationId;
            int danger = target != null ? target.dangerLevel : 0;

            foreach (var vId in exp.villagerIds) {
                var villager = state.villagers.FirstOrDefault(v => v.id == vId);
                if (villager == null || villager.hp <= 0) continue;

                // Injury roll
                if (danger > 0 && rng.NextDouble() < exp.injuryChance) {
                    int damage = 10 * danger;
                    villager.hp = Mathf.Max(1, villager.hp - damage);
                    Log($"[World] {villager.name} was injured during the expedition.");
                }

                // Restore previous job
                var prev = exp.previousJobs.FirstOrDefault(pj => pj.villagerId == vId);
                string targetJob = prev != null ? prev.jobId : "Builder";
                
                // Validate target job
                bool jobExists = repo.GetJob(targetJob) != null;
                bool capacityAvailable = true;
                if (targetJob == "Blacksmith") {
                    int forges = state.buildings.FirstOrDefault(b => b.id == "blacksmithsForge")?.count ?? 0;
                    if (forges <= 0) {
                        jobExists = false;
                    } else {
                        int activeBlacksmiths = state.villagers.Count(v => v.job == "Blacksmith" && v.hp > 0);
                        if (activeBlacksmiths >= forges * 2) {
                            capacityAvailable = false;
                        }
                    }
                } else if (targetJob == "towerGuard") {
                    int towers = state.buildings.FirstOrDefault(b => b.id == NormalizeBuildingId("guardTower"))?.count ?? 0;
                    if (towers <= 0) {
                        jobExists = false;
                    }
                }

                if (!jobExists) {
                    targetJob = "Builder";
                } else if (!capacityAvailable) {
                    targetJob = "Builder";
                    Log($"[World] Expedition return job fallback applied for {villager.name}.");
                }

                villager.job = targetJob;
                villager.isOnExpedition = false;
                villager.expeditionId = "";
            }

            // Reward
            int reward = exp.rewardAmount;
            if (reward > 0 && !string.IsNullOrEmpty(exp.rewardType)) {
                string resName = exp.rewardType.ToLowerInvariant();
                if (resName == "wood") {
                    state.wood = Mathf.Min(state.woodCapacity, state.wood + reward);
                } else if (resName == "food") {
                    state.food = Mathf.Min(state.foodCapacity, state.food + reward);
                } else if (resName == "iron") {
                    state.iron = Mathf.Min(state.ironCapacity, state.iron + reward);
                } else if (resName == "steel") {
                    state.steel = Mathf.Min(state.steelCapacity, state.steel + reward);
                } else if (resName == "coal") {
                    state.coal = Mathf.Min(state.coalCapacity, state.coal + reward);
                }
                Log($"[World] Expedition returned from {locName}: +{reward} {exp.rewardType}");
            } else {
                Log($"[World] Expedition returned from {locName}");
            }

            // Queue expedition report string
            string reportMsg = $"Expedition to {locName} completed!";
            if (reward > 0 && !string.IsNullOrEmpty(exp.rewardType)) {
                reportMsg += $"\nRecovered: {reward} {exp.rewardType}";
            }
            if (state.pendingExpeditionReports == null) {
                state.pendingExpeditionReports = new List<string>();
            }
            state.pendingExpeditionReports.Add(reportMsg);
        }

        public GameSnapshot GetSnapshot() { 
            state.totalDefense = 10;
            
            int pop = 4;
            int totalHutsCount = state.buildings.Find(b => b.id == NormalizeBuildingId("hut"))?.count ?? 0;
            int placedHutsCount = 0;
            int popBonus = 0;
            if (state.userPlacements != null) {
                foreach (var place in state.userPlacements) {
                    if (place != null && place.id.StartsWith("building:hut:")) {
                        placedHutsCount++;
                        if (place.level == 2) popBonus += 4;
                        else popBonus += 2;
                    }
                }
            }
            int unplacedHuts = Mathf.Max(0, totalHutsCount - placedHutsCount);
            popBonus += unplacedHuts * 2;
            state.maxPopulation = pop + popBonus;

            int wCap = 250;
            int fCap = 100;
            int iCap = 100;
            int sCap = 50;
            int cCap = 50;
            
            int totalStorageCount = state.buildings.Find(b => b.id == NormalizeBuildingId("storage"))?.count ?? 0;
            int placedStorageCount = 0;
            int storageBonusW = 0;
            int storageBonusFIC = 0;
            if (state.userPlacements != null) {
                foreach (var place in state.userPlacements) {
                    if (place != null && place.id.StartsWith("building:storage:")) {
                        placedStorageCount++;
                        if (place.level == 2) {
                            storageBonusW += 300;
                            storageBonusFIC += 200;
                        } else {
                            storageBonusW += 150;
                            storageBonusFIC += 100;
                        }
                    }
                }
            }
            int unplacedStorage = Mathf.Max(0, totalStorageCount - placedStorageCount);
            storageBonusW += unplacedStorage * 150;
            storageBonusFIC += unplacedStorage * 100;
            
            state.woodCapacity = wCap + storageBonusW;
            state.foodCapacity = fCap + storageBonusFIC;
            state.ironCapacity = iCap + storageBonusFIC;
            state.steelCapacity = sCap + (storageBonusFIC / 2);
            state.coalCapacity = cCap + (storageBonusFIC / 2);

            // Enforce capacity clamping at read-time just in case
            if (state.wood > state.woodCapacity) state.wood = state.woodCapacity;
            if (state.food > state.foodCapacity) state.food = state.foodCapacity;
            if (state.iron > state.ironCapacity) state.iron = state.ironCapacity;
            if (state.steel > state.steelCapacity) state.steel = state.steelCapacity;
            if (state.coal > state.coalCapacity) state.coal = state.coalCapacity;

            return state; 
        }

        private CommandResult HandleTrade(TradeCommand command) {
            CommandResult result = new CommandResult { success = true };
            if (command == null) {
                result.success = false;
                result.message = "Null command";
                UnityEngine.Debug.Log("[Trade 16A] Trade failed reason=Null command");
                return result;
            }

            if (state.tradeState == null) {
                state.tradeState = new TradeState {
                    isMerchantPresent = false,
                    daysUntilNextMerchant = 2,
                    merchantDaysRemaining = 0
                };
            }

            if (!state.tradeState.isMerchantPresent) {
                result.success = false;
                result.message = "Merchant is not present";
                UnityEngine.Debug.Log("[Trade 16B] Trade failed reason=Merchant is not present");
                return result;
            }

            var offer = TradeOffers.GetOffer(command.offerId);
            if (offer == null) {
                result.success = false;
                result.message = $"Offer not found: {command.offerId}";
                UnityEngine.Debug.Log($"[Trade 16A] Trade failed reason=Offer not found: {command.offerId}");
                return result;
            }

            if (offer.sellAmount <= 0 || offer.buyAmount <= 0) {
                result.success = false;
                result.message = "Amounts in offer must be positive";
                UnityEngine.Debug.Log("[Trade 16A] Trade failed reason=Amounts in offer must be positive");
                return result;
            }

            string sellRes = offer.sellResource;
            string buyRes = offer.buyResource;

            var validResources = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "wood", "food", "iron", "steel", "coal" };
            if (!validResources.Contains(sellRes) || !validResources.Contains(buyRes)) {
                result.success = false;
                result.message = $"Unknown resource ID. Sell: {sellRes}, Buy: {buyRes}";
                UnityEngine.Debug.Log($"[Trade 16A] Trade failed reason=Unknown resource ID. Sell: {sellRes}, Buy: {buyRes}");
                return result;
            }

            int currentSellAmount = GetResourceAmount(sellRes);
            if (currentSellAmount < offer.sellAmount) {
                result.success = false;
                result.message = $"Not enough {sellRes}. Have: {currentSellAmount}, Need: {offer.sellAmount}";
                UnityEngine.Debug.Log($"[Trade 16A] Trade failed reason=Not enough {sellRes}. Have: {currentSellAmount}, Need: {offer.sellAmount}");
                return result;
            }

            int currentBuyAmount = GetResourceAmount(buyRes);
            int buyCap = GetResourceCapacity(buyRes);
            
            UnityEngine.Debug.Log($"[Trade 16A] Capacity check resource={buyRes} current={currentBuyAmount} add={offer.buyAmount} cap={buyCap}");

            if (currentBuyAmount + offer.buyAmount > buyCap) {
                result.success = false;
                result.message = $"Exceeds capacity for {buyRes}. Cap: {buyCap}";
                UnityEngine.Debug.Log($"[Trade 16A] Trade failed reason=Exceeds capacity for {buyRes}. Cap: {buyCap}");
                return result;
            }

            ModifyResourceAmount(sellRes, -offer.sellAmount);
            ModifyResourceAmount(buyRes, offer.buyAmount);

            if (state.questState == null) {
                state.questState = new QuestState();
            }
            state.questState.completedTradeCountForQuest++;

            UnityEngine.Debug.Log($"[Trade 16A] Trade success offer={offer.id} sell={offer.sellResource}:{offer.sellAmount} buy={offer.buyResource}:{offer.buyAmount}");
            Log($"[Trade] Completed: {offer.id}");

            return result;
        }

        private int GetResourceAmount(string resId) {
            switch (resId.ToLowerInvariant()) {
                case "wood": return state.wood;
                case "food": return state.food;
                case "iron": return state.iron;
                case "steel": return state.steel;
                case "coal": return state.coal;
                default: return 0;
            }
        }

        private int GetResourceCapacity(string resId) {
            switch (resId.ToLowerInvariant()) {
                case "wood": return state.woodCapacity;
                case "food": return state.foodCapacity;
                case "iron": return state.ironCapacity;
                case "steel": return state.steelCapacity;
                case "coal": return state.coalCapacity;
                default: return 0;
            }
        }

        private void ModifyResourceAmount(string resId, int delta) {
            switch (resId.ToLowerInvariant()) {
                case "wood":
                    state.wood += delta;
                    if (state.wood < 0) state.wood = 0;
                    if (state.wood > state.woodCapacity) state.wood = state.woodCapacity;
                    break;
                case "food":
                    state.food += delta;
                    if (state.food < 0) state.food = 0;
                    if (state.food > state.foodCapacity) state.food = state.foodCapacity;
                    break;
                case "iron":
                    state.iron += delta;
                    if (state.iron < 0) state.iron = 0;
                    if (state.iron > state.ironCapacity) state.iron = state.ironCapacity;
                    break;
                case "steel":
                    state.steel += delta;
                    if (state.steel < 0) state.steel = 0;
                    if (state.steel > state.steelCapacity) state.steel = state.steelCapacity;
                    break;
                case "coal":
                    state.coal += delta;
                    if (state.coal < 0) state.coal = 0;
                    if (state.coal > state.coalCapacity) state.coal = state.coalCapacity;
                    break;
            }
        }
    }

    public static class SpawnPointProvider {
        public class SpawnPoint {
            public string name;
            public Vector2 position;
            public string enemyType; // "Basic", "Fast", "Tank" or "" (general/raid)
        }
        
        private static System.Collections.Generic.List<SpawnPoint> _mockPoints = null;
        
        public static void SetMockPoints(System.Collections.Generic.List<SpawnPoint> points) {
            _mockPoints = points;
        }
        
        public static void ClearMockPoints() {
            _mockPoints = null;
        }
        
        public static System.Collections.Generic.List<SpawnPoint> GetSpawnPoints() {
            if (_mockPoints != null) {
                return _mockPoints;
            }
            
            var points = new System.Collections.Generic.List<SpawnPoint>();
            
            // Find EnemySpawnPointAuthorings in play mode or scene load
            var enemySpawns = UnityEngine.Object.FindObjectsOfType<EnemySpawnPointAuthoring>();
            if (enemySpawns != null) {
                foreach (var es in enemySpawns) {
                    if (es == null) continue;
                    var rect = es.GetComponent<RectTransform>();
                    if (rect != null) {
                        points.Add(new SpawnPoint {
                            name = es.gameObject.name,
                            position = rect.anchoredPosition,
                            enemyType = es.enemyType
                        });
                    }
                }
            }
            
            // Find SpawnSlotAuthorings starting with "RaidSpawn"
            var slotSpawns = UnityEngine.Object.FindObjectsOfType<SpawnSlotAuthoring>();
            if (slotSpawns != null) {
                foreach (var ss in slotSpawns) {
                    if (ss == null) continue;
                    if (!string.IsNullOrEmpty(ss.slotId) && ss.slotId.StartsWith("RaidSpawn", System.StringComparison.OrdinalIgnoreCase)) {
                        var rect = ss.GetComponent<RectTransform>();
                        if (rect != null) {
                            points.Add(new SpawnPoint {
                                name = ss.gameObject.name,
                                position = rect.anchoredPosition,
                                enemyType = ""
                            });
                        }
                    }
                }
            }
            
            return points;
        }
    }
}
