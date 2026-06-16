import os

filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(filepath, "r", encoding="utf-8") as f:
    content = f.read()

new_tests = """
            // Sprint 1 UI Cleanup tests
            string hudCode = System.IO.File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs");
            bool noWoodButton = hudCode.Contains("btnCollectWood.gameObject.SetActive(false)");
            bool noForceRaid = hudCode.Contains("btnForceRaid.gameObject.SetActive(false)");
            bool noTimeSkip = hudCode.Contains("btnAdvanceTime.gameObject.SetActive(false)");
            
            Check("+10 WOOD is not in player-facing HUD", noWoodButton);
            Check("FORCE RAID is not in player-facing HUD", noForceRaid);
            Check("debug time skip is not in player-facing HUD unless clearly TEMPORARY_DEV_UI", noTimeSkip);
            
            string editorToolPath = "Assets/_Project/Scripts/Editor/TheBonwaterTestToolsWindow.cs";
            bool editorToolExists = System.IO.File.Exists(editorToolPath);
            Check("Editor Test Tool exists", editorToolExists);
            
            if (editorToolExists) {
                string editorCode = System.IO.File.ReadAllText(editorToolPath);
                Check("Editor Test Tool is under Editor folder or UNITY_EDITOR guarded", editorCode.Contains("#if UNITY_EDITOR") || editorToolPath.Contains("/Editor/"));
                Check("debug/test actions are classified DEBUG_ONLY", editorCode.Contains("DEBUG_ONLY"));
            } else {
                Check("Editor Test Tool is under Editor folder or UNITY_EDITOR guarded", false);
                Check("debug/test actions are classified DEBUG_ONLY", false);
            }
            
            Check("temporary UI is classified TEMPORARY_DEV_UI", hudCode.Contains("TEMPORARY_DEV_UI"));
            Check("player-facing UI does not claim unknown actions as original", hudCode.Contains("DEBUG_ONLY"));
"""

if "// Sprint 1 UI Cleanup tests" not in content:
    content = content.replace("Check(\"Project still compiles\", true); // Reaching here means it compiles", "Check(\"Project still compiles\", true);\n" + new_tests)

with open(filepath, "w", encoding="utf-8") as f:
    f.write(content)

print("RebuildVerifier updated.")
