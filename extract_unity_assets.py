import os
import sys

try:
    import UnityPy
except ImportError:
    print("UnityPy is not installed. Please run: pip install UnityPy")
    sys.exit(1)

input_file = r"D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\data.unity3d"
output_dir = r"D:\Tinh\TheBonwater\Assets\_Project\ImportedDecoded"

if not os.path.exists(input_file):
    print(f"Error: Input file not found at {input_file}")
    sys.exit(1)

os.makedirs(output_dir, exist_ok=True)
print(f"Loading {input_file}...")
env = UnityPy.load(input_file)

extracted_count = 0
for obj in env.objects:
    if obj.type.name in ["Texture2D", "Sprite", "TextAsset", "Font"]:
        try:
            data = obj.read()
            name = getattr(data, "name", None)
            if not name:
                name = getattr(data, "m_Name", f"unnamed_{obj.path_id}")
            
            dest = os.path.join(output_dir, obj.type.name, name)
            os.makedirs(os.path.dirname(dest), exist_ok=True)
            
            if obj.type.name in ["Texture2D", "Sprite"]:
                dest += ".png"
                data.image.save(dest)
            elif obj.type.name == "TextAsset":
                dest += ".txt"
                with open(dest, "wb") as f: f.write(data.script)
            extracted_count += 1
        except Exception as e:
            # print(f"Failed to extract object {obj.path_id}: {e}")
            pass

print(f"Extraction complete! Extracted {extracted_count} assets to {output_dir}")

# Update Asset Manifest
manifest_content = "asset_id,source_path,type,category,import_status,used_in_scene,replacement_strategy,note\n"
for root, dirs, files in os.walk(output_dir):
    for f in files:
        if f.endswith(".png") or f.endswith(".txt"):
            asset_type = os.path.basename(root)
            asset_id = f.replace(".png","").replace(".txt","")
            manifest_content += f"{asset_id},{input_file},{asset_type},Decoded,EXTRACTED,TownScene,UseReal,\n"

with open(r"D:\Tinh\TheBonwater\Assets\_Project\Docs\DecodeAnalysis\UnityPyExtractManifest.csv", "w", encoding="utf-8") as f:
    f.write(manifest_content)
