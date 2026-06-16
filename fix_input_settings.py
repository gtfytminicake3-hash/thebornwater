import os

path = r"D:\Tinh\TheBonwater\ProjectSettings\ProjectSettings.asset"
with open(path, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace("activeInputHandler: 1", "activeInputHandler: 2")
content = content.replace("activeInputHandler: 0", "activeInputHandler: 2")

with open(path, "w", encoding="utf-8") as f:
    f.write(content)

print("Changed activeInputHandler to 2 (Both) in ProjectSettings.asset")
