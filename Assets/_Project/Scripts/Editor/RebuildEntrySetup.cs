#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using System.IO;

namespace TheBonwater.Rebuild.Editor
{
    public static class RebuildEntrySetup
    {
        [MenuItem("Tools/Rebuild/Setup Entry Settings")]
        public static void SetupAll()
        {
            // 1. Setup Build Settings
            RebuildBuildSettingsSetup.SetupBuildSettings();

            // 2. Set Play Mode Start Scene
            PlayModeStartSceneSetter.SetBootSceneAsPlayStart();

            // 3. Create START_HERE_BootScene.unity
            string bootScenePath = "Assets/_Project/Scenes/BootScene.unity";
            string startHerePath = "Assets/_Project/Scenes/START_HERE_BootScene.unity";
            if (File.Exists(bootScenePath) && !File.Exists(startHerePath))
            {
                AssetDatabase.CopyAsset(bootScenePath, startHerePath);
                UnityEngine.Debug.Log("[Rebuild] Created START_HERE_BootScene.unity");
            }

            // 4. Inject Redirector into SampleScene
            string sampleScenePath = "Assets/Scenes/SampleScene.unity";
            if (File.Exists(sampleScenePath))
            {
                var scene = EditorSceneManager.OpenScene(sampleScenePath, OpenSceneMode.Single);
                var existing = GameObject.Find("RebuildEntryRedirector");
                if (existing == null)
                {
                    var go = new GameObject("RebuildEntryRedirector");
                    go.AddComponent<SampleSceneRedirector>();
                    EditorSceneManager.SaveScene(scene);
                    UnityEngine.Debug.Log("[Rebuild] Injected SampleSceneRedirector into SampleScene.");
                }
            }

            // Re-run Verification
            RebuildVerifier.Verify();
        }
    }
}
#endif
