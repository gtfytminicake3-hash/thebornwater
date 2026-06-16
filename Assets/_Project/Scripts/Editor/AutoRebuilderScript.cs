#if UNITY_EDITOR
using UnityEditor;

namespace TheBonwater.Rebuild.Editor {
    public static class AutoRebuilderScript {
        [InitializeOnLoadMethod]
        public static void RunOnce() {
            if (!EditorPrefs.GetBool("Phase5_Rebuild_Done_v2", false)) {
                EditorApplication.delayCall += () => {
                    RebuildSceneGenerator.CreateScenes();
                    EditorPrefs.SetBool("Phase5_Rebuild_Done_v2", true);
                    UnityEngine.Debug.Log("==== AUTO REBUILD SCENE ONCE FOR PHASE 5 ====");
                };
            }
        }
    }
}
#endif
