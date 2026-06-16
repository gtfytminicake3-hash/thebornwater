import os
import json
import csv

export_dir = r"D:\Tinh\TheBonwater\ExternalExtracts\AssetStudio_ManualExport"
output_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"

inventory = []
candidates = []
report = []

keywords = ["Hut", "Bonfire", "GuardTower", "Wood", "Food", "Iron", "labour", "capacity", "damage", "raid", "enemy", "monster"]

def scan_files():
    found_files = []
    for root, _, files in os.walk(export_dir):
        for f in files:
            if f.endswith((".json", ".txt", ".yaml", ".asset", ".bytes")):
                found_files.append(os.path.join(root, f))
    return found_files

def parse_file(path):
    try:
        with open(path, "r", encoding="utf-8", errors="ignore") as f:
            content = f.read()
    except Exception as e:
        return
        
    filename = os.path.basename(path)
    # Naive JSON parsing for now if it's a JSON
    if path.endswith(".json"):
        try:
            data = json.loads(content)
            inventory.append([filename, "JSON", len(content), "Parsed successfully"])
            
            # recursive search for keys
            def search_dict(d, path_str):
                if isinstance(d, dict):
                    for k, v in d.items():
                        if any(kw.lower() in str(k).lower() for kw in keywords) or any(kw.lower() in str(v).lower() for kw in keywords):
                            if isinstance(v, (int, float, str)):
                                candidates.append(["UNKNOWN", "UNKNOWN", filename, k, v, type(v).__name__, filename, str(v), "LOW", "DECODED_VALUE_CANDIDATE", "Auto-extracted"])
                        search_dict(v, path_str + "." + k)
                elif isinstance(d, list):
                    for i, v in enumerate(d):
                        search_dict(v, path_str + f"[{i}]")
                        
            search_dict(data, "")
        except:
            inventory.append([filename, "JSON", len(content), "Parse failed"])
    else:
        # Just text scan
        inventory.append([filename, "TEXT", len(content), "Scanned as text"])
        for line in content.splitlines():
            if any(kw.lower() in line.lower() for kw in keywords):
                # We can't extract structured data easily from raw text without context, so we just log it as UNKNOWN
                pass

files = scan_files()
if not files or (len(files) == 1 and files[0].endswith("PUT_ASSETSTUDIO_EXPORTED_FILES_HERE.txt")):
    with open(os.path.join(output_dir, "AssetStudioPostExportParseReport.md"), "w", encoding="utf-8") as f:
        f.write("# AssetStudio Post-Export Parse Report\n\nStatus: WAITING_FOR_MANUAL_ASSETSTUDIO_EXPORT\n\nNo exported files found in the export directory.")
    print("WAITING_FOR_MANUAL_ASSETSTUDIO_EXPORT")
else:
    for f in files:
        if not f.endswith("PUT_ASSETSTUDIO_EXPORTED_FILES_HERE.txt"):
            parse_file(f)
            
    with open(os.path.join(output_dir, "AssetStudioExportInventory.csv"), "w", encoding="utf-8", newline="") as f:
        w = csv.writer(f)
        w.writerow(["fileName", "format", "size", "status"])
        w.writerows(inventory)
        
    with open(os.path.join(output_dir, "AssetStudioDecodedValueCandidates.csv"), "w", encoding="utf-8", newline="") as f:
        w = csv.writer(f)
        w.writerow(["system", "className", "objectName", "fieldName", "value", "valueType", "sourceFile", "evidenceText", "confidence", "status", "notes"])
        w.writerows(candidates)
        
    with open(os.path.join(output_dir, "AssetStudioPostExportParseReport.md"), "w", encoding="utf-8") as f:
        f.write(f"# AssetStudio Post-Export Parse Report\n\nStatus: PARSED\n\nTotal files parsed: {len(files)-1}\nCandidates extracted: {len(candidates)}")
        
    print(f"Parsed {len(files)-1} files.")
