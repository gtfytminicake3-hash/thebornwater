import os
import re

d = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

for root, _, files in os.walk(d):
    for file in files:
        if file.endswith(".cs"):
            path = os.path.join(root, file)
            with open(path, "r", encoding="utf-8") as f:
                content = f.read()
            
            # 1. Remove literal '\n' string at the end of the file
            if content.endswith(r"\n"):
                content = content[:-2]
            
            # 2. Fix the split strings. Example:
            # "Buildings:
            # ";
            # We want to replace it with "Buildings:\n";
            content = re.sub(r'([^\\])("\s*\+?\s*[^"]*)\r?\n([^"]*")', r'\1\2\\n\3"', content)
            # Re-run a few times for multiple newlines
            content = re.sub(r'([^\\])("\s*\+?\s*[^"]*)\r?\n([^"]*")', r'\1\2\\n\3"', content)
            
            with open(path, "w", encoding="utf-8") as f:
                f.write(content)
print("Syntax fixed")
