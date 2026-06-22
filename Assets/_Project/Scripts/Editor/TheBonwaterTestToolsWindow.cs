#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using TheBonwater.Rebuild;
using System.Linq;

namespace TheBonwater.Rebuild.Editor {
    public class TheBonwaterTestToolsWindow : EditorWindow {
        [MenuItem("Tools/TheBonwater/Test Tools")]
        public static void ShowWindow() {
            GetWindow<TheBonwaterTestToolsWindow>("Bonwater Test Tools");
        }

        private string selectedTaskId = "";

        private void Update() {
            if (Application.isPlaying) {
                Repaint();
            }
        }

        private void OnGUI() {
            GUILayout.Label("DEBUG_ONLY Test Tools", EditorStyles.boldLabel);
            GUILayout.Label("These actions must NOT be part of original gameplay.", EditorStyles.wordWrappedLabel);
            EditorGUILayout.Space();

            if (Application.isPlaying) {
                if (GUILayout.Button("Next Phase")) {
                    GameServiceLocator.Backend?.Execute(new AdvanceTimeCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Advance Simulation Tick")) {
                    GameServiceLocator.Backend?.Execute(new AdvanceTimeCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Add Test Wood (+10)")) {
                    GameServiceLocator.Backend?.Execute(new CollectWoodCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Add Test Iron (+10)")) {
                    var state = GameServiceLocator.Backend?.GetSnapshot();
                    if (state != null) { state.iron += 10; TownInteractionController.Instance?.RefreshUI(); }
                }

                if (GUILayout.Button("Add Test Food (+10)")) {
                    var state = GameServiceLocator.Backend?.GetSnapshot();
                    if (state != null) { state.food += 10; TownInteractionController.Instance?.RefreshUI(); }
                }

                if (GUILayout.Button("Select Next Villager")) {
                    GameServiceLocator.Backend?.Execute(new SelectNextVillagerCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Assign Test Builder")) {
                    GameServiceLocator.Backend?.Execute(new AssignWorkerCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Spawn Villager (+1)")) {
                    GameServiceLocator.Backend?.Execute(new SpawnVillagerCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Trigger Raid Test")) {
                    GameServiceLocator.Backend?.Execute(new ForceRaidCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Save Game")) {
                    GameServiceLocator.Backend?.Execute(new SaveGameCommand());
                }

                if (GUILayout.Button("Load Game")) {
                    GameServiceLocator.Backend?.Execute(new LoadGameCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }
                
                EditorGUILayout.Space();
                GUILayout.Label("Construction Tests", EditorStyles.boldLabel);
                var stateSnap = GameServiceLocator.Backend?.GetSnapshot();
                if (stateSnap != null && stateSnap.tasks != null && stateSnap.tasks.Count > 0) {
                    var tasks = stateSnap.tasks.ToList();
                    string[] taskLabels = tasks.Select(t => t.targetBuildingId + " (" + t.status + ")").ToArray();
                    int selectedIndex = 0;
                    for (int i=0; i<tasks.Count; i++) if (tasks[i].id == selectedTaskId) selectedIndex = i;
                    
                    selectedIndex = EditorGUILayout.Popup("Select Task", selectedIndex, taskLabels);
                    if (selectedIndex >= 0 && selectedIndex < tasks.Count) {
                        selectedTaskId = tasks[selectedIndex].id;
                        var task = tasks[selectedIndex];
                        
                        if (GUILayout.Button("Deposit Test Resources")) {
                            if (GameServiceLocator.Backend is LocalGameBackend lb) lb.DepositResource(task.id);
                            TownInteractionController.Instance?.RefreshUI();
                        }
                        if (GUILayout.Button("Progress Fallback Labour (50)")) {
                            if (GameServiceLocator.Backend is LocalGameBackend lb) lb.UpdateConstruction(task.id, 50);
                            TownInteractionController.Instance?.RefreshUI();
                        }
                        if (GUILayout.Button("Complete Construction")) {
                            if (GameServiceLocator.Backend is LocalGameBackend lb) lb.FinishConstruction(task.id);
                            TownInteractionController.Instance?.RefreshUI();
                        }
                    }
                } else {
                    GUILayout.Label("No active construction tasks.");
                }

                EditorGUILayout.Space();
                if (GUILayout.Button("Print Current Snapshot")) {
                    if (stateSnap != null) {
                        UnityEngine.Debug.Log("==== RAW SNAPSHOT DUMP ====\n" + JsonUtility.ToJson(stateSnap, true));
                        foreach(var t in stateSnap.tasks) {
                            UnityEngine.Debug.Log($"[SNAPSHOT_TASK] targetBuildingId={t.targetBuildingId} progress={t.currentCompletion}/{t.finalCompletion}");
                        }
                    }
                }
                
                if (GUILayout.Button("Run Phase 7B Auto Time Loop Test")) {
                    TheBonwater.Rebuild.Tests.Phase7BAutoTimeLoopTest.RunTest();
                }

                if (GUILayout.Button("Run Phase 7C Health Recovery Test")) {
                    if (GameServiceLocator.Backend is LocalGameBackend lb) {
                        var snap = lb.GetSnapshot();
                        lb.Execute(new AdvanceTimeCommand()); // ensure we can transition
                        
                        // Force a villager to 90 HP
                        if (snap.villagers.Count > 0) {
                            snap.villagers[0].hp = 90;
                        }
                        // Force enough food
                        snap.food += 50;
                        
                        UnityEngine.Debug.Log("PHASE 7C TEST: Forced V1 HP to 90 and added 50 food. Please click 'Next Phase (DEV)' until Morning to see healing.");
                        TownInteractionController.Instance?.RefreshUI();
                    }
                }

                if (GUILayout.Button("Run Phase 8A Combat Targeting Test")) {
                    if (GameServiceLocator.Backend is LocalGameBackend lb) {
                        var snap = lb.GetSnapshot();
                        if (snap.villagers.Count >= 2) {
                            snap.villagers[0].job = "Guard";
                            snap.villagers[0].hp = 100;
                            snap.villagers[1].job = "Forager";
                            snap.villagers[1].hp = 100;
                            
                            // Advance to Evening
                            snap.timeOfDay = "Evening";
                            lb.Execute(new AdvanceTimeCommand()); // Will transition to Night and trigger Raid Check
                            
                            UnityEngine.Debug.Log("PHASE 8A TEST: Triggered Raid Check with V1=Guard, V2=Forager. Check EventLog/Console for who lost HP.");
                        } else {
                            UnityEngine.Debug.Log("PHASE 8A TEST: Need at least 2 villagers.");
                        }
                        TownInteractionController.Instance?.RefreshUI();
                    }
                }

                if (GUILayout.Button("Run Phase 7D Save/Load Test")) {
                    if (GameServiceLocator.Backend is LocalGameBackend lb) {
                        var snap = lb.GetSnapshot();
                        if (snap.villagers.Count >= 2) {
                            snap.villagers[0].job = "Woodcutter";
                            snap.villagers[1].hp = 80;
                        }
                        snap.wood -= 5;
                        lb.Execute(new SaveGameCommand());
                        
                        // Mutate
                        snap.wood += 500;
                        if (snap.villagers.Count >= 2) snap.villagers[1].hp = 10;
                        snap.day = 99;
                        
                        UnityEngine.Debug.Log("PHASE 7D TEST: Saved game with custom state, then heavily mutated current state. Click Load button in game HUD to verify restore.");
                        TownInteractionController.Instance?.RefreshUI();
                    }
                }

                if (GUILayout.Button("Run Phase 7 E2E Completion Test")) {
                    if (GameServiceLocator.Backend is LocalGameBackend lb) {
                        var snap = lb.GetSnapshot();
                        
                        // Setup miner and wait for time
                        if (snap.villagers.Count >= 2) {
                            snap.villagers[0].job = "Miner";
                            snap.villagers[1].job = "Woodcutter";
                        }
                        
                        // Give lots of food to test recruitment
                        snap.food = 100;
                        
                        // Build a hut to increase population
                        lb.Execute(new BuildHutCommand());
                        var hutTask = snap.tasks.FirstOrDefault(t => t.targetBuildingId == "hut");
                        if (hutTask != null) {
                            lb.DepositResource(hutTask.id);
                            lb.UpdateConstruction(hutTask.id, 1000);
                        }

                        // Advance to Morning to trigger recruitment and objective check
                        snap.timeOfDay = "Night";
                        snap.day = 3;
                        lb.Execute(new AdvanceTimeCommand()); // transitions to Day 3 Morning

                        UnityEngine.Debug.Log("PHASE 7 E2E TEST: Miner set, Food added, Hut built. Time advanced to Morning. Check EventLog for Recruitment, HUD for Population, Iron increase, and Objective Victory.");
                        TownInteractionController.Instance?.RefreshUI();
                    }
                }
            } else {
                GUILayout.Label("Enter Play Mode to use these tools.");
            }
        }
    }
}
#endif
