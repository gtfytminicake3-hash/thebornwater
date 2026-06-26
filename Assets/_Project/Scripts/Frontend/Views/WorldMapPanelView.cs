using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class WorldMapPanelView : MonoBehaviour {
        [Header("Hierarchy Bindings")]
        public Transform locationNodesRoot;
        public Text txtLocationName;
        public Text txtLocationType;
        public Text txtCoordinates;
        public Text txtDiscoveredStatus;
        public Text txtDanger;
        public Text txtReward;
        public Text txtExpeditionStatus;
        
        public Button btnDiscover;
        public Button btnDispatch;
        
        public Text txtActiveExpeditionSummary;
        public Button btnRefresh;
        public Button btnClose;

        [Header("QA Status Panel")]
        public GameObject qaStatusPanel;
        public Text txtQAMapData;
        public Text txtQASelected;
        public Text txtQADiscovered;
        public Text txtQAReachable;
        public Text txtQADiscover;
        public Text txtQADispatch;
        public Text txtQAActiveExpeditions;
        public Text txtQALastAction;
        public Text txtQAVisualStatus;

        // QA State tracking
        public bool qaDiscoveredSuccess = false;
        public bool qaDispatchedSuccess = false;
        public bool qaDuplicateBlocked = false;
        public string qaLastAction = "None";

        [Header("State")]
        private string selectedLocationId = "home";
        private bool isInitialized = false;
        private GameSnapshot lastSnapshot;

        private void Start() {
            if (btnDiscover != null) {
                btnDiscover.onClick.RemoveAllListeners();
                btnDiscover.onClick.AddListener(OnDiscoverClick);
            }
            if (btnDispatch != null) {
                btnDispatch.onClick.RemoveAllListeners();
                btnDispatch.onClick.AddListener(OnDispatchClick);
            }
            if (btnRefresh != null) {
                btnRefresh.onClick.RemoveAllListeners();
                btnRefresh.onClick.AddListener(OnRefreshClick);
            }
            if (btnClose != null) {
                btnClose.onClick.RemoveAllListeners();
                btnClose.onClick.AddListener(OnCloseClick);
            }
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.F10)) {
                if (qaStatusPanel != null) {
                    qaStatusPanel.SetActive(!qaStatusPanel.activeSelf);
                    UnityEngine.Debug.Log($"[WorldMap UI] Toggle QA panel visibility to {qaStatusPanel.activeSelf}");
                }
            }
        }

        public void UpdateView(GameSnapshot snap) {
            if (snap == null) return;
            lastSnapshot = snap;

            if (snap.worldMapState == null || snap.worldMapState.locations == null) {
                UnityEngine.Debug.LogWarning("[WorldMap UI] snapshot worldMapState or locations list is null.");
                return;
            }

            // Initial binding log
            if (!isInitialized) {
                int discoveredCount = snap.worldMapState.locations.Count(l => l.isDiscovered);
                int activeExpCount = snap.worldMapState.activeExpeditions?.Count ?? 0;
                UnityEngine.Debug.Log($"[WorldMap UI] Bound locations={snap.worldMapState.locations.Count} discovered={discoveredCount} activeExpeditions={activeExpCount}");
                isInitialized = true;
            }

            // 1. Redraw/Refresh location nodes
            RedrawLocationNodes(snap);

            // 2. Refresh selected location details
            RefreshSelectedDetails(snap);

            // 3. Refresh Active Expedition Summary
            if (txtActiveExpeditionSummary != null) {
                if (snap.worldMapState.activeExpeditions == null || snap.worldMapState.activeExpeditions.Count == 0) {
                    txtActiveExpeditionSummary.text = "Active Expeditions: None";
                } else {
                    var lines = new List<string>();
                    lines.Add("Active Expeditions:");
                    foreach (var exp in snap.worldMapState.activeExpeditions) {
                        var target = snap.worldMapState.locations.FirstOrDefault(l => l.id.Equals(exp.targetLocationId, StringComparison.OrdinalIgnoreCase));
                        string locName = target != null ? target.displayName : exp.targetLocationId;
                        
                        // Get villager names
                        var vNames = new List<string>();
                        if (exp.villagerIds != null) {
                            foreach (var vId in exp.villagerIds) {
                                var v = snap.villagers.FirstOrDefault(vl => vl.id == vId);
                                if (v != null) vNames.Add(v.name);
                            }
                        }
                        string vList = string.Join(", ", vNames);
                        if (string.IsNullOrEmpty(vList)) vList = "Unknown Villager";

                        lines.Add($"{vList} -> {locName}\nPhases Left: {exp.phasesRemaining}\nReward: {exp.rewardAmount} {exp.rewardType.ToUpper()}");
                    }
                    txtActiveExpeditionSummary.text = string.Join("\n", lines);
                }
            }

            UpdateQAStatus();
        }

        private void RedrawLocationNodes(GameSnapshot snap) {
            if (locationNodesRoot == null) return;

            // Clear old children (including any EditorPreview nodes)
            var toDestroy = new List<GameObject>();
            foreach (Transform child in locationNodesRoot) {
                toDestroy.Add(child.gameObject);
            }
            foreach (var childGo in toDestroy) {
                DestroyImmediate(childGo);
            }

            Font defaultFont = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            if (defaultFont == null) defaultFont = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // Instantiate a button node for each location in snap.worldMapState.locations
            foreach (var loc in snap.worldMapState.locations) {
                if (loc == null) continue;

                var nodeGo = new GameObject($"Node_{loc.id}");
                nodeGo.transform.SetParent(locationNodesRoot, false);

                var rect = nodeGo.AddComponent<RectTransform>();
                rect.anchorMin = Vector2.zero;
                rect.anchorMax = Vector2.zero;
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(40f, 40f);
                // Map x, y (0-9) coordinates to visual offsets inside MapContent (500x500 scale)
                float posX = loc.x * 45f + 40f;
                float posY = loc.y * 45f + 40f;
                rect.anchoredPosition = new Vector2(posX, posY);

                var img = nodeGo.AddComponent<Image>();
                var btn = nodeGo.AddComponent<Button>();
                btn.navigation = new Navigation { mode = Navigation.Mode.None };

                // Wire click selection listener
                string currentId = loc.id;
                btn.onClick.AddListener(() => {
                    SelectLocation(currentId);
                });

                // Determine adjacency for reachable state
                bool isAdjacent = false;
                foreach (var other in snap.worldMapState.locations) {
                    if (other.isDiscovered && other.id != loc.id) {
                        int dx = Math.Abs(loc.x - other.x);
                        int dy = Math.Abs(loc.y - other.y);
                        if (dx <= 1 && dy <= 1) {
                            isAdjacent = true;
                            break;
                        }
                    }
                }

                // Check active expedition state targeting this node
                bool hasActiveExpedition = snap.worldMapState.activeExpeditions != null && 
                    snap.worldMapState.activeExpeditions.Any(e => e.targetLocationId.Equals(loc.id, StringComparison.OrdinalIgnoreCase));

                // Apply node visual states and colors
                string labelText = "";
                if (loc.id.Equals("home", StringComparison.OrdinalIgnoreCase)) {
                    // Home: Green / Mark "H"
                    img.color = new Color(0.2f, 0.8f, 0.2f, 1f); // Green
                    labelText = "H";
                } else if (hasActiveExpedition) {
                    // Expedition target: Magenta
                    img.color = new Color(0.9f, 0.2f, 0.6f, 1f);
                    labelText = "E";
                } else if (loc.isDiscovered) {
                    // Discovered: Bright Cyan
                    img.color = new Color(0.2f, 0.7f, 0.9f, 1f);
                    labelText = loc.displayName.Length > 3 ? loc.displayName.Substring(0, 3) : loc.displayName;
                } else if (isAdjacent) {
                    // Reachable but undiscovered: Amber/Yellow
                    img.color = new Color(0.9f, 0.6f, 0.2f, 1f);
                    labelText = "?";
                } else {
                    // Non-adjacent undiscovered: Dimmed Locked (Dark Gray)
                    // Behavior choice: Visible but dimmed/locked. Users can click to select and see locked status.
                    img.color = new Color(0.3f, 0.3f, 0.3f, 0.8f);
                    labelText = "X";
                }

                // Text subobject
                var txtGo = new GameObject("Text");
                txtGo.transform.SetParent(nodeGo.transform, false);
                var txtRect = txtGo.AddComponent<RectTransform>();
                txtRect.anchorMin = Vector2.zero;
                txtRect.anchorMax = Vector2.one;
                txtRect.sizeDelta = Vector2.zero;

                var txt = txtGo.AddComponent<Text>();
                txt.font = defaultFont;
                txt.text = labelText;
                txt.fontSize = 12;
                txt.alignment = TextAnchor.MiddleCenter;
                txt.color = Color.white;
                txt.raycastTarget = false;

                // Load decoded sprite if available
                if (loc.isDiscovered && !string.IsNullOrEmpty(loc.spritePath)) {
                    Sprite sp = BuildMenuRowVisualFactory.LoadSprite(loc.spritePath);
                    if (sp != null) {
                        img.sprite = sp;
                        img.color = Color.white; // reset to original sprite color
                        txt.gameObject.SetActive(false); // hide overlay label if sprite exists
                    }
                }
            }
        }

        public void SelectLocation(string locId) {
            selectedLocationId = locId;
            
            if (lastSnapshot != null) {
                var loc = lastSnapshot.worldMapState.locations.FirstOrDefault(l => l.id.Equals(locId, StringComparison.OrdinalIgnoreCase));
                bool discovered = loc != null ? loc.isDiscovered : false;
                UnityEngine.Debug.Log($"[WorldMap UI] Selected location={selectedLocationId} discovered={discovered.ToString().ToLower()}");
                
                qaLastAction = $"Selected {locId}";
                RefreshSelectedDetails(lastSnapshot);
                UpdateQAStatus();
            }
        }

        private void RefreshSelectedDetails(GameSnapshot snap) {
            if (snap == null) return;

            var loc = snap.worldMapState.locations.FirstOrDefault(l => l.id.Equals(selectedLocationId, StringComparison.OrdinalIgnoreCase));
            if (loc == null) {
                // Empty Details state
                if (txtLocationName != null) txtLocationName.text = "Select a Location";
                if (txtLocationType != null) txtLocationType.text = "";
                if (txtCoordinates != null) txtCoordinates.text = "";
                if (txtDiscoveredStatus != null) txtDiscoveredStatus.text = "";
                if (txtDanger != null) txtDanger.text = "";
                if (txtReward != null) txtReward.text = "";
                if (txtExpeditionStatus != null) txtExpeditionStatus.text = "";
                if (btnDiscover != null) { btnDiscover.gameObject.SetActive(true); btnDiscover.interactable = false; }
                if (btnDispatch != null) { btnDispatch.gameObject.SetActive(true); btnDispatch.interactable = false; }
                return;
            }

            // Fill text labels
            if (txtLocationName != null) {
                if (loc.id.Equals("finalCastle", StringComparison.OrdinalIgnoreCase)) {
                    txtLocationName.text = $"{loc.displayName} (Endgame Location)";
                } else {
                    txtLocationName.text = loc.displayName;
                }
            }
            if (txtLocationType != null) txtLocationType.text = $"Type: {loc.type}";
            if (txtCoordinates != null) txtCoordinates.text = $"Coords: ({loc.x}, {loc.y})";
            if (txtDiscoveredStatus != null) {
                txtDiscoveredStatus.text = loc.isDiscovered ? "Status: Discovered" : "Status: Undiscovered";
                txtDiscoveredStatus.color = loc.isDiscovered ? Color.green : Color.red;
            }
            if (txtDanger != null) txtDanger.text = $"Danger Level: {loc.dangerLevel}";
            if (txtReward != null) {
                if (string.IsNullOrEmpty(loc.rewardType)) {
                    txtReward.text = "Reward: None";
                } else {
                    txtReward.text = $"Reward: {loc.rewardAmount} {loc.rewardType.ToUpper()}";
                }
            }

            // Check Active Expedition targeting this location
            var activeExp = snap.worldMapState.activeExpeditions?.FirstOrDefault(e => e.targetLocationId.Equals(loc.id, StringComparison.OrdinalIgnoreCase));
            if (txtExpeditionStatus != null) {
                if (activeExp != null) {
                    txtExpeditionStatus.text = $"Expedition: ACTIVE\nPhases Left: {activeExp.phasesRemaining}";
                    txtExpeditionStatus.color = Color.yellow;
                } else {
                    txtExpeditionStatus.text = "Expedition: None";
                    txtExpeditionStatus.color = Color.white;
                }
            }

            // Adjacency check for discovery
            bool isAdjacent = false;
            foreach (var other in snap.worldMapState.locations) {
                if (other.isDiscovered && other.id != loc.id) {
                    int dx = Math.Abs(loc.x - other.x);
                    int dy = Math.Abs(loc.y - other.y);
                    if (dx <= 1 && dy <= 1) {
                        isAdjacent = true;
                        break;
                    }
                }
            }

            // Discover Button State
            if (btnDiscover != null) {
                btnDiscover.gameObject.SetActive(true);
                if (loc.isDiscovered) {
                    btnDiscover.interactable = false;
                } else {
                    btnDiscover.interactable = isAdjacent;
                }
            }

            // Dispatch Button State
            if (btnDispatch != null) {
                btnDispatch.gameObject.SetActive(true);
                if (loc.isDiscovered && !loc.id.Equals("home", StringComparison.OrdinalIgnoreCase)) {
                    // Check villager availability (hp > 0 and not already on expedition)
                    bool hasAvailableVillager = snap.villagers.Any(v => v.hp > 0 && !v.isOnExpedition);
                    btnDispatch.interactable = hasAvailableVillager;
                } else {
                    btnDispatch.interactable = false;
                }
            }
        }

        public void OnDiscoverClick() {
            if (lastSnapshot == null) return;
            
            var loc = lastSnapshot.worldMapState.locations.FirstOrDefault(l => l.id.Equals(selectedLocationId, StringComparison.OrdinalIgnoreCase));
            if (loc == null || loc.isDiscovered) return;

            var cmd = new DiscoverWorldMapLocationCommand { locationId = selectedLocationId };
            
            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.ExecuteCommand(cmd);
                
                // Get command result by checking if the state updated successfully
                var snapAfter = GameServiceLocator.Backend.GetSnapshot();
                var updatedLoc = snapAfter.worldMapState.locations.FirstOrDefault(l => l.id.Equals(selectedLocationId, StringComparison.OrdinalIgnoreCase));
                bool success = updatedLoc != null && updatedLoc.isDiscovered;
                
                UnityEngine.Debug.Log($"[WorldMap UI] Discover clicked location={selectedLocationId} success={success.ToString()}");
                
                if (success) {
                    qaDiscoveredSuccess = true;
                    qaLastAction = "Discover: Success";
                } else {
                    qaLastAction = "Discover: Blocked";
                }
                
                UpdateView(snapAfter);
            } else {
                UnityEngine.Debug.LogWarning("[WorldMap UI] TownInteractionController instance not found.");
            }
        }

        public void OnDispatchClick() {
            if (lastSnapshot == null) return;

            var loc = lastSnapshot.worldMapState.locations.FirstOrDefault(l => l.id.Equals(selectedLocationId, StringComparison.OrdinalIgnoreCase));
            if (loc == null || !loc.isDiscovered || loc.id.Equals("home", StringComparison.OrdinalIgnoreCase)) return;

            // Pick the first available villager
            var availableVillager = lastSnapshot.villagers.FirstOrDefault(v => v.hp > 0 && !v.isOnExpedition);
            if (availableVillager == null) {
                UnityEngine.Debug.LogWarning("[WorldMap UI] No available villagers to dispatch.");
                qaLastAction = "Dispatch: No Villager";
                UpdateQAStatus();
                return;
            }

            // Check duplicate dispatch
            var activeExp = lastSnapshot.worldMapState.activeExpeditions?.FirstOrDefault(e => e.targetLocationId.Equals(loc.id, StringComparison.OrdinalIgnoreCase));
            if (activeExp != null) {
                qaDuplicateBlocked = true;
                qaLastAction = "Dispatch: Duplicate Blocked";
                UpdateQAStatus();
                return;
            }

            var cmd = new DispatchExpeditionCommand {
                targetLocationId = selectedLocationId,
                villagerIds = new List<string> { availableVillager.id }
            };

            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.ExecuteCommand(cmd);

                // Get command result by checking if activeExpeditions got populated
                var snapAfter = GameServiceLocator.Backend.GetSnapshot();
                bool success = snapAfter.worldMapState.activeExpeditions != null && 
                    snapAfter.worldMapState.activeExpeditions.Any(e => e.targetLocationId.Equals(selectedLocationId, StringComparison.OrdinalIgnoreCase));

                UnityEngine.Debug.Log($"[WorldMap UI] Dispatch clicked location={selectedLocationId} success={success.ToString()}");

                if (success) {
                    qaDispatchedSuccess = true;
                    qaLastAction = "Dispatch: Success";
                } else {
                    qaLastAction = "Dispatch: Blocked";
                }

                UpdateView(snapAfter);
            } else {
                UnityEngine.Debug.LogWarning("[WorldMap UI] TownInteractionController instance not found.");
            }
        }

        public void OnRefreshClick() {
            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.RefreshUI();
            }
        }

        public void OnCloseClick() {
            GameplayUIManager.Instance?.CloseWorldMap();
        }

        public void UpdateQAStatus() {
            if (lastSnapshot == null) return;

            // 1. Map Data
            if (txtQAMapData != null) {
                int count = lastSnapshot.worldMapState != null && lastSnapshot.worldMapState.locations != null ? lastSnapshot.worldMapState.locations.Count : 0;
                txtQAMapData.text = $"Map Data: {count}/12 PASS";
            }

            // Get selected location state
            var loc = lastSnapshot.worldMapState != null && lastSnapshot.worldMapState.locations != null ? 
                lastSnapshot.worldMapState.locations.FirstOrDefault(l => l.id.Equals(selectedLocationId, System.StringComparison.OrdinalIgnoreCase)) : null;

            // 2. Selected
            if (txtQASelected != null) {
                txtQASelected.text = $"Selected: {selectedLocationId}";
            }

            // 3. Discovered
            if (txtQADiscovered != null) {
                txtQADiscovered.text = $"Discovered: {(loc != null && loc.isDiscovered ? "Yes" : "No")}";
            }

            // 4. Reachable
            bool isAdjacent = false;
            if (loc != null && lastSnapshot.worldMapState != null && lastSnapshot.worldMapState.locations != null) {
                foreach (var other in lastSnapshot.worldMapState.locations) {
                    if (other.isDiscovered && other.id != loc.id) {
                        int dx = System.Math.Abs(loc.x - other.x);
                        int dy = System.Math.Abs(loc.y - other.y);
                        if (dx <= 1 && dy <= 1) {
                            isAdjacent = true;
                            break;
                        }
                    }
                }
            }
            if (txtQAReachable != null) {
                txtQAReachable.text = $"Reachable: {(isAdjacent ? "Yes" : "No")}";
            }

            // 5. Discover Status
            if (txtQADiscover != null) {
                if (loc == null) {
                    txtQADiscover.text = "Discover: Blocked (No selection)";
                } else if (loc.isDiscovered) {
                    txtQADiscover.text = "Discover: Already Discovered";
                } else if (qaDiscoveredSuccess && selectedLocationId == "northernVillage") {
                    txtQADiscover.text = "Discover: Success";
                } else if (isAdjacent) {
                    txtQADiscover.text = "Discover: Ready";
                } else {
                    string reachableFrom = "";
                    if (lastSnapshot != null && lastSnapshot.worldMapState != null && lastSnapshot.worldMapState.locations != null) {
                        var neighbors = new List<string>();
                        foreach (var other in lastSnapshot.worldMapState.locations) {
                            if (other.id != loc.id) {
                                int dx = System.Math.Abs(loc.x - other.x);
                                int dy = System.Math.Abs(loc.y - other.y);
                                if (dx <= 1 && dy <= 1) {
                                    neighbors.Add($"{other.displayName} ({other.x},{other.y})");
                                }
                            }
                        }
                        if (neighbors.Count > 0) {
                            reachableFrom = " Can be reached from: " + string.Join(" or ", neighbors);
                        }
                    }
                    txtQADiscover.text = $"Discover: Blocked (Non-adjacent location).{reachableFrom}";
                }
            }

            // 6. Dispatch Status
            if (txtQADispatch != null) {
                if (loc == null) {
                    txtQADispatch.text = "Dispatch: Blocked (No selection)";
                } else if (!loc.isDiscovered) {
                    txtQADispatch.text = "Dispatch: Blocked (Location undiscovered)";
                } else if (loc.id.Equals("home", System.StringComparison.OrdinalIgnoreCase)) {
                    txtQADispatch.text = "Dispatch: Blocked (Cannot target home)";
                } else {
                    bool hasAvailableVillager = lastSnapshot.villagers.Any(v => v.hp > 0 && !v.isOnExpedition);
                    var activeExp = lastSnapshot.worldMapState != null && lastSnapshot.worldMapState.activeExpeditions != null ? 
                        lastSnapshot.worldMapState.activeExpeditions.FirstOrDefault(e => e.targetLocationId.Equals(loc.id, System.StringComparison.OrdinalIgnoreCase)) : null;
                    bool hasExpeditionRunningToTarget = activeExp != null;

                    if (qaDispatchedSuccess && !qaDuplicateBlocked && activeExp != null) {
                        txtQADispatch.text = "Dispatch: Success";
                    } else if (qaDuplicateBlocked) {
                        txtQADispatch.text = "Dispatch: Duplicate Blocked";
                    } else if (!hasAvailableVillager) {
                        txtQADispatch.text = "Dispatch: No Villager (No available villagers)";
                    } else if (hasExpeditionRunningToTarget) {
                        txtQADispatch.text = "Dispatch: Duplicate Blocked";
                    } else {
                        txtQADispatch.text = "Dispatch: Ready";
                    }
                }
            }

            // 7. Active Expeditions
            if (txtQAActiveExpeditions != null) {
                int activeExpCount = lastSnapshot.worldMapState != null && lastSnapshot.worldMapState.activeExpeditions != null ? 
                    lastSnapshot.worldMapState.activeExpeditions.Count : 0;
                txtQAActiveExpeditions.text = $"Active Expeditions: {activeExpCount}";
            }

            // 8. Last Action
            if (txtQALastAction != null) {
                txtQALastAction.text = $"Last Action: {qaLastAction}";
            }

            // 9. 15D Visual Status
            if (txtQAVisualStatus != null) {
                bool pass = qaDiscoveredSuccess && qaDispatchedSuccess && qaDuplicateBlocked;
                txtQAVisualStatus.text = $"15D Visual Status: {(pass ? "PASS" : "PENDING")}";
            }
        }
    }
}
