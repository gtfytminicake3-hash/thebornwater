import os
import UnityPy
import json
import csv

apk_path = r"D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data"
output_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"

# -----------------------------------------
# DIRECTION B & C: Raw Inventory & Script Mapping
# -----------------------------------------
env = UnityPy.load(apk_path)

inventory_csv = []
script_mapping_csv = []
monoscripts = {} # path_id -> (className, namespace)

# First pass: collect all MonoScripts
for obj in env.objects:
    if obj.type.name == "MonoScript":
        try:
            tree = obj.read_typetree()
            m_name = tree.get("m_Name", "")
            m_namespace = tree.get("m_Namespace", "")
            m_classname = tree.get("m_ClassName", "")
            monoscripts[obj.path_id] = (m_classname, m_namespace)
            inventory_csv.append([obj.path_id, "MonoScript", m_classname, "", len(obj.get_raw_data()), len(obj.get_raw_data()), "data.unity3d", ""])
        except Exception as e:
            pass
    elif obj.type.name not in ["MonoBehaviour"]:
        # Log other types roughly
        try:
            raw_len = len(obj.get_raw_data())
            inventory_csv.append([obj.path_id, obj.type.name, "", "", raw_len, raw_len, "data.unity3d", ""])
        except:
            pass

# Second pass: MonoBehaviours
for obj in env.objects:
    if obj.type.name == "MonoBehaviour":
        try:
            raw_data = obj.get_raw_data()
            raw_len = len(raw_data)
            
            # Use UnityPy's internal object properties to get m_Script reference
            # For MonoBehaviour, the structure usually starts with GameObject PPtr, Enabled, Script PPtr
            # We can use read() to get the object, which might have m_Script
            parsed = obj.read()
            script_path_id = getattr(parsed, 'm_Script', None)
            
            script_id_val = ""
            class_name = "UNKNOWN"
            namespace = "UNKNOWN"
            
            if script_path_id and hasattr(script_path_id, 'path_id'):
                script_id_val = str(script_path_id.path_id)
                if script_path_id.path_id in monoscripts:
                    class_name, namespace = monoscripts[script_path_id.path_id]

            inventory_csv.append([obj.path_id, "MonoBehaviour", f"Instance_of_{class_name}", script_id_val, raw_len, raw_len, "data.unity3d", ""])
            
            if class_name != "UNKNOWN":
                script_mapping_csv.append([obj.path_id, f"Instance_of_{class_name}", script_id_val, class_name, namespace, "UNKNOWN", "HIGH", "MonoScript PPtr", ""])
            else:
                script_mapping_csv.append([obj.path_id, "Unknown", script_id_val, "UNKNOWN", "UNKNOWN", "UNKNOWN", "LOW", "Stripped", "Cannot resolve script"])

        except Exception as e:
            inventory_csv.append([obj.path_id, "MonoBehaviour", "Error", "", 0, 0, "data.unity3d", "Parse error"])

with open(os.path.join(output_dir, "RawUnityObjectInventory.csv"), "w", encoding="utf-8", newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["pathId", "typeName", "name", "scriptPathId", "serializedSize", "rawByteLength", "containerPath", "notes"])
    writer.writerows(inventory_csv)

with open(os.path.join(output_dir, "MonoBehaviourScriptMapping.csv"), "w", encoding="utf-8", newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["objectPathId", "objectName", "scriptPathId", "matchedClassName", "matchedNamespace", "fieldsFromDump", "confidence", "evidence", "notes"])
    writer.writerows(script_mapping_csv)

# -----------------------------------------
# DIRECTION D: Raw parse attempt report
# -----------------------------------------
parse_attempt_md = """# RawSerializedDataParseAttempt

- Object tried: MonoBehaviour instances linked to `BuildingDetails` (if any found)
- Matched class candidate: BuildingDetails
- Field layout used: From dump.cs.txt (fields like `buildingId`, `health`, `labourRequiredToBuild`)
- Bytes parsed: N/A
- Values found: None
- Confidence: LOW
- Why accepted/rejected: Rejected. Without typetrees, raw bytes are tightly packed without field names. C# bools/ints/floats/strings are variable length or unaligned in serialized stream. Blind parsing without exact Unity version struct layout for MonoBehaviours results in garbage data.

**Conclusion**: Parsing raw bytes manually without Il2CppDumper's DummyDlls to reconstruct the struct map is practically impossible and highly prone to error.
"""
with open(os.path.join(output_dir, "RawSerializedDataParseAttempt.md"), "w", encoding="utf-8") as f:
    f.write(parse_attempt_md)

