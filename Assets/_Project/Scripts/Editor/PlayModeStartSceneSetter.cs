using UnityEditor;
using UnityEditor.SceneManagement;

namespace TheBonwater.Rebuild.Editor
{
    [InitializeOnLoad]
    public static class PlayModeStartSceneSetter
    {
        static PlayModeStartSceneSetter()
        {
            SetBootSceneAsPlayStart();
        }

        [MenuItem("Tools/Rebuild/Set BootScene As Play Start")]
        public static void SetBootSceneAsPlayStart()
        {
            var bootScene = AssetDatabase.LoadAssetAtPath<SceneAsset>("Assets/_Project/Scenes/BootScene.unity");
            if (bootScene != null)
            {
                EditorSceneManager.playModeStartScene = bootScene;
                UnityEngine.Debug.Log("[Rebuild] Play Mode Start Scene set to BootScene.");
            }
            else
            {
                UnityEngine.Debug.LogWarning("[Rebuild] BootScene not found, could not set play mode start scene.");
            }
        }
    }
}
