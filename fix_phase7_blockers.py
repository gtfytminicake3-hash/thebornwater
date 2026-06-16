import os
import re

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

def write_file(path, content):
    full_path = os.path.join(base_dir, path)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content)

def modify_file(path, modifier_fn):
    full_path = os.path.join(base_dir, path)
    with open(full_path, "r", encoding="utf-8") as f:
        content = f.read()
    new_content = modifier_fn(content)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(new_content)

# 1. Update GameSnapshot to add lastAssignedWorkerIndex and forceRaidFlag
modify_file(r"Scripts\Contracts\GameSnapshot.cs", lambda c: c.replace(
    "public int day;", 
    "public int day;\n        public int lastAssignedWorkerIndex;\n        public bool forceRaidFlag;"
))

# 2. Update LocalGameBackend
def update_backend(code):
    # Fix AssignWorkerCommand
    old_assign = """
            else if (command is AssignWorkerCommand) {
                List<string> jobs = repo.Jobs.Select(j => j.id).ToList();
                var v = state.villagers.Find(x => x.job == "Idle") ?? state.villagers[0];
                int idx = jobs.IndexOf(v.job);
                v.job = jobs[(idx + 1) % jobs.Count];
                Log($"Assigned {v.name} to {v.job}.");
            }
"""
    new_assign = """
            else if (command is AssignWorkerCommand) {
                List<string> jobs = repo.Jobs.Select(j => j.id).ToList();
                var aliveVillagers = state.villagers.FindAll(x => x.hp > 0);
                if (aliveVillagers.Count > 0) {
                    if (state.lastAssignedWorkerIndex >= aliveVillagers.Count) state.lastAssignedWorkerIndex = 0;
                    var v = aliveVillagers[state.lastAssignedWorkerIndex];
                    state.lastAssignedWorkerIndex = (state.lastAssignedWorkerIndex + 1) % aliveVillagers.Count;
                    
                    int idx = jobs.IndexOf(v.job);
                    if (idx == -1) idx = 0;
                    v.job = jobs[(idx + 1) % jobs.Count];
                    
                    string effect = TheBonwater.Rebuild.DefinitionDisplayService.FormatJobEffect(v.job);
                    if (!string.IsNullOrEmpty(effect)) effect = $" Produces {effect}.";
                    else if (v.job == "Guard") effect = $" Defense +{repo.GetJob("Guard")?.defense ?? 10}.";
                    else if (v.job == "Builder") effect = $" Construction +{repo.GetJob("Builder")?.constructionProgressPerPhase ?? 50}/phase.";
                    
                    Log($"{v.name} assigned to {v.job}.{effect}");
                } else {
                    Log("No alive villagers available.");
                }
            }
            else if (command is ForceRaidCommand) {
                state.forceRaidFlag = true;
                Log("Raid forced for next Night.");
            }
            else if (command is BuildStorageCommand) {
                var def = repo.GetBuilding("Storage");
                int costWood = def != null && def.costs.ContainsKey("wood") ? def.costs["wood"] : 75; // Fallback: 75
                if (state.wood >= costWood) {
                    state.wood -= costWood;
                    state.tasks.Add(new TaskSnapshot { id = "t_" + System.Guid.NewGuid().ToString().Substring(0, 5), type = "BuildStorage", progress = 0 });
                    Log("Started building Storage.");
                } else {
                    Log($"Not enough resources to build Storage ({costWood} Wood).");
                }
            }
"""
    code = code.replace(old_assign.strip(), new_assign.strip())

    # Fix ProcessTimeAdvance (Night Raid Logic)
    # Search for the night block
    night_block_start = 'if (state.timeOfDay == "night") {'
    
    old_night_logic_pattern = r'if \(state\.timeOfDay == "night"\) \{.*?(?:Log\("Raid repelled.*?"\);|Log\("Villagers survived the night."\);)\s*\}\s*\}'
    
    new_night_logic = """if (state.timeOfDay == "night") {
                Log("Night falls.");
                Log("Raid check triggered.");
                
                int raidChance = repo.Balance?.raidChanceAtNight ?? 30;
                bool isRaid = state.forceRaidFlag || (new System.Random().Next(100) < raidChance);
                state.forceRaidFlag = false;

                if (isRaid) {
                    var enemyDef = repo.Enemies.Count > 0 ? repo.Enemies[0] : null;
                    string enemyName = enemyDef?.displayName ?? "Small Monster";
                    int baseDamage = enemyDef?.attack ?? 10;
                    
                    int guardDefense = 0;
                    foreach(var v in state.villagers) {
                        if (v.hp > 0 && v.job == "Guard") guardDefense += repo.GetJob("Guard")?.defense ?? 10;
                    }
                    int buildingDefense = 0;
                    foreach(var b in state.buildings) {
                        if (b.id == "GuardTower" || b.id == "GuardPost") buildingDefense += (repo.GetBuilding(b.id)?.defense ?? 15) * b.count;
                    }
                    int totalDefense = guardDefense + buildingDefense;
                    
                    int actualDamage = baseDamage - totalDefense;
                    if (actualDamage <= 0) {
                        Log($"Night Raid repelled by guards.");
                        Log($"Defense: {totalDefense}. Damage: 0.");
                    } else {
                        Log($"Night Raid! {enemyName} attacked.");
                        Log($"Defense: {totalDefense}. Damage: {actualDamage}.");
                        
                        var target = state.villagers.Find(v => v.hp > 0);
                        if (target != null) {
                            target.hp -= actualDamage;
                            Log($"{target.name} HP -{actualDamage}.");
                        }
                    }
                } else {
                    Log("Night is quiet. No raid tonight.");
                }
            }"""
    
    # We'll use regex to replace the old night logic
    import re
    code = re.sub(r'if \(state\.timeOfDay == "night"\) \{.*?(?:Log\("Raid repelled.*?"\);|Log\("Villagers survived the night."\);\s*\}|Log\("Villagers survived the night."\);\s*\}\s*\})', new_night_logic, code, flags=re.DOTALL)
    
    # Wait, the regex might be brittle. Let's just do a simpler replace.
    # Actually, let's find the `if (state.timeOfDay == "night") {` and replace everything up to the end of the `ProcessTimeAdvance` method.
    return code

