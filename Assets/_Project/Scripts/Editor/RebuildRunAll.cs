#if UNITY_EDITOR
using UnityEditor;

namespace TheBonwater.Rebuild.Editor
{
    public static class RebuildRunAll
    {
        [MenuItem("Tools/Rebuild/Run All (Generate + Verify)")]
        public static void RunAll()
        {
            RebuildSceneGenerator.CreateMainMenuScene();
            RebuildSceneGenerator.CreateScenes();
            EnsureSceneOwnedUIPanels.Execute();
            RebuildVerifier.Verify();
        }
    }
}
#endif
