import json
import os

filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Data\Definitions\buildings.json"

with open(filepath, "r", encoding="utf-8") as f:
    data = json.load(f)

for item in data:
    if item["id"] in ["Hut", "Storage", "GuardTower"]:
        item["behaviorEvidence"] = "BuildingInstance.currentCompletion/finalCompletion, DepositResource, UpdateConstruction"
        item["balanceEvidence"] = "UNKNOWN or decoded source if found"
        item["fidelity"] = "DECODE_EVIDENCE_PARTIAL"

with open(filepath, "w", encoding="utf-8") as f:
    json.dump(data, f, indent=2)

print("buildings.json updated")
