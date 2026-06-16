using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;
using TheBonwater.Rebuild;

namespace TheBonwater.Rebuild.Editor
{
    public class BuildMenuCommandBindingRegressionTest : EditorWindow
    {
        [MenuItem("Tools/TheBonwater/Run Build Menu Binding Regression Test")]
        public static void Run()
        {
            UnityEngine.Debug.Log("==== STARTING BUILD MENU REGRESSION TEST ====");
            
            var repo = new DataRepository();
            repo.LoadAll();
            
            bool hasErrors = false;
            void AssertTrue(bool condition, string successMsg, string errorMsg) {
                if (!condition) {
                    UnityEngine.Debug.LogError("[FAIL] " + errorMsg);
                    hasErrors = true;
                } else {
                    UnityEngine.Debug.Log("[PASS] " + successMsg);
                }
            }

            var hutItem = repo.BuildMenu.menuItems.Find(m => m.id == "Hut");
            AssertTrue(hutItem != null, "Hut item found in build menu", "Hut item missing in build menu");

            // Setup Backend and give it lots of resources to guarantee GuardTower task creation
            var backend = new LocalGameBackend();
            backend.Execute(new CollectWoodCommand()); // 60
            backend.Execute(new CollectWoodCommand()); // 70
            backend.Execute(new CollectWoodCommand()); // 80
            backend.Execute(new CollectWoodCommand()); // 90
            backend.Execute(new CollectWoodCommand()); // 100
            
            // LocalGameBackend GetSnapshot gives direct access to the snapshot
            var state = backend.GetSnapshot();
            state.wood = 200;
            state.iron = 200;

            if (hutItem != null && hutItem.buildingId == "hut") {
                backend.Execute(new BuildHutCommand());
            }

            var storageItem = repo.BuildMenu.menuItems.Find(m => m.id == "Storage");
            if (storageItem != null && storageItem.buildingId == "storage") {
                backend.Execute(new BuildStorageCommand());
            }

            var towerItem = repo.BuildMenu.menuItems.Find(m => m.id == "GuardTower");
            if (towerItem != null && towerItem.buildingId == "guardTower") {
                backend.Execute(new BuildGuardTowerCommand());
            }

            var snapshot = backend.GetSnapshot();
            
            // Check Hut
            var hutTask = snapshot.tasks.Find(t => t.targetBuildingId.Equals("hut", System.StringComparison.OrdinalIgnoreCase));
            if (hutTask != null && hutTask.targetBuildingId != "hut") {
                UnityEngine.Debug.LogError($"CANONICAL_ID_MISMATCH_FOUND: {hutTask.targetBuildingId} should be hut");
                hasErrors = true;
            }
            AssertTrue(hutTask != null && hutTask.targetBuildingId == "hut", "Snapshot contains hut construction task with exact canonical id", "Snapshot is missing exact hut construction task");

            // Check Storage
            var storageTask = snapshot.tasks.Find(t => t.targetBuildingId.Equals("storage", System.StringComparison.OrdinalIgnoreCase));
            if (storageTask != null && storageTask.targetBuildingId != "storage") {
                UnityEngine.Debug.LogError($"CANONICAL_ID_MISMATCH_FOUND: {storageTask.targetBuildingId} should be storage");
                hasErrors = true;
            }
            AssertTrue(storageTask != null && storageTask.targetBuildingId == "storage", "Snapshot contains storage construction task with exact canonical id", "Snapshot is missing exact storage construction task");

            // Check GuardTower
            var towerTask = snapshot.tasks.Find(t => t.targetBuildingId.Equals("guardTower", System.StringComparison.OrdinalIgnoreCase));
            if (towerTask != null && towerTask.targetBuildingId != "guardTower") {
                UnityEngine.Debug.LogError($"CANONICAL_ID_MISMATCH_FOUND: {towerTask.targetBuildingId} should be guardTower");
                hasErrors = true;
            }
            AssertTrue(towerTask != null && towerTask.targetBuildingId == "guardTower", "Snapshot contains guardTower construction task with exact canonical id", "Snapshot is missing exact guardTower construction task");

            // Now test Completion
            if (hutTask != null) backend.FinishConstruction(hutTask.id);
            if (storageTask != null) backend.FinishConstruction(storageTask.id);
            if (towerTask != null) backend.FinishConstruction(towerTask.id);

            snapshot = backend.GetSnapshot();
            bool hasHutBuilding = snapshot.buildings.Exists(b => b.id == "hut");
            bool hasStorageBuilding = snapshot.buildings.Exists(b => b.id == "storage");
            bool hasTowerBuilding = snapshot.buildings.Exists(b => b.id == "guardTower");
            
            AssertTrue(hasHutBuilding, "Completed building id is hut", "Completed hut is missing or has wrong id");
            AssertTrue(hasStorageBuilding, "Completed building id is storage", "Completed storage is missing or has wrong id");
            AssertTrue(hasTowerBuilding, "Completed building id is guardTower", "Completed guardTower is missing or has wrong id");

            if (!hasErrors) {
                UnityEngine.Debug.Log("==== BUILD MENU REGRESSION TEST PASSED ====");
            } else {
                UnityEngine.Debug.LogError("==== BUILD MENU REGRESSION TEST FAILED ====");
            }
        }
    }
}
