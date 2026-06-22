using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

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
                }
            }
        }

        private void InitializeMenu() {
            var repo = GameServiceLocator.Backend?.repo;
            if (repo == null || repo.BuildMenu == null) return;

            // Clear old
            foreach (Transform child in contentRoot) {
                Destroy(child.gameObject);
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
            // Add ScrollRect to parent if not already present
            var parentScrollRect = contentRoot.parent.GetComponent<ScrollRect>();
            if (parentScrollRect == null) {
                parentScrollRect = contentRoot.parent.gameObject.AddComponent<ScrollRect>();
                parentScrollRect.horizontal = false;
                parentScrollRect.vertical = true;
                parentScrollRect.movementType = ScrollRect.MovementType.Clamped;
                parentScrollRect.scrollSensitivity = 25;
                parentScrollRect.decelerationRate = 0.1f;
                parentScrollRect.content = contentRoot as RectTransform;
            }
            
            foreach (var item in repo.BuildMenu.menuItems) {
                var btnGo = new GameObject("BtnBuild_" + item.buildingId);
                btnGo.transform.SetParent(contentRoot, false);
                var rect = btnGo.AddComponent<RectTransform>();
                rect.sizeDelta = new Vector2(300, 60);
                
                var img = btnGo.AddComponent<Image>();
                img.color = new Color(0.3f, 0.3f, 0.3f);
                var btn = btnGo.AddComponent<Button>();
                btn.navigation = new Navigation { mode = Navigation.Mode.None };

                // Get building details
                string bName = DefinitionDisplayService.GetBuildingName(item.buildingId);
                string bCost = DefinitionDisplayService.FormatBuildingCost(item.buildingId);

                // Create text
                var txtGo = new GameObject("Text");
                txtGo.transform.SetParent(btnGo.transform, false);
                var tRect = txtGo.AddComponent<RectTransform>();
                tRect.anchorMin = Vector2.zero; tRect.anchorMax = Vector2.one;
                tRect.offsetMin = new Vector2(80, 0); // space for icon
                
                var txt = txtGo.AddComponent<Text>();
                txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txt.text = $"<b>{bName}</b>\n{bCost}";
                txt.alignment = TextAnchor.MiddleLeft;
                txt.color = Color.white;
                txt.fontSize = 20;
                txt.raycastTarget = false;

                // Create status text
                var stGo = new GameObject("StatusText");
                stGo.transform.SetParent(btnGo.transform, false);
                var stRect = stGo.AddComponent<RectTransform>();
                stRect.anchorMin = Vector2.zero; stRect.anchorMax = Vector2.one;
                stRect.offsetMax = new Vector2(-10, 0);
                var stTxt = stGo.AddComponent<Text>();
                stTxt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                stTxt.text = "Available";
                stTxt.alignment = TextAnchor.MiddleRight;
                stTxt.fontSize = 16;
                stTxt.raycastTarget = false;

                // Load icon
                if (!string.IsNullOrEmpty(item.iconAssetId) && repo.AssetMap != null && repo.AssetMap.assets.ContainsKey(item.iconAssetId)) {
                    string assetPath = repo.AssetMap.assets[item.iconAssetId];
                    Sprite iconSp = null;
                    if (System.IO.File.Exists(assetPath)) {
                        var bytes = System.IO.File.ReadAllBytes(assetPath);
                        var tex = new Texture2D(2, 2);
                        if (tex.LoadImage(bytes)) {
                            iconSp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                        }
                    }
                    if (iconSp != null) {
                        var iconGo = new GameObject("Icon");
                        iconGo.transform.SetParent(btnGo.transform, false);
                        var iRect = iconGo.AddComponent<RectTransform>();
                        iRect.anchorMin = new Vector2(0, 0.5f); iRect.anchorMax = new Vector2(0, 0.5f);
                        iRect.sizeDelta = new Vector2(60, 60);
                        iRect.anchoredPosition = new Vector2(40, 0);
                        var iImg = iconGo.AddComponent<Image>();
                        iImg.sprite = iconSp;
                        iImg.preserveAspect = true;
                        iImg.raycastTarget = false;
                    }
                }

                // Add listener
                string tId = item.buildingId;
                btn.onClick.RemoveAllListeners();
                btn.onClick.AddListener(() => TryBuild(tId));
                Diagnostics.RuntimeTrace.Log("BUILD_MENU_LISTENER", $"BtnBuild_{tId} -> TryBuild({tId})");
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


    }
}
