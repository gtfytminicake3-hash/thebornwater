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
        public int wood = 100;
        public int woodCapacity = 500;
        public int food = 50;
        public int foodCapacity = 200;
        public int iron = 0;
        public int ironCapacity = 100;
        public List<VillagerSnapshot> villagers = new List<VillagerSnapshot>();
        public List<BuildingSnapshot> buildings = new List<BuildingSnapshot>();
        public List<string> taskLogs = new List<string>();
    }
    [Serializable] public class VillagerSnapshot { public string name; public string job; public int hp; }
    [Serializable] public class BuildingSnapshot { public string id; public int count; }
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

write_file(r"Contracts\CommandResult.cs", """
namespace TheBonwater.Rebuild {
    public class CommandResult {
        public bool success;
        public string message;
        public GameStateDelta delta;
    }
}
""")

write_file(r"Contracts\IGameBackend.cs", """
namespace TheBonwater.Rebuild {
    public interface IGameBackend {
        CommandResult Execute(GameCommand command);
        GameSnapshot GetSnapshot();
    }
}
""")

# Empty out unused contracts
write_file(r"Contracts\GameStateDelta.cs", "// empty")
write_file(r"Contracts\GameEnums.cs", "// empty")

# --- BACKEND ---
write_file(r"Backend\Mock\MockBackend.cs", """
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
namespace TheBonwater.Rebuild {
    public class MockBackend : IGameBackend {
        private GameSnapshot state;
        private string savePath;
        public MockBackend() {
            savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            InitNewState();
        }
        private void InitNewState() {
            state = new GameSnapshot();
            state.villagers.Add(new VillagerSnapshot { name = "Bryn", job = "Idle", hp = 100 });
            state.villagers.Add(new VillagerSnapshot { name = "Alaric", job = "Idle", hp = 100 });
            state.buildings.Add(new BuildingSnapshot { id = "Bonfire", count = 1 });
            state.taskLogs.Add("Game Started.");
        }
        public CommandResult Execute(GameCommand command) {
            CommandResult result = new CommandResult { success = true };
            if (command is StartNewGameCommand) { InitNewState(); Log("Started New Game."); }
            else if (command is CollectWoodCommand) {
                int amount = 10;
                if (state.wood + amount <= state.woodCapacity) { state.wood += amount; Log($"Collected +{amount} Wood"); }
                else { state.wood = state.woodCapacity; Log($"Collected max Wood (Capacity full)"); }
            }
            else if (command is BuildHutCommand) {
                int cost = 50;
                if (state.wood >= cost) {
                    state.wood -= cost;
                    var hut = state.buildings.Find(b => b.id == "Hut");
                    if (hut == null) { hut = new BuildingSnapshot { id = "Hut", count = 0 }; state.buildings.Add(hut); }
                    hut.count++;
                    Log($"Built Hut (-{cost} Wood)");
                } else { result.success = false; result.message = "Not enough Wood to build Hut"; Log(result.message); }
            }
            else if (command is AssignWorkerCommand) {
                var idle = state.villagers.Find(v => v.job == "Idle");
                if (idle != null) { idle.job = "Woodcutter"; Log($"Assigned {idle.name} to Woodcutter"); }
                else { result.success = false; result.message = "No idle villagers available"; Log(result.message); }
            }
            else if (command is AdvanceTimeCommand) {
                if (state.timeOfDay == "Morning") state.timeOfDay = "Afternoon";
                else if (state.timeOfDay == "Afternoon") state.timeOfDay = "Evening";
                else if (state.timeOfDay == "Evening") state.timeOfDay = "Night";
                else if (state.timeOfDay == "Night") { state.timeOfDay = "Morning"; state.day++; }
                int woodcutters = state.villagers.FindAll(v => v.job == "Woodcutter").Count;
                if (woodcutters > 0) {
                    state.wood = Mathf.Min(state.wood + woodcutters * 5, state.woodCapacity);
                    Log($"Woodcutters produced +{woodcutters * 5} Wood");
                }
                Log($"Advanced time to {state.timeOfDay}");
            }
            else if (command is SaveGameCommand) {
                try { File.WriteAllText(savePath, JsonUtility.ToJson(state, true)); Log($"Game saved: {savePath}"); }
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
        private void Log(string msg) {
            state.taskLogs.Insert(0, msg);
            if (state.taskLogs.Count > 5) state.taskLogs.RemoveAt(state.taskLogs.Count - 1);
        }
        public GameSnapshot GetSnapshot() { return state; }
    }
}
""")

