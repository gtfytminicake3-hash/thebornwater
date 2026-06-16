import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\OriginalFidelity"

# 1. Create DecodedDataExtractionInventory.csv
inventory_content = """system,recordId,fieldName,decodedValue,sourceAssetPath,sourceClassOrType,sourceField,evidenceText,confidence,fidelityLabel,notes
Building,hut,labourRequiredToBuild,UNKNOWN,data.unity3d,BuildingDetails,labourRequiredToBuild,field exists in dump but serialized value stripped,LOW,MISSING_FROM_CURRENT_DECODE,UnityPy read_typetree failed due to stripped typetrees
Building,hut,requiredResources,UNKNOWN,data.unity3d,BuildingDetails,resourceRequired,field exists in dump but serialized value stripped,LOW,MISSING_FROM_CURRENT_DECODE,UnityPy read_typetree failed
Building,bonfire,finalCompletion,UNKNOWN,data.unity3d,BuildingDetails,finalCompletion,field exists in dump but serialized value stripped,LOW,MISSING_FROM_CURRENT_DECODE,UnityPy read_typetree failed
Resource,wood,capacity,UNKNOWN,data.unity3d,ResourceData,capacity,field exists in dump but serialized value stripped,LOW,MISSING_FROM_CURRENT_DECODE,UnityPy read_typetree failed
Job,woodcutter,productionPerPhase,UNKNOWN,data.unity3d,JobData,productionPerPhase,field exists in dump but serialized value stripped,LOW,MISSING_FROM_CURRENT_DECODE,UnityPy read_typetree failed
Combat,enemy,health,UNKNOWN,data.unity3d,Enemy,health,field exists in dump but serialized value stripped,LOW,MISSING_FROM_CURRENT_DECODE,UnityPy read_typetree failed
"""
with open(os.path.join(base_dir, "DecodedDataExtractionInventory.csv"), "w", encoding="utf-8") as f:
    f.write(inventory_content)

# 2. Create DecodeDataExtractionReport.md
report_content = """# Decode Data Extraction Report

## Final Status
DECODE_DATA_EXTRACTION_NEEDS_FIX

## Sources inspected
- Assets/_Project/Docs/BackendDecode/Il2CppDump/dump.cs.txt
- Assets/_Project/Docs/BackendDecode/Il2CppDump/script.json
- D:\\Tinh\\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\\resources\\com.xigmaGames.thebonfire2.apk\\assets\\bin\\Data\\data.unity3d (via UnityPy)

## Values successfully extracted
None.

## Values still missing
All serialized numerical data.

## Building data
- cost: UNKNOWN (MISSING_FROM_CURRENT_DECODE)
- labourRequiredToBuild: UNKNOWN (MISSING_FROM_CURRENT_DECODE)

## Resource data
- capacity: UNKNOWN (MISSING_FROM_CURRENT_DECODE)

## Job data
- production numbers: UNKNOWN (MISSING_FROM_CURRENT_DECODE)

## Construction data
- finalCompletion: UNKNOWN (MISSING_FROM_CURRENT_DECODE)
- addedLabour per tick: UNKNOWN (MISSING_FROM_CURRENT_DECODE)

## Combat/Raid data
- enemy hp/damage: UNKNOWN (MISSING_FROM_CURRENT_DECODE)
- raid chance: UNKNOWN (MISSING_FROM_CURRENT_DECODE)

## Save/Load data
- original schema: UNKNOWN (MISSING_FROM_CURRENT_DECODE)

## Definitions updated
None (no new decoded values found).

## Definitions not updated because evidence is missing
All definitions (buildings.json, resources.json, jobs.json, balance.json, enemies.json) retain their PROTOTYPE_FALLBACK labels.

## Risks
Cannot reconstruct faithful gameplay balance or exact construction ticks without these numbers. 
UnityPy `read_typetree()` fails because IL2CPP games strip type trees.

## Next recommended sprint
Provide a TypeTree generated from Il2CppDumper to UnityPy, or reverse-engineer the constructor functions in IDA Pro/Ghidra to find default balance values if they are hardcoded.
"""
with open(os.path.join(base_dir, "DecodeDataExtractionReport.md"), "w", encoding="utf-8") as f:
    f.write(report_content)

# 3. Update MissingDecodeEvidenceList.md
missing_content = """# Missing Decode Evidence
- finalCompletion per building
- labourRequiredToBuild per building
- addedLabour per builder/action
- building cost/resource requirements
- job production numbers
- resource capacity values
- raid chance/damage/defense
- AIAgent exact deposit sequence
- original job UI flow
- original save schema
"""
with open(os.path.join(base_dir, "MissingDecodeEvidenceList.md"), "w", encoding="utf-8") as f:
    f.write(missing_content)

# 4. Update Definition files to ensure they strictly separate labels (they already do mostly, but let's re-verify)
import json

def update_def_file(filename):
    path = os.path.join(r"D:\Tinh\TheBonwater\Assets\_Project\Data\Definitions", filename)
    if not os.path.exists(path): return
    with open(path, "r", encoding="utf-8") as f:
        data = json.load(f)
    
    # Just ensure fidelity is explicitly PROTOTYPE_FALLBACK if not already
    changed = False
    if isinstance(data, list):
        items = data
    else:
        items = [data]
        
    for item in items:
        if "fidelity" in item and item["fidelity"] != "PROTOTYPE_FALLBACK" and item["fidelity"] != "DECODE_EVIDENCE_PARTIAL":
            item["fidelity"] = "PROTOTYPE_FALLBACK"
            changed = True
            
        # Ensure new fields requested by user are present conceptually
        item["decodedValueSource"] = "UNKNOWN"
        item["fidelityLabel"] = item.get("fidelity", "PROTOTYPE_FALLBACK")
        changed = True

    if changed:
        with open(path, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=4)

for f in ["buildings.json", "resources.json", "jobs.json", "tasks.json", "enemies.json", "balance.json"]:
    update_def_file(f)

print("Data extraction sprint documentation generated.")
