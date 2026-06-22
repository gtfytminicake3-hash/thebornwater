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
                        
                        if (state != null) {
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
                        }

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
            else if (command is ResolveRaidCombatHitCommand hitCmd) {
                return HandleResolveRaidCombatHit(hitCmd);
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
                    int prod = repo.GetJob("Forager")?.productionPerPhase ?? 2;
                    if (prod <= 0) prod = 2;
                    state.food = Mathf.Min(state.foodCapacity, state.food + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Forager foodDelta=+{prod} food={state.food}/{state.foodCapacity} worksite=fallback_or_visual_forage");
                }
                else if (v.job == "Farmer") {
                    int prod = repo.GetJob("farmer")?.productionPerPhase ?? 3;
                    if (prod <= 0) prod = 3;
                    state.food = Mathf.Min(state.foodCapacity, state.food + prod);
                    RuntimeTrace.Log("RESOURCE_TICK", $"villager={v.id} job=Farmer foodDelta=+{prod} food={state.food}/{state.foodCapacity} worksite=farm_1");
                }
                else if (v.job == "Miner") {
                    int prod = repo.GetJob("Miner")?.productionPerPhase ?? 1;
                    if (prod <= 0) prod = 1;
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
                    }
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
                            
                            // Transfer placement from construction to completed building
                            string constrId = "construction:" + task.targetBuildingId + ":" + task.id;
                            var place = state.userPlacements.Find(p => p.id == constrId);
                            if (place != null) {
                                place.id = "building:" + task.targetBuildingId + ":" + (bld.count - 1);
                            }

                            var bdef = repo.GetBuilding(task.targetBuildingId);
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
                ProcessRaidCheck(false);
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
            if (state.isGameOver || state.objectiveState.status == "FAILED" || state.objectiveState.status == "COMPLETED") return;
            RuntimeTrace.Log("RAID_CHECK", $"Day={state.day}");
            
            float roll = (float)rng.NextDouble();
            bool spawned = false;

            if (state.lastRaidDay != state.day && (forced || roll < NightRaidChance)) {
                spawned = true;
                state.lastRaidDay = state.day;
                Log("[Raid] Monster appeared.");
                
                state.totalDefense = 10; // Cache for UI: baseline villager defense is 10
                
                int enemyCount = 1 + (state.day / 10);
                enemyCount = Mathf.Clamp(enemyCount, 1, 4);

                System.Collections.Generic.List<string> typesToSpawn = new System.Collections.Generic.List<string>();
                for (int i = 0; i < enemyCount; i++) {
                    double typeRoll = rng.NextDouble();
                    string type = "Basic";
                    if (state.day == 1) {
                        type = typeRoll < 0.5 ? "SmallMonster" : "Basic";
                    } else if (state.day >= 2 && state.day <= 9) {
                        if (typeRoll < 0.45) type = "SmallMonster";
                        else if (typeRoll < 0.90) type = "Basic";
                        else type = "Fast";
                    } else { // Day 10+
                        if (typeRoll < 0.25) type = "SmallMonster";
                        else if (typeRoll < 0.50) type = "Basic";
                        else if (typeRoll < 0.75) type = "Fast";
                        else type = "Tank";
                    }
                    typesToSpawn.Add(type);
                }

                for (int i = 0; i < typesToSpawn.Count; i++) {
                    string type = typesToSpawn[i];
                    var enemyDef = repo.GetEnemy(type);
                    int eHp = enemyDef?.hp ?? (type == "Tank" ? 120 : type == "Fast" ? 40 : type == "SmallMonster" ? 30 : 60);
                    int eAtk = enemyDef?.attack ?? (type == "Tank" ? 25 : type == "Fast" ? 10 : type == "SmallMonster" ? 15 : 15);
                    string displayName = enemyDef?.displayName ?? (type == "Tank" ? "Orc Titan" : type == "Fast" ? "Feral Wolf" : type == "SmallMonster" ? "Small Monster" : "Goblin Raider");

                    EnemyState enemy = new EnemyState { 
                        id = "e_" + state.day + "_" + i, 
                        typeId = type, 
                        monsterId = type,
                        displayName = displayName, 
                        hp = eHp, 
                        maxHp = eHp,
                        attack = eAtk, 
                        status = "Active", 
                        spawnPhase = state.day, 
                        clearAtNextPhase = true, 
                        removePending = false,
                        nx = 0,
                        ny = 0,
                        x = 0, 
                        y = 0  
                    };
                    var spawnPos = GetRandomPlayableSpawn();
                    enemy.nx = spawnPos.x;
                    enemy.ny = spawnPos.y;
                    
                    state.enemies.Add(enemy);
                    RuntimeTrace.Log("RAID_SPAWN", $"Spawn enemy state id={enemy.id} monsterId={enemy.monsterId} hp={enemy.hp} atk={enemy.attack} pos=({enemy.nx},{enemy.ny})");
                }
                RuntimeTrace.Log("RAID_SPAWN", $"Snapshot enemy count={state.enemies.Count}");
                
                // Activate the heal skip flag for the next morning
                skipMorningHealAfterRaid = true;
            }
            UnityEngine.Debug.Log($"[RaidCheck] chance={NightRaidChance} roll={roll} spawned={spawned}");
        }

        private void CheckObjectives() {
            if (state.isGameOver || state.gameStatus == "Victory" || state.gameStatus == "GameOver") return;

            int aliveCount = state.villagers.Count(v => v.hp > 0);
            if (aliveCount == 0) {
                state.isGameOver = true;
                state.gameStatus = "GameOver";
                RuntimeTrace.Log("GAME_OVER", "reason=all_villagers_dead");
                Log("All villagers have fallen. Game Over.");
                return;
            }

            if (state.day >= 3) {
                int hutCount = state.buildings.Find(b => b.id == "hut")?.count ?? 0;
                if (hutCount >= 2) {
                    state.isGameOver = true;
                    state.isObjectiveComplete = true;
                    state.gameStatus = "Victory";
                    RuntimeTrace.Log("OBJECTIVE_COMPLETE", $"Day {state.day}, Huts {hutCount}");
                    Log("Objective complete! Your settlement survives.");
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

        public GameSnapshot GetSnapshot() { 
            state.totalDefense = 10;
            
            int pop = 4;
            int huts = state.buildings.Find(b => b.id == NormalizeBuildingId("hut"))?.count ?? 0;
            pop += huts * 2;
            state.maxPopulation = pop;

            int wCap = 250;
            int fCap = 100;
            int iCap = 100;
            int sCap = 50;
            int cCap = 50;
            int storage = state.buildings.Find(b => b.id == NormalizeBuildingId("storage"))?.count ?? 0;
            wCap += storage * 150;
            fCap += storage * 100;
            iCap += storage * 100;
            sCap += storage * 50;
            cCap += storage * 50;
            
            state.woodCapacity = wCap;
            state.foodCapacity = fCap;
            state.ironCapacity = iCap;
            state.steelCapacity = sCap;
            state.coalCapacity = cCap;

            // Enforce capacity clamping at read-time just in case
            if (state.wood > state.woodCapacity) state.wood = state.woodCapacity;
            if (state.food > state.foodCapacity) state.food = state.foodCapacity;
            if (state.iron > state.ironCapacity) state.iron = state.ironCapacity;
            if (state.steel > state.steelCapacity) state.steel = state.steelCapacity;
            if (state.coal > state.coalCapacity) state.coal = state.coalCapacity;

            return state; 
        }
    }
}