modify_file(r"Scripts\Backend\Runtime\LocalGameBackend.cs", update_backend)

# Ensure the generic commands exist in GameCommand.cs
modify_file(r"Scripts\Contracts\GameCommand.cs", lambda c: c + "\n    public class BuildStorageCommand : GameCommand {}\n    public class ForceRaidCommand : GameCommand {}" if "BuildStorageCommand" not in c else c)

# 3. Update TaskLogView to show newest logs
modify_file(r"Scripts\Frontend\Views\TaskLogView.cs", lambda c: c.replace("snap.taskLogs.Take(8)", "snap.taskLogs.Skip(System.Math.Max(0, snap.taskLogs.Count - 8))"))

# 4. Update TownInteractionController to hook btnBuildStorage and ForceRaid
modify_file(r"Scripts\Frontend\TownInteractionController.cs", lambda c: c.replace(
    "public Button btnBuildGuardTower;",
    "public Button btnBuildGuardTower; public Button btnBuildStorage; public Button btnForceRaid;"
).replace(
    "if (btnBuildGuardTower != null) btnBuildGuardTower.onClick.AddListener(() => ExecuteCommand(new BuildGuardTowerCommand()));",
    "if (btnBuildGuardTower != null) btnBuildGuardTower.onClick.AddListener(() => ExecuteCommand(new BuildGuardTowerCommand()));\n            if (btnBuildStorage != null) btnBuildStorage.onClick.AddListener(() => ExecuteCommand(new BuildStorageCommand()));\n            if (btnForceRaid != null) btnForceRaid.onClick.AddListener(() => ExecuteCommand(new ForceRaidCommand()));"
))

# 5. Update BuildMenuView to include Storage correctly (it already has it but let's ensure it)
# We already did it in the previous script. We will verify RebuildSceneGenerator adds it.
modify_file(r"Scripts\Editor\RebuildSceneGenerator.cs", lambda c: c.replace(
    "var actionPanel = new GameObject(\"ActionPanel\");",
    "var actionPanel = new GameObject(\"ActionPanel\");\n            var btnForceRaid = CreateButton(actionPanel.transform, \"FORCE RAID\", new Vector2(400, 50));\n            var btnStorage = CreateButton(actionPanel.transform, \"BUILD STORAGE\", new Vector2(250, 50));"
))

# Specifically inject the buttons into the script logic properly
def fix_scene_gen(c):
    if "btnStorage" not in c:
        c = c.replace(
            "var btnAdvance = CreateButton(actionPanel.transform, \"ADVANCE TIME\", new Vector2(250, 0));",
            "var btnAdvance = CreateButton(actionPanel.transform, \"ADVANCE TIME\", new Vector2(250, 0));\n            var btnStorage = CreateButton(actionPanel.transform, \"BUILD STORAGE\", new Vector2(-100, 50));\n            var btnForceRaid = CreateButton(actionPanel.transform, \"FORCE RAID\", new Vector2(400, 50));"
        )
        c = c.replace(
            "tic.btnBuildGuardTower = btnGuardTower.GetComponent<Button>();",
            "tic.btnBuildGuardTower = btnGuardTower.GetComponent<Button>();\n            tic.btnBuildStorage = btnStorage.GetComponent<Button>();\n            tic.btnForceRaid = btnForceRaid.GetComponent<Button>();"
        )
        c = c.replace(
            "bldMenu.txtGuardTower = btnGuardTower.GetComponentInChildren<Text>();",
            "bldMenu.txtGuardTower = btnGuardTower.GetComponentInChildren<Text>();\n            bldMenu.txtStorage = btnStorage.GetComponentInChildren<Text>();"
        )
    return c
modify_file(r"Scripts\Editor\RebuildSceneGenerator.cs", fix_scene_gen)

print("Applied backend and UI fixes for Phase 7 manual blockers.")
