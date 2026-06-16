using NUnit.Framework;
using UnityEngine;
using TheBonwater.Rebuild;
using TheBonwater.Rebuild.Data;
using UnityEditor;

namespace TheBonwater.Rebuild.Editor.Tests {
    public class AutoAnimationIntegrationTest {

        [MenuItem("Tools/TheBonwater/Test Tools/Run Animation Integration Test")]
        public static void RunTestMenu() {
            var test = new AutoAnimationIntegrationTest();
            test.RunSmokeTest();
        }

        public void RunSmokeTest() {
            Debug.Log("==== STARTING ANIMATION INTEGRATION SMOKE TEST ====");
            bool hasErrors = false;
            void AssertTrue(bool condition, string errorMsg) {
                if (!condition) { Debug.LogError("[FAIL] " + errorMsg); hasErrors = true; }
            }

            // 1. Compile safe init
            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            var goRoot = GameObject.Find("TownWorldRoot");
            if (goRoot != null) GameObject.DestroyImmediate(goRoot);

            goRoot = new GameObject("TownWorldRoot");
            var visualCtrl = goRoot.AddComponent<TownRuntimeVisualController>();
            
            var registry = goRoot.AddComponent<AnimationRegistry>();
            AnimationRegistryBuilder.BuildRegistry();

            // Just test visual initialization via empty snapshot
            var snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // 2. Dummy UI visual bind missing clip không crash
            var canvasGo = new GameObject("AnimationSmokeCanvas", typeof(Canvas), typeof(UnityEngine.UI.CanvasScaler), typeof(UnityEngine.UI.GraphicRaycaster));
            var testBinderGo = new GameObject("AnimationSmokeVillager", typeof(RectTransform), typeof(UnityEngine.UI.Image), typeof(Animation), typeof(AnimationStateBinder));
            testBinderGo.transform.SetParent(canvasGo.transform);

            var testBinder = testBinderGo.GetComponent<AnimationStateBinder>();
            testBinder.objectId = "test";
            testBinder.objectType = "villager";
            testBinder.image = testBinderGo.GetComponent<UnityEngine.UI.Image>();
            testBinder.animationLegacy = testBinderGo.GetComponent<Animation>();

            // It should not crash now
            testBinder.Bind("non_existent_clip", null);
            AssertTrue(testBinder.usingFallbackBob, "Binder did not fallback when clip is missing");
            
            GameObject.DestroyImmediate(canvasGo);
            GameObject.DestroyImmediate(goRoot);

            if (!hasErrors) {
                Debug.Log("ANIMATION_INTEGRATION_SMOKE_TEST_PASS");
            } else {
                Debug.LogError("[TEST FAILED] Animation Integration Smoke Test finished with errors.");
            }
        }

        private WorldObjectView GetView(GameObject root, string id) {
            foreach (var view in root.GetComponentsInChildren<WorldObjectView>()) {
                if (view.objectId == id) return view;
            }
            return null;
        }
    }
}
