import os
import re

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

# Fix Validator
val_path = os.path.join(base_dir, r"Scripts\Backend\Data\DataDefinitionValidator.cs")
with open(val_path, "r", encoding="utf-8") as f:
    val_code = f.read()

val_code = val_code.replace("void Check(string condition, bool result) {", "void Check(ref int p, ref int f, string condition, bool result) {")
val_code = val_code.replace("if (result) pass++; else fail++;", "if (result) p++; else f++;")
val_code = val_code.replace("Check(", "Check(ref pass, ref fail, ")
with open(val_path, "w", encoding="utf-8") as f:
    f.write(val_code)

# Fix LocalGameBackend
lgb_path = os.path.join(base_dir, r"Scripts\Backend\Runtime\LocalGameBackend.cs")
with open(lgb_path, "r", encoding="utf-8") as f:
    lgb_code = f.read()

# Fix targetId
lgb_code = lgb_code.replace("""
                    float req = 100f;
                    var def = repo.GetBuilding(targetId);
                    if (def != null) req = def.constructionRequired;
                    if (task.progress >= req) {
                        string targetId = task.type == "BuildHut" ? "Hut" : "GuardTower";
""", """
                    string targetId = task.type == "BuildHut" ? "Hut" : "GuardTower";
                    float req = 100f;
                    var def = repo.GetBuilding(targetId);
                    if (def != null) req = def.constructionRequired;
                    if (task.progress >= req) {
""")

# Fix penalty
lgb_code = lgb_code.replace("""
                    if (true) /* logic moved below */ int penalty = repo.Balance?.woodPenaltyOnUnblockedRaid ?? 10;
                    if (state.wood >= penalty) state.wood -= penalty;
""", """
                    int penalty = repo.Balance?.woodPenaltyOnUnblockedRaid ?? 10;
                    if (state.wood >= penalty) state.wood -= penalty;
""")

with open(lgb_path, "w", encoding="utf-8") as f:
    f.write(lgb_code)

print("Fixed syntax errors")
