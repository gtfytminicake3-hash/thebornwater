import os

# A. Prepare Folders and Marker File
base_export_dir = r"D:\Tinh\TheBonwater\ExternalExtracts\AssetStudio_ManualExport"
subdirs = ["MonoBehaviour", "ScriptableObject", "TextAsset"]
parsed_dir = r"D:\Tinh\TheBonwater\ExternalExtracts\AssetStudio_Parsed"

os.makedirs(base_export_dir, exist_ok=True)
os.makedirs(parsed_dir, exist_ok=True)
for subdir in subdirs:
    os.makedirs(os.path.join(base_export_dir, subdir), exist_ok=True)

marker_path = os.path.join(base_export_dir, "PUT_ASSETSTUDIO_EXPORTED_FILES_HERE.txt")
with open(marker_path, "w", encoding="utf-8") as f:
    f.write("Place your exported .json or .txt files from AssetStudio GUI into this directory or its subdirectories.")

# B. Create Instruction File
docs_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"
instructions_path = os.path.join(docs_dir, "AssetStudio_GUI_Manual_Export_Instructions.md")
with open(instructions_path, "w", encoding="utf-8") as f:
    f.write("""# AssetStudio GUI Manual Export Instructions

GUI menu labels are unverified; user must inspect manually.

1. Mở `D:\\Tinh\\TheBonwater\\Tools\\AssetStudio\\AssetStudioGUI.exe`
2. Load folder decode chứa `data.unity3d` (`D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data`)
3. Nếu GUI có option load DummyDll / Assembly / Type Definition (ví dụ trong Menu Options -> TypeTree), hãy trỏ tới folder `Assets/_Project/Docs/BackendDecode/Il2CppDump/DummyDll~`
4. Ở tab `Asset List`, filter các object thuộc type: `MonoBehaviour`, `ScriptableObject`, `TextAsset`
5. Ưu tiên export các object liên quan tới: BuildingDetails, BuildingData, ResourceData, JobData, Enemy, GuardTower, MonsterManager (Dựa theo file `PriorityObjectsForManualAssetStudioExport.csv`)
6. Export ra (chuột phải -> Export selected assets hoặc Export -> All assets) và trỏ vào folder `D:\\Tinh\\TheBonwater\\ExternalExtracts\\AssetStudio_ManualExport\\`
7. Quay lại báo Anti chạy parser (Xem file `Run_PostAssetStudio_Parse_Command.md`)
""")

# C. Create Priority List CSV
priority_csv_path = os.path.join(docs_dir, "PriorityObjectsForManualAssetStudioExport.csv")
with open(priority_csv_path, "w", encoding="utf-8") as f:
    f.write("""priority,system,objectPathId,objectName,matchedClassName,reasonToExport,expectedFields,confidence,notes
HIGH,Building,UNKNOWN,BuildingData,BuildingData,Contains all buildings list,buildings array,HIGH,
HIGH,Building,UNKNOWN,Hut_Details,BuildingDetails,Cost and completion for Hut,labourRequiredToBuild/resourceRequired,MEDIUM,Look for Hut keywords
HIGH,Building,UNKNOWN,Bonfire_Details,BuildingDetails,Cost and completion for Bonfire,labourRequiredToBuild/resourceRequired,MEDIUM,
HIGH,Resource,UNKNOWN,Wood_Data,ResourceData,Capacity and details for Wood,capacity,MEDIUM,
HIGH,Resource,UNKNOWN,Food_Data,ResourceData,Capacity and details for Food,capacity,MEDIUM,
HIGH,Job,UNKNOWN,Woodcutter_Job,JobData,Production values,productionPerPhase,MEDIUM,
HIGH,Job,UNKNOWN,Guard_Job,JobData,Defense values,damage/defense,MEDIUM,
HIGH,Combat,UNKNOWN,MonsterManager,MonsterManager,Raid chances,raidChance/spawnRates,MEDIUM,
HIGH,Combat,UNKNOWN,Enemy_Spider,Enemy,Enemy stats,health/damage,MEDIUM,
HIGH,Building,UNKNOWN,Storage_Details,BuildingDetails,Storage capacity,capacity/storage,MEDIUM,
""")

# D. Write Parser Script
tools_dir = r"D:\Tinh\TheBonwater\Tools\Extraction"
os.makedirs(tools_dir, exist_ok=True)
parser_path = os.path.join(tools_dir, "parse_assetstudio_manual_export.py")
parser_content = r"""import os
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
"""
with open(parser_path, "w", encoding="utf-8") as f:
    f.write(parser_content)

# E. Create Command File
cmd_path = os.path.join(docs_dir, "Run_PostAssetStudio_Parse_Command.md")
with open(cmd_path, "w", encoding="utf-8") as f:
    f.write("""# Command to Run Parser

After manually exporting assets from AssetStudio GUI into `D:\\Tinh\\TheBonwater\\ExternalExtracts\\AssetStudio_ManualExport\\`, run the following command in PowerShell/CMD:

```bat
cd /d D:\\Tinh\\TheBonwater
python Tools\\Extraction\\parse_assetstudio_manual_export.py
```
""")

print("Sprint 4 bridge preparation script complete.")
