import os

search_paths = [
    r"C:\Program Files",
    r"C:\Program Files (x86)",
    os.path.expanduser(r"~\AppData\Local"),
    os.path.expanduser(r"~\AppData\Roaming"),
    r"D:\Unity",
    r"D:\UnityHub",
    r"D:\Tinh"
]

found = []
print("Searching for Unity.exe...")
for path in search_paths:
    if os.path.exists(path):
        for root, dirs, files in os.walk(path):
            if "Unity.exe" in files:
                found.append(os.path.join(root, "Unity.exe"))

if found:
    print("Found Unity.exe at:")
    for f in found:
        print(f)
    with open(r"D:\Tinh\TheBonwater\unity_path.txt", "w", encoding="utf-8") as f:
        f.write(found[0])
else:
    print("Unity.exe not found.")
