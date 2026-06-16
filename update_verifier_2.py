import os

content = """#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;
using System.Text;

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

            // 5. Add scenes to Build Settings check
            bool bootInBuild = false, mainInBuild = false, loadInBuild = false, townInBuild = false;
            foreach (var s in EditorBuildSettings.scenes) {
                if (s.path.Contains("BootScene")) bootInBuild = true;
                if (s.path.Contains("MainMenuScene")) mainInBuild = true;
                if (s.path.Contains("LoadingScene")) loadInBuild = true;
                if (s.path.Contains("TownScene")) townInBuild = true;
            }
            Check("BootScene/MainMenu/Loading/Town are in Build Settings", bootInBuild && mainInBuild && loadInBuild && townInBuild);

            // Open MainMenuScene to verify
            var sMain = EditorSceneManager.OpenScene("Assets/_Project/Scenes/MainMenuScene.unity", OpenSceneMode.Single);
            
            var btnNewGo = GameObject.Find("Btn_NewGame");
            Check("Btn_NewGame exists", btnNewGo != null);
            Button btnNew = btnNewGo != null ? btnNewGo.GetComponent<Button>() : null;
            Check("Btn_NewGame has Button component", btnNew != null);

            var btnLoadGo = GameObject.Find("Btn_LoadGame");
            Check("Btn_LoadGame exists", btnLoadGo != null);
            Button btnLoad = btnLoadGo != null ? btnLoadGo.GetComponent<Button>() : null;
            Check("Btn_LoadGame has Button component", btnLoad != null);

            var view = Object.FindObjectOfType<MainMenuView>();
            Check("Btn_NewGame has onClick listener", view != null && view.btnNewGame != null);
            Check("Btn_LoadGame has onClick listener", view != null && view.btnLoadGame != null);

            var bgGo = GameObject.Find("DecodedAssetBackground");
            if (bgGo != null) {
                var img = bgGo.GetComponent<Image>();
                Check("DecodedAssetBackground raycastTarget is false", img != null && img.raycastTarget == false);
            } else {
                Check("DecodedAssetBackground raycastTarget is false", false);
            }

            var es = Object.FindObjectOfType<EventSystem>();
            bool hasInputModule = es != null && es.GetComponent<BaseInputModule>() != null;
            Check("MainMenuScene has EventSystem with working input module", hasInputModule);

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
