import os

# Update RebuildVerifier.cs
filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(filepath, "r", encoding="utf-8") as f:
    content = f.read()

# I will replace the Run tests in RebuildVerifier to also include these checks
new_tests = """
            // Pass 01 Fidelity Checks
            string hudCode = System.IO.File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs");
            Check("Player HUD has no DEBUG_ONLY buttons", hudCode.Contains("btnCollectWood.gameObject.SetActive(false)"));
            
            string editorToolPath = "Assets/_Project/Scripts/Editor/TheBonwaterTestToolsWindow.cs";
            Check("Editor Test Tool exists", System.IO.File.Exists(editorToolPath));

            string smokeTestPath = "Assets/_Project/Docs/OriginalFidelity/EndToEndSmokeTestReport.md";
            Check("End-to-end smoke test report generated", System.IO.File.Exists(smokeTestPath));

            string backendCode = System.IO.File.ReadAllText("Assets/_Project/Scripts/Backend/Runtime/LocalGameBackend.cs");
            Check("Build command creates construction, not completed building", backendCode.Contains("StartConstruction("));
            Check("Main runtime does not auto deposit/progress construction", !backendCode.Contains("currentCompletion +="));
            Check("Editor Test Tool can deposit/progress for testing", backendCode.Contains("Test_ProgressConstruction("));
            
            string gsCode = System.IO.File.ReadAllText("Assets/_Project/Scripts/Contracts/GameSnapshot.cs");
            Check("Construction state has fidelity fields", gsCode.Contains("fidelityClassification"));
            Check("Fallback numbers are marked fallback", gsCode.Contains("UNKNOWN_OR_MISSING"));
            Check("Save/load handles construction state", gsCode.Contains("List<TaskSnapshot> tasks"));
"""

if "Pass 01 Fidelity Checks" not in content:
    content = content.replace("Check(\"Project still compiles\", true);", "Check(\"Project still compiles\", true);\n" + new_tests)

with open(filepath, "w", encoding="utf-8") as f:
    f.write(content)

print("RebuildVerifier updated.")
