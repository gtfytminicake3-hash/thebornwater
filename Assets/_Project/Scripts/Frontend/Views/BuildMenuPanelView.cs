using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class BuildMenuPanelView : MonoBehaviour {
        public Transform contentRoot;
        private bool isInitialized = false;

        public void UpdateView(GameSnapshot snap) {
            if (snap == null) return;
            if (!isInitialized) {
                InitializeMenu();
            }

            // Update interactability based on resources
            if (GameServiceLocator.Backend?.repo != null) {
                var repo = GameServiceLocator.Backend.repo;
                foreach (Transform child in contentRoot) {
                    var btn = child.GetComponent<Button>();
                    if (btn != null && btn.name.StartsWith("BtnBuild_")) {
                        string bId = btn.name.Replace("BtnBuild_", "");
                        var bDef = repo.GetBuilding(bId);
                        if (bDef != null && bDef.costs != null) {
                            bool canAfford = true;
                            if (bDef.costs.TryGetValue("wood", out int w) && snap.wood < w) canAfford = false;
                            if (bDef.costs.TryGetValue("food", out int f) && snap.food < f) canAfford = false;
                            if (bDef.costs.TryGetValue("iron", out int i) && snap.iron < i) canAfford = false;
                            
                            btn.interactable = true; // explicitly keep interactable
                            
                            // Optional: Update text color or add warning label if can't afford
                            var txts = btn.GetComponentsInChildren<Text>();
                            foreach(var txt in txts) {
                                if (txt.name == "StatusText") {
                                    txt.text = canAfford ? "Available" : "Not enough resources";
                                    txt.color = canAfford ? Color.green : Color.red;
                                }
                            }
                        }
                    }
                    else if (btn != null && btn.name.StartsWith("BtnUpgrade_")) {
                        string bId = btn.name.Replace("BtnUpgrade_", "");
                        var bDef = repo.GetBuilding(bId);
                        
                        PlacedObject eligiblePlacement = null;
                        string blockedReason = "";
                        
                        if (snap.userPlacements != null) {
                            var completedOfThisType = new List<PlacedObject>();
                            var constructionsOfThisType = new List<PlacedObject>();
                            
                            foreach (var place in snap.userPlacements) {
                                if (place == null) continue;
                                string[] parts = place.id.Split(':');
                                if (parts.Length >= 3) {
                                    if (parts[0] == "building" && parts[1] == bId) completedOfThisType.Add(place);
                                    else if (parts[0] == "construction" && parts[1] == bId) constructionsOfThisType.Add(place);
                                }
                            }
                            
                            if (completedOfThisType.Count == 0) {
                                if (constructionsOfThisType.Count > 0) {
                                    blockedReason = "Under construction";
                                } else {
                                    string displayName = bId == "hut" ? "Hut" : (bId == "storage" ? "Storage" : bId);
                                    blockedReason = $"No completed {displayName} exists";
                                }
                            } else {
                                var level1List = completedOfThisType.Where(p => p.level == 1).ToList();
                                if (level1List.Count == 0) {
                                    blockedReason = "Already upgraded to Lv2";
                                } else {
                                    var notUpgrading = new List<PlacedObject>();
                                    foreach (var place in level1List) {
                                        bool isUpgrading = false;
                                        if (snap.tasks != null) {
                                            foreach (var t in snap.tasks) {
                                                if (t != null && t.type == "UpgradeBuilding" && t.targetPlacementId == place.id) {
                                                    isUpgrading = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (!isUpgrading) {
                                            notUpgrading.Add(place);
                                        }
                                    }
                                    
                                    if (notUpgrading.Count == 0) {
                                        blockedReason = "Upgrade in progress";
                                    } else {
                                        eligiblePlacement = notUpgrading[0];
                                    }
                                }
                            }
                        } else {
                            string displayName = bId == "hut" ? "Hut" : (bId == "storage" ? "Storage" : bId);
                            blockedReason = $"No completed {displayName} exists";
                        }

                        // Upgrade button is always visible in the Build Menu
                        btn.gameObject.SetActive(true);

                        if (eligiblePlacement != null && bDef != null && bDef.costs != null) {
                            int woodCost = 0;
                            int ironCost = 0;
                            if (bDef.costs.TryGetValue("wood", out int w)) woodCost = w * 2;
                            if (bDef.costs.TryGetValue("iron", out int i)) ironCost = i * 2;

                            bool canAfford = snap.wood >= woodCost && snap.iron >= ironCost;
                            btn.interactable = canAfford;
                            
                            var txts = btn.GetComponentsInChildren<Text>();
                            foreach(var txt in txts) {
                                if (txt.name == "StatusText") {
                                    txt.text = canAfford ? "Available" : "Not enough resources";
                                    txt.color = canAfford ? Color.green : Color.red;
                                }
                            }
                        } else {
                            btn.interactable = false;
                            
                            var txts = btn.GetComponentsInChildren<Text>();
                            foreach(var txt in txts) {
                                if (txt.name == "StatusText") {
                                    txt.text = blockedReason;
                                    txt.color = Color.red;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InitializeMenu() {
            // Global UI Rule Comment:
            // "Main panels and viewports must be scene-owned and visible/editable in Edit Mode. Runtime may only populate dynamic child content."

            var repo = GameServiceLocator.Backend?.repo;
            if (repo == null || repo.BuildMenu == null) return;

            // Clear old, including editor preview placeholders
            var toDestroy = new System.Collections.Generic.List<GameObject>();
            foreach (Transform child in contentRoot) {
                if (child != null && (child.name.StartsWith("EditorPreview_") || child.name.StartsWith("BtnBuild_") || child.name.StartsWith("BtnUpgrade_"))) {
                    toDestroy.Add(child.gameObject);
                }
            }
            foreach (var go in toDestroy) {
                if (Application.isPlaying) {
                    Destroy(go);
                } else {
                    DestroyImmediate(go);
                }
            }

            // Setup proper ScrollRect and Viewport at runtime if not already done (Emergency fallback)
            if (contentRoot.parent != null && contentRoot.parent.name == "BuildMenuPanel") {
                UnityEngine.Debug.LogWarning("[BUILD_MENU_UI] BuildMenuViewport not found under BuildMenuPanel in scene. Creating runtime emergency fallback viewport.");
                Transform panelTrans = contentRoot.parent;
                
                // Create Viewport
                GameObject viewportGo = new GameObject("BuildMenuViewport");
                viewportGo.transform.SetParent(panelTrans, false);
                var vpRect = viewportGo.AddComponent<RectTransform>();
                
                // Copy the original layout of contentRoot (320x230 scroll window)
                var originalCRect = contentRoot as RectTransform;
                vpRect.anchorMin = originalCRect.anchorMin;
                vpRect.anchorMax = originalCRect.anchorMax;
                vpRect.pivot = originalCRect.pivot;
                vpRect.sizeDelta = originalCRect.sizeDelta; // (0, 230)
                vpRect.anchoredPosition = originalCRect.anchoredPosition; // (0, -55)
                
                // Add masking/clipping
                viewportGo.AddComponent<RectMask2D>();
                
                // Add ScrollRect
                var scrollRect = viewportGo.AddComponent<ScrollRect>();
                scrollRect.horizontal = false;
                scrollRect.vertical = true;
                scrollRect.movementType = ScrollRect.MovementType.Clamped;
                scrollRect.scrollSensitivity = 25f;
                scrollRect.decelerationRate = 0.1f;
                
                // Reparent contentRoot under viewport
                contentRoot.SetParent(viewportGo.transform, false);
                
                // Set contentRoot layout to expand within viewport
                originalCRect.anchorMin = new Vector2(0, 1);
                originalCRect.anchorMax = new Vector2(1, 1);
                originalCRect.pivot = new Vector2(0.5f, 1f);
                originalCRect.anchoredPosition = Vector2.zero;
                originalCRect.sizeDelta = new Vector2(0, 0); // stretch width, custom height via layout components
                
                // Wire ScrollRect references
                scrollRect.viewport = vpRect;
                scrollRect.content = originalCRect;
            }

            // Wire / validate ScrollRect references at runtime if already present in scene-owned setup
            if (contentRoot.parent != null) {
                var scroll = contentRoot.parent.GetComponent<ScrollRect>();
                if (scroll != null) {
                    scroll.content = contentRoot as RectTransform;
                    scroll.viewport = contentRoot.parent as RectTransform;
                    scroll.horizontal = false;
                    scroll.vertical = true;
                    scroll.movementType = ScrollRect.MovementType.Clamped;
                    scroll.scrollSensitivity = 25f;
                    scroll.decelerationRate = 0.1f;
                }
            }

            // Auto-layout: add VerticalLayoutGroup + ContentSizeFitter to contentRoot on first init
            if (contentRoot.GetComponent<VerticalLayoutGroup>() == null) {
                var vlg = contentRoot.gameObject.AddComponent<VerticalLayoutGroup>();
                vlg.spacing = 6;
                vlg.childControlHeight = true;
                vlg.childForceExpandHeight = false;
                vlg.childControlWidth = true;
                vlg.childForceExpandWidth = true;
                vlg.padding = new RectOffset(10, 10, 4, 4);
            }
            if (contentRoot.GetComponent<ContentSizeFitter>() == null) {
                var csf = contentRoot.gameObject.AddComponent<ContentSizeFitter>();
                csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                csf.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
            }
            
            Font defaultFont = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            if (defaultFont == null) defaultFont = Resources.GetBuiltinResource<Font>("Arial.ttf");

            foreach (var item in repo.BuildMenu.menuItems) {
                // Get building details
                string bName = DefinitionDisplayService.GetBuildingName(item.buildingId);
                string bCost = DefinitionDisplayService.FormatBuildingCost(item.buildingId);

                // Load icon
                Sprite iconSp = null;
                if (!string.IsNullOrEmpty(item.iconAssetId) && repo.AssetMap != null && repo.AssetMap.assets.ContainsKey(item.iconAssetId)) {
                    string assetPath = repo.AssetMap.assets[item.iconAssetId];
                    if (System.IO.File.Exists(assetPath)) {
                        var bytes = System.IO.File.ReadAllBytes(assetPath);
                        var tex = new Texture2D(2, 2);
                        if (tex.LoadImage(bytes)) {
                            iconSp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                        }
                    }
                }

                string tId = item.buildingId;
                var btnGo = BuildMenuRowVisualFactory.CreateRow(
                    contentRoot,
                    "BtnBuild_" + item.buildingId,
                    bName,
                    bCost,
                    "Available",
                    Color.green,
                    iconSp,
                    false,
                    false,
                    defaultFont,
                    () => TryBuild(tId)
                );

                Diagnostics.RuntimeTrace.Log("BUILD_MENU_LISTENER", $"BtnBuild_{tId} -> TryBuild({tId})");
            }

            string[] upgradableTypes = new string[] { "hut", "storage" };
            foreach (var bId in upgradableTypes) {
                var bdef = repo.GetBuilding(bId);
                string bName = bId == "hut" ? "Upgrade Hut Lv2" : "Upgrade Storage Lv2";
                
                string bCost = "";
                if (bdef != null && bdef.costs != null) {
                    List<string> costParts = new List<string>();
                    foreach (var kvp in bdef.costs) {
                        costParts.Add($"{System.Char.ToUpper(kvp.Key[0]) + kvp.Key.Substring(1)}: {kvp.Value * 2}");
                    }
                    bCost = string.Join(", ", costParts);
                }

                // Load icon from matching menuItem
                Sprite iconSp = null;
                var menuItem = repo.BuildMenu.menuItems.Find(mi => mi.buildingId == bId);
                if (menuItem != null && !string.IsNullOrEmpty(menuItem.iconAssetId) && repo.AssetMap != null && repo.AssetMap.assets.ContainsKey(menuItem.iconAssetId)) {
                    string assetPath = repo.AssetMap.assets[menuItem.iconAssetId];
                    if (System.IO.File.Exists(assetPath)) {
                        var bytes = System.IO.File.ReadAllBytes(assetPath);
                        var tex = new Texture2D(2, 2);
                        if (tex.LoadImage(bytes)) {
                            iconSp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                        }
                    }
                }

                string targetBId = bId;
                var btnGo = BuildMenuRowVisualFactory.CreateRow(
                    contentRoot,
                    "BtnUpgrade_" + bId,
                    bName,
                    bCost,
                    "Available",
                    Color.green,
                    iconSp,
                    true,
                    false,
                    defaultFont,
                    () => TryUpgrade(targetBId)
                );

                Diagnostics.RuntimeTrace.Log("BUILD_MENU_LISTENER", $"BtnUpgrade_{targetBId} -> TryUpgrade({targetBId})");
            }

            LogLayoutDiagnostics();
            isInitialized = true;
            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"BuildMenu opened items={repo.BuildMenu.menuItems.Count}");
        }

        private void LogLayoutDiagnostics() {
            var closeBtn = transform.parent?.Find("BuildMenuPanel/HeaderCloseArea/BtnCloseBuildMenu")?.GetComponent<RectTransform>();
            if (closeBtn == null) closeBtn = transform.Find("HeaderCloseArea/BtnCloseBuildMenu")?.GetComponent<RectTransform>();
            var hutBtn = contentRoot.Find("BtnBuild_hut")?.GetComponent<RectTransform>();
            var storageBtn = contentRoot.Find("BtnBuild_storage")?.GetComponent<RectTransform>();
            var towerBtn = contentRoot.Find("BtnBuild_guardTower")?.GetComponent<RectTransform>();

            string closeRect = closeBtn != null ? $"{closeBtn.rect.x},{closeBtn.rect.y},{closeBtn.rect.width},{closeBtn.rect.height}" : "null";
            string hutRect = hutBtn != null ? $"{hutBtn.rect.x},{hutBtn.rect.y},{hutBtn.rect.width},{hutBtn.rect.height}" : "null";
            string storeRect = storageBtn != null ? $"{storageBtn.rect.x},{storageBtn.rect.y},{storageBtn.rect.width},{storageBtn.rect.height}" : "null";
            string towerRect = towerBtn != null ? $"{towerBtn.rect.x},{towerBtn.rect.y},{towerBtn.rect.width},{towerBtn.rect.height}" : "null";

            Diagnostics.RuntimeTrace.Log("BUILD_MENU_RECT", $"close={closeRect}");
            Diagnostics.RuntimeTrace.Log("BUILD_MENU_RECT", $"hut={hutRect}");
            Diagnostics.RuntimeTrace.Log("BUILD_MENU_RECT", $"storage={storeRect}");
            Diagnostics.RuntimeTrace.Log("BUILD_MENU_RECT", $"guardTower={towerRect}");
            
            int closeSibling = closeBtn != null ? closeBtn.GetSiblingIndex() : -1;
            int hutSibling = hutBtn != null ? hutBtn.GetSiblingIndex() : -1;
            Diagnostics.RuntimeTrace.Log("BUILD_MENU_RECT", $"closeSiblingIndex={closeSibling} hutSiblingIndex={hutSibling}");
        }

        private void TryBuild(string tId) {
            var currentSnap = GameServiceLocator.Backend?.GetSnapshot();
            
            // Double check affordability
            bool canAfford = true;
            if (currentSnap != null) {
                var repo = GameServiceLocator.Backend?.repo;
                var bDef = repo?.GetBuilding(tId);
                if (bDef != null && bDef.costs != null) {
                    if (bDef.costs.TryGetValue("wood", out int w) && currentSnap.wood < w) canAfford = false;
                    if (bDef.costs.TryGetValue("food", out int f) && currentSnap.food < f) canAfford = false;
                    if (bDef.costs.TryGetValue("iron", out int i) && currentSnap.iron < i) canAfford = false;
                }
            }

            if (!canAfford) {
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Build blocked id={tId} reason=Not enough resources");
                UnityEngine.Debug.LogWarning("[GAMEPLAY_UI] Build blocked id=" + tId + " reason=Not enough resources");
                // TODO: ShowToast("Not enough resources");
                if (UnityEngine.EventSystems.EventSystem.current != null) {
                    UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
                }
                return;
            }

            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Build clicked id={tId}");

            if (BuildingPlacementController.Instance != null) {
                BuildingPlacementController.Instance.StartPlacement(tId);
                
                // Hide the build menu so player can place
                var closeBtn = transform.parent?.Find("BuildMenuPanel/HeaderCloseArea/BtnCloseBuildMenu")?.GetComponent<Button>();
                if (closeBtn != null) {
                    closeBtn.onClick.Invoke();
                } else {
                    // Fallback to previous behavior of just disabling this gameObject
                    gameObject.SetActive(false);
                    // Also try disabling parent BuildMenuPanel
                    if (transform.parent != null && transform.parent.name == "BuildMenuPanel") {
                        transform.parent.gameObject.SetActive(false);
                    }
                }
            } else {
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI_ERROR", $"BuildingPlacementController not found!");
            }
        }

        private void TryUpgrade(string bId) {
            var backend = GameServiceLocator.Backend;
            if (backend == null) return;
            var currentSnap = backend.GetSnapshot();
            if (currentSnap == null) return;

            // Find eligible placed building using explicit validation matching UpdateView
            PlacedObject target = null;
            if (currentSnap.userPlacements != null) {
                foreach (var place in currentSnap.userPlacements) {
                    if (place == null) continue;
                    string[] parts = place.id.Split(':');
                    if (parts.Length >= 3 && parts[0] == "building" && parts[1] == bId && place.level == 1) {
                        // Check if an upgrade task is already active for this placement
                        bool isUpgrading = false;
                        if (currentSnap.tasks != null) {
                            foreach (var t in currentSnap.tasks) {
                                if (t != null && t.type == "UpgradeBuilding" && t.targetPlacementId == place.id) {
                                    isUpgrading = true;
                                    break;
                                }
                            }
                        }
                        if (!isUpgrading) {
                            target = place;
                            break;
                        }
                    }
                }
            }

            if (target == null) {
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Upgrade blocked type={bId} reason=No eligible level 1 building");
                UnityEngine.Debug.LogWarning("[GAMEPLAY_UI] Upgrade blocked type=" + bId + " reason=No eligible level 1 building");
                return;
            }

            // Check resource cost
            var repo = backend.repo;
            var bDef = repo?.GetBuilding(bId);
            if (bDef == null || bDef.costs != null) {
                int woodCost = 0;
                int ironCost = 0;
                if (bDef != null && bDef.costs.TryGetValue("wood", out int w)) woodCost = w * 2;
                if (bDef != null && bDef.costs.TryGetValue("iron", out int i)) ironCost = i * 2;

                if (currentSnap.wood < woodCost || currentSnap.iron < ironCost) {
                    Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Upgrade blocked type={bId} placementId={target.id} reason=Not enough resources");
                    UnityEngine.Debug.LogWarning("[GAMEPLAY_UI] Upgrade blocked type=" + bId + " placementId=" + target.id + " reason=Not enough resources");
                    return;
                }
            }

            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Upgrade clicked type={bId} placementId={target.id}");
            
            var cmd = new UpgradeBuildingCommand {
                buildingPlacementId = target.id
            };
            TownInteractionController.Instance?.ExecuteCommand(cmd);

            // Set UI selection to null to avoid button highlight sticky focus
            if (UnityEngine.EventSystems.EventSystem.current != null) {
                UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }
}
