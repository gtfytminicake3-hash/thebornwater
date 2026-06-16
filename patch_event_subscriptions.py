import os
import glob

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Frontend\Views"

for file_path in glob.glob(os.path.join(base_dir, "*.cs")):
    with open(file_path, "r", encoding="utf-8") as f:
        code = f.read()
    
    if "public void UpdateState" in code or "public void Refresh" in code:
        if "private void Start()" not in code:
            if "public void UpdateState" in code:
                code = code.replace("public void UpdateState", "private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateState; }\n        public void UpdateState")
            elif "public void Refresh" in code:
                code = code.replace("public void Refresh", "private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += (_) => Refresh(); }\n        public void Refresh")
                
            with open(file_path, "w", encoding="utf-8") as f:
                f.write(code)

# Fix TownInteractionController to hook btnBuildGuardTower and ensure it triggers RefreshUI manually on start
tic_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Frontend\TownInteractionController.cs"
with open(tic_path, "r", encoding="utf-8") as f:
    tic_code = f.read()

if "btnBuildGuardTower.onClick.AddListener" not in tic_code:
    tic_code = tic_code.replace("if (btnBuildHut != null) btnBuildHut.onClick.AddListener(() => ExecuteCommand(new BuildHutCommand()));", "if (btnBuildHut != null) btnBuildHut.onClick.AddListener(() => ExecuteCommand(new BuildHutCommand()));\n            if (btnBuildGuardTower != null) btnBuildGuardTower.onClick.AddListener(() => ExecuteCommand(new BuildGuardTowerCommand()));")

with open(tic_path, "w", encoding="utf-8") as f:
    f.write(tic_code)

print("Patched event subscriptions.")
