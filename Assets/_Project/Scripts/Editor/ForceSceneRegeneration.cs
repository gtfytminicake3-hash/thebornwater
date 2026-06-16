#if UNITY_EDITOR
using UnityEditor;

namespace TheBonwater.Rebuild.Editor {
    [InitializeOnLoad]
    public static class ForceSceneRegeneration {
        static ForceSceneRegeneration() {
            if (!SessionState.GetBool("HasForcedSceneGenSprint15_v2", false)) {
                EditorApplication.delayCall += () => {
                    if (EditorApplication.isPlayingOrWillChangePlaymode) return;
                    RebuildSceneGenerator.CreateScenes();
                    SessionState.SetBool("HasForcedSceneGenSprint15_v2", true);
                    UnityEngine.Debug.Log("Forced Scene Regeneration for Sprint 15 fixes!");
                };
            }
        }
    }
}
#endif
