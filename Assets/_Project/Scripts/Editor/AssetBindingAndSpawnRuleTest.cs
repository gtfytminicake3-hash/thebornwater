#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using TheBonwater.Rebuild;
using UnityEngine.UI;

namespace TheBonwater.Rebuild.Editor {
    public static class AssetBindingAndSpawnRuleTest {
        
        [MenuItem("Tools/TheBonwater/Run Asset Binding Test")]
        public static void Run() {
            UnityEngine.Debug.Log("Starting Asset Binding and Spawn Rule Test...");
            
            // 1. Initial State Check
            var backend = new LocalGameBackend();
            var controller = Object.FindObjectOfType<TownRuntimeVisualController>();
            if (controller == null) {
                UnityEngine.Debug.LogError("No TownRuntimeVisualController found in scene. Enter Play mode first or spawn it.");
                return;
            }

            // Sync initial state
            // Use reflection or just public methods to trigger UI update
            var interaction = Object.FindObjectOfType<TownInteractionController>();
            if (interaction != null) interaction.RefreshUI();
            
            var worldRoot = controller.transform.Find("TownWorldRoot") ?? controller.transform;
            
            int bonfireCount = 0;
            int hutCount = 0;
            int fallbackLabels = 0;
            bool bonfireSpriteValid = false;
            bool menuHasBonfire = false;

            foreach (Transform t in worldRoot) {
                if (t.name.StartsWith("Bld_Bonfire")) {
                    bonfireCount++;
                    var img = t.GetComponent<Image>();
                    if (img != null && img.sprite != null && img.sprite.name.Contains("Bonfire")) {
                        bonfireSpriteValid = true;
                    }
                    if (t.Find("FallbackLabel") != null) fallbackLabels++;
                }
                if (t.name.StartsWith("Bld_Hut")) hutCount++;
            }

            if (bonfireCount == 1) UnityEngine.Debug.Log("PASS: New Game has exactly 1 Bonfire.");
            else UnityEngine.Debug.LogError($"FAIL: Expected 1 Bonfire, found {bonfireCount}");

            if (bonfireSpriteValid) UnityEngine.Debug.Log("PASS: Bonfire sprite loaded correctly.");
            else UnityEngine.Debug.LogError("FAIL: Bonfire sprite invalid or fallback used.");

            if (fallbackLabels == 0) UnityEngine.Debug.Log("PASS: No duplicate FallbackLabel for Bonfire.");
            else UnityEngine.Debug.LogError($"FAIL: Found {fallbackLabels} FallbackLabel(s) on Bonfire.");

            if (hutCount == 0) UnityEngine.Debug.Log("PASS: New Game has no completed Hut.");
            else UnityEngine.Debug.LogError($"FAIL: Expected 0 Huts, found {hutCount}");

            // 2. Build Menu Check
            if (interaction != null) {
                var btnList = interaction.GetComponentsInChildren<Button>(true);
                foreach (var btn in btnList) {
                    if (btn.name.Contains("Bonfire")) menuHasBonfire = true;
                }
                if (!menuHasBonfire) UnityEngine.Debug.Log("PASS: Build Menu does not contain Bonfire core object.");
                else UnityEngine.Debug.LogError("FAIL: Build Menu contains Bonfire!");
            }

            // 3. Construction Logic Check
            backend.Execute(new CollectWoodCommand()); // 10 wood
            backend.Execute(new CollectWoodCommand()); // 20 wood
            backend.Execute(new CollectWoodCommand()); // 30 wood
            var snap = backend.GetSnapshot();
            snap.wood = 200; // Cheat
            
            backend.Execute(new BuildHutCommand());
            if (interaction != null) interaction.RefreshUI();

            int underConstructionCount = 0;
            foreach (Transform t in worldRoot) {
                if (t.name.StartsWith("Task_")) {
                    underConstructionCount++;
                    var lbl = t.Find("FallbackLabel");
                    if (lbl != null && lbl.GetComponent<Text>().text.Contains("BUILDING SITE")) {
                        UnityEngine.Debug.Log("PASS: Hut spawned as under-construction visual.");
                    } else {
                        UnityEngine.Debug.LogError("FAIL: Construction site lacks BUILDING SITE label.");
                    }
                }
            }
            if (underConstructionCount > 0) UnityEngine.Debug.Log($"PASS: Found {underConstructionCount} under-construction site.");
            else UnityEngine.Debug.LogError("FAIL: No under-construction site found.");

            // Find Task and complete it
            snap = backend.GetSnapshot();
            if (snap.tasks.Count > 0) {
                string tId = snap.tasks[0].id;
                backend.DepositResource(tId);
                backend.UpdateConstruction(tId, 200); // finish
                if (interaction != null) interaction.RefreshUI();

                int completedHutCount = 0;
                foreach (Transform t in worldRoot) {
                    if (t.name.StartsWith("Bld_Hut")) completedHutCount++;
                }
                if (completedHutCount > 0) UnityEngine.Debug.Log("PASS: Completed Hut visual spawned successfully.");
                else UnityEngine.Debug.LogError("FAIL: Completed Hut visual NOT spawned.");
            }

            UnityEngine.Debug.Log("Asset Binding and Spawn Rule Test complete.");
        }
    }
}
#endif
