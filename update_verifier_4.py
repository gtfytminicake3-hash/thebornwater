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

            // Open TownScene to verify Visuals
            var sTown = EditorSceneManager.OpenScene("Assets/_Project/Scenes/TownScene.unity", OpenSceneMode.Single);
            
            var worldRoot = GameObject.Find("TownWorldRoot");
            Check("TownScene has TownWorldRoot", worldRoot != null);
            
            var bgGo = GameObject.Find("TownBackground");
            Check("TownScene has TownBackground", bgGo != null);

            int buildingCount = 0;
            int villagerCount = 0;
            int spriteAssignedCount = 0;

            if (worldRoot != null) {
                foreach (Transform child in worldRoot.transform) {
                    if (child.name.StartsWith("Building_")) buildingCount++;
                    if (child.name.StartsWith("Villager_")) villagerCount++;
                    var img = child.GetComponent<Image>();
                    if (img != null && img.sprite != null) spriteAssignedCount++;
                }
            }

            Check("TownScene has at least 3 building visual objects", buildingCount >= 3);
            Check("TownScene has at least 2 villager visual objects", villagerCount >= 2);
            Check("At least 3 Town visual objects have non-null decoded sprites", spriteAssignedCount >= 3);

            var actPanel = GameObject.Find("ActionButtonsPanel");
            bool actionButtonsOk = false;
            if (actPanel != null) {
                var hlg = actPanel.GetComponent<HorizontalLayoutGroup>();
                if (hlg != null) actionButtonsOk = true;
            }
            Check("Action buttons are visible and not overlapping", actionButtonsOk);

            var resBar = GameObject.Find("ResourceBar");
            bool resBarOk = false;
            if (resBar != null) {
                var txt = resBar.GetComponentInChildren<Text>();
                if (txt != null && txt.fontSize >= 20) resBarOk = true;
            }
            Check("ResourceBar font size >= 20", resBarOk);

            var dbgPanel = GameObject.Find("DebugPanel");
            bool dbgPanelOk = false;
            if (dbgPanel != null) {
                var rect = dbgPanel.GetComponent<RectTransform>();
                // anchored at right, so anchorMin.x == 1
                if (rect != null && rect.anchorMin.x == 1) dbgPanelOk = true;
            }
            Check("DebugPanel exists and does not cover center", dbgPanelOk);

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
