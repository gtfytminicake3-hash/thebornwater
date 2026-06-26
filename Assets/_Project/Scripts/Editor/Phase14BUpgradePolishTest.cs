#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TheBonwater.Rebuild.Editor {
    public static class Phase14BUpgradePolishTest {
        [MenuItem("Tools/Rebuild/Tests/Run Phase14B Upgrade Polish Test")]
        public static void Run() {
            var backend = new LocalGameBackend();
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Phase 14B Upgrade Polish Test Report");

            void Check(string name, bool condition) {
                if (condition) { pass++; report.AppendLine($"- [PASS] {name}"); }
                else { fail++; report.AppendLine($"- [FAIL] {name}"); }
            }

            // 1. Initialize State
            var state = backend.GetSnapshot();
            state.wood = 500;
            state.iron = 200;
            state.food = 100;

            // 2. Build a Hut and complete it
            backend.Execute(new BuildHutCommand { x = 100, y = 100 });
            var hutTask = state.tasks.FirstOrDefault(t => t.targetBuildingId == "hut");
            Check("Hut task created", hutTask != null);
            if (hutTask != null) {
                backend.FinishConstruction(hutTask.id);
            }
            var completedHut = state.userPlacements.FirstOrDefault(p => p.id.StartsWith("building:hut:"));
            Check("Completed Hut exists", completedHut != null && completedHut.level == 1);

            // 3. Try invalid upgrade (not enough resources)
            state.wood = 0;
            var upgradeCmd = new UpgradeBuildingCommand { buildingPlacementId = completedHut.id };
            var res = backend.Execute(upgradeCmd);
            Check("Upgrade fails with insufficient resources", !res.success && res.message == "Not enough resources.");

            // Reset resources
            state.wood = 200;
            state.iron = 100;

            // 4. Try valid upgrade (should succeed and deduct resources once)
            int woodBefore = state.wood;
            int ironBefore = state.iron;
            res = backend.Execute(upgradeCmd);
            Check("Upgrade command succeeds with enough resources", res.success);
            Check("Resource deducted exactly once on command execution", state.wood == woodBefore - 100 && state.iron == ironBefore); 
            
            // Check that the task is created
            var upgTask = state.tasks.FirstOrDefault(t => t.type == "UpgradeBuilding" && t.targetPlacementId == completedHut.id);
            Check("Upgrade task created", upgTask != null);

            // 5. Try duplicate upgrade command (should fail)
            var resDuplicate = backend.Execute(upgradeCmd);
            Check("Duplicate upgrade command is blocked", !resDuplicate.success && resDuplicate.message == "An upgrade is already in progress for this building.");

            // 6. Complete the upgrade task
            upgTask.currentCompletion = upgTask.finalCompletion;
            backend.Execute(new AdvanceTimeCommand()); // Ticks task completion

            Check("Hut level is now 2", completedHut.level == 2);
            Check("Upgrade task removed from active tasks", !state.tasks.Contains(upgTask));

            // 7. Try upgrading already Level 2 building (should fail)
            var resL2 = backend.Execute(upgradeCmd);
            Check("Already upgraded building cannot be upgraded again", !resL2.success && resL2.message == "Target building is already at max level.");

            // 8. Test Save/Load stability of building levels
            backend.Execute(new SaveGameCommand());
            var backend2 = new LocalGameBackend();
            var state2 = backend2.GetSnapshot();
            var loadedHut = state2.userPlacements.FirstOrDefault(p => p.id == completedHut.id);
            Check("Hut Level 2 remains Level 2 after load", loadedHut != null && loadedHut.level == 2);
            Check("Population capacity is correct after load (and not double-applied)", state2.maxPopulation == 8); 

            // 9. Test Storage level 2 upgrade and resource cap recalculations
            backend2.Execute(new BuildStorageCommand { x = 200, y = 200 });
            var storageTask = state2.tasks.FirstOrDefault(t => t.targetBuildingId == "storage");
            if (storageTask != null) {
                backend2.FinishConstruction(storageTask.id);
            }
            var completedStorage = state2.userPlacements.FirstOrDefault(p => p.id.StartsWith("building:storage:"));
            Check("Completed Storage exists", completedStorage != null && completedStorage.level == 1);
            Check("Baseline resource capacity is correct", state2.woodCapacity == 400); 

            // Upgrade storage
            state2.wood = 200; state2.iron = 200;
            var upgStorageCmd = new UpgradeBuildingCommand { buildingPlacementId = completedStorage.id };
            var resStorage = backend2.Execute(upgStorageCmd);
            Check("Storage upgrade command succeeds", resStorage.success);
            var upgStoreTask = state2.tasks.FirstOrDefault(t => t.type == "UpgradeBuilding" && t.targetPlacementId == completedStorage.id);
            
            // Complete storage upgrade
            upgStoreTask.currentCompletion = upgStoreTask.finalCompletion;
            backend2.Execute(new AdvanceTimeCommand());
            Check("Storage level is now 2", completedStorage.level == 2);
            Check("Resource capacity increases correctly for Level 2 Storage", state2.woodCapacity == 550); 

            // Save and load Level 2 Storage
            backend2.Execute(new SaveGameCommand());
            var backend3 = new LocalGameBackend();
            var state3 = backend3.GetSnapshot();
            var loadedStorage = state3.userPlacements.FirstOrDefault(p => p.id == completedStorage.id);
            Check("Storage Level 2 remains Level 2 after load", loadedStorage != null && loadedStorage.level == 2);
            Check("Resource capacity remains correct after load", state3.woodCapacity == 550);

            // 10. Test Upgrade Task safety and cancellation
            state3.wood = 200; state3.iron = 200;
            backend3.Execute(new BuildHutCommand { x = 300, y = 300 });
            var hutTask2 = state3.tasks.FirstOrDefault(t => t.targetBuildingId == "hut");
            if (hutTask2 != null) {
                backend3.FinishConstruction(hutTask2.id);
            }
            var completedHut2 = state3.userPlacements.FirstOrDefault(p => p.id.StartsWith("building:hut:1"));
            Check("Second Completed Hut exists", completedHut2 != null);

            backend3.Execute(new UpgradeBuildingCommand { buildingPlacementId = completedHut2.id });
            var upgTask2 = state3.tasks.FirstOrDefault(t => t.type == "UpgradeBuilding" && t.targetPlacementId == completedHut2.id);
            Check("Upgrade task 2 created", upgTask2 != null);

            // Destroy/Remove the second Hut placement from state
            state3.userPlacements.Remove(completedHut2);

            // Tick time advance - the task should be safely cancelled and cleaned up
            backend3.Execute(new AdvanceTimeCommand());
            Check("Upgrade task is safely cancelled/removed after target placement is removed", !state3.tasks.Contains(upgTask2));

            File.WriteAllText("Assets/_Project/Docs/Phase14BUpgradePolishReport.md", report.ToString());
            UnityEngine.Debug.Log($"Phase 14B Upgrade Polish Test Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) {
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
