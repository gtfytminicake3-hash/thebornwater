import os
import re

metadata_path = r"D:\Tinh\The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com\resources\com.xigmaGames.thebonfire2.apk\assets\bin\Data\Managed\Metadata\global-metadata.dat"
output_csv = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\DecodeAnalysis\MetadataStrings.csv"
output_md = r"D:\Tinh\TheBonwater\Assets\_Project\Docs\DecodeAnalysis\KeywordHits.md"

keywords = ["Resource", "Resources", "Building", "Build", "Villager", "Worker", "Task", "Job", 
            "Time", "Day", "Night", "Save", "Load", "Inventory", "Item", "Food", "Wood", "Coal", 
            "Iron", "Gold", "Enemy", "Combat", "Raid", "Explore", "Expedition", "Map", "Scene", 
            "Menu", "Audio", "FMOD", "IAP", "Ad", "Firebase"]

# Read binary file and extract strings (ASCII >= 4 chars)
print(f"Reading {metadata_path}...")
with open(metadata_path, "rb") as f:
    data = f.read()

strings = re.findall(b"[A-Za-z0-9_]{4,}", data)
strings = set(s.decode("ascii") for s in strings)

hits = {k: [] for k in keywords}
for s in strings:
    for k in keywords:
        if k.lower() in s.lower():
            hits[k].append(s)

with open(output_csv, "w", encoding="utf-8") as f:
    f.write("keyword,matched_string,probable_system\n")
    for k, matches in hits.items():
        for m in list(set(matches))[:20]: # Limit to 20 matches per keyword to avoid bloat
            f.write(f"{k},{m},{k}System\n")

with open(output_md, "w", encoding="utf-8") as f:
    f.write("# Keyword Hits from global-metadata.dat\n\n")
    for k, matches in hits.items():
        if matches:
            f.write(f"## {k}\n")
            for m in list(set(matches))[:10]:
                f.write(f"- {m}\n")
            f.write("\n")

print(f"Extracted {sum(len(v) for v in hits.values())} hits. Saved to {output_csv}")
