#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using TheBonwater.Rebuild.Data;

namespace TheBonwater.Rebuild.Editor {
    public static class WorldMapDataFoundationTest {
        [MenuItem("Tools/Rebuild/Tests/Run World Map Data Foundation Test")]
        public static void Run() {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# World Map Data Foundation Test Report");

            void Check(string name, bool condition) {
                if (condition) { pass++; report.AppendLine($"- [PASS] {name}"); }
                else { fail++; report.AppendLine($"- [FAIL] {name}"); }
            }

            // Ensure we delete any pre-existing runtime save file for clean testing
            string runtimeSavePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (File.Exists(runtimeSavePath)) {
                File.Delete(runtimeSavePath);
            }

            // --- 1. New Game World Map Initialization ---
            var backend = new LocalGameBackend();
            var state = backend.GetSnapshot();

            Check("worldMapState is not null", state.worldMapState != null);
            Check("locations is not null", state.worldMapState?.locations != null);
            
            if (state.worldMapState?.locations != null) {
                Check("12 locations initialized in world map", state.worldMapState.locations.Count == 12);
                
                var homeLoc = state.worldMapState.locations.FirstOrDefault(l => l.id == "home");
                Check("Home location exists", homeLoc != null);
                Check("Home is discovered", homeLoc != null && homeLoc.isDiscovered);
                
                var agathaLoc = state.worldMapState.locations.FirstOrDefault(l => l.id == "agatha");
                Check("Agatha location exists", agathaLoc != null);
                Check("Agatha is not discovered at start", agathaLoc != null && !agathaLoc.isDiscovered);
                Check("Agatha coords are correct", agathaLoc != null && agathaLoc.x == 7 && agathaLoc.y == 7);
                Check("Agatha dangerLevel is correct", agathaLoc != null && agathaLoc.dangerLevel == 4);
                Check("Agatha rewardType is correct", agathaLoc != null && agathaLoc.rewardType == "steel");
            }

            // --- 2. Equipment Stack regression test (not nulled on init) ---
            Check("Equipment stock is not null on start", state.equipmentStock != null);
            state.equipmentStock = new List<EquipmentStack> {
                new EquipmentStack { equipmentId = "stoneAxe", count = 3 }
            };

            // --- 3. Save / Load Roundtrip ---
            backend.Execute(new SaveGameCommand());
            Check("Save file exists after SaveGameCommand", File.Exists(runtimeSavePath));

            var loadedBackend = new LocalGameBackend();
            var loadedState = loadedBackend.GetSnapshot();

            Check("Loaded worldMapState is not null", loadedState.worldMapState != null);
            Check("Loaded locations count matches", loadedState.worldMapState?.locations?.Count == 12);

            var loadedHome = loadedState.worldMapState?.locations?.FirstOrDefault(l => l.id == "home");
            Check("Loaded Home remains discovered", loadedHome != null && loadedHome.isDiscovered);

            var loadedAgatha = loadedState.worldMapState?.locations?.FirstOrDefault(l => l.id == "agatha");
            Check("Loaded Agatha remains undiscovered", loadedAgatha != null && !loadedAgatha.isDiscovered);

            // Verify equipment remains intact
            Check("Loaded equipmentStock contains stoneAxe", loadedState.equipmentStock != null && loadedState.equipmentStock.Any(e => e.equipmentId == "stoneAxe" && e.count == 3));

            // --- 4. Sanitization and Definition Merging ---
            // Simulate obsolete location in save game, plus missing definition
            // We manually modify the save file and reload
            if (File.Exists(runtimeSavePath)) {
                string savedJson = File.ReadAllText(runtimeSavePath);
                var saveSnapshot = JsonUtility.FromJson<GameSnapshot>(savedJson);
                
                // Remove 'agatha' location from list to simulate missing definition in save
                var agatha = saveSnapshot.worldMapState.locations.FirstOrDefault(l => l.id == "agatha");
                if (agatha != null) {
                    saveSnapshot.worldMapState.locations.Remove(agatha);
                }
                
                // Add an unknown/obsolete location to simulate obsolete saved ID
                saveSnapshot.worldMapState.locations.Add(new WorldMapLocationState {
                    id = "obsolete_location",
                    displayName = "Lost Island",
                    type = "island",
                    x = 11,
                    y = 11,
                    isDiscovered = true
                });

                // Add a duplicate location to test duplicate handling
                saveSnapshot.worldMapState.locations.Add(new WorldMapLocationState {
                    id = "home",
                    displayName = "Duplicate Home",
                    type = "home",
                    x = 0,
                    y = 0,
                    isDiscovered = false
                });

                // Set home to undiscovered to test forced home discovery
                var home = saveSnapshot.worldMapState.locations.FirstOrDefault(l => l.id == "home");
                if (home != null) {
                    home.isDiscovered = false;
                }

                string hackedJson = JsonUtility.ToJson(saveSnapshot);
                File.WriteAllText(runtimeSavePath, hackedJson);
            }

            var sanitizedBackend = new LocalGameBackend();
            var sanitizedState = sanitizedBackend.GetSnapshot();

            // Verify merged/repaired state
            var finalHome = sanitizedState.worldMapState?.locations?.FirstOrDefault(l => l.id == "home");
            Check("Forced Home to be discovered", finalHome != null && finalHome.isDiscovered);
            
            var duplicates = sanitizedState.worldMapState?.locations?.Where(l => l.id == "home").ToList();
            Check("Duplicate home location removed (exactly 1 left)", duplicates != null && duplicates.Count == 1);

            var finalAgatha = sanitizedState.worldMapState?.locations?.FirstOrDefault(l => l.id == "agatha");
            Check("Missing definition (Agatha) was successfully merged back in", finalAgatha != null);

            var finalObsolete = sanitizedState.worldMapState?.locations?.FirstOrDefault(l => l.id == "obsolete_location");
            Check("Obsolete saved location (Lost Island) was preserved", finalObsolete != null && finalObsolete.isDiscovered);

            // --- 5. Phase 12/14 Regression Checks ---
            // Hut upgrade level fields and caps check
            sanitizedState.wood = 500;
            sanitizedState.iron = 500;
            sanitizedBackend.Execute(new BuildHutCommand { x = 400, y = 400 });
            var hutTask = sanitizedState.tasks.FirstOrDefault(t => t.targetBuildingId == "hut");
            if (hutTask != null) {
                sanitizedBackend.FinishConstruction(hutTask.id);
            }
            var completedHut = sanitizedState.userPlacements.FirstOrDefault(p => p.id.StartsWith("building:hut:"));
            Check("Completed Hut is Level 1", completedHut != null && completedHut.level == 1);

            // Upgrade it
            var upgradeCmd = new UpgradeBuildingCommand { buildingPlacementId = completedHut.id };
            sanitizedBackend.Execute(upgradeCmd);
            var upgTask = sanitizedState.tasks.FirstOrDefault(t => t.type == "UpgradeBuilding" && t.targetPlacementId == completedHut.id);
            if (upgTask != null) {
                upgTask.currentCompletion = upgTask.finalCompletion;
                sanitizedBackend.Execute(new AdvanceTimeCommand());
            }
            sanitizedState = sanitizedBackend.GetSnapshot();
            completedHut = sanitizedState.userPlacements.FirstOrDefault(p => p.id == completedHut.id);

            Check("Hut level upgraded to 2", completedHut != null && completedHut.level == 2);
            Check("Population capacity increased correctly", sanitizedState.maxPopulation == 8);

            // Save and load Level 2 Hut and verify it remains Lv2 and doesn't get corrupted
            sanitizedBackend.Execute(new SaveGameCommand());
            
            var regressBackend = new LocalGameBackend();
            var regressState = regressBackend.GetSnapshot();
            var loadedHut = regressState.userPlacements.FirstOrDefault(p => p.id == completedHut.id);
            Check("Hut Level 2 remains Level 2 after reload with world map initialized", loadedHut != null && loadedHut.level == 2);
            Check("Population capacity remains intact after load", regressState.maxPopulation == 8);

            // --- 6. Phase 15B World Map Discovery Tests ---
            // Clear test save file first
            if (File.Exists(runtimeSavePath)) {
                File.Delete(runtimeSavePath);
            }

            var discBackend = new LocalGameBackend();
            var discState = discBackend.GetSnapshot();

            // Temporarily modify northernVillage coordinates to be adjacent to home (5, 5) -> (5, 6)
            var nvLoc = discState.worldMapState?.locations?.FirstOrDefault(l => l.id == "northernVillage");
            if (nvLoc != null) {
                nvLoc.x = 5;
                nvLoc.y = 6;
            }

            // Test 1: Discover adjacent undiscovered location succeeds
            var resDiscAdjacent = discBackend.Execute(new DiscoverWorldMapLocationCommand { locationId = "northernVillage" });
            Check("Discover adjacent location succeeds", resDiscAdjacent.success);
            Check("Adjacent location is marked as discovered", nvLoc != null && nvLoc.isDiscovered);

            // Test 2: Discover already discovered location fails cleanly
            var resDiscAlready = discBackend.Execute(new DiscoverWorldMapLocationCommand { locationId = "home" });
            Check("Discover already discovered location fails", !resDiscAlready.success && resDiscAlready.message == "Location already discovered.");

            // Test 3: Discover missing/invalid location fails cleanly
            var resDiscMissing = discBackend.Execute(new DiscoverWorldMapLocationCommand { locationId = "invalid_id" });
            Check("Discover invalid location fails", !resDiscMissing.success && resDiscMissing.message == "Location not found on map.");

            var resDiscEmpty = discBackend.Execute(new DiscoverWorldMapLocationCommand { locationId = "" });
            Check("Discover empty location ID fails", !resDiscEmpty.success && resDiscEmpty.message == "Location ID cannot be empty.");

            // Test 4: Discover non-adjacent location fails cleanly
            var scLoc = discState.worldMapState?.locations?.FirstOrDefault(l => l.id == "slaverCove");
            Check("Slaver's Cove is initially undiscovered", scLoc != null && !scLoc.isDiscovered);

            var resDiscNonAdjacent = discBackend.Execute(new DiscoverWorldMapLocationCommand { locationId = "slaverCove" });
            Check("Discover non-adjacent location fails", !resDiscNonAdjacent.success && resDiscNonAdjacent.message == "Location is not adjacent to discovered territory.");
            Check("Slaver's Cove remains undiscovered", scLoc != null && !scLoc.isDiscovered);

            // Test 5: Save/load preserves discovered location
            discBackend.Execute(new SaveGameCommand());
            Check("Save file exists after discovery save", File.Exists(runtimeSavePath));

            // Force load in a new backend instance
            var discLoadBackend = new LocalGameBackend();
            var discLoadState = discLoadBackend.GetSnapshot();

            var loadedNV = discLoadState.worldMapState?.locations?.FirstOrDefault(l => l.id == "northernVillage");
            Check("Discovered location (northernVillage) remains discovered after load", loadedNV != null && loadedNV.isDiscovered);

            var loadedSC = discLoadState.worldMapState?.locations?.FirstOrDefault(l => l.id == "slaverCove");
            Check("Undiscovered location (slaverCove) remains undiscovered after load", loadedSC != null && !loadedSC.isDiscovered);

            // Test 6: Sanitization after discovery does not wipe discovered state
            // Sanitization is run automatically during constructor, let's explicitly run it again to make sure
            // Note: SanitizeLoadedState is private but we can confirm that loading ran it successfully.
            // Let's verify home remains discovered as well.
            var loadedHomeAgain = discLoadState.worldMapState?.locations?.FirstOrDefault(l => l.id == "home");
            Check("Home remains discovered after load", loadedHomeAgain != null && loadedHomeAgain.isDiscovered);

            // Test 7: Phase 14 building level/cap data remains stable
            // Max population should be correct (since no huts are upgraded in discLoadState, it's 4)
            Check("Baseline max population capacity is stable", discLoadState.maxPopulation == 4);

            // Clean up test save file
            if (File.Exists(runtimeSavePath)) {
                File.Delete(runtimeSavePath);
            }

            // --- 7. Phase 15C World Map Expedition Tests ---
            var expBackend = new LocalGameBackend();
            var expState = expBackend.GetSnapshot();

            // We make sure home is discovered (it is by default) and northernVillage is discovered.
            var nvForExp = expState.worldMapState?.locations?.FirstOrDefault(l => l.id == "northernVillage");
            if (nvForExp != null) {
                nvForExp.x = 5;
                nvForExp.y = 6;
                nvForExp.isDiscovered = true;
            }

            // Ensure slaverCove is undiscovered
            var scForExp = expState.worldMapState?.locations?.FirstOrDefault(l => l.id == "slaverCove");
            if (scForExp != null) {
                scForExp.isDiscovered = false;
            }

            // Get valid living villagers
            var ev1 = expState.villagers.FirstOrDefault(v => v.id == "v1");
            var ev2 = expState.villagers.FirstOrDefault(v => v.id == "v2");

            // Test 1: Undiscovered location dispatch blocks
            var cmdUndisc = new DispatchExpeditionCommand {
                targetLocationId = "slaverCove",
                villagerIds = new List<string> { "v1" }
            };
            var resUndisc = expBackend.Execute(cmdUndisc);
            Check("Dispatch to undiscovered location fails", !resUndisc.success);

            // Test 2: Missing/dead villager dispatch blocks
            // Missing villager
            var cmdMissingV = new DispatchExpeditionCommand {
                targetLocationId = "northernVillage",
                villagerIds = new List<string> { "nonexistent_v" }
            };
            var resMissingV = expBackend.Execute(cmdMissingV);
            Check("Dispatch with missing villager fails", !resMissingV.success);

            // Dead villager
            if (ev2 != null) ev2.hp = 0;
            var cmdDeadV = new DispatchExpeditionCommand {
                targetLocationId = "northernVillage",
                villagerIds = new List<string> { "v2" }
            };
            var resDeadV = expBackend.Execute(cmdDeadV);
            Check("Dispatch with dead villager fails", !resDeadV.success);
            if (ev2 != null) ev2.hp = 100; // Restore hp

            // Test 3: Successful dispatch (villager marked as isOnExpedition and job changed)
            if (ev1 != null) {
                ev1.job = "Woodcutter";
            }
            var cmdSuccess = new DispatchExpeditionCommand {
                targetLocationId = "northernVillage",
                villagerIds = new List<string> { "v1" }
            };
            var resSuccess = expBackend.Execute(cmdSuccess);
            Check("Successful dispatch command executes", resSuccess.success);
            Check("Villager is marked isOnExpedition", ev1 != null && ev1.isOnExpedition);
            Check("Villager expeditionId is set", ev1 != null && !string.IsNullOrEmpty(ev1.expeditionId));
            Check("Villager job is set to Expedition", ev1 != null && ev1.job == "Expedition");

            // Check that active expeditions has 1 entry
            var activeExp = expState.worldMapState?.activeExpeditions?.FirstOrDefault(e => e.id == ev1.expeditionId);
            Check("Active expedition is tracked in state", activeExp != null);
            Check("Expedition has correct phasesRemaining", activeExp != null && activeExp.phasesRemaining == 2);

            // Test 4: Successful resolution (restores previous job, awards resource clamped to cap)
            // Setup reward
            if (activeExp != null) {
                activeExp.rewardType = "wood";
                activeExp.rewardAmount = 100;
            }
            // Baseline wood
            expState.wood = 200;
            expState.woodCapacity = 250;

            // Advance time once
            expBackend.Execute(new AdvanceTimeCommand());
            Check("Active expedition phasesRemaining decreased", activeExp != null && activeExp.phasesRemaining == 1);
            Check("Villager is still on expedition", ev1 != null && ev1.isOnExpedition);

            // Advance time again (should complete/resolve expedition)
            expBackend.Execute(new AdvanceTimeCommand());
            Check("Villager isOnExpedition cleared after resolution", ev1 != null && !ev1.isOnExpedition);
            Check("Villager expeditionId cleared", ev1 != null && string.IsNullOrEmpty(ev1.expeditionId));
            Check("Villager previous job restored", ev1 != null && ev1.job == "Woodcutter");
            Check("Expedition reward granted and clamped to cap", expState.wood == 250);
            Check("Expedition removed from active expeditions", expState.worldMapState?.activeExpeditions?.Count == 0);

            // Test 5: Save/load preservation of active expeditions
            // Set up a new dispatch
            var cmdSuccess2 = new DispatchExpeditionCommand {
                targetLocationId = "northernVillage",
                villagerIds = new List<string> { "v1" }
            };
            expBackend.Execute(cmdSuccess2);
            string activeExpId = ev1?.expeditionId;
            Check("Second dispatch succeeded", !string.IsNullOrEmpty(activeExpId));

            // Save
            expBackend.Execute(new SaveGameCommand());
            Check("Save file written with active expedition", File.Exists(runtimeSavePath));

            // Load and check active expedition is preserved
            var loadExpBackend = new LocalGameBackend();
            var loadExpState = loadExpBackend.GetSnapshot();
            var loadExp = loadExpState.worldMapState?.activeExpeditions?.FirstOrDefault(e => e.id == activeExpId);
            var loadV1 = loadExpState.villagers.FirstOrDefault(v => v.id == "v1");

            Check("Loaded state has active expedition", loadExp != null);
            Check("Loaded villager remains isOnExpedition", loadV1 != null && loadV1.isOnExpedition);
            Check("Loaded villager has correct expeditionId", loadV1 != null && loadV1.expeditionId == activeExpId);

            // Test 6: Sanitization/repair of corrupted expedition states
            if (File.Exists(runtimeSavePath)) {
                string savedJson = File.ReadAllText(runtimeSavePath);
                var saveSnapshot = JsonUtility.FromJson<GameSnapshot>(savedJson);

                if (saveSnapshot.worldMapState?.activeExpeditions != null && saveSnapshot.worldMapState.activeExpeditions.Count > 0) {
                    saveSnapshot.worldMapState.activeExpeditions[0].targetLocationId = "invalidLocationXYZ";
                }

                string hackedJson = JsonUtility.ToJson(saveSnapshot);
                File.WriteAllText(runtimeSavePath, hackedJson);
            }

            var repairBackend = new LocalGameBackend();
            var repairState = repairBackend.GetSnapshot();
            var repairV1 = repairState.villagers.FirstOrDefault(v => v.id == "v1");

            Check("Corrupted expedition was removed", repairState.worldMapState?.activeExpeditions?.Count == 0);
            Check("Villager isOnExpedition cleared after corruption repair", repairV1 != null && !repairV1.isOnExpedition);
            Check("Villager expeditionId cleared after corruption repair", repairV1 != null && string.IsNullOrEmpty(repairV1.expeditionId));
            Check("Villager returned to preserved previous job (Woodcutter)", repairV1 != null && repairV1.job == "Woodcutter");

            // Test 7: Job capacity fallback test (e.g. Blacksmith capacity exceeded)
            var capBackend = new LocalGameBackend();
            var capState = capBackend.GetSnapshot();

            // Set up blacksmith forge count = 1 (capacity = 2 blacksmiths)
            var blacksmithsForge = capState.buildings.FirstOrDefault(b => b.id == "blacksmithsForge");
            if (blacksmithsForge == null) {
                capState.buildings.Add(new BuildingSnapshot { id = "blacksmithsForge", count = 1 });
            } else {
                blacksmithsForge.count = 1;
            }

            // Assign v2 and v3 as blacksmiths
            var v2ForCap = capState.villagers.FirstOrDefault(v => v.id == "v2");
            var v3ForCap = capState.villagers.FirstOrDefault(v => v.id == "v3");
            if (v2ForCap != null) v2ForCap.job = "Blacksmith";
            if (v3ForCap != null) v3ForCap.job = "Blacksmith";

            // Dispatch v1 (whose previous job was Blacksmith)
            var v1ForCap = capState.villagers.FirstOrDefault(v => v.id == "v1");
            if (v1ForCap != null) {
                v1ForCap.job = "Blacksmith";
            }

            var nvLocCap = capState.worldMapState?.locations?.FirstOrDefault(l => l.id == "northernVillage");
            if (nvLocCap != null) {
                nvLocCap.x = 5;
                nvLocCap.y = 6;
                nvLocCap.isDiscovered = true;
            }

            var cmdCap = new DispatchExpeditionCommand {
                targetLocationId = "northernVillage",
                villagerIds = new List<string> { "v1" }
            };
            capBackend.Execute(cmdCap);

            // Now resolve
            capBackend.Execute(new AdvanceTimeCommand());
            capBackend.Execute(new AdvanceTimeCommand()); // Resolve

            Check("Villager whose job is full fell back to Builder", v1ForCap != null && v1ForCap.job == "Builder");

            // Clean up test save file
            if (File.Exists(runtimeSavePath)) {
                File.Delete(runtimeSavePath);
            }

            File.WriteAllText("Assets/_Project/Docs/WorldMapDataFoundationReport.md", report.ToString());
            UnityEngine.Debug.Log($"World Map Data Foundation Test Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) {
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
