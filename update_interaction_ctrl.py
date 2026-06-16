import sys

file_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Frontend\TownInteractionController.cs"

with open(file_path, "r", encoding="utf-8") as f:
    content = f.read()

replacement = """using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TheBonwater.Rebuild.Diagnostics;

namespace TheBonwater.Rebuild {
    public class TownInteractionController : MonoBehaviour {
        public static TownInteractionController Instance;

        public Button btnSelectVillager;
        public Button btnAssignWorker;
        public Button btnNextPhase;
        public Button btnSave; 
        public Button btnLoad;
        public delegate void StateChangedHandler(GameSnapshot snapshot);
        public event StateChangedHandler OnStateChanged;
        private void Awake() { Instance = this; }
        private void Start() {
            if (GameServiceLocator.Backend == null) GameServiceLocator.RegisterBackend(new LocalGameBackend());
            
            // DEBUG_ONLY: Disable all debug/prototype buttons from player HUD
            if (btnSelectVillager != null) btnSelectVillager.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=SelectVillager Scene=TownScene"); ExecuteCommand(new SelectNextVillagerCommand()); });
            if (btnAssignWorker != null) btnAssignWorker.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=AssignWorker Scene=TownScene"); ExecuteCommand(new AssignWorkerCommand()); });
            if (btnNextPhase != null) btnNextPhase.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=NextPhase Scene=TownScene"); ExecuteCommand(new AdvanceTimeCommand()); });
            if (btnSave != null) btnSave.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=Save Scene=TownScene"); ExecuteCommand(new SaveGameCommand()); });
            if (btnLoad != null) btnLoad.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=Load Scene=TownScene"); ExecuteCommand(new LoadGameCommand()); });
            
            RefreshUI();
        }

        public void ExecuteCommand(GameCommand cmd) {
            RuntimeTrace.Log("BACKEND_COMMAND", $"Command={cmd.GetType().Name}");
            var snapBefore = GameServiceLocator.Backend.GetSnapshot();
            RuntimeTrace.Log("BACKEND_STATE_BEFORE", $"Wood={snapBefore.wood} Buildings={snapBefore.buildings.Count} Tasks={snapBefore.tasks.Count}");
            
            GameServiceLocator.Backend.Execute(cmd);
            
            var snapAfter = GameServiceLocator.Backend.GetSnapshot();
            RuntimeTrace.Log("BACKEND_STATE_AFTER", $"Wood={snapAfter.wood} Buildings={snapAfter.buildings.Count} Tasks={snapAfter.tasks.Count}");
            
            RefreshUI();
        }
        public void RefreshUI() {
            var snap = GameServiceLocator.Backend.GetSnapshot();
            OnStateChanged?.Invoke(snap);
        }
    }
}
"""

with open(file_path, "w", encoding="utf-8") as f:
    f.write(replacement)

print("Updated TownInteractionController.")