# --- FRONTEND CONTROLLER ---
write_file(r"Frontend\TownInteractionController.cs", """
using UnityEngine;
using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class TownInteractionController : MonoBehaviour {
        public static TownInteractionController Instance;
        public Button btnCollectWood; public Button btnBuildHut; public Button btnAssignWorker;
        public Button btnAdvanceTime; public Button btnSave; public Button btnLoad;
        public delegate void StateChangedHandler(GameSnapshot snapshot);
        public event StateChangedHandler OnStateChanged;
        private void Awake() { Instance = this; }
        private void Start() {
            if (GameServiceLocator.Backend == null) GameServiceLocator.RegisterBackend(new MockBackend());
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
                if (hutSnap != null) {
                    int currentHuts = 0;
                    foreach(Transform child in worldRoot.transform) { if (child.name.StartsWith("HutVisual_Runtime")) currentHuts++; }
                    for(int i = currentHuts; i < hutSnap.count; i++) {
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
}
""")

# --- VIEWS ---
write_file(r"Frontend\Views\TownView.cs", """
using UnityEngine; using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class TownView : MonoBehaviour {
        public Text txtDayTime;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) { if (txtDayTime != null) txtDayTime.text = $"Day {snap.day} - {snap.timeOfDay}"; }
    }
}
""")

write_file(r"Frontend\Views\ResourceBarView.cs", """
using UnityEngine; using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class ResourceBarView : MonoBehaviour {
        public Text txtResources;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtResources != null) txtResources.text = $"Wood: {snap.wood} / {snap.woodCapacity}   Food: {snap.food} / {snap.foodCapacity}   Iron: {snap.iron} / {snap.ironCapacity}";
        }
    }
}
""")

write_file(r"Frontend\Views\VillagerListView.cs", """
using UnityEngine; using UnityEngine.UI; using System.Text;
namespace TheBonwater.Rebuild {
    public class VillagerListView : MonoBehaviour {
        public Text txtVillagers;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtVillagers != null) {
                var sb = new StringBuilder(); sb.AppendLine("VILLAGERS");
                foreach(var v in snap.villagers) sb.AppendLine($"{v.name} | Job: {v.job} | HP: {v.hp}");
                txtVillagers.text = sb.ToString();
            }
        }
    }
}
""")

write_file(r"Frontend\Views\BuildingListView.cs", """
using UnityEngine; using UnityEngine.UI; using System.Text;
namespace TheBonwater.Rebuild {
    public class BuildingListView : MonoBehaviour {
        public Text txtBuildings;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtBuildings != null) {
                var sb = new StringBuilder(); sb.AppendLine("BUILDINGS");
                foreach(var b in snap.buildings) sb.AppendLine($"{b.id} x{b.count}");
                txtBuildings.text = sb.ToString();
            }
        }
    }
}
""")

write_file(r"Frontend\Views\TaskLogView.cs", """
using UnityEngine; using UnityEngine.UI; using System.Text;
namespace TheBonwater.Rebuild {
    public class TaskLogView : MonoBehaviour {
        public Text txtLog;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtLog != null) {
                var sb = new StringBuilder(); sb.AppendLine("TASK LOG");
                foreach(var log in snap.taskLogs) sb.AppendLine($"- {log}");
                txtLog.text = sb.ToString();
            }
        }
    }
}
""")

write_file(r"Frontend\Views\DebugStateView.cs", """
using UnityEngine; using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class DebugStateView : MonoBehaviour {
        public Text txtDebug;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtDebug != null) txtDebug.text = "Debug Raw Snapshot\\n" + JsonUtility.ToJson(snap, true);
        }
    }
}
""")

# Empty out old presenters and unused views to avoid conflicts
write_file(r"Frontend\Presenters\TownPresenter.cs", "// empty")
write_file(r"Frontend\Presenters\ResourceBarPresenter.cs", "// empty")
write_file(r"Frontend\Presenters\BuildingPresenter.cs", "// empty")
write_file(r"Frontend\Presenters\VillagerPresenter.cs", "// empty")
write_file(r"Frontend\Presenters\BuildMenuPresenter.cs", "// empty")

print("Backend and Frontend architecture overwritten successfully via python!")
