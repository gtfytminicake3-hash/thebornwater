import os
import json

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

def read_file(path):
    full_path = os.path.join(base_dir, path)
    with open(full_path, "r", encoding="utf-8") as f:
        return f.read()

def write_file(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

# 1. Update JSON definitions
jobs_path = "Data/Definitions/jobs.json"
jobs = json.loads(read_file(jobs_path))
if not any(j["id"] == "Guard" for j in jobs):
    jobs.append({"id": "Guard", "name": "Guard", "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "GuardTower logic"})
write_file(jobs_path, json.dumps(jobs, indent=2))

buildings_path = "Data/Definitions/buildings.json"
buildings = json.loads(read_file(buildings_path))
if not any(b["id"] == "GuardTower" for b in buildings):
    buildings.append({"id": "GuardTower", "name": "Guard Tower", "source": "il2cpp_dump", "confidence": "HIGH", "evidence": "GuardTower class"})
write_file(buildings_path, json.dumps(buildings, indent=2))


# 2. Modify LocalGameBackend.cs
local_backend_path = r"Scripts\Backend\Runtime\LocalGameBackend.cs"
backend_code = read_file(local_backend_path)

# Ensure EnemyState exists
if "public class EnemyState" not in backend_code:
    enemy_state_class = """
    [System.Serializable]
    public class EnemyState
    {
        public string id;
        public string typeId;
        public string displayName;
        public int hp;
        public int attack;
        public string status;
    }
"""
    backend_code = backend_code.replace("public class GameSnapshot", enemy_state_class + "\n    public class GameSnapshot")

# Ensure GameSnapshot has raid tracking
if "public List<EnemyState> enemies;" not in backend_code:
    add_snap_fields = """
        public List<EnemyState> enemies;
        public int lastRaidDay;
        public int totalDefense;
"""
    backend_code = backend_code.replace("public List<TaskSnapshot> tasks;", "public List<TaskSnapshot> tasks;\n" + add_snap_fields)

# State
if "public List<EnemyState> enemies = new List<EnemyState>();" not in backend_code:
    backend_code = backend_code.replace("public List<TaskSnapshot> tasks = new List<TaskSnapshot>();", "public List<TaskSnapshot> tasks = new List<TaskSnapshot>();\n        public List<EnemyState> enemies = new List<EnemyState>();\n        public int lastRaidDay = 0;")

# Snapshot populating
if "snap.enemies = new List<EnemyState>(enemies);" not in backend_code:
    backend_code = backend_code.replace("snap.tasks = new List<TaskSnapshot>(tasks);", "snap.tasks = new List<TaskSnapshot>(tasks);\n            snap.enemies = new List<EnemyState>(enemies);\n            snap.lastRaidDay = lastRaidDay;")
    
# Calculate total defense
if "snap.totalDefense =" not in backend_code:
    calc_def = """
            int defense = 0;
            foreach (var v in villagers) if (v.hp > 0 && v.job == "Guard") defense += 10;
            var gt = buildings.Find(b => b.id == "GuardTower");
            if (gt != null) defense += gt.count * 15;
            snap.totalDefense = defense;
"""
    backend_code = backend_code.replace("return snap;", calc_def + "\n            return snap;")

# Job cycle
backend_code = backend_code.replace(
    'string[] jobs = new[] { "Idle", "Woodcutter", "Builder", "Forager", "Miner" };',
    'string[] jobs = new[] { "Idle", "Woodcutter", "Builder", "Forager", "Miner", "Guard" };'
)

# AdvanceTime Raid Logic
raid_logic = """
            if (isGameOver) {
                LogTask("Game is over. Cannot advance time.");
                return;
            }

            int prevTime = timeOfDay;
            timeOfDay++;
            if (timeOfDay > 3) {
                timeOfDay = 0;
                day++;
            }

            // Production & Tasks only if not game over
            if (timeOfDay != prevTime) {
                int defense = 0;
                var gt = buildings.Find(b => b.id == "GuardTower");
                if (gt != null) defense += gt.count * 15;

                foreach (var v in villagers) {
                    if (v.hp <= 0) continue;
                    if (v.job == "Woodcutter") wood += 10;
                    else if (v.job == "Forager") food += 8;
                    else if (v.job == "Miner") iron += 4;
                    else if (v.job == "Guard") defense += 10;
                }

                // Process tasks
                for (int i = tasks.Count - 1; i >= 0; i--) {
                    var t = tasks[i];
                    t.progress += 25;
                    if (t.progress >= 100) {
                        t.progress = 100;
                        t.status = "COMPLETED";
                        var b = buildings.Find(x => x.id == t.targetId);
                        if (b != null) b.count++;
                        else buildings.Add(new BuildingSnapshot { id = t.targetId, count = 1 });
                        LogTask($"{t.targetId} completed!");
                        tasks.RemoveAt(i);
                    }
                }

                // Upkeep and Raid checks
                if (timeOfDay == 0) { // Morning (Start of Day)
                    foreach (var v in villagers) {
                        if (v.hp > 0) {
                            if (food >= 5) food -= 5;
                            else {
                                v.hp -= 10;
                                LogTask($"{v.name} is starving! HP -10.");
                            }
                        }
                    }
                }
                
                if (timeOfDay == 3 && !isObjectiveComplete) { // Night
                    if (lastRaidDay != day && UnityEngine.Random.value > 0.5f) {
                        lastRaidDay = day;
                        LogTask("Night falls. Raid check triggered. A small monster raid approaches!");
                        
                        EnemyState enemy = new EnemyState { id = "e_" + day, typeId = "SmallMonster", displayName = "Small Monster", hp = 30, attack = 15, status = "ATTACKING" };
                        enemies.Add(enemy);
                        
                        int dmg = UnityEngine.Mathf.Max(0, enemy.attack - defense);
                        if (dmg > 0) {
                            foreach(var v in villagers) {
                                if (v.hp > 0) {
                                    v.hp -= dmg;
                                    LogTask($"Night Raid! SmallMonster attacked. Defense: {defense}. Damage: {dmg}. {v.name} HP -{dmg}.");
                                    break; // Only first villager takes damage
                                }
                            }
                            if (wood >= 10) wood -= 10;
                        } else {
                            LogTask($"Night Raid repelled by guards. Defense: {defense}. Damage: 0.");
                        }
                        enemies.Remove(enemy);
                    }
                }

                // Check Game Over
                bool anyAlive = false;
                foreach (var v in villagers) {
                    if (v.hp > 0) anyAlive = true;
                }
                if (!anyAlive) {
                    isGameOver = true;
                    LogTask("GAME OVER - All villagers died.");
                }

                CheckObjective();
            }
"""

import re
backend_code = re.sub(
    r'timeOfDay\+\+;.*?CheckObjective\(\);\s*\}', 
    raid_logic.strip(), 
    backend_code, 
    flags=re.DOTALL
)

# Build GuardTower Command
if "public class BuildGuardTowerCommand" not in backend_code:
    build_gt_cmd = """
    public class BuildGuardTowerCommand : IGameCommand {}
"""
    backend_code = backend_code.replace("public class BuildHutCommand : IGameCommand {}", "public class BuildHutCommand : IGameCommand {}\n" + build_gt_cmd)

# Handle BuildGuardTower
if "if (command is BuildGuardTowerCommand)" not in backend_code:
    handle_build_gt = """
            if (command is BuildGuardTowerCommand) {
                if (isGameOver) return;
                if (wood >= 80 && iron >= 20) {
                    wood -= 80;
                    iron -= 20;
                    tasks.Add(new TaskSnapshot { id = "t_" + System.Guid.NewGuid().ToString().Substring(0, 5), type = "CONSTRUCTION", targetId = "GuardTower", progress = 0, status = "IN_PROGRESS" });
                    LogTask("Started building GuardTower.");
                } else {
                    LogTask("Not enough resources to build GuardTower (80 Wood, 20 Iron).");
                }
            }
"""
    backend_code = backend_code.replace("if (command is BuildHutCommand)", handle_build_gt + "\n            if (command is BuildHutCommand)")

# Handle restore lastRaidDay
if "lastRaidDay = snap.lastRaidDay;" not in backend_code:
    backend_code = backend_code.replace("tasks = new System.Collections.Generic.List<TaskSnapshot>(snap.tasks);", "tasks = new System.Collections.Generic.List<TaskSnapshot>(snap.tasks);\n                enemies = snap.enemies != null ? new System.Collections.Generic.List<EnemyState>(snap.enemies) : new System.Collections.Generic.List<EnemyState>();\n                lastRaidDay = snap.lastRaidDay;")

write_file(local_backend_path, backend_code)


# 3. Modify TownScene UI (MainMenuView.cs / TownUIRoot / MockBackend)
# Actually, the UI interacts via IGameBackend. We need to add Build GuardTower to TownScene view.
town_ui_path = r"Scripts\Frontend\TownScene\TownSceneController.cs" # Wait, button bindings might be in TownView.cs
# Let's search for the script handling Build Hut.
import glob
for script_path in glob.glob(os.path.join(base_dir, r"Scripts\**\*.cs"), recursive=True):
    with open(script_path, "r", encoding="utf-8") as f:
        content = f.read()
    if "btnBuildHut.onClick.AddListener" in content:
        # TownSceneController or TownView
        if "btnBuildGuardTower" not in content:
            content = content.replace("public Button btnBuildHut;", "public Button btnBuildHut;\n    public Button btnBuildGuardTower;")
            content = content.replace("btnBuildHut.onClick.AddListener(() => backend.Execute(new BuildHutCommand()));", "btnBuildHut.onClick.AddListener(() => backend.Execute(new BuildHutCommand()));\n        if(btnBuildGuardTower != null) btnBuildGuardTower.onClick.AddListener(() => backend.Execute(new BuildGuardTowerCommand()));")
            
            # Add defense to UI
            content = content.replace("txtResources.text = $\"Wood: {snap.wood}", "txtResources.text = $\"Wood: {snap.wood} | Defense: {snap.totalDefense}")
            
            # Fix Villager UI presentation
            content = re.sub(
                r'foreach \(var v in snap\.villagers\).*?sb\.AppendLine\(\$\"\{v\.name\} - \{v\.job\}\"\);\s*\}',
                r'foreach (var v in snap.villagers) { sb.AppendLine($"{v.name} - {v.job} - HP {v.hp}" + (v.job == "Guard" ? " (Def +10)" : "")); }',
                content,
                flags=re.DOTALL
            )
            write_file(script_path.replace(base_dir + "\\", ""), content)


print("Update completed.")
