import os

verifier_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(verifier_path, "r", encoding="utf-8") as f:
    content = f.read()

extraction_checks = """
            // SPRINT 04 - AssetStudio Bridge Checks
            Check("AssetStudio manual export instructions exist", File.Exists(docsPath + "AssetStudio_GUI_Manual_Export_Instructions.md"));
            Check("PriorityObjectsForManualAssetStudioExport.csv exists", File.Exists(docsPath + "PriorityObjectsForManualAssetStudioExport.csv"));
            Check("parse_assetstudio_manual_export.py exists", File.Exists("Tools/Extraction/parse_assetstudio_manual_export.py"));
            Check("Run_PostAssetStudio_Parse_Command.md exists", File.Exists(docsPath + "Run_PostAssetStudio_Parse_Command.md"));
            
            // Check that no fallback was guessed in definitions (which is covered by SPRINT 02 logic already)
"""

if "SPRINT 04 - AssetStudio Bridge Checks" not in content:
    content = content.replace("            // SPRINT 02 - Data Extraction Checks", extraction_checks + "\n            // SPRINT 02 - Data Extraction Checks")
    with open(verifier_path, "w", encoding="utf-8") as f:
        f.write(content)

print("RebuildVerifier updated for Sprint 4.")
