using UnityEngine;
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
            
            var autoTime = GetComponent<AutoTimeController>();
            if (autoTime == null) {
                autoTime = gameObject.AddComponent<AutoTimeController>();
            }

            // DEBUG_ONLY: Disable all debug/prototype buttons from player HUD
            if (btnSelectVillager != null) btnSelectVillager.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=SelectVillager Scene=TownScene"); ExecuteCommand(new SelectNextVillagerCommand()); });
            if (btnAssignWorker != null) btnAssignWorker.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=AssignWorker Scene=TownScene"); ExecuteCommand(new AssignWorkerCommand()); });
            
            if (btnNextPhase != null) {
                var txt = btnNextPhase.GetComponentInChildren<Text>();
                if (txt != null) txt.text = "Next Phase (DEV)";

                btnNextPhase.onClick.AddListener(() => { 
                    RuntimeTrace.Log("UI_CLICK", "Button=NextPhase Scene=TownScene"); 
                    var snapBefore = GameServiceLocator.Backend?.GetSnapshot();
                    string oldPhase = snapBefore != null ? snapBefore.timeOfDay : "Unknown";
                    int oldDay = snapBefore != null ? snapBefore.day : 0;
                    
                    ExecuteCommand(new AdvanceTimeCommand()); 
                    
                    var snapAfter = GameServiceLocator.Backend?.GetSnapshot();
                    string newPhase = snapAfter != null ? snapAfter.timeOfDay : "Unknown";
                    int newDay = snapAfter != null ? snapAfter.day : 0;
                    
                    RuntimeTrace.Log("TIME_MANUAL_ADVANCE", $"from={oldPhase} to={newPhase} day={newDay}");
                    if (autoTime != null) autoTime.ResetTimer();
                });
            }

            if (btnSave != null) btnSave.onClick.AddListener(() => { RuntimeTrace.Log("UI_CLICK", "Button=Save Scene=TownScene"); ExecuteCommand(new SaveGameCommand()); });
            if (btnLoad != null) btnLoad.onClick.AddListener(() => { 
                RuntimeTrace.Log("UI_CLICK", "Button=Load Scene=TownScene"); 
                ExecuteCommand(new LoadGameCommand()); 
                if (autoTime != null) {
                    autoTime.ResetTimer();
                    autoTime.Play();
                    RuntimeTrace.Log("SAVELOAD_AUTO_TIME_RESET", "");
                }
                var snap = GameServiceLocator.Backend.GetSnapshot();
                var visualController = FindObjectOfType<TownRuntimeVisualController>();
                if (visualController != null) {
                    visualController.HandleLoadedSnapshot(snap);
                } else {
                    OnStateChanged?.Invoke(snap);
                }
            });
            
            RefreshUI();

            if (autoTime != null) {
                autoTime.ResetTimer();
                autoTime.Play();
            }
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
