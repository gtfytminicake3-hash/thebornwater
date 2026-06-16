import os

content = """#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using System.Text;
using TheBonwater.Rebuild.Frontend;

namespace TheBonwater.Rebuild.Editor
{
    public class RebuildVerifier
    {
        [MenuItem("Tools/Rebuild/Run Verification")]
        public static void Verify()
        {
            string reportPath = "Assets/_Project/Docs/VerificationReport.md";
            StringBuilder report = new StringBuilder();
            report.AppendLine("# Verification Report");
            report.AppendLine();
            
            int pass = 0; int fail = 0;

            void Check(string condition, bool result) {
                report.AppendLine($"[{(result ? "PASS" : "FAIL")}] {condition}");
                if (result) pass++; else fail++;
            }

            // Check Build Settings
            bool townInBuild = false;
            foreach (var s in EditorBuildSettings.scenes) {
                if (s.path.Contains("TownScene")) townInBuild = true;
            }
            Check("TownScene exists", File.Exists("Assets/_Project/Scenes/TownScene.unity"));
            Check("TownScene in Build Settings", townInBuild);

            // Open MainMenuScene to verify
            var sMain = EditorSceneManager.OpenScene("Assets/_Project/Scenes/MainMenuScene.unity", OpenSceneMode.Single);
            
            var loaderGo = GameObject.Find("MainMenuDirectLoader");
            Check("MainMenuDirectLoader exists", loaderGo != null);
            var loader = loaderGo != null ? loaderGo.GetComponent<MainMenuButtonDirectLoader>() : null;
            Check("MainMenuButtonDirectLoader component exists", loader != null);

            var btnNewGo = GameObject.Find("Btn_NewGame");
            Check("Btn_NewGame exists", btnNewGo != null);
            Button btnNew = btnNewGo != null ? btnNewGo.GetComponent<Button>() : null;
            Check("Btn_NewGame Button component exists", btnNew != null);
            Check("Btn_NewGame has listener count > 0", btnNew != null && btnNew.onClick.GetPersistentEventCount() > 0);

            var btnLoadGo = GameObject.Find("Btn_LoadGame");
            Button btnLoad = btnLoadGo != null ? btnLoadGo.GetComponent<Button>() : null;

            var es = Object.FindObjectOfType<EventSystem>();
            bool hasInputModule = es != null && es.GetComponent<BaseInputModule>() != null;
            Check("MainMenuScene has EventSystem with working input module", hasInputModule);

            // Open TownScene to verify label
            var sTown = EditorSceneManager.OpenScene("Assets/_Project/Scenes/TownScene.unity", OpenSceneMode.Single);
            bool hasLabel = false;
            foreach(var t in Resources.FindObjectsOfTypeAll<Text>()) {
                if (t.text == "TOWN SCENE LOADED") {
                    hasLabel = true;
                    break;
                }
            }
            Check("TownScene has visible TOWN SCENE LOADED label", hasLabel);

            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            File.WriteAllText(reportPath, report.ToString());
            AssetDatabase.Refresh();
            Debug.Log($"Verification Complete! PASS: {pass}, FAIL: {fail}.");
            
            // Re-open BootScene at end of verification to leave editor in safe state
            if (File.Exists("Assets/_Project/Scenes/BootScene.unity")) {
                EditorSceneManager.OpenScene("Assets/_Project/Scenes/BootScene.unity", OpenSceneMode.Single);
            }
        }
    }
}
#endif
"""

with open(r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs", "w", encoding="utf-8") as f:
    f.write(content)

print("Updated RebuildVerifier.cs via python!")
