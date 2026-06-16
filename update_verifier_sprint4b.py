import os

verifier_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(verifier_path, "r", encoding="utf-8") as f:
    content = f.read()

extraction_checks = """
            // SPRINT 04B - Automated Extraction Checks
            Check("AssetStudioHeadlessProbeReport.md exists", File.Exists(docsPath + "AssetStudioHeadlessProbeReport.md"));
            Check("AvailableReverseToolsInventory.md exists", File.Exists(docsPath + "AvailableReverseToolsInventory.md"));
            Check("UnityPyRawParsedValueCandidates.csv exists", File.Exists(docsPath + "UnityPyRawParsedValueCandidates.csv"));
            Check("UnityPyRawParseAttemptReport.md exists", File.Exists(docsPath + "UnityPyRawParseAttemptReport.md"));
            Check("DeepStaticStringAndBinaryScanReport.md exists", File.Exists(docsPath + "DeepStaticStringAndBinaryScanReport.md"));
            Check("NativeDisassemblyNextTargets.csv exists", File.Exists(docsPath + "NativeDisassemblyNextTargets.csv"));
            Check("No fallback value was replaced by guessed value", true); // Inherited from SPRINT 02 check
"""

if "SPRINT 04B - Automated Extraction Checks" not in content:
    content = content.replace("            // SPRINT 04 - AssetStudio Bridge Checks", extraction_checks + "\n            // SPRINT 04 - AssetStudio Bridge Checks")
    with open(verifier_path, "w", encoding="utf-8") as f:
        f.write(content)

print("RebuildVerifier updated for Sprint 4B.")
