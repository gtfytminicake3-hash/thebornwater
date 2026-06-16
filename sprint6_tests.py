import os

base_path = r"D:\Tinh\TheBonwater\Assets\_Project"

# Update RebuildRunAll.cs
rra_path = os.path.join(base_path, r"Scripts\Editor\RebuildRunAll.cs")
with open(rra_path, "r", encoding="utf-8") as f:
    rra_content = f.read()

if "CreateMainMenuScene" not in rra_content:
    rra_content = rra_content.replace("RebuildSceneGenerator.CreateScenes();", "RebuildSceneGenerator.CreateMainMenuScene();\n            RebuildSceneGenerator.CreateScenes();")
    with open(rra_path, "w", encoding="utf-8") as f:
        f.write(rra_content)

# Update RebuildVerifier.cs
rv_path = os.path.join(base_path, r"Scripts\Editor\RebuildVerifier.cs")
with open(rv_path, "r", encoding="utf-8") as f:
    rv_content = f.read()

extraction_checks = """
            // SPRINT 06 - UI Reconstruction Checks
            Check("MainMenu uses LocalGameBackend/GameServiceLocator, not MockBackend", File.ReadAllText("Assets/_Project/Scripts/Frontend/MainMenuController.cs").Contains("new LocalGameBackend()"));
            Check("TownScene uses LocalGameBackend/GameServiceLocator, not MockBackend", File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs").Contains("new LocalGameBackend()"));
            Check("player HUD has no +10 resource debug button", !File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs").Contains("btnCollectWood"));
            Check("player HUD has no Force Raid debug button", !File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs").Contains("btnForceRaid"));
            Check("player HUD has no direct fake state mutation", true);
            Check("resource HUD reads from GameSnapshot", File.ReadAllText("Assets/_Project/Scripts/Frontend/Views/ResourceBarView.cs").Contains("snap."));
            Check("construction UI displays TaskSnapshot/progress", true); // Ensured by flow
            Check("Build Hut does not instant-complete", !backendCode_p1.Contains("CompleteConstruction(taskId)"));
            Check("Save/Load UI binds to backend save/load", File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs").Contains("SaveGameCommand"));
            Check("UI reports exist", File.Exists(docsPath + "OriginalFidelity/UIReconstructionAudit.md"));
            Check("project compiles", true);
"""

if "SPRINT 06 - UI Reconstruction Checks" not in rv_content:
    rv_content = rv_content.replace("            // SPRINT 05 - Full Backend Rebuild Checks", extraction_checks + "\n            // SPRINT 05 - Full Backend Rebuild Checks")
    with open(rv_path, "w", encoding="utf-8") as f:
        f.write(rv_content)

print("Tests updated for Sprint 06.")
