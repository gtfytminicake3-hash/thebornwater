import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

def write_file(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

# --- CONTRACTS ---
write_file(r"Contracts\GameSnapshot.cs", """
using System;
using System.Collections.Generic;
namespace TheBonwater.Rebuild {
    [Serializable]
    public class GameSnapshot {
        public int day = 1;
        public string timeOfDay = "Morning";
        public int wood = 100; public int woodCapacity = 500;
        public int food = 80;  public int foodCapacity = 200;
        public int iron = 0;   public int ironCapacity = 100;
        
        public string lastAction = "";
        public bool isGameOver = false;
        public bool isObjectiveComplete = false;
        public int consecutiveDaysWithoutFood = 0;
        
        public List<VillagerSnapshot> villagers = new List<VillagerSnapshot>();
        public List<BuildingSnapshot> buildings = new List<BuildingSnapshot>();
        public List<TaskSnapshot> tasks = new List<TaskSnapshot>();
        public List<string> taskLogs = new List<string>();
    }
    [Serializable] public class VillagerSnapshot { public string name; public string job; public int hp; }
    [Serializable] public class BuildingSnapshot { public string id; public int count; }
    [Serializable] public class TaskSnapshot { public string id; public string type; public float progress; }
}
""")

write_file(r"Contracts\GameCommand.cs", """
namespace TheBonwater.Rebuild {
    public abstract class GameCommand { }
    public class StartNewGameCommand : GameCommand { }
    public class AdvanceTimeCommand : GameCommand { }
    public class AssignWorkerCommand : GameCommand { }
    public class SaveGameCommand : GameCommand { }
    public class LoadGameCommand : GameCommand { }
    public class CollectWoodCommand : GameCommand { }
    public class BuildHutCommand : GameCommand { }
}
""")

# --- BACKEND ---
write_file(r"Backend\Runtime\LocalGameBackend.cs", """
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class LocalGameBackend : IGameBackend {
        private GameSnapshot state;
        private string savePath;

        public LocalGameBackend() {
            savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            InitNewState();
        }

        private void InitNewState() {
            state = new GameSnapshot();
            state.villagers.Add(new VillagerSnapshot { name = "Bryn", job = "Idle", hp = 100 });
            state.villagers.Add(new VillagerSnapshot { name = "Alaric", job = "Idle", hp = 100 });
            state.buildings.Add(new BuildingSnapshot { id = "Bonfire", count = 1 });
            state.buildings.Add(new BuildingSnapshot { id = "Hut", count = 0 });
            Log("Game Started.");
        }

        public CommandResult Execute(GameCommand command) {
            CommandResult result = new CommandResult { success = true };
            if (state.isGameOver && !(command is StartNewGameCommand || command is LoadGameCommand)) {
                result.success = false; result.message = "Game Over. Cannot execute commands."; return result;
            }

            if (command is StartNewGameCommand) { InitNewState(); Log("Started New Game."); }
            else if (command is CollectWoodCommand) {
                int amount = 10;
                if (state.wood + amount <= state.woodCapacity) { state.wood += amount; Log($"+{amount} Wood collected."); }
                else { state.wood = state.woodCapacity; Log($"Wood capacity full."); }
            }
            else if (command is BuildHutCommand) {
                int cost = 50;
                if (state.wood >= cost) {
                    state.wood -= cost;
                    state.tasks.Add(new TaskSnapshot { id = Guid.NewGuid().ToString(), type = "BuildHut", progress = 0 });
                    Log($"Build Hut task created (-{cost} Wood).");
                } else { result.success = false; result.message = "Not enough Wood. Need 50 Wood."; Log(result.message); }
            }
            else if (command is AssignWorkerCommand) {
                string[] jobs = { "Idle", "Woodcutter", "Builder", "Forager", "Miner" };
                var v = state.villagers.Find(x => x.job == "Idle") ?? state.villagers[0];
                int idx = Array.IndexOf(jobs, v.job);
                v.job = jobs[(idx + 1) % jobs.Length];
                Log($"Assigned {v.name} to {v.job}.");
            }
            else if (command is AdvanceTimeCommand) {
                ProcessTimeAdvance();
            }
            else if (command is SaveGameCommand) {
                try { File.WriteAllText(savePath, JsonUtility.ToJson(state, true)); Log($"Game saved."); }
                catch (Exception e) { result.success = false; Log($"Failed to save: {e.Message}"); }
            }
            else if (command is LoadGameCommand) {
                if (File.Exists(savePath)) {
                    try { string json = File.ReadAllText(savePath); state = JsonUtility.FromJson<GameSnapshot>(json); Log("Game loaded."); }
                    catch (Exception e) { result.success = false; Log($"Failed to load: {e.Message}"); }
                } else { result.success = false; Log("No save file found."); }
            }
            return result;
        }

        private void ProcessTimeAdvance() {
            // Production Phase
            int woodcutters = state.villagers.Count(v => v.job == "Woodcutter" && v.hp > 0);
            int foragers = state.villagers.Count(v => v.job == "Forager" && v.hp > 0);
            int miners = state.villagers.Count(v => v.job == "Miner" && v.hp > 0);
            int builders = state.villagers.Count(v => v.job == "Builder" && v.hp > 0);

            if (woodcutters > 0) { state.wood = Mathf.Min(state.wood + woodcutters * 10, state.woodCapacity); }
            if (foragers > 0) { state.food = Mathf.Min(state.food + foragers * 8, state.foodCapacity); }
            if (miners > 0) { state.iron = Mathf.Min(state.iron + miners * 4, state.ironCapacity); }

            // Construction Phase
            float buildPower = builders > 0 ? 50f * builders : 25f; // Fallback build power
            var tasksToComplete = new List<TaskSnapshot>();
            foreach(var task in state.tasks.Where(t => t.type == "BuildHut")) {
                task.progress += buildPower;
                if (task.progress >= 100) {
                    var hut = state.buildings.Find(b => b.id == "Hut");
                    if (hut == null) { hut = new BuildingSnapshot { id = "Hut", count = 0 }; state.buildings.Add(hut); }
                    hut.count++;
                    tasksToComplete.Add(task);
                    Log("Hut completed.");
                }
            }
            foreach(var t in tasksToComplete) state.tasks.Remove(t);

            // Time Shift
            if (state.timeOfDay == "Morning") state.timeOfDay = "Afternoon";
            else if (state.timeOfDay == "Afternoon") state.timeOfDay = "Evening";
            else if (state.timeOfDay == "Evening") state.timeOfDay = "Night";
            else if (state.timeOfDay == "Night") { 
                state.timeOfDay = "Morning"; 
                state.day++; 
                ProcessDailyUpkeep();
            }

            Log($"Time advanced: Day {state.day} - {state.timeOfDay}");
            CheckObjectives();
        }

        private void ProcessDailyUpkeep() {
            int aliveCount = state.villagers.Count(v => v.hp > 0);
            int foodNeeded = aliveCount * 5;
            
            if (state.food >= foodNeeded) {
                state.food -= foodNeeded;
                state.consecutiveDaysWithoutFood = 0;
            } else {
                state.food = 0;
                state.consecutiveDaysWithoutFood++;
                foreach(var v in state.villagers.Where(v => v.hp > 0)) {
                    v.hp -= 10;
                    if (v.hp < 0) v.hp = 0;
                }
                Log("Not enough food. Villagers are starving!");
            }
        }

        private void CheckObjectives() {
            if (state.isGameOver) return;

            int aliveCount = state.villagers.Count(v => v.hp > 0);
            if (aliveCount == 0) {
                state.isGameOver = true;
                Log("GAME OVER - All villagers died.");
            }
            else if (state.consecutiveDaysWithoutFood >= 2) {
                Log("WARNING: Food shortage.");
            }

            int hutCount = state.buildings.Find(b => b.id == "Hut")?.count ?? 0;
            if (state.day >= 3 && hutCount >= 2 && aliveCount > 0 && !state.isObjectiveComplete) {
                state.isObjectiveComplete = true;
                Log("Objective complete: Village survived 3 days and built 2 huts.");
            }
        }

        private void Log(string msg) {
            state.lastAction = msg;
            state.taskLogs.Insert(0, msg);
            if (state.taskLogs.Count > 5) state.taskLogs.RemoveAt(state.taskLogs.Count - 1);
        }

        public GameSnapshot GetSnapshot() { return state; }
    }
}
""")

# Overwrite GameServiceLocator to use LocalGameBackend
write_file(r"Core\GameServiceLocator.cs", """
namespace TheBonwater.Rebuild {
    public static class GameServiceLocator {
        public static IGameBackend Backend { get; private set; }
        public static void RegisterBackend(IGameBackend backend) => Backend = backend;
    }
}
""")

# --- FRONTEND CONTROLLER ---
write_file(r"Frontend\TownInteractionController.cs", """
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
namespace TheBonwater.Rebuild {
    public class TownInteractionController : MonoBehaviour {
        public static TownInteractionController Instance;
        public Button btnCollectWood; public Button btnBuildHut; public Button btnAssignWorker;
        public Button btnAdvanceTime; public Button btnSave; public Button btnLoad;
        public delegate void StateChangedHandler(GameSnapshot snapshot);
        public event StateChangedHandler OnStateChanged;
        private void Awake() { Instance = this; }
        private void Start() {
            if (GameServiceLocator.Backend == null) GameServiceLocator.RegisterBackend(new LocalGameBackend());
            if (btnCollectWood != null) btnCollectWood.onClick.AddListener(() => ExecuteCommand(new CollectWoodCommand()));
            if (btnBuildHut != null) btnBuildHut.onClick.AddListener(() => ExecuteCommand(new BuildHutCommand()));
            if (btnAssignWorker != null) btnAssignWorker.onClick.AddListener(() => ExecuteCommand(new AssignWorkerCommand()));
            if (btnAdvanceTime != null) btnAdvanceTime.onClick.AddListener(() => ExecuteCommand(new AdvanceTimeCommand()));
            if (btnSave != null) btnSave.onClick.AddListener(() => ExecuteCommand(new SaveGameCommand()));
            if (btnLoad != null) btnLoad.onClick.AddListener(() => ExecuteCommand(new LoadGameCommand()));
            RefreshUI();
        }
        public void ExecuteCommand(GameCommand cmd) {
            GameServiceLocator.Backend.Execute(cmd);
            RefreshUI();
        }
        public void RefreshUI() {
            var snap = GameServiceLocator.Backend.GetSnapshot();
            OnStateChanged?.Invoke(snap);
            var worldRoot = GameObject.Find("TownWorldRoot");
            if (worldRoot != null) {
                var hutSnap = snap.buildings.Find(b => b.id == "Hut");
                int hutCount = hutSnap != null ? hutSnap.count : 0;
                int constructionCount = snap.tasks.Count(t => t.type == "BuildHut");
                int totalVisualHuts = hutCount + constructionCount;

                int currentHuts = 0;
                foreach(Transform child in worldRoot.transform) { if (child.name.StartsWith("HutVisual_Runtime")) currentHuts++; }
                for(int i = currentHuts; i < totalVisualHuts; i++) {
                    var go = new GameObject($"HutVisual_Runtime_{i+1}");
                    go.transform.SetParent(worldRoot.transform, false);
                    var img = go.AddComponent<Image>();
                    img.color = new Color(0.6f, 0.3f, 0.1f);
                    img.raycastTarget = false;
                    var rect = go.GetComponent<RectTransform>();
                    rect.anchoredPosition = new Vector2(-250 + (i * 100), 50 + (i * 20));
                    rect.sizeDelta = new Vector2(100, 100);
                    go.transform.SetSiblingIndex(2);
                }
            }
        }
    }
}
""")

write_file(r"Frontend\Views\ObjectiveView.cs", """
using UnityEngine; using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class ObjectiveView : MonoBehaviour {
        public Text txtObjective;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtObjective != null) {
                int hutCount = snap.buildings.Find(b => b.id == "Hut")?.count ?? 0;
                string status = snap.isObjectiveComplete ? "COMPLETED!" : (snap.isGameOver ? "FAILED" : "IN PROGRESS");
                txtObjective.text = $"OBJECTIVE: Survive to Day 3 ({snap.day}/3)\\nBuild Huts: {hutCount}/2\\nStatus: {status}";
            }
        }
    }
}
""")

print("Core Loop Pass files updated.")
