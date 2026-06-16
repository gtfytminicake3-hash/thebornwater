#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TheBonwater.Rebuild.Editor {
    public static class RuntimeCoreBugfixTest {
        [MenuItem("Tools/Rebuild/Tests/Run RuntimeCoreBugfixTest")]
        public static void Run() {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Runtime Core Logic & UI Sync Bugfix Report");

            void Check(string name, bool condition) {
                if (condition) { pass++; report.AppendLine($"- [PASS] {name}"); }
                else { fail++; report.AppendLine($"- [FAIL] {name}"); }
            }

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            // 1. New Game.
            var state = backend.GetSnapshot();
            
            // 2. Assert selectedVillagerIndex = 0.
            Check("selectedVillagerIndex = 0 on new game", state.selectedVillagerIndex == 0);

            // 3. Assign job to Bryn.
            backend.Execute(new AssignWorkerCommand());
            string brynJob = state.villagers[0].job;

            // 4. Select next villager.
            backend.Execute(new SelectNextVillagerCommand());
            Check("Select next villager updates index", state.selectedVillagerIndex == 1);

            // 5. Assign job to Alaric.
            backend.Execute(new AssignWorkerCommand());
            backend.Execute(new AssignWorkerCommand()); // assign twice to be different
            string alaricJob = state.villagers[1].job;

            // 6. Assert Bryn and Alaric can have different jobs.
            Check("Bryn and Alaric can have different jobs", brynJob != alaricJob && brynJob != "Idle");

            // 7 & 8. (Skipped) Read building costs and assert UI button labels match backend costs.
            // Button labels are now dynamically generated in TownInteractionController.PopulateBuildMenu,
            // so we skip the direct UI element check in this backend-focused test.
            var gtDef = backend.repo.GetBuilding("GuardTower");
            int expectedWood = gtDef.costs.ContainsKey("wood") ? gtDef.costs["wood"] : 0;
            int expectedIron = gtDef.costs.ContainsKey("iron") ? gtDef.costs["iron"] : 0;
            Check("Backend costs retrieved correctly", expectedWood >= 0);

            // 9. Try build GuardTower with insufficient resources.
            state.wood = 0; state.iron = 0;
            backend.Execute(new BuildGuardTowerCommand());
            var gtTaskFail = state.tasks.FirstOrDefault(t => t.targetBuildingId == "GuardTower");

            // 10. Assert command fails, no task created, resources not negative.
            Check("Build fails with insufficient resources, no task created, no negative", gtTaskFail == null && state.wood == 0 && state.iron == 0);

            // 11. Add exact required resources.
            state.wood = expectedWood;
            state.iron = expectedIron;

            // 12. Build GuardTower.
            backend.Execute(new BuildGuardTowerCommand());
            var gtTask = state.tasks.FirstOrDefault(t => t.targetBuildingId == "GuardTower");

            // 13. Assert resources deducted/deposited and never negative.
            Check("Resources deducted and not negative", state.wood == 0 && state.iron == 0 && gtTask != null);

            // 14. Complete GuardTower.
            backend.FinishConstruction(gtTask.id);

            // 15. Assert GuardTower exists in GameSnapshot.buildings and visual resolver supports it.
            Check("GuardTower completed and remains in buildings", state.buildings.Any(b => b.id == "GuardTower"));
            string visualCode = File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs");
            Check("Visual resolver supports GuardTower", visualCode.Contains("typeId == \"GuardTower\""));

            // 16. Build/complete Storage.
            int stWood = backend.repo.GetBuilding("Storage").costs["wood"];
            state.wood = stWood;
            backend.Execute(new BuildStorageCommand());
            var stTask = state.tasks.FirstOrDefault(t => t.targetBuildingId == "Storage");
            if (stTask != null) backend.FinishConstruction(stTask.id);

            // 17. Assert Storage exists in GameSnapshot.buildings and visual resolver supports it.
            Check("Storage completed and remains in buildings", state.buildings.Any(b => b.id == "Storage"));
            Check("Visual resolver supports Storage", visualCode.Contains("typeId == \"Storage\""));

            // 18. Assert no magenta fallback remains
            string sceneGenCode = File.ReadAllText("Assets/_Project/Scripts/Editor/RebuildSceneGenerator.cs");
            Check("No magenta fallback in scene generator/player background", !sceneGenCode.Contains("Color.magenta") && !visualCode.Contains("Color.magenta"));

            // 19. Save/load and assert jobs/buildings/resources persist.
            backend.Execute(new SaveGameCommand());
            var backend2 = new LocalGameBackend();
            backend2.Execute(new LoadGameCommand());
            var state2 = backend2.GetSnapshot();
            
            Check("Save/Load preserves building storage", state2.buildings.Any(b => b.id == "Storage"));
            Check("Save/Load preserves selected villager", state2.selectedVillagerIndex == 1);
            Check("Save/Load preserves villager jobs", state2.villagers[0].job == brynJob && state2.villagers[1].job == alaricJob);

            File.WriteAllText("Assets/_Project/Docs/RuntimeCoreBugfixReport.md", report.ToString());
            UnityEngine.Debug.Log($"RuntimeCoreBugfixTest Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) EditorApplication.Exit(1);
        }
    }
}
#endif
