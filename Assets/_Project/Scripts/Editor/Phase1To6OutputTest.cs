using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;
using System.Linq;

namespace TheBonwater.Rebuild.Editor.Tests {
    public class Phase1To6OutputTest {
        [MenuItem("Tools/TheBonwater/Test Tools/Run Phase 1-6 Output Test")]
        public static void RunTest() {
            Debug.Log("==== STARTING PHASE 1-6 OUTPUT TEST ====");
            bool hasErrors = false;
            void AssertTrue(bool condition, string errorMsg) {
                if (!condition) { Debug.LogError("[FAIL] " + errorMsg); hasErrors = true; }
            }

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            var goRoot = GameObject.Find("TownWorldRoot");
            if (goRoot != null) GameObject.DestroyImmediate(goRoot);
            goRoot = new GameObject("TownWorldRoot");

            var visualCtrl = goRoot.AddComponent<TownRuntimeVisualController>();
            
            // Rebuild registry first for test if needed, or rely on Resources
            AnimationRegistryBuilder.BuildRegistry();
            
            // 1. New Game visual checks
            var snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // 5. Raid Visual Test trigger
            // Create test raid explicitly:
            EnemyState enemy = new EnemyState { 
                id = "test_raid_output", 
                typeId = "SmallMonster", 
                displayName = "Test Monster", 
                hp = 30, 
                attack = 15, 
                status = "Active", 
                spawnPhase = snap.day, 
                clearAtNextPhase = true, 
                removePending = false 
            };
            
            backend.GetSnapshot().enemies.Add(enemy);
            visualCtrl.HandleStateChanged(backend.GetSnapshot());
            
            bool monsterFound = false;
            bool hasValidImage = false;
            foreach (Transform t in goRoot.GetComponentsInChildren<Transform>(true)) {
                if (t.name == "monster:test_raid_output") {
                    monsterFound = true;
                    var img = t.GetComponent<UnityEngine.UI.Image>();
                    if (t.gameObject.activeInHierarchy && img != null && img.enabled && img.sprite != null && img.color.a > 0) {
                        hasValidImage = true;
                    }
                }
            }
            
            AssertTrue(monsterFound, "Monster visual not created");
            AssertTrue(hasValidImage, "Monster visual has no sprite or fallback label configured");

            if (!hasErrors) {
                Debug.Log("PHASE_1_TO_6_OUTPUT_TEST_PASS");
            } else {
                Debug.LogError("[TEST FAILED] Phase 1-6 Output Test finished with errors.");
            }
        }
    }
}
