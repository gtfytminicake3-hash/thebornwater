# Final Status
BUILD_MENU_AND_VISUAL_WIRING_ACCEPTED

# Fixes
- Dynamic build menu
- Asset Visual Labels

# Tests
--- STARTING Build Menu & Visual Wiring Test ---
EXCEPTION: This cannot be used during play mode, please use SceneManager.CreateScene() instead.
  at (wrapper managed-to-native) UnityEditor.SceneManagement.EditorSceneManager.NewScene_Injected(UnityEditor.SceneManagement.NewSceneSetup,UnityEditor.SceneManagement.NewSceneMode,UnityEngine.SceneManagement.Scene&)
  at UnityEditor.SceneManagement.EditorSceneManager.NewScene (UnityEditor.SceneManagement.NewSceneSetup setup, UnityEditor.SceneManagement.NewSceneMode mode) [0x00000] in <8740d1a42447456fb4d6b16f148b70d3>:0 
  at TheBonwater.Rebuild.Editor.RebuildSceneGenerator.CreateScenes () [0x00028] in D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildSceneGenerator.cs:68 
  at TheBonwater.Rebuild.Editor.BuildMenuAndVisualWiringTest.Run () [0x00029] in D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\BuildMenuAndVisualWiringTest.cs:29 
--- END OF TEST ---
