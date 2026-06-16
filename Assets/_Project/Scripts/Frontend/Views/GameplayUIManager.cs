using UnityEngine;
using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    public class GameplayUIManager : MonoBehaviour {
        public static GameplayUIManager Instance;

        public TopResourceBarView topResourceBar;
        public LeftStatusPanelView leftStatusPanel;
        public BuildMenuPanelView buildMenuPanel;
        public SelectedVillagerPanelView selectedVillagerPanel;
        public ConstructionPanelView constructionPanel;
        public TaskLogView eventLogPanel;

        private void Awake() { Instance = this; }

        private void Start() {
            if (buildMenuPanel != null) {
                buildMenuPanel.gameObject.SetActive(false);
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Init BuildMenuPanel active=false");
            }
            
            var bottomActionBar = GameObject.Find("BottomActionBar");
            bool hasBuild = false;
            bool hasNext = bottomActionBar?.transform.Find("Next Phase") != null;
            bool hasSave = bottomActionBar?.transform.Find("Save") != null;
            bool hasLoad = bottomActionBar?.transform.Find("Load") != null;

            if (bottomActionBar != null) {
                var btnOpenBuildMenuTransform = bottomActionBar.transform.Find("BtnOpenBuildMenu");
                if (btnOpenBuildMenuTransform != null) {
                    hasBuild = true;
                    var btnCmp = btnOpenBuildMenuTransform.GetComponent<UnityEngine.UI.Button>();
                    if (btnCmp != null) {
                        btnCmp.navigation = new UnityEngine.UI.Navigation { mode = UnityEngine.UI.Navigation.Mode.None };
                        btnCmp.onClick.RemoveAllListeners();
                        btnCmp.onClick.AddListener(() => {
                            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Build button clicked");
                            ToggleBuildMenu();
                        });
                    }
                } else {
                    Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI_ERROR", "BtnOpenBuildMenu missing from BottomActionBar");
                }
            }
            if (buildMenuPanel != null) {
                var btnCloseTransform = buildMenuPanel.transform.Find("HeaderCloseArea/BtnCloseBuildMenu");
                if (btnCloseTransform != null) {
                    var btnClose = btnCloseTransform.GetComponent<UnityEngine.UI.Button>();
                    if (btnClose != null) {
                        btnClose.navigation = new UnityEngine.UI.Navigation { mode = UnityEngine.UI.Navigation.Mode.None };
                        btnClose.onClick.RemoveAllListeners();
                        btnClose.onClick.AddListener(() => {
                            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Close BuildMenu clicked");
                            CloseBuildMenu();
                        });
                    }
                }
            } else {
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI_ERROR", "BuildMenuPanel missing");
            }

            if (selectedVillagerPanel != null && selectedVillagerPanel.btnCycleJobDev != null) {
                selectedVillagerPanel.btnCycleJobDev.onClick.RemoveAllListeners();
                selectedVillagerPanel.btnCycleJobDev.onClick.AddListener(() => {
                    var snap = GameServiceLocator.Backend?.GetSnapshot();
                    if (snap != null && snap.selectedVillagerIndex >= 0 && snap.selectedVillagerIndex < snap.villagers.Count) {
                        string vName = snap.villagers[snap.selectedVillagerIndex].name;
                        string beforeJob = snap.villagers[snap.selectedVillagerIndex].job;
                        TownInteractionController.Instance?.ExecuteCommand(new AssignWorkerCommand());
                        var snapAfter = GameServiceLocator.Backend?.GetSnapshot();
                        string afterJob = snapAfter?.villagers[snapAfter.selectedVillagerIndex].job;
                        Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"AssignWorker clicked villager={vName} before={beforeJob} after={afterJob}");
                        if (beforeJob == afterJob) {
                            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI_ERROR", "AssignWorker clicked but job did not change");
                        }
                    }
                });
            }

            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"BottomActionBar buttons: Build={hasBuild} NextPhase={hasNext} Save={hasSave} Load={hasLoad}");

            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.OnStateChanged += HandleStateChanged;
                // Force an initial refresh if backend already exists
                TownInteractionController.Instance.RefreshUI();
            }
        }

        private void OnDestroy() {
            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.OnStateChanged -= HandleStateChanged;
            }
        }

        public void HandleStateChanged(GameSnapshot snap) {
            if (snap == null) return;
            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Snapshot refresh day={snap.day} phase={snap.timeOfDay} tasks={snap.tasks.Count} buildings={snap.buildings.Count}");

            if (topResourceBar != null) topResourceBar.UpdateView(snap);
            if (leftStatusPanel != null) leftStatusPanel.UpdateView(snap);
            if (buildMenuPanel != null && buildMenuPanel.gameObject.activeSelf) buildMenuPanel.UpdateView(snap);
            if (selectedVillagerPanel != null) selectedVillagerPanel.UpdateView(snap);
            if (constructionPanel != null) constructionPanel.UpdateView(snap);
            if (eventLogPanel != null) eventLogPanel.UpdateView(snap);
        }

        public void ToggleBuildMenu() {
            if (buildMenuPanel == null) return;

            if (buildMenuPanel.gameObject.activeSelf)
                CloseBuildMenu();
            else
                OpenBuildMenu();
        }

        public void OpenBuildMenu() {
            if (buildMenuPanel != null) {
                buildMenuPanel.gameObject.SetActive(true);
                if (GameServiceLocator.Backend != null) {
                    buildMenuPanel.UpdateView(GameServiceLocator.Backend.GetSnapshot());
                }
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
            }
        }

        public void CloseBuildMenu() {
            if (buildMenuPanel != null) {
                buildMenuPanel.gameObject.SetActive(false);
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "BuildMenu closed");
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
            }
        }
    }
}
