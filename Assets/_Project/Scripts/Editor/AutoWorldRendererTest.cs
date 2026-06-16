using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;
using TheBonwater.Rebuild;
using System.Linq;

namespace TheBonwater.Rebuild.Editor
{
    public class AutoWorldRendererTest : EditorWindow
    {
        [MenuItem("Tools/TheBonwater/Test Tools/Run Auto World Renderer Test")]
        public static void RunTest()
        {
            UnityEngine.Debug.Log("==== STARTING AUTO WORLD RENDERER TEST ====");

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

            // Setup mock world hierarchy
            var oldRoot = GameObject.Find("TownWorldRoot_Mock");
            if (oldRoot != null) DestroyImmediate(oldRoot);
            
            var worldRootGo = new GameObject("TownWorldRoot_Mock");
            var worldRootRect = worldRootGo.AddComponent<RectTransform>();
            worldRootRect.sizeDelta = new Vector2(3000, 2000); // Verify size > viewport
            
            // Create layers
            string[] layerNames = new string[] { "TerrainLayer", "DecorationLayer", "ConstructionLayer", "BuildingLayer", "VillagerLayer", "MonsterLayer" };
            foreach (var layerName in layerNames) {
                var layerGo = new GameObject(layerName);
                layerGo.transform.SetParent(worldRootGo.transform, false);
            }

            var rendererGo = new GameObject("RendererMock");
            var renderer = rendererGo.AddComponent<TownRuntimeVisualController>();
            renderer.worldRoot = worldRootGo.transform;

            // Clear save file to start with a clean state
            string savePath = System.IO.Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (System.IO.File.Exists(savePath)) {
                System.IO.File.Delete(savePath);
            }

            // Setup Backend
            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            // Give resources
            backend.Execute(new CollectWoodCommand());
            backend.Execute(new CollectWoodCommand());
            var state = backend.GetSnapshot();
            state.wood = 500;
            state.iron = 500;

            // Force renderer initialization
            renderer.Initialize();
            renderer.HandleStateChanged(state);

            // Step 1: Verify Hierarchy
            AssertTrue(worldRootGo.transform.Find("TerrainLayer") != null, "TerrainLayer exists", "TerrainLayer missing");
            AssertTrue(worldRootRect.sizeDelta.x > 1000, "TownWorldRoot is large", "TownWorldRoot size is too small");

            // Step 2: Multiple construction tasks
            backend.Execute(new BuildHutCommand());
            backend.Execute(new BuildStorageCommand());
            var snap = backend.GetSnapshot();
            renderer.HandleStateChanged(snap);

            var views = worldRootGo.GetComponentsInChildren<WorldObjectView>();
            var hutSite = views.FirstOrDefault(v => v.objectId.StartsWith("construction:hut:"));
            var storageSite = views.FirstOrDefault(v => v.objectId.StartsWith("construction:storage:"));
            
            AssertTrue(hutSite != null, "Hut construction site exists", "Hut construction site missing");
            AssertTrue(storageSite != null, "Storage construction site exists", "Storage construction site missing");
            AssertTrue(hutSite.taskId != storageSite.taskId, "Hut and Storage have different task IDs", "Tasks share the same ID!");
            AssertTrue(hutSite.targetBuildingId == "hut", "Hut site bound to hut", "Hut site bound to wrong target");
            AssertTrue(storageSite.targetBuildingId == "storage", "Storage site bound to storage", "Storage site bound to wrong target");

            // Step 3: No flicker requirement (Capture instance ID)
            int hutSiteInstanceId = hutSite.gameObject.GetInstanceID();
            
            // Simulate next phase
            snap = backend.GetSnapshot();
            snap.day = 2; // trigger change
            renderer.HandleStateChanged(snap);

            views = worldRootGo.GetComponentsInChildren<WorldObjectView>();
            var hutSiteAfter = views.FirstOrDefault(v => v.objectId.StartsWith("construction:hut:"));
            AssertTrue(hutSiteAfter != null && hutSiteAfter.gameObject.GetInstanceID() == hutSiteInstanceId, 
                "No flicker - instance ID maintained after Next Phase", "Flicker detected! Object recreated.");

            // Step 4: Completion Transition
            var hutTask = snap.tasks.Find(t => t.targetBuildingId == "hut");
            if (hutTask != null) backend.FinishConstruction(hutTask.id);
            
            renderer.HandleStateChanged(backend.GetSnapshot());
            views = worldRootGo.GetComponentsInChildren<WorldObjectView>();
            
            var hutSiteFinal = views.FirstOrDefault(v => v.objectId.StartsWith("construction:hut:"));
            var hutCompleted = views.FirstOrDefault(v => v.objectId == "building:hut:0");
            var storageSiteFinal = views.FirstOrDefault(v => v.objectId.StartsWith("construction:storage:"));
            
            AssertTrue(hutSiteFinal == null, "Hut construction site removed", "Hut construction site still exists");
            AssertTrue(hutCompleted != null, "Hut completed visual exists", "Hut completed visual missing");
            AssertTrue(storageSiteFinal != null, "Storage construction site still exists", "Storage construction site wrongly removed");

            // Step 5: Save/Load (simulate HandleStateChanged again)
            renderer.HandleStateChanged(backend.GetSnapshot());
            views = worldRootGo.GetComponentsInChildren<WorldObjectView>();
            int completedHutCount = views.Count(v => v.objectId.StartsWith("building:hut:"));
            foreach (var v in views) {
                if (v.objectId.StartsWith("building:hut:")) {
                    UnityEngine.Debug.Log("Hut view found: " + v.objectId + " instanceId=" + v.gameObject.GetInstanceID());
                }
            }
            int bonfireCount = views.Count(v => v.objectId.StartsWith("building:bonfire:"));
            AssertTrue(completedHutCount == 1, "Save/Load restores exactly 1 Hut", $"Found {completedHutCount} huts after multiple syncs");
            AssertTrue(bonfireCount == 1, "Save/Load restores exactly 1 Bonfire", $"Found {bonfireCount} bonfires after multiple syncs");

            if (!hasErrors) {
                UnityEngine.Debug.Log("==== AUTO WORLD RENDERER TEST PASSED ====");
            } else {
                UnityEngine.Debug.LogError("==== AUTO WORLD RENDERER TEST FAILED ====");
            }

            // Cleanup
            DestroyImmediate(worldRootGo);
            DestroyImmediate(rendererGo);
        }
    }

