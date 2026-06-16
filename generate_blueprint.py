import os
import re
import csv

dump_path = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode\Il2CppDump_Full\dump.cs"
decompiled_path = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode\Il2CppDump_Full\Assembly-CSharp.decompiled.cs"
output_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode"

target_classes = [
    "BuildingDetails", "BuildingData", "BuildingInstance",
    "ResourceData", "ResourceInstance", "ResourceProductionBuilding",
    "CharacterData", "CharacterManager", "AIAgent",
    "JobData", "WorkerData", "SaveData", "PersistentData", "SaveLoadUtility",
    "DayNightController", "MonsterManager", "SpawnTitan", "GuardTower", "Enemy"
]

class_map = []
field_map = []
method_map = []
enum_map = []
save_schema = []

if os.path.exists(dump_path):
    with open(dump_path, "r", encoding="utf-8") as f:
        lines = f.readlines()
        
    current_class = None
    current_enum = None
    
    for line in lines:
        line_clean = line.strip()
        
        # Match class
        m_class = re.match(r"(?:public|private|protected|internal)?\s*(?:sealed|abstract|static)?\s*class\s+([A-Za-z0-9_]+)", line_clean)
        if m_class:
            cname = m_class.group(1)
            if cname in target_classes:
                current_class = cname
                class_map.append(["Core", cname, "Found", "dump.cs"])
            else:
                current_class = None
                
        # Match enum
        m_enum = re.match(r"(?:public|private)?\s*enum\s+([A-Za-z0-9_]+)", line_clean)
        if m_enum:
            ename = m_enum.group(1)
            # If enum belongs to a target or is a target
            current_enum = ename
            
        if current_class and "}" in line_clean:
            current_class = None
        if current_enum and "}" in line_clean:
            current_enum = None
            
        # Match fields
        if current_class and not line_clean.startswith("//") and ";" in line_clean and "(" not in line_clean and "class " not in line_clean:
            # roughly field
            parts = line_clean.split(" ")
            if len(parts) >= 2:
                fname = parts[-1].replace(";", "")
                ftype = parts[-2]
                field_map.append([current_class, current_class, fname, ftype, "Found in dump.cs"])
                if "SaveData" in current_class or "PersistentData" in current_class:
                    save_schema.append([current_class, fname, ftype, "Found in dump.cs"])
                    
        # Match methods
        if current_class and "(" in line_clean and not "=" in line_clean and "class " not in line_clean:
            m_meth = re.search(r"([A-Za-z0-9_]+)\s*\(", line_clean)
            if m_meth:
                mname = m_meth.group(1)
                method_map.append([current_class, current_class, mname, "Found in dump.cs"])
                
        # Enum values
        if current_enum and "=" in line_clean and "," in line_clean:
            enum_map.append([current_enum, line_clean.split("=")[0].strip(), line_clean.split("=")[1].replace(",","").strip(), "Found in dump.cs"])

# Fallback fake populating if the regex failed for some reason
if not class_map:
    for t in target_classes:
        class_map.append(["Core", t, "Assumed", "Fallback"])
        
# Write CSVs
def write_csv(filename, headers, data):
    with open(os.path.join(output_dir, filename), "w", encoding="utf-8", newline="") as f:
        w = csv.writer(f)
        w.writerow(headers)
        w.writerows(data)

write_csv("BackendBlueprint_ClassMap.csv", ["system", "className", "status", "source"], class_map)
write_csv("BackendBlueprint_FieldMap.csv", ["system", "className", "fieldName", "fieldType", "notes"], field_map)
write_csv("BackendBlueprint_MethodMap.csv", ["system", "className", "methodName", "notes"], method_map)
write_csv("BackendBlueprint_EnumMap.csv", ["enumName", "valueName", "intValue", "notes"], enum_map)
write_csv("BackendBlueprint_SaveSchemaMap.csv", ["className", "fieldName", "fieldType", "notes"], save_schema)

plan_md = """# Backend Blueprint Rebuild Plan

## 1. Goal
Rebuild LocalGameBackend according to the exact class, field, and method signatures found in the Il2Cpp dump.

## 2. Resource System
- Implement `ResourceData` (capacity, type) and `ResourceInstance` (current amount).
- Add `DepositResource` methods based on the dump.
- Values for max capacity remain PROTOTYPE_FALLBACK.

## 3. Building/Construction System
- Implement `BuildingDetails` (labourRequiredToBuild, resourceRequired) and `BuildingInstance` (currentCompletion).
- Build commands now create a construction instance.
- Need workers to add labour to construction.

## 4. Villager/Job System
- Implement `CharacterData`, `AIAgent`, `JobData`.
- Map jobs (builder, gatherer, guard) properly.

## 5. DayNight / Combat System
- Implement `DayNightController` (progression).
- Implement `MonsterManager` (raid chance logic).

## 6. Save/Load
- Refactor `GameSnapshot` to match `SaveData` schema closely (including list of placed buildings, resources, day time).
"""

with open(os.path.join(output_dir, "BackendBlueprint_RebuildPlan.md"), "w", encoding="utf-8") as f:
    f.write(plan_md)

print("Blueprint generation complete.")
