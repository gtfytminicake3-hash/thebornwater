import os

d = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

for root, _, files in os.walk(d):
    for file in files:
        if file.endswith(".cs"):
            path = os.path.join(root, file)
            with open(path, "r", encoding="utf-8") as f:
                content = f.read()
            
            # ONLY remove literal \n at the very end of the file!
            if content.endswith(r"\n"):
                content = content[:-2]
            
            with open(path, "w", encoding="utf-8") as f:
                f.write(content)
print("Safe syntax fix complete.")
