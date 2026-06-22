#if UNITY_EDITOR
using UnityEditor;

namespace TheBonwater.Rebuild.Editor {
    [InitializeOnLoad]
    public static class ForceSceneRegeneration {
        static ForceSceneRegeneration() {
            // Automatic scene regeneration is DISABLED by default.
            // To enable temporarily, set EditorPref:
            //   EditorPrefs.SetBool("TheBonwater.AutoRegenerateScenes", true);
            //
            // To create the initial scene, use:
            //   Tools > Rebuild > Create Town Scene
            //
            if (EditorPrefs.GetBool("TheBonwater.AutoRegenerateScenes", false)) {
                EditorApplication.delayCall += () => {
                    if (EditorApplication.isPlayingOrWillChangePlaymode) return;
                    RebuildSceneGenerator.CreateScenes();
                    EditorPrefs.SetBool("TheBonwater.AutoRegenerateScenes", false);
                    UnityEngine.Debug.Log("[ForceSceneRegeneration] Auto scene regeneration complete. EditorPref has been reset to false.");
                };
            }
        }
    }
}
#endif
