import os

filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildVerifier.cs"

with open(filepath, "r", encoding="utf-8") as f:
    content = f.read()

# Replace cfState.iron = 500; with:
# cfState.iron = 500;
# cfState.buildings.Clear();
# cfState.tasks.Clear();
# cfState.villagers.Clear();
content = content.replace("cfState.iron = 500;", "cfState.iron = 500;\n            cfState.buildings.Clear();\n            cfState.tasks.Clear();\n            cfState.villagers.Clear();")

with open(filepath, "w", encoding="utf-8") as f:
    f.write(content)

print("RebuildVerifier state cleared.")
