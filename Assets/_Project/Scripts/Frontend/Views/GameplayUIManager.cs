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
        public WorldMapPanelView worldMapPanel;

        [Header("Trade Panel")]
        public GameObject tradePanel;
        public UnityEngine.UI.Button tradeOpenButton;
        public TradePanelView tradePanelView;
        
        [Header("Merchant Arrival Notification")]
        public MerchantNotificationView merchantNotificationView;

        [Header("Objective and Quest Notification")]
        public ObjectiveTrackerView objectiveTrackerView;
        public QuestAchievementNotificationView questNotificationView;

        [Header("Expedition Result Popup")]
        public GameObject panelExpeditionResult;
        public UnityEngine.UI.Text txtResultText;
        public UnityEngine.UI.Button btnResultOk;

        [Header("Titan Endgame Panel")]
        public TitanBossPanelView titanBossPanelView;

        private void Awake() { Instance = this; }

        public void OnResultOkClick() {
            UnityEngine.Debug.Log("[WorldMap UI] Dismiss report requested");
            TownInteractionController.Instance?.ExecuteCommand(new DismissExpeditionReportCommand());
            UnityEngine.Debug.Log("[WorldMap UI] Dismissed report");
        }

        private void Start() {
            if (panelExpeditionResult != null) {
                panelExpeditionResult.SetActive(false);
            }

            if (btnResultOk != null) {
                btnResultOk.onClick.RemoveAllListeners();
                btnResultOk.onClick.AddListener(OnResultOkClick);
            }

            if (selectedVillagerPanel == null) {
                UnityEngine.Debug.LogError("[GameplayUIManager] SelectedVillagerPanel is missing from the scene or not assigned to GameplayUIManager!");
            }

            if (buildMenuPanel != null) {
                buildMenuPanel.gameObject.SetActive(false);
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Init BuildMenuPanel active=false");
            }

            if (worldMapPanel != null) {
                worldMapPanel.gameObject.SetActive(false);
                UnityEngine.Debug.Log("[WorldMap UI] Play start hidden=True");
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Init WorldMapPanel active=false");
            }

            if (tradePanel != null) {
                tradePanel.SetActive(false);
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Init TradePanel active=false");
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

                var btnOpenWorldMapTransform = bottomActionBar.transform.Find("WorldMapOpenButton");
                if (btnOpenWorldMapTransform != null) {
                    var btnCmp = btnOpenWorldMapTransform.GetComponent<UnityEngine.UI.Button>();
                    if (btnCmp != null) {
                        btnCmp.navigation = new UnityEngine.UI.Navigation { mode = UnityEngine.UI.Navigation.Mode.None };
                        btnCmp.onClick.RemoveAllListeners();
                        btnCmp.onClick.AddListener(() => {
                            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "WorldMap open button clicked");
                            OpenWorldMap("WorldMapOpenButton");
                        });
                    }
                }

                if (tradeOpenButton != null) {
                    tradeOpenButton.navigation = new UnityEngine.UI.Navigation { mode = UnityEngine.UI.Navigation.Mode.None };
                    tradeOpenButton.onClick.RemoveAllListeners();
                    tradeOpenButton.onClick.AddListener(() => {
                        Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Trade open button clicked");
                        ToggleTradePanel();
                    });
                } else {
                    var btnOpenTradeTransform = bottomActionBar.transform.Find("TradeOpenButton");
                    if (btnOpenTradeTransform != null) {
                        var btnCmp = btnOpenTradeTransform.GetComponent<UnityEngine.UI.Button>();
                        if (btnCmp != null) {
                            btnCmp.navigation = new UnityEngine.UI.Navigation { mode = UnityEngine.UI.Navigation.Mode.None };
                            btnCmp.onClick.RemoveAllListeners();
                            btnCmp.onClick.AddListener(() => {
                                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "Trade open button clicked");
                                ToggleTradePanel();
                            });
                        }
                    }
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
            if (worldMapPanel != null && worldMapPanel.gameObject.activeSelf) worldMapPanel.UpdateView(snap);
            if (tradePanelView != null) tradePanelView.UpdateView(snap);
            if (merchantNotificationView != null) merchantNotificationView.UpdateView(snap);
            if (objectiveTrackerView != null) objectiveTrackerView.RenderState(snap);
            if (questNotificationView != null) {
                if (questNotificationView.BackendController == null) {
                    questNotificationView.Bind(GameServiceLocator.Backend);
                }
                questNotificationView.RenderState(snap);
            }

            if (titanBossPanelView != null) {
                titanBossPanelView.RenderState(snap);
            }

            if (tradeOpenButton != null) {
                var btnTxt = tradeOpenButton.GetComponentInChildren<UnityEngine.UI.Text>();
                if (btnTxt != null) {
                    btnTxt.text = (snap.tradeState != null && snap.tradeState.isMerchantPresent) ? "Trade!" : "Trade";
                }
            }

            if (panelExpeditionResult != null) {
                if (snap.pendingExpeditionReports != null && snap.pendingExpeditionReports.Count > 0) {
                    panelExpeditionResult.SetActive(true);
                    if (txtResultText != null) {
                        txtResultText.text = snap.pendingExpeditionReports[0];
                    }
                } else {
                    panelExpeditionResult.SetActive(false);
                }
            }
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

        public void ToggleWorldMap() {
            if (worldMapPanel == null) return;

            if (worldMapPanel.gameObject.activeSelf)
                CloseWorldMap("WorldMapOpenButton");
            else
                OpenWorldMap("WorldMapOpenButton");
        }

        public void OpenWorldMap(string source = "WorldMapOpenButton") {
            if (worldMapPanel != null) {
                UnityEngine.Debug.Log($"[WorldMap UI] Open requested source={source}");
                worldMapPanel.gameObject.SetActive(true);
                UnityEngine.Debug.Log($"[WorldMap UI] Opened active={worldMapPanel.gameObject.activeSelf.ToString()}");
                if (buildMenuPanel != null && buildMenuPanel.gameObject.activeSelf) {
                    CloseBuildMenu();
                }
                if (GameServiceLocator.Backend != null) {
                    worldMapPanel.UpdateView(GameServiceLocator.Backend.GetSnapshot());
                }
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
            }
        }

        public void CloseWorldMap(string source = "CloseButton") {
            if (worldMapPanel != null) {
                UnityEngine.Debug.Log($"[WorldMap UI] Close requested source={source}");
                worldMapPanel.gameObject.SetActive(false);
                UnityEngine.Debug.Log($"[WorldMap UI] Closed active={worldMapPanel.gameObject.activeSelf.ToString()}");
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "WorldMap closed");
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
            }
        }

        public void ToggleTradePanel() {
            if (tradePanel == null) return;
            if (tradePanel.activeSelf)
                CloseTradePanel();
            else
                OpenTradePanel();
        }

        public void OpenTradePanel() {
            if (tradePanel != null) {
                tradePanel.SetActive(true);
                if (GameServiceLocator.Backend != null) {
                    var snap = GameServiceLocator.Backend.GetSnapshot();
                    if (tradePanelView != null) {
                        tradePanelView.UpdateView(snap);
                    }
                }
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
            }
        }

        public void CloseTradePanel() {
            if (tradePanel != null) {
                tradePanel.SetActive(false);
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", "TradePanel closed");
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
            }
        }
    }
}
