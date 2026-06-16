import UnityPy
import os
import json

apk_path = r"D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data"
output_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\DecodeAnalysis\ExtractedData"

if not os.path.exists(output_dir):
    os.makedirs(output_dir)

def dump_monobehaviours():
    try:
        env = UnityPy.load(apk_path)
    except Exception as e:
        print(f"Error loading UnityPy: {e}")
        return

    extracted_data = []

    for obj in env.objects:
        if obj.type.name == "MonoBehaviour":
            try:
                tree = obj.read_typetree()
                if "m_Name" in tree:
                    name = tree["m_Name"]
                    if any(x in name.lower() for x in ["building", "resource", "job", "enemy", "balance", "hut", "guard", "bonfire", "storage"]):
                        # Check if it looks like building details
                        if "labourRequiredToBuild" in tree or "requiredResources" in tree or "capacity" in tree:
                            extracted_data.append(tree)
            except Exception as e:
                pass

    with open(os.path.join(output_dir, "ExtractedMonoBehaviours.json"), "w", encoding="utf-8") as f:
        json.dump(extracted_data, f, indent=4)
        
    print(f"Extracted {len(extracted_data)} MonoBehaviours of interest.")

dump_monobehaviours()
