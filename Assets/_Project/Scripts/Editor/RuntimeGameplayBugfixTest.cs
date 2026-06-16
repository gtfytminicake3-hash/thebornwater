#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;

namespace TheBonwater.Rebuild.Editor {
    public static class RuntimeGameplayBugfixTest {
        [MenuItem("Tools/Rebuild/Tests/Run RuntimeGameplayBugfixTest")]
        public static void Run() {
            var backend = new LocalGameBackend();
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Runtime Gameplay Bugfix Test Report");

            void Check(string name, bool condition) {
                if (condition) { pass++; report.AppendLine($"- [PASS] {name}"); }
                else { fail++; report.AppendLine($"- [FAIL] {name}"); }
            }

            // 1. New Game
            var state = backend.GetSnapshot();
            
            // 2. Record resource
            state.wood = 300;
            state.iron = 100;
            int woodBefore = state.wood;

            // 3. Build Hut with enough Wood
            backend.Execute(new BuildHutCommand());
            var taskHut = state.tasks.FirstOrDefault(t => t.targetBuildingId == "Hut");
            
            // 4. Assert Wood decreased or deposited into task
            Check("Build Hut spends or deposits Wood", state.wood == woodBefore - 50 && taskHut != null && taskHut.depositedResources.Any(r => r.resourceId == "wood" && r.amount == 50));
            
            // 5. Complete Hut
            backend.FinishConstruction(taskHut.id);
            Check("Hut exists in buildings after complete", state.buildings.Any(b => b.id == "Hut" && b.count > 0));

            // 6. Build Storage
            int woodBeforeStorage = state.wood;
            backend.Execute(new BuildStorageCommand());
            var taskStorage = state.tasks.FirstOrDefault(t => t.targetBuildingId == "Storage");
            Check("Build Storage spends or deposits Wood", state.wood == woodBeforeStorage - 100 && taskStorage != null);

            // 7. Complete Storage
            backend.FinishConstruction(taskStorage.id);
            Check("Storage exists in buildings after complete", state.buildings.Any(b => b.id == "Storage" && b.count > 0));

            // 8. Build GuardTower
            int woodBeforeGT = state.wood;
            int ironBeforeGT = state.iron;
            backend.Execute(new BuildGuardTowerCommand());
            var taskGT = state.tasks.FirstOrDefault(t => t.targetBuildingId == "GuardTower");
            Check("Build GuardTower spends or deposits Wood and Iron", state.wood == woodBeforeGT - 150 && state.iron == ironBeforeGT - 50 && taskGT != null);

            // 9. Complete GuardTower
            backend.FinishConstruction(taskGT.id);
            Check("GuardTower exists in buildings after complete", state.buildings.Any(b => b.id == "GuardTower" && b.count > 0));

            // 10. Assign job to villager 1
            state.selectedVillagerIndex = 0;
            backend.Execute(new AssignWorkerCommand());
            string v1Job = state.villagers[0].job;
            Check("Villager 1 changed job", v1Job != "Idle");

            // 11. Select/cycle villager
            backend.Execute(new SelectNextVillagerCommand());
            Check("Selected villager index cycled", state.selectedVillagerIndex == 1);

            // 12. Assign job to villager 2
            backend.Execute(new AssignWorkerCommand());
            string v2Job = state.villagers[1].job;

            // 13. Assert both villagers can change job independently
            Check("Villagers can change job independently", state.villagers[0].job != "Idle" && state.villagers[1].job != "Idle");

            // 14. Assert no magenta fallback remains
            string visualCtrlCode = File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs");
            Check("No magenta fallback in TownRuntimeVisualController", !visualCtrlCode.Contains("Color.magenta"));

            // 15. Save/load
            backend.Execute(new SaveGameCommand());
            var backend2 = new LocalGameBackend();
            var state2 = backend2.GetSnapshot();
            Check("Save/load preserves buildings", state2.buildings.Any(b => b.id == "Storage" && b.count > 0) && state2.buildings.Any(b => b.id == "GuardTower" && b.count > 0));
            Check("Save/load preserves jobs", state2.villagers[0].job == v1Job && state2.villagers[1].job == v2Job);
            Check("Save/load preserves resources", state2.wood == state.wood && state2.iron == state.iron);

            File.WriteAllText("Assets/_Project/Docs/RuntimeGameplayBugfixReport.md", report.ToString());
            UnityEngine.Debug.Log($"RuntimeGameplayBugfixTest Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) EditorApplication.Exit(1);
        }
    }
}
#endif
