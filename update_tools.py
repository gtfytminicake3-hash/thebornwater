import os

# Update TheBonwaterTestToolsWindow.cs
tools_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\TheBonwaterTestToolsWindow.cs"
with open(tools_path, "r", encoding="utf-8") as f:
    tools_code = f.read()

new_tools_code = """#if UNITY_EDITOR
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

        private void OnGUI() {
            GUILayout.Label("DEBUG_ONLY Test Tools", EditorStyles.boldLabel);
            GUILayout.Label("These actions must NOT be part of original gameplay.", EditorStyles.wordWrappedLabel);
            EditorGUILayout.Space();

            if (Application.isPlaying) {
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

                if (GUILayout.Button("Assign Test Builder")) {
                    GameServiceLocator.Backend?.Execute(new AssignWorkerCommand());
                    TownInteractionController.Instance?.RefreshUI();
                }

                if (GUILayout.Button("Trigger Raid Test")) {
                    GameServiceLocator.Backend?.Execute(new ForceRaidCommand());
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
                            if (GameServiceLocator.Backend is LocalGameBackend lb) lb.Test_DepositResourcesIntoConstruction(task.id);
                            TownInteractionController.Instance?.RefreshUI();
                        }
                        if (GUILayout.Button("Progress Fallback Labour (50)")) {
                            if (GameServiceLocator.Backend is LocalGameBackend lb) lb.Test_ProgressConstruction(task.id, 50);
                            TownInteractionController.Instance?.RefreshUI();
                        }
                        if (GUILayout.Button("Complete Construction")) {
                            if (GameServiceLocator.Backend is LocalGameBackend lb) lb.Test_CompleteConstruction(task.id);
                            TownInteractionController.Instance?.RefreshUI();
                        }
                    }
                } else {
                    GUILayout.Label("No active construction tasks.");
                }

                EditorGUILayout.Space();
                if (GUILayout.Button("Print Current Snapshot")) {
                    if (stateSnap != null) {
                        Debug.Log(JsonUtility.ToJson(stateSnap, true));
                    }
                }
            } else {
                GUILayout.Label("Enter Play Mode to use these tools.");
            }
        }
    }
}
#endif
"""
with open(tools_path, "w", encoding="utf-8") as f:
    f.write(new_tools_code)

# Update BuildingListView.cs to render tasks
ui_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Frontend\Views\BuildingListView.cs"
new_ui_code = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class BuildingListView : MonoBehaviour {
        public Text txtList;

        public void UpdateView(GameSnapshot snapshot) {
            if (txtList == null) return;
            string s = "Buildings:\\n";
            if (snapshot.buildings != null) {
                foreach (var b in snapshot.buildings) {
                    if (b.count > 0) s += $"- {b.id}: {b.count}\\n";
                }
            }
            if (snapshot.tasks != null && snapshot.tasks.Count > 0) {
                s += "\\nConstructions:\\n";
                foreach (var t in snapshot.tasks) {
                    if (t.status == "AwaitingResources") s += $"- {t.targetBuildingId} awaiting resources\\n";
                    else s += $"- {t.targetBuildingId} under construction ({t.currentCompletion}/{t.finalCompletion})\\n";
                }
            }
            txtList.text = s;
        }
    }
}
"""
with open(ui_path, "w", encoding="utf-8") as f:
    f.write(new_ui_code)

print("Editor and UI files updated.")
