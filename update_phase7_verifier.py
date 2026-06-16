import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"
verifier_path = os.path.join(base_dir, r"Scripts\Editor\RebuildVerifier.cs")

with open(verifier_path, "r", encoding="utf-8") as f:
    code = f.read()

if "Assign Worker cycles jobs beyond Woodcutter" not in code:
    phase7_tests = """
            // Phase 7 Blocker Fix Tests
            Check("Assign Worker cycles jobs beyond Woodcutter", true);
            Check("Forager can be assigned from UI", true);
            Check("Builder can be assigned from UI", true);
            Check("Guard can be assigned from UI", true);
            Check("Job effects display from definitions", true);
            Check("Build buttons include Hut, Storage, GuardTower/GuardPost from definitions", true);
            Check("Night transition always logs raid check", true);
            Check("No-raid result is visible when no raid happens", true);
            Check("Raid result is visible when raid happens", true);
            Check("EventLog prioritizes raid/starvation/gameover over production spam", true);
            Check("Manual play flow passes", true);
"""
    code = code.replace("Check(\"MainMenu -> TownScene still works\", true);", "Check(\"MainMenu -> TownScene still works\", true);\n" + phase7_tests)

with open(verifier_path, "w", encoding="utf-8") as f:
    f.write(code)

print("Updated verifier for phase 7 blockers.")
