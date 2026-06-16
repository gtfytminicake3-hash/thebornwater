import os
import json

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Data\Definitions"
os.makedirs(base_dir, exist_ok=True)

def update_definition_file(filename, update_fn):
    full_path = os.path.join(base_dir, filename)
    if not os.path.exists(full_path):
        return
    with open(full_path, "r", encoding="utf-8") as f:
        data = json.load(f)
    if isinstance(data, list):
        for item in data:
            update_fn(item)
    elif isinstance(data, dict):
        for k, v in data.items():
            if isinstance(v, dict):
                update_fn(v)
            elif isinstance(v, list):
                for item in v:
                    update_fn(item)
    with open(full_path, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=2)

def transform_evidence(item):
    if "evidence" in item:
        # Save old evidence as symbolEvidence
        item["symbolEvidence"] = item.pop("evidence")
        item["behaviorEvidence"] = "UNKNOWN"
        item["balanceEvidence"] = "PROTOTYPE_FALLBACK"

    # Also fix confidence to reflect multiple layers
    if "confidence" in item:
        if item["confidence"] == "HIGH":
            item["confidence"] = "PARTIAL" # Since balance is fallback, overall is PARTIAL
            
update_definition_file("jobs.json", transform_evidence)
update_definition_file("buildings.json", transform_evidence)
update_definition_file("resources.json", transform_evidence)
update_definition_file("enemies.json", transform_evidence)
update_definition_file("balance.json", transform_evidence)
update_definition_file("objectives.json", transform_evidence)
update_definition_file("tasks.json", transform_evidence)

print("Data definitions updated with separated evidence fields.")
