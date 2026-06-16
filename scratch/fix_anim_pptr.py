import os
import re

anim_dir = r"D:\Tinh\TheBonwater\Assets\_Project\ImportedDecoded\Animation"
pattern = re.compile(r'script:\s*\{fileID:\s*1\}')
replacement = r'script: {fileID: 0}'

count = 0
for root, dirs, files in os.walk(anim_dir):
    for file in files:
        if file.endswith(".anim"):
            path = os.path.join(root, file)
            with open(path, "r", encoding="utf-8") as f:
                content = f.read()
            
            new_content = pattern.sub(replacement, content)
            if new_content != content:
                with open(path, "w", encoding="utf-8") as f:
                    f.write(new_content)
                count += 1

print(f"Fixed {count} files.")
