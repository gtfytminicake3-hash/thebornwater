import os
import json

dump_file = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\DecodeAnalysis\Il2CppDump\script.json"
if not os.path.exists(dump_file):
    print(f"Error: {dump_file} not found. Please run run_il2cpp_dump.bat first.")
    exit(1)

print(f"Analyzing {dump_file}...")
with open(dump_file, "r", encoding="utf-8") as f:
    data = json.load(f)

# Sample analysis to find systems
systems = ["Resource", "Building", "Villager", "Task", "Time", "Save"]
found_classes = {}

for cls in data.get("ScriptMethod", []):
    name = cls.get("Name", "")
    for sys in systems:
        if sys in name:
            found_classes[name] = sys

print(f"Found {len(found_classes)} interesting classes:")
for k, v in found_classes.items():
    print(f" - {k} (Probable system: {v})")

print("Analysis complete. Update BackendLogicMap.csv with these findings.")