    public class MapPanHierarchyTest : EditorWindow
    {
        [MenuItem("Tools/TheBonwater/Test Tools/Run Map Pan Hierarchy Test")]
        public static void RunMapPanHierarchyTest() {
            UnityEngine.Debug.Log("==== STARTING MAP PAN HIERARCHY TEST ====");
            
            // Auto-generate the scene so we are testing the latest hierarchy
            UnityEngine.Debug.Log("Generating fresh TownScene for testing...");
            RebuildSceneGenerator.CreateScenes();

            bool hasErrors = false;
            void AssertTrue(bool condition, string errorMsg) {
                if (!condition) {
                    UnityEngine.Debug.LogError("[FAIL] " + errorMsg);
                    hasErrors = true;
                }
            }

            var dragCtrl = GameObject.FindObjectOfType<MapDragController>();
            AssertTrue(dragCtrl != null, "MapDragController is missing in scene");
            
            var worldRootGo = GameObject.Find("TownWorldRoot");
            AssertTrue(worldRootGo != null, "TownWorldRoot is missing in scene");

            if (dragCtrl != null && worldRootGo != null) {
                AssertTrue(dragCtrl.targetTransform == worldRootGo.GetComponent<RectTransform>(), "MapDragController.target is not TownWorldRoot");
            }

            var terrainLayer = worldRootGo != null ? worldRootGo.transform.Find("TerrainLayer") : null;
            AssertTrue(terrainLayer != null, "TerrainLayer is not a child of TownWorldRoot");
            
            if (terrainLayer != null) {
                bool hasBg = terrainLayer.childCount > 0;
                AssertTrue(hasBg, "At least one background/terrain image is not a child of TerrainLayer");
            }

            AssertTrue(worldRootGo != null && worldRootGo.transform.Find("BuildingLayer") != null, "BuildingLayer is missing");
            var decoLayer = worldRootGo != null ? worldRootGo.transform.Find("DecorationLayer") : null;
            AssertTrue(decoLayer != null, "DecorationLayer is missing");
            if (decoLayer != null) {
                AssertTrue(decoLayer.childCount > 0, "DecorationLayer has no static decorations/trees");
            }

            var villagerLayer = worldRootGo != null ? worldRootGo.transform.Find("VillagerLayer") : null;
            AssertTrue(villagerLayer != null, "VillagerLayer is missing");

            var hudRoot = GameObject.Find("HUDRoot");
            if (hudRoot != null && worldRootGo != null) {
                AssertTrue(!hudRoot.transform.IsChildOf(worldRootGo.transform), "HUDRoot should NOT be child of TownWorldRoot");
            }
            
            var buildMenu = GameObject.Find("BuildMenuPanel");
            if (buildMenu != null && worldRootGo != null) {
                AssertTrue(!buildMenu.transform.IsChildOf(worldRootGo.transform), "BuildMenuPanel should NOT be child of TownWorldRoot");
            }

            if (!hasErrors) {
                UnityEngine.Debug.Log("==== MAP PAN HIERARCHY TEST PASSED ====");
            } else {
                UnityEngine.Debug.LogError("==== MAP PAN HIERARCHY TEST FAILED ====");
            }
        }

