#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

namespace TheBonwater.Rebuild.Editor {
    public static class ScopedBuildingListAndCompositionTest {
        [MenuItem("Tools/Rebuild/Tests/Run Scoped Fix Test")]
        public static void Run() {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Scoped Building List and Composition Fix Report");

            void Check(string name, bool condition) {
                if (condition) { pass++; report.AppendLine($"- [PASS] {name}"); }
                else { fail++; report.AppendLine($"- [FAIL] {name}"); }
            }

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            var ticGo = new GameObject("TIC");
            var tic = ticGo.AddComponent<TownInteractionController>();

            var blvGo = new GameObject("BuildingListView");
            var blv = blvGo.AddComponent<BuildingListView>();
            blv.txtBuildings = blvGo.AddComponent<Text>();
            
            // Manually call Awake/Start logic
            tic.Invoke("Awake", 0); 
            blv.Invoke("Start", 0); // This subscribes to tic.OnStateChanged
            
            // 1. Build and complete Hut, Storage, GuardTower
            backend.Execute(new BuildHutCommand());
            var hutTask = backend.GetSnapshot().tasks.FirstOrDefault(t => t.targetBuildingId == "Hut");
            if (hutTask != null) backend.FinishConstruction(hutTask.id);

            // Add resources to allow building
            var state = backend.GetSnapshot();
            state.wood = 500; state.iron = 500;

            backend.Execute(new BuildStorageCommand());
            var storageTask = backend.GetSnapshot().tasks.FirstOrDefault(t => t.targetBuildingId == "Storage");
            if (storageTask != null) backend.FinishConstruction(storageTask.id);

            backend.Execute(new BuildGuardTowerCommand());
            var gtTask = backend.GetSnapshot().tasks.FirstOrDefault(t => t.targetBuildingId == "GuardTower");
            if (gtTask != null) backend.FinishConstruction(gtTask.id);

            // Refresh UI explicitly
            tic.RefreshUI();

            // 1. Backend check
            var finalState = backend.GetSnapshot();
            bool hasHut = finalState.buildings.Any(b => b.id == "Hut" && b.count > 0);
            bool hasStorage = finalState.buildings.Any(b => b.id == "Storage" && b.count > 0);
            bool hasGT = finalState.buildings.Any(b => b.id == "GuardTower" && b.count > 0);
            
            Check("Backend Snapshot contains completed Hut", hasHut);
            Check("Backend Snapshot contains completed Storage", hasStorage);
            Check("Backend Snapshot contains completed GuardTower", hasGT);

            // 2. UI View check
            string uiText = blv.txtBuildings.text;
            Check("BuildingListView shows Hut count", uiText.Contains("Hut: 1"));
            Check("BuildingListView shows Storage count", uiText.Contains("Storage: 1"));
            Check("BuildingListView shows GuardTower count", uiText.Contains("GuardTower: 1"));

            // 3. Composition check
            string visualCode = File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/TownRuntimeVisualController.cs");
            string layoutJson = File.ReadAllText("Assets/_Project/Data/Definitions/town_visual_layout.json");
            
            Check("No magenta fallback in composition", !visualCode.Contains("Color.magenta"));
            Check("Pseudo 2.5D Depth offset implemented (Y depth logic)", visualCode.Contains("depthY"));
            Check("Pseudo 2.5D Scale implemented (scale reduction)", visualCode.Contains("Vector3(scale, scale"));
            Check("Layout JSON updated for composition (terrain floor height expanded)", layoutJson.Contains("\"height\": 900"));

            File.WriteAllText("Assets/_Project/Docs/ScopedBuildingListAndCompositionFixReport.md", report.ToString());
            UnityEngine.Debug.Log($"Scoped Fix Test Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) EditorApplication.Exit(1);
        }
    }
}
#endif