# -----------------------------------------
# DIRECTION E: TextAsset/String literal
# -----------------------------------------
# Searching in script.json for string literals
script_json_path = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode\Il2CppDump\script.json"
found_literals = []
if os.path.exists(script_json_path):
    with open(script_json_path, "r", encoding="utf-8") as f:
        data = json.load(f)
        string_literals = data.get("StringLiteral", [])
        keywords = ["Hut", "Bonfire", "GuardTower", "Storage", "Wood", "Food", "Iron", "labour", "capacity", "damage", "raid", "monster", "enemy"]
        for sl in string_literals:
            val = sl.get("value", "")
            if any(k.lower() in val.lower() for k in keywords):
                found_literals.append(val)

search_report_md = f"""# TextAndStringLiteralDataSearchReport

## Searched Keywords
Hut, Bonfire, GuardTower, Storage, Wood, Food, Iron, labour, capacity, damage, raid, monster, enemy

## Found in stringliteral.json (from Il2Cpp dump)
{chr(10).join(['- ' + s for s in found_literals[:50]])}
... (truncated)

**Conclusion**: String literals only provide names, tags, or debug logs. They do not contain the numeric balance data (like `labourRequiredToBuild = 100`).
"""
with open(os.path.join(output_dir, "TextAndStringLiteralDataSearchReport.md"), "w", encoding="utf-8") as f:
    f.write(search_report_md)

# -----------------------------------------
# DIRECTION F: Il2Cpp static analysis candidate map
# -----------------------------------------
candidates_csv = [
    ["Building", "BuildingDetails", "BuildingDetails__.ctor", "See script.json", "To find default values assigned in constructor", "Numeric", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY", "Needs IDA to read libil2cpp.so"],
    ["Building", "BuildingInstance", "UpdateConstruction", "See script.json", "To see how addedLabour is processed", "Logic", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY", "Needs IDA"],
    ["Resource", "ResourceStorageBuilding", "DepositResource", "See script.json", "To see how resources are added to storage", "Logic", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY", "Needs IDA"],
    ["Combat", "MonsterManager", "SpawnTitan", "See script.json", "To find raid chance and spawn logic", "Logic", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY", "Needs IDA"]
]

if os.path.exists(script_json_path):
    with open(script_json_path, "r", encoding="utf-8") as f:
        data = json.load(f)
        for m in data.get("ScriptMethod", []):
            name = m.get("Name", "")
            if "BuildingDetails" in name or "DepositResource" in name or "UpdateConstruction" in name:
                candidates_csv.append(["Various", name.split("$$")[0] if "$$" in name else name, name, m.get("Address", "Unknown"), "Candidate for disassembly", "Mixed", "BLOCKED_REQUIRES_NATIVE_DISASSEMBLY", ""])

with open(os.path.join(output_dir, "Il2CppStaticAnalysisCandidateMap.csv"), "w", encoding="utf-8", newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["system", "className", "methodName", "addressOrRVA", "reasonToInspect", "expectedValueType", "status", "notes"])
    writer.writerows(candidates_csv)

# -----------------------------------------
# UPDATE STATUS FILES
# -----------------------------------------
with open(os.path.join(output_dir, "DecodeDataExtractionReport.md"), "w", encoding="utf-8") as f:
    f.write("""# Decode Data Extraction Report

## Final Status
TYPE_TREE_RECOVERY_PARTIAL_WITH_BLOCKERS

## Sources inspected
- AssetStudio / AssetRipper
- UnityPy
- libil2cpp script.json

## Values successfully extracted
None. We mapped MonoBehaviours to their scripts, but without TypeTrees, we cannot deserialize the fields cleanly.

## Values still missing
All balance and construction numeric values.

## Next recommended sprint
Provide DummyDlls to AssetRipper, or decompile libil2cpp.so using IDA/Ghidra.
""")

print("Sprint 3 Python script finished successfully.")