        [MenuItem("Tools/TheBonwater/Test Tools/Run Multi Construction Test")]
        public static void RunMultiConstructionTest() {
            UnityEngine.Debug.Log("==== STARTING MULTI CONSTRUCTION TEST ====");
            bool hasErrors = false;
            void AssertTrue(bool condition, string errorMsg) {
                if (!condition) { UnityEngine.Debug.LogError("[FAIL] " + errorMsg); hasErrors = true; }
            }

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);

            var visualCtrl = GameObject.FindObjectOfType<TownRuntimeVisualController>();
            if (visualCtrl == null) {
                UnityEngine.Debug.LogError("[FAIL] TownRuntimeVisualController not found in scene. Run from TownScene.");
                return;
            }
            visualCtrl.Initialize();

            // 1. Add enough resources
            for (int i=0; i<10; i++) backend.Execute(new CollectWoodCommand());
            var state = backend.GetSnapshot();
            state.iron += 100;

            // 2. Build Hut
            backend.Execute(new BuildHutCommand());
            // 3. Build Storage
            backend.Execute(new BuildStorageCommand());
            
            var snap = backend.GetSnapshot();
            // 4. Assert snapshot.tasks count >= 2 before completion
            AssertTrue(snap.tasks.Count >= 2, "Backend should have >= 2 tasks after building Hut and Storage.");
            
            visualCtrl.HandleStateChanged(snap);

            // 5. Assert construction visual count >= 2
            var worldRootGo = GameObject.Find("TownWorldRoot");
            var constructionLayer = worldRootGo.transform.Find("ConstructionLayer");
            if (constructionLayer == null) constructionLayer = worldRootGo.transform; // fallback

            var views = worldRootGo.GetComponentsInChildren<WorldObjectView>(true);
            var constructionViews = views.Where(v => v.objectId.StartsWith("construction:")).ToList();
            AssertTrue(constructionViews.Count >= 2, "Expected >= 2 construction views in scene.");

            // 6. Assert each construction visual has unique key
            var ids = constructionViews.Select(v => v.objectId).Distinct().ToList();
            AssertTrue(ids.Count == constructionViews.Count, "Construction views do not have unique keys!");

            // 7. Assert each construction visual has its own progress label
            foreach (var cv in constructionViews) {
                var progressText = cv.transform.Find("ConstructionLabel/ProgressText")?.GetComponent<UnityEngine.UI.Text>();
                AssertTrue(progressText != null, $"Construction {cv.objectId} missing progress label");
                if (progressText != null) {
                    UnityEngine.Debug.Log($"[CONSTRUCTION_VISUAL] key={cv.objectId} target={cv.targetBuildingId} progress={progressText.text} pos={cv.rectTransform.anchoredPosition}");
                }
            }
            UnityEngine.Debug.Log($"[CONSTRUCTION_VISUAL] activeCount={constructionViews.Count}");

            // 8. Advance phase once
            backend.Execute(new AdvanceTimeCommand());
            var snapAfterAdvance = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snapAfterAdvance);

            var viewsAfterAdvance = worldRootGo.GetComponentsInChildren<WorldObjectView>(true).Where(v => v.objectId.StartsWith("construction:")).ToList();
            
            // 9. Assert same instance IDs remain, no flicker
            AssertTrue(viewsAfterAdvance.Count == constructionViews.Count, "Construction views count changed after advancing time!");

            // 11. Complete Hut only
            var hutTask = snapAfterAdvance.tasks.FirstOrDefault(t => t.targetBuildingId == "hut");
            if (hutTask != null) {
                // Complete it manually or add labour
                if (backend is LocalGameBackend lb) {
                    lb.UpdateConstruction(hutTask.id, 9999);
                }
            }
            var snapAfterHut = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snapAfterHut);

            // 12. Assert Hut construction visual removed
            var viewsAfterHut = worldRootGo.GetComponentsInChildren<WorldObjectView>(true);
            var hutConst = viewsAfterHut.FirstOrDefault(v => v.objectId.StartsWith("construction:hut:"));
            AssertTrue(hutConst == null, "Hut construction visual should be removed after completion.");

            // 13. Assert Hut completed building exists
            var hutBld = viewsAfterHut.FirstOrDefault(v => v.objectId.StartsWith("building:hut:"));
            AssertTrue(hutBld != null, "Hut completed visual should exist after completion.");

            // 14. Assert Storage construction visual remains
            var storageConst = viewsAfterHut.FirstOrDefault(v => v.objectId.StartsWith("construction:storage:"));
            AssertTrue(storageConst != null, "Storage construction visual should remain after Hut completed.");

            if (!hasErrors) {
                UnityEngine.Debug.Log("==== MULTI CONSTRUCTION TEST PASSED ====");
            } else {
                UnityEngine.Debug.LogError("==== MULTI CONSTRUCTION TEST FAILED ====");
            }
        }
    }
}
