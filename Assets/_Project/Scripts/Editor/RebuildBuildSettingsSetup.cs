using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild.Editor
{
    [InitializeOnLoad]
    public static class RebuildBuildSettingsSetup
    {
        static RebuildBuildSettingsSetup()
        {
            SetupBuildSettings();
        }

        [MenuItem("Tools/Rebuild/Setup Build Settings")]
        public static void SetupBuildSettings()
        {
            string[] requiredScenes = new string[]
            {
                "Assets/_Project/Scenes/BootScene.unity",
                "Assets/_Project/Scenes/MainMenuScene.unity",
                "Assets/_Project/Scenes/LoadingScene.unity",
                "Assets/_Project/Scenes/TownScene.unity"
            };

            var editorBuildSettingsScenes = new List<EditorBuildSettingsScene>();
            
            // Add required scenes first
            foreach (var path in requiredScenes)
            {
                if (System.IO.File.Exists(path))
                {
                    editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(path, true));
                }
            }

            // Append existing scenes if they are not in the required list
            foreach (var existing in EditorBuildSettings.scenes)
            {
                if (!requiredScenes.Contains(existing.path) && System.IO.File.Exists(existing.path))
                {
                    editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(existing.path, existing.enabled));
                }
            }

            EditorBuildSettings.scenes = editorBuildSettingsScenes.ToArray();
            UnityEngine.Debug.Log("[Rebuild] EditorBuildSettings updated with Rebuild scenes automatically.");
        }
    }
}
