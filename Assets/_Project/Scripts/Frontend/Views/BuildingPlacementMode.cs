using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    public class BuildingPlacementMode : MonoBehaviour {
        public string buildingId;
        private GameObject ghost;
        private Image ghostImg;
        private RectTransform ghostRect;
        private RectTransform placementRootRect;
        private Canvas canvas;
        private Camera eventCamera;
        private int initializedFrame;
        private bool isActive;
        private CanvasGroup hiddenPanelGroup;
        private GameObject sourceBuildMenu;

        /// <summary>
        /// Stores the background Image located on the BuildMenu parent (if any)
        /// so we can hide/show it without disabling any ancestor's gameObject.
        /// </summary>
        private Image parentBackgroundImage;
        private Color cachedParentBgColor;

        public bool IsActive => isActive;

        public void Initialize(string bId) {
            Initialize(bId, null);
        }

        public void Initialize(string bId, GameObject buildMenuToHide) {
            if (isActive) {
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Placement already active id={buildingId} ignoredClick={bId}");
                return;
            }

            this.buildingId = bId;
            this.sourceBuildMenu = buildMenuToHide;
            canvas = GetComponentInParent<Canvas>();
            eventCamera = canvas != null && canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : Camera.main;

            // World root for placement coordinates
            var visualController = FindObjectOfType<TownRuntimeVisualController>();
            if (visualController != null && visualController.worldRoot != null) {
                placementRootRect = visualController.worldRoot.GetComponent<RectTransform>();
            }
            if (placementRootRect == null && canvas != null) {
                placementRootRect = canvas.GetComponent<RectTransform>();
            }

            // --- Hide build menu panel completely so it does NOT show as a "dark panel" ---
            // Approach: find the first parent (above BuildMenuPanelView) that has a background Image,
            // and make it transparent + non-interactive. We keep the parent gameObject active so
            // that our own component and Update() keep running.
            if (sourceBuildMenu != null) {
                sourceBuildMenu.SetActive(false);
                UnityEngine.Debug.Log($"[PLACEMENT] build menu closed={sourceBuildMenu.name}");
            } else {
                HideBuildMenuPanel();
            }

            // Create ghost
            ghost = new GameObject("PlacementGhost");
            ghost.transform.SetParent(placementRootRect != null ? placementRootRect : transform.parent, false);
            ghostImg = ghost.AddComponent<Image>();
            ghostImg.raycastTarget = false;
            ghostImg.color = new Color(1f, 1f, 1f, 0.5f);

            // Load ghost sprite from build menu icon asset
            var repo = GameServiceLocator.Backend?.repo;
            if (repo != null && repo.AssetMap != null) {
                var btnDef = repo.BuildMenu?.menuItems.Find(m => m.buildingId == bId);
                if (btnDef != null && repo.AssetMap.assets.ContainsKey(btnDef.iconAssetId)) {
                    string assetPath = repo.AssetMap.assets[btnDef.iconAssetId];
                    if (System.IO.File.Exists(assetPath)) {
                        var bytes = System.IO.File.ReadAllBytes(assetPath);
                        var tex = new Texture2D(2, 2);
                        if (tex.LoadImage(bytes)) {
                            ghostImg.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                        }
                    }
                }
            }

            ghostRect = ghost.GetComponent<RectTransform>();
            ghostRect.sizeDelta = new Vector2(100, 100);
            initializedFrame = Time.frameCount;
            isActive = true;

            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Placement mode started id={bId}");
            UnityEngine.Debug.Log($"[PLACEMENT] mode=active buildingId={bId}");
        }

        /// <summary>
        /// Hide the build menu panel background without disabling any ancestor gameObject
        /// (which would kill our Update loop). We find the parent panel Image and set it
        /// transparent + non-raycast.
        /// </summary>
        private void HideBuildMenuPanel() {
            parentBackgroundImage = null;

            // Walk up from BuildMenuPanelView's parent to find a panel-level Image
            Transform current = transform.parent;
            while (current != null) {
                // Stop at the Canvas
                if (current.GetComponent<Canvas>() != null) break;

                var img = current.GetComponent<Image>();
                if (img != null) {
                    // Found a panel background
                    parentBackgroundImage = img;
                    break;
                }
                // Also check for a dark panel that might not have our component
                if (current.name.Contains("Panel") || current.name.Contains("Menu")) {
                    img = current.GetComponentInChildren<Image>();
                    if (img != null && img.raycastTarget) {
                        // Use this as the background to hide
                        parentBackgroundImage = img;
                        break;
                    }
                }

                current = current.parent;
            }

            if (parentBackgroundImage != null) {
                cachedParentBgColor = parentBackgroundImage.color;
                parentBackgroundImage.color = new Color(cachedParentBgColor.r, cachedParentBgColor.g, cachedParentBgColor.b, 0f);
                parentBackgroundImage.raycastTarget = false;
                UnityEngine.Debug.Log($"[PLACEMENT] hidden panel background={parentBackgroundImage.name}");
            }
        }

        /// <summary>
        /// Restore the build menu panel background that was hidden during placement.
        /// </summary>
        private void RestoreBuildMenuPanel() {
            if (parentBackgroundImage != null) {
                parentBackgroundImage.color = cachedParentBgColor;
                parentBackgroundImage.raycastTarget = true;
                parentBackgroundImage = null;
            }
        }

        void Update() {
            if (ghost == null || placementRootRect == null) return;

            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                placementRootRect, Input.mousePosition, eventCamera, out localPoint);

            bool overWorld = RectTransformUtility.RectangleContainsScreenPoint(
                placementRootRect, Input.mousePosition, eventCamera);
            bool overBlockingUi = IsPointerOverBlockingUi();

            // Ghost follows mouse only when over the map/world area
            if (overWorld && !overBlockingUi) {
                ghostRect.anchoredPosition = localPoint;
                if (!ghost.activeSelf) ghost.SetActive(true);
            } else {
                if (ghost.activeSelf) ghost.SetActive(false);
            }

            if (Time.frameCount == initializedFrame) return;

            // Left-click on world confirms placement
            if (Input.GetMouseButtonDown(0) && overWorld && !overBlockingUi) {
                ghostRect.anchoredPosition = localPoint;
                ConfirmPlacement(localPoint);
            }
            // Right-click or ESC cancels
            else if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape)) {
                CancelPlacement();
            }
        }

        private bool IsPointerOverBlockingUi() {
            if (EventSystem.current == null) return false;

            var pointerData = new PointerEventData(EventSystem.current) { position = Input.mousePosition };
            var hits = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, hits);

            foreach (var hit in hits) {
                if (hit.gameObject == null) continue;
                var hitTransform = hit.gameObject.transform;

                // Ignore ghost itself
                if (ghost != null && hitTransform.IsChildOf(ghost.transform)) continue;
                // Ignore world root children (map decorations, buildings, villagers, etc.)
                // These have raycastTarget=false so they shouldn't appear in hits anyway,
                // but be safe and skip them.
                if (placementRootRect != null && hitTransform.IsChildOf(placementRootRect)) continue;

                // Ignore graphics that have raycastTarget disabled
                var graphic = hit.gameObject.GetComponent<Graphic>();
                if (graphic != null && !graphic.raycastTarget) continue;

                // Any remaining hit is blocking UI (HUD buttons, panels, etc.)
                return true;
            }

            return false;
        }

        private void ConfirmPlacement(Vector2 pos) {
            GameCommand cmd = null;
            if (buildingId == "hut") cmd = new BuildHutCommand { x = pos.x, y = pos.y };
            else if (buildingId == "storage") cmd = new BuildStorageCommand { x = pos.x, y = pos.y };
            else if (buildingId == "guardTower") cmd = new BuildGuardTowerCommand { x = pos.x, y = pos.y };
            else if (buildingId == "blacksmithsForge") cmd = new BuildBlacksmithsForgeCommand { x = pos.x, y = pos.y };

            if (cmd != null) {
                // Backend handles resource deduction and construction creation
                TownInteractionController.Instance.ExecuteCommand(cmd);

                var snapAfter = GameServiceLocator.Backend?.GetSnapshot();
                bool hasTask = snapAfter != null && snapAfter.tasks.Exists(
                    task => !string.IsNullOrEmpty(task.targetBuildingId) && task.targetBuildingId == buildingId);
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI",
                    $"Placement confirmed id={buildingId} x={pos.x} y={pos.y} taskCreated={hasTask}");
                UnityEngine.Debug.Log($"[PLACEMENT] confirmed id={buildingId} x={pos.x} y={pos.y} taskCreated={hasTask}");
            }

            CleanupAndClose(false);
        }

        private void CancelPlacement() {
            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"Placement cancelled id={buildingId}");
            UnityEngine.Debug.Log($"[PLACEMENT] cancelled id={buildingId} reason=user_cancel");
            CleanupAndClose(true);
        }

        private void CleanupAndClose(bool restoreBuildMenu) {
            if (ghost != null) Destroy(ghost);
            ghost = null;
            isActive = false;

            if (restoreBuildMenu && sourceBuildMenu != null) {
                sourceBuildMenu.SetActive(true);
            }
            sourceBuildMenu = null;
            RestoreBuildMenuPanel();

            // Destroy this component so placement mode fully ends
            Destroy(this);
        }

        private void OnDestroy() {
            // Safety cleanup if component is destroyed externally
            if (ghost != null) Destroy(ghost);
            RestoreBuildMenuPanel();
        }
    }
}
