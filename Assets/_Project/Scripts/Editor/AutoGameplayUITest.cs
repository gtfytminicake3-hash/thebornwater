using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Linq;
using TheBonwater.Rebuild;
using TheBonwater.Rebuild.Data;

namespace TheBonwater.Rebuild.Editor {
    public class AutoGameplayUITest : EditorWindow {
        [MenuItem("Tools/TheBonwater/Test Tools/Run Gameplay UI Test")]
        public static void Run() {
            Debug.Log("==== STARTING GAMEPLAY UI TEST ====");
            bool hasErrors = false;
            void AssertTrue(bool condition, string errorMsg) {
                if (!condition) { Debug.LogError("[FAIL] " + errorMsg); hasErrors = true; }
            }

            void TEST_ONLY_SetResources(LocalGameBackend testBackend, int wood, int food, int iron) {
                var stateField = typeof(LocalGameBackend).GetField("state", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (stateField != null) {
                    var s = stateField.GetValue(testBackend) as GameSnapshot;
                    if (s != null) {
                        s.wood = wood; s.food = food; s.iron = iron;
                    }
                }
            }

            // 1. New Game
            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            RebuildSceneGenerator.CreateScenes();
            var hudRoot = GameObject.Find("HUDRoot");
            var uiManager = GameObject.FindFirstObjectByType<GameplayUIManager>();
            
            // 2. Assert HUDRoot exists
            AssertTrue(hudRoot != null, "HUDRoot not found");
            AssertTrue(uiManager != null, "GameplayUIManager not found");
            
            var snap = backend.GetSnapshot();
            uiManager.HandleStateChanged(snap);

            // 3. Assert TopResourceBar text
            var topBar = GameObject.FindFirstObjectByType<TopResourceBarView>();
            AssertTrue(topBar != null && topBar.txtResources != null, "TopResourceBar not found");
            AssertTrue(topBar.txtResources.text.Contains($"DAY {snap.day}"), "TopResourceBar missing DAY text");

            var bottomActionBar = GameObject.Find("BottomActionBar");
            AssertTrue(bottomActionBar != null, "BottomActionBar not found");
            var btnOpenBuildMenuTransform = bottomActionBar.transform.Find("BtnOpenBuildMenu");
            AssertTrue(btnOpenBuildMenuTransform != null, "BtnOpenBuildMenu missing from BottomActionBar");
            AssertTrue(bottomActionBar.transform.Find("Next Phase") != null, "BtnNextPhase missing");
            AssertTrue(bottomActionBar.transform.Find("Save") != null, "BtnSaveGame missing");
            AssertTrue(bottomActionBar.transform.Find("Load") != null, "BtnLoadGame missing");

            // 4. Assert BuildMenuPanel starts hidden
            var buildMenu = GameObject.FindFirstObjectByType<BuildMenuPanelView>(FindObjectsInactive.Include);
            AssertTrue(buildMenu != null, "BuildMenuPanelView not found");
            AssertTrue(!buildMenu.gameObject.activeSelf, "BuildMenuPanel must start hidden");
            
            var btnOpenBuildMenu = btnOpenBuildMenuTransform.GetComponent<Button>();
            AssertTrue(btnOpenBuildMenu != null, "BtnOpenBuildMenu has no Button component");
            
            // 7. Invoke BtnOpenBuildMenu.onClick
            btnOpenBuildMenu.onClick.Invoke();
            AssertTrue(buildMenu.gameObject.activeSelf, "BuildMenuPanel must be visible");

            // Raycast test at center of Close button
            var closeBtn = buildMenu.transform.Find("HeaderCloseArea/BtnCloseBuildMenu")?.GetComponent<Button>();
            AssertTrue(closeBtn != null, "BtnCloseBuildMenu not found");
            var closeRectTr = closeBtn.GetComponent<RectTransform>();
            Vector3[] corners = new Vector3[4];
            closeRectTr.GetWorldCorners(corners);
            Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(null, (corners[0] + corners[2]) / 2f);
            
            var pointerData = new UnityEngine.EventSystems.PointerEventData(UnityEngine.EventSystems.EventSystem.current) {
                position = screenPoint
            };
            var results = new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>();
            UnityEngine.EventSystems.EventSystem.current.RaycastAll(pointerData, results);
            
            if (results.Count > 0) {
                Diagnostics.RuntimeTrace.Log("BUILD_MENU_RAYCAST_TEST", $"point=closeCenter hit0={results[0].gameObject.name}");
                AssertTrue(results[0].gameObject.name == "BtnCloseBuildMenu", $"BUILD_MENU_RAYCAST_ERROR: close center is blocked by {results[0].gameObject.name}");
            } else {
                Diagnostics.RuntimeTrace.Log("BUILD_MENU_RAYCAST_TEST", "point=closeCenter hit0=NONE");
            }

            // 5. Invoke BtnOpenBuildMenu.onClick again to toggle close.
            btnOpenBuildMenu.onClick.Invoke();
            AssertTrue(!buildMenu.gameObject.activeSelf, "BuildMenuPanel must be hidden after toggle close click");

            // 8. Assert no hut construction task was created by clicking X
            snap = backend.GetSnapshot();
            bool hasAnyHutTask = snap.tasks.Exists(t => !string.IsNullOrEmpty(t.targetBuildingId) && t.targetBuildingId == "hut");
            AssertTrue(!hasAnyHutTask, "X button should not create a construction task");
            
            // Assert logs from old test parts
            var logsInitial = Diagnostics.RuntimeTrace.GetLogs();

            // 11. Invoke BtnOpenBuildMenu again
            btnOpenBuildMenu.onClick.Invoke();
            AssertTrue(buildMenu.gameObject.activeSelf, "BuildMenuPanel must be visible again");

            // 5. Assert Hut/Storage/GuardTower buttons exist
            var hutBtn = buildMenu.contentRoot.Find("BtnBuild_hut")?.GetComponent<Button>();
            var storageBtn = buildMenu.contentRoot.Find("BtnBuild_storage")?.GetComponent<Button>();
            var towerBtn = buildMenu.contentRoot.Find("BtnBuild_guardTower")?.GetComponent<Button>();
            
            AssertTrue(hutBtn != null, "Hut build button missing");
            AssertTrue(storageBtn != null, "Storage build button missing");
            AssertTrue(towerBtn != null, "GuardTower build button missing");

            // 2. Set Wood=0 TEST_ONLY.
            TEST_ONLY_SetResources(backend, 0, 0, 0);
            snap = backend.GetSnapshot();
            uiManager.HandleStateChanged(snap);

            // 3. Open BuildMenu.
            Diagnostics.RuntimeTrace.Clear();
            btnOpenBuildMenu.onClick.Invoke();
            AssertTrue(buildMenu.gameObject.activeSelf, "BuildMenuPanel must be visible again");

            // 4. Invoke BtnOpenBuildMenu.onClick to toggle close.
            btnOpenBuildMenu.onClick.Invoke();

            // 5. Assert BuildMenuPanel hidden.
            AssertTrue(!buildMenu.gameObject.activeSelf, "BuildMenuPanel must be hidden after toggle close click");

            // 6. Assert no hut task created.
            snap = backend.GetSnapshot();
            bool hasHutTaskZeroRes = snap.tasks.Exists(t => !string.IsNullOrEmpty(t.targetBuildingId) && t.targetBuildingId == "hut");
            AssertTrue(!hasHutTaskZeroRes, "Hut task created even with 0 resources");

            // 7. Assert RuntimeTrace contains "BuildMenu closed".
            var logs = Diagnostics.RuntimeTrace.GetLogs();
            bool hasCloseLog = logs.Exists(l => l.Contains("BuildMenu closed"));
            AssertTrue(hasCloseLog, "Missing 'BuildMenu closed' log");

            // 8. Assert RuntimeTrace does NOT contain "Build blocked id=hut".
            bool hasBlockedLog = logs.Exists(l => l.Contains("Build blocked id=hut"));
            AssertTrue(!hasBlockedLog, "'Build blocked' log found when clicking X. X button overlaps with Hut button!");

            // 9. Open BuildMenu again.
            btnOpenBuildMenu.onClick.Invoke();

            // 10. Invoke BtnBuild_hut.onClick.
            var buildMenuObj = uiManager.buildMenuPanel;
            var closeBtnTransform = buildMenuObj.transform.parent?.Find("BuildMenuPanel/HeaderCloseArea/BtnCloseBuildMenu");
            if (closeBtnTransform == null) closeBtnTransform = buildMenuObj.transform.Find("HeaderCloseArea/BtnCloseBuildMenu");
            var closeBtnRef = closeBtnTransform?.GetComponent<Button>();
            hutBtn = buildMenuObj.contentRoot.Find("BtnBuild_hut")?.GetComponent<Button>();
            AssertTrue(hutBtn != null, "Hut build button missing");
            if (hutBtn != null) hutBtn.onClick.Invoke();

            // 11. Assert no hut task created.
            snap = backend.GetSnapshot();
            hasHutTaskZeroRes = snap.tasks.Exists(t => !string.IsNullOrEmpty(t.targetBuildingId) && t.targetBuildingId == "hut");
            AssertTrue(!hasHutTaskZeroRes, "Hut task created even with 0 resources");

            // 12. Assert RuntimeTrace contains "Build blocked id=hut reason=Not enough resources".
            logs = Diagnostics.RuntimeTrace.GetLogs();
            hasBlockedLog = logs.Exists(l => l.Contains("Build blocked id=hut reason=Not enough resources"));
            AssertTrue(hasBlockedLog, "Missing 'Build blocked' log when clicking Hut with 0 resources");

            // 13. Invoke BtnOpenBuildMenu.onClick again to toggle close.
            btnOpenBuildMenu.onClick.Invoke();

            // 14. Assert BuildMenuPanel hidden.
            AssertTrue(!buildMenu.gameObject.activeSelf, "BuildMenuPanel must be hidden after close click when blocked");

            // 15. Set Wood=200 TEST_ONLY.
            TEST_ONLY_SetResources(backend, 200, 200, 200);
            snap = backend.GetSnapshot();
            uiManager.HandleStateChanged(snap);

            // 16. Open BuildMenu.
            btnOpenBuildMenu.onClick.Invoke();

            // 17. Invoke BtnOpenBuildMenu.onClick to toggle close.
            Diagnostics.RuntimeTrace.Clear();
            btnOpenBuildMenu.onClick.Invoke();

            // 18. Assert still no hut task created.
            snap = backend.GetSnapshot();
            hasHutTaskZeroRes = snap.tasks.Exists(t => !string.IsNullOrEmpty(t.targetBuildingId) && t.targetBuildingId == "hut");
            AssertTrue(!hasHutTaskZeroRes, "Hut task created when clicking X with enough resources!");

            // 19. Open BuildMenu.
            btnOpenBuildMenu.onClick.Invoke();

            // 20. Invoke BtnBuild_hut.onClick.
            if (hutBtn != null) hutBtn.onClick.Invoke();

            // 21. Assert exactly one hut task created.
            snap = backend.GetSnapshot();
            int hutTaskCount = snap.tasks.FindAll(t => !string.IsNullOrEmpty(t.targetBuildingId) && t.targetBuildingId == "hut").Count;
            AssertTrue(hutTaskCount == 1, $"Expected exactly 1 hut task, got {hutTaskCount}");

            // 22. Build/complete Hut three times TEST_ONLY
            for (int i=0; i<10; i++) backend.Execute(new AdvanceTimeCommand()); // complete first hut
            
            // second hut
            btnOpenBuildMenu.onClick.Invoke();
            if (hutBtn != null) hutBtn.onClick.Invoke();
            for (int i=0; i<10; i++) backend.Execute(new AdvanceTimeCommand());
            
            // third hut
            btnOpenBuildMenu.onClick.Invoke();
            if (hutBtn != null) hutBtn.onClick.Invoke();
            for (int i=0; i<10; i++) backend.Execute(new AdvanceTimeCommand());

            // 23. Assert Buildings UI shows Hut: 3.
            snap = backend.GetSnapshot();
            uiManager.HandleStateChanged(snap);
            var leftStatus = GameObject.FindFirstObjectByType<LeftStatusPanelView>(FindObjectsInactive.Include);
            AssertTrue(leftStatus != null, "LeftStatusPanel missing");
            AssertTrue(leftStatus.txtStatus.text.Contains("Hut: 3") || leftStatus.txtStatus.text.Contains("Hut:  3") || leftStatus.txtStatus.text.Contains("Hut : 3"), "Buildings UI doesn't show Hut: 3");

            // 18. Set 2 villagers Woodcutter TEST_ONLY if no direct command exists.
            foreach(var v in snap.villagers) v.job = "Woodcutter";
            
            int woodBefore = snap.wood;
            Diagnostics.RuntimeTrace.Clear();

            // 19. Click Next Phase UI.
            var btnNextPhase = GameObject.Find("BottomActionBar")?.transform.Find("Next Phase")?.GetComponent<Button>();
            AssertTrue(btnNextPhase != null, "TEMPORARY_DEV_UI: Next Phase button missing");
            if (btnNextPhase != null) btnNextPhase.onClick.Invoke();

            // 20. Assert RESOURCE_DELTA exists.
            logs = Diagnostics.RuntimeTrace.GetLogs();
            bool hasDeltaLog = logs.Exists(l => l.Contains("RESOURCE_DELTA"));
            AssertTrue(hasDeltaLog, "Missing RESOURCE_DELTA log after Next Phase");

            // 21. Assert productionWood > 0 or explicit blocking reason exists.
            snap = backend.GetSnapshot();
            AssertTrue(snap.wood > woodBefore, $"Wood didn't increase. Before={woodBefore}, After={snap.wood}. Logs: {string.Join("\n", logs.FindAll(l => l.Contains("RESOURCE_DELTA") || l.Contains("JOB_TICK")))}");

            // 24. Save/Load UI no exception.
            backend.Execute(new SaveGameCommand());
            backend.Execute(new LoadGameCommand());
            snap = backend.GetSnapshot();
            uiManager.HandleStateChanged(snap);
            
            AssertTrue(leftStatus.txtStatus.text.Contains("Hut: 3") || leftStatus.txtStatus.text.Contains("Hut:  3") || leftStatus.txtStatus.text.Contains("Hut : 3"), "UI failed to refresh after Load");

            if (!hasErrors) {
                Debug.Log("==== GAMEPLAY UI TEST PASSED ====");
            } else {
                Debug.LogError("==== GAMEPLAY UI TEST FAILED ====");
            }
        }
    }
}
