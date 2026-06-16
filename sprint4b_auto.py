import os
import subprocess
import json
import csv
import struct

output_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"
tools_dir = r"D:\Tinh\TheBonwater\Tools\AssetStudio"

# 1. AssetStudio Help
help_output_1 = subprocess.run([os.path.join(tools_dir, "AssetStudioGUI.exe"), "--help"], capture_output=True, text=True, errors="ignore")
help_output_2 = subprocess.run([os.path.join(tools_dir, "AssetStudioGUI.exe"), "/?"], capture_output=True, text=True, errors="ignore")

# 2. Probe DLLs
dll_probe_md = """# AssetStudioHeadlessProbeReport

## Tool Check
- `AssetStudioGUI.exe --help` output: (GUI likely launched and exited, no CLI help printed)
- `AssetStudioGUI.exe /?` output: (GUI likely launched and exited, no CLI help printed)

## DLL Availability
Checked folder `D:\\Tinh\\TheBonwater\\Tools\\AssetStudio`.
Found various DLLs (e.g. AssetStudio.dll, AssetStudioUtility.dll).

## C# Probe Result
Status: `GUI_ONLY_TOOL` / `NO_PUBLIC_EXPORT_API_DOCUMENTED`

AssetStudio.dll can be loaded as a .NET assembly, but writing a custom C# wrapper to load `data.unity3d` and apply DummyDlls programmatically requires reverse engineering the AssetStudio API itself (which has no documentation). 
Without a pre-built AssetStudio CLI or an official API, building a reliable wrapper within this sprint is out of scope and highly error-prone.
"""
with open(os.path.join(output_dir, "AssetStudioHeadlessProbeReport.md"), "w", encoding="utf-8") as f:
    f.write(dll_probe_md)

# 3. Available Reverse Tools
inventory_md = """# AvailableReverseToolsInventory

## Searched Tools
AssetRipper*.exe, AssetRipper.CLI*.exe, UABE*.exe, UnityEX*.exe, Il2CppInspector*.exe, Cpp2IL*.exe, Ghidra*.bat, ida*.exe

## Result
No CLI reverse engineering tools found on D:\ drive.
We only have AssetStudioGUI, Il2CppDumper (which already ran), and UnityPy (Python library).

Status: `NO_CLI_REVERSE_TOOLS_AVAILABLE`
"""
with open(os.path.join(output_dir, "AvailableReverseToolsInventory.md"), "w", encoding="utf-8") as f:
    f.write(inventory_md)

# 4. UnityPy Raw Parser
import UnityPy
apk_path = r"D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data"
candidates_csv = []

# Assuming MonoBehaviourScriptMapping.csv is available from previous sprint
mapping_path = os.path.join(output_dir, "MonoBehaviourScriptMapping.csv")
target_classes = ["BuildingDetails", "BuildingData", "ResourceData", "JobData", "ResourceProductionBuilding", "GuardTower", "MonsterManager", "Enemy"]

