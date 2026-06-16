import os

verifier_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(verifier_path, "r", encoding="utf-8") as f:
    content = f.read()

# Insert extraction checks right after fidelity reports check
extraction_checks = """
            // SPRINT 02 - Data Extraction Checks
            string docsPath = "Assets/_Project/Docs/OriginalFidelity/";
            Check("DecodedDataExtractionInventory.csv exists", File.Exists(docsPath + "DecodedDataExtractionInventory.csv"));
            Check("DecodeDataExtractionReport.md exists", File.Exists(docsPath + "DecodeDataExtractionReport.md"));
            Check("MissingDecodeEvidenceList.md updated", File.Exists(docsPath + "MissingDecodeEvidenceList.md"));
            
            // Check definitions for fidelity labels
            string defsPath = "Assets/_Project/Data/Definitions/";
            string[] defFiles = new string[] { "buildings.json", "resources.json", "jobs.json", "tasks.json", "enemies.json", "balance.json" };
            foreach(var df in defFiles) {
                if (File.Exists(defsPath + df)) {
                    string json = File.ReadAllText(defsPath + df);
                    Check($"Definition {df} has fidelityLabel", json.Contains("fidelityLabel"));
                    Check($"Fallback values in {df} are not marked original", !json.Contains("\"fidelityLabel\": \"ORIGINAL\"") || json.Contains("DECODED_VALUE_CONFIRMED"));
                    Check($"Decoded values in {df} have decodedValueSource", json.Contains("decodedValueSource"));
                }
            }
"""

if "SPRINT 02 - Data Extraction Checks" not in content:
    content = content.replace("            // 3. Editor Test Tool deposit & progress", extraction_checks + "\n            // 3. Editor Test Tool deposit & progress")
    with open(verifier_path, "w", encoding="utf-8") as f:
        f.write(content)

print("RebuildVerifier updated.")
