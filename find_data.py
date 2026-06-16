import os
import csv

search_dir = r"D:\Tinh\TheBonwater\Assets\_Project\ImportedDecoded"
out_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\BackendDecode"

keywords = ["wood", "food", "iron", "coal", "hut", "house", "bonfire", "villager", "worker", "job", "profession", "recipe", "craft", "build", "cost", "health", "hunger", "raid", "enemy", "day", "night", "save", "config", "data", "balance"]

inventory = []

for root, dirs, files in os.walk(search_dir):
    for f in files:
        if f.endswith(('.json', '.xml', '.csv', '.txt')):
            f_lower = f.lower()
            match = None
            for kw in keywords:
                if kw in f_lower:
                    match = kw
                    break
            
            if match or True: # Actually let's just inventory all text assets that look like data
                full_path = os.path.join(root, f)
                # Try to peek into file
                peek = ""
                try:
                    with open(full_path, 'r', encoding='utf-8') as file:
                        peek = file.read(100).replace('\n', ' ')
                except:
                    pass
                
                inventory.append({
                    "file_name": f,
                    "path": full_path.replace(r"D:\Tinh\TheBonwater\\", ""),
                    "type": os.path.splitext(f)[1],
                    "matched_keyword": match if match else "None",
                    "preview": peek
                })

os.makedirs(out_dir, exist_ok=True)
with open(os.path.join(out_dir, "DecodedGameplayDataInventory.csv"), 'w', newline='', encoding='utf-8') as f:
    writer = csv.DictWriter(f, fieldnames=["file_name", "path", "type", "matched_keyword", "preview"])
    writer.writeheader()
    writer.writerows(inventory)

print(f"Inventoried {len(inventory)} gameplay data files.")