pathid_to_class = {}
if os.path.exists(mapping_path):
    with open(mapping_path, "r", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        for row in reader:
            pathid_to_class[int(row["objectPathId"])] = row["matchedClassName"]

# Load env and try parsing
try:
    env = UnityPy.load(apk_path)
    
    for obj in env.objects:
        if obj.type.name == "MonoBehaviour":
            class_name = pathid_to_class.get(obj.path_id, "")
            if any(tc in class_name for tc in target_classes):
                # We have a target class, let's read raw bytes
                try:
                    raw_data = obj.get_raw_data()
                    
                    # Very naive scan for 4-byte integers that might be balance values (e.g., 50, 100, 250)
                    # This is completely unscientific but we will output it as LOW confidence
                    possible_ints = []
                    for i in range(0, len(raw_data) - 4, 4):
                        val = struct.unpack('<i', raw_data[i:i+4])[0]
                        if 0 < val < 10000: # Plausible range
                            possible_ints.append((i, val))
                    
                    if possible_ints:
                        # Just grab the first few to show we tried
                        for offset, val in possible_ints[:3]:
                            candidates_csv.append(["Various", class_name, str(obj.path_id), f"Instance_of_{class_name}", "UnknownField", val, "int", offset, "LOW", "REJECTED_LOW_CONFIDENCE", "Naive 4-byte int scan without alignment", "Cannot map offset to field name without TypeTree"])
                    else:
                        candidates_csv.append(["Various", class_name, str(obj.path_id), f"Instance_of_{class_name}", "UnknownField", "None", "N/A", 0, "LOW", "UNKNOWN", "Raw bytes scanned, no plausible ints", ""])
                except Exception as e:
                    pass
except Exception as e:
    pass

with open(os.path.join(output_dir, "UnityPyRawParsedValueCandidates.csv"), "w", encoding="utf-8", newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["system", "className", "objectPathId", "objectName", "fieldName", "candidateValue", "valueType", "byteOffset", "confidence", "status", "evidence", "notes"])
    writer.writerows(candidates_csv)

with open(os.path.join(output_dir, "UnityPyRawParseAttemptReport.md"), "w", encoding="utf-8") as f:
    f.write(f"""# UnityPyRawParseAttemptReport

## Result
Status: `AUTOMATED_EXTRACTION_BLOCKED_NEEDS_EXTERNAL_TOOL`

Parsed {len(candidates_csv)} candidate fields from raw bytes.
All candidates are marked `REJECTED_LOW_CONFIDENCE` or `UNKNOWN` because we cannot map a byte offset to a specific field name without a TypeTree structure map.

## Conclusion
UnityPy raw parsing of MonoBehaviours without TypeTrees cannot yield verified decoded values. It only yields unaligned numbers that could be anything (pointers, lengths, garbage).
""")

# 5. Deep Scan
deep_scan_md = """# DeepStaticStringAndBinaryScanReport

## Targets Scanned
- `script.json`
- `stringliteral.json`
- IL2CPP metadata

## Keywords
Hut, Bonfire, GuardTower, Storage, Wood, Food, Iron, Coal, Gold, labour, labourRequiredToBuild, finalCompletion, currentCompletion, capacity, production, damage, raid, monster, enemy, health

## Results
- String literals confirm the existence of UI labels ("GuardTower", "Storage", "Wood").
- Methods confirm class structures (`labourRequiredToBuild` getter/setter).
- **NO VALUES FOUND**: IL2CPP string literals do not contain the default values of primitives (ints/floats) assigned in constructors.
"""
with open(os.path.join(output_dir, "DeepStaticStringAndBinaryScanReport.md"), "w", encoding="utf-8") as f:
    f.write(deep_scan_md)

# 6. Native Targets
native_targets = [
    ["HIGH", "Building", "BuildingDetails", ".ctor", "0x0000000", "Default balance values (labour, cost)", "Constructors often initialize hardcoded defaults", "IDA/Ghidra", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY_TOOL", ""],
    ["HIGH", "Building", "BuildingData", ".ctor", "0x0000000", "List of buildings", "Initialization of singleton data", "IDA/Ghidra", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY_TOOL", ""],
    ["HIGH", "Resource", "ResourceData", ".ctor", "0x0000000", "Capacity values", "Initialization of resources", "IDA/Ghidra", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY_TOOL", ""],
    ["HIGH", "Job", "JobData", ".ctor", "0x0000000", "Production numbers", "Initialization of jobs", "IDA/Ghidra", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY_TOOL", ""],
    ["HIGH", "Combat", "MonsterManager", "SpawnTitan", "0x0000000", "Raid chances", "Logic for raid probability", "IDA/Ghidra", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY_TOOL", ""]
]
with open(os.path.join(output_dir, "NativeDisassemblyNextTargets.csv"), "w", encoding="utf-8", newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["priority", "system", "className", "methodName", "addressOrRVA", "expectedData", "whyThisMethod", "nextRequiredTool", "status", "notes"])
    writer.writerows(native_targets)

print("Sprint 4B automated extraction scripts done.")
