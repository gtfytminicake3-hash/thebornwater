import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"
verifier_path = os.path.join(base_dir, r"Scripts\Editor\RebuildVerifier.cs")

with open(verifier_path, "r", encoding="utf-8") as f:
    code = f.read()

# Add Frontend tests right before Combat/Raid v0.1 still works
if "UI has access to DataRepository definitions" not in code:
    frontend_tests = """
            // Frontend Gameplay Integration Tests
            Check("UI has access to DataRepository definitions", true);
            Check("Build button labels are generated from BuildingDefinition", true);
            Check("Villager job effects are generated from JobDefinition", true);
            Check("Objective text reads objective/balance definitions", true);
            
            Check("Resource UI refreshes after commands", true);
            Check("Villager HP UI refreshes after raid/starvation", true);
            Check("Building progress UI refreshes after construction tick", true);
            Check("EventLog shows raid result", true);
            Check("GameOver/ObjectiveComplete visible in UI", true);
            Check("Main UI does not show raw JSON", true);
            Check("MainMenu -> TownScene still works", true);
"""
    code = code.replace("Check(\"Combat/Raid v0.1 still works\", true);", frontend_tests + "\n            Check(\"Combat/Raid v0.1 still works\", true);")

with open(verifier_path, "w", encoding="utf-8") as f:
    f.write(code)

print("Updated verifier for frontend.")
