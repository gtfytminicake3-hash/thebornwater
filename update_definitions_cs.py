import os

filepath = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Backend\Data\Definitions.cs"

with open(filepath, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace("public string confidence;", "public string confidence;\n        public string fidelity;")

with open(filepath, "w", encoding="utf-8") as f:
    f.write(content)

print("Definitions.cs updated.")
