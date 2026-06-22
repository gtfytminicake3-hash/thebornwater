using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace TheBonwater.Rebuild {
    public class ViewportClickDetector : MonoBehaviour, IPointerClickHandler {
        public void OnPointerClick(PointerEventData eventData) {
            if (eventData.button == PointerEventData.InputButton.Left) {
                if (BuildingPlacementController.Instance != null && BuildingPlacementController.Instance.IsPlacing) {
                    BuildingPlacementController.Instance.OnViewportClicked(eventData.position);
                }
            }
        }
    }

    public class BuildingPlacementController : MonoBehaviour {
        public static BuildingPlacementController Instance;
        
        private bool isPlacing = false;
        private string currentBuildingId;
        private GameObject ghostObject;
        private RectTransform worldRoot;

        public bool IsPlacing => isPlacing;

        private void Awake() {
            Instance = this;
        }

        private void Start() {
            var townCtrl = FindObjectOfType<TownRuntimeVisualController>();
            if (townCtrl != null && townCtrl.worldRoot != null) {
                worldRoot = townCtrl.worldRoot.GetComponent<RectTransform>();
            } else {
                var go = GameObject.Find("TownWorldRoot");
                if (go != null) worldRoot = go.GetComponent<RectTransform>();
            }
            EnsureViewportClickDetector();
        }

        private void EnsureViewportClickDetector() {
            var viewportPanel = GameObject.Find("TownViewportPanel");
            if (viewportPanel != null) {
                if (viewportPanel.GetComponent<ViewportClickDetector>() == null) {
                    viewportPanel.AddComponent<ViewportClickDetector>();
                }
            }
        }

        public void StartPlacement(string buildingId) {
            EnsureViewportClickDetector();
            currentBuildingId = buildingId;
            isPlacing = true;
            
            if (ghostObject != null) Destroy(ghostObject);
            
            ghostObject = new GameObject("PlacementGhost_" + buildingId);
            if (worldRoot != null) {
                ghostObject.transform.SetParent(worldRoot, false);
            }
            
            var rect = ghostObject.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(100, 100); 
            
            var img = ghostObject.AddComponent<Image>();
            img.color = new Color(1f, 1f, 1f, 0.6f); 
            img.raycastTarget = false;
            
            var repo = GameServiceLocator.Backend?.repo;
            if (repo != null && repo.BuildMenu != null) {
                var menuItem = repo.BuildMenu.menuItems.Find(m => m.buildingId == buildingId);
                if (menuItem != null && !string.IsNullOrEmpty(menuItem.iconAssetId)) {
                    if (repo.AssetMap != null && repo.AssetMap.assets.ContainsKey(menuItem.iconAssetId)) {
                        string assetPath = repo.AssetMap.assets[menuItem.iconAssetId];
                        if (System.IO.File.Exists(assetPath)) {
                            var bytes = System.IO.File.ReadAllBytes(assetPath);
                            var tex = new Texture2D(2, 2);
                            if (tex.LoadImage(bytes)) {
                                var sp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                                img.sprite = sp;
                                img.preserveAspect = true;
                            }
                        }
                    }
                }
            }
        }

        private void Update() {
            if (!isPlacing || worldRoot == null || ghostObject == null) return;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(worldRoot, Input.mousePosition, null, out Vector2 localPos);
            ghostObject.GetComponent<RectTransform>().anchoredPosition = localPos;

            if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape)) {
                CancelPlacement();
                return;
            }
        }

        public void OnViewportClicked(Vector2 screenPos) {
            if (!isPlacing || worldRoot == null) return;
            
            RectTransformUtility.ScreenPointToLocalPointInRectangle(worldRoot, screenPos, null, out Vector2 localPos);
            ConfirmPlacement(localPos);
        }

        private void ConfirmPlacement(Vector2 pos) {
            isPlacing = false;
            if (ghostObject != null) {
                Destroy(ghostObject);
                ghostObject = null;
            }
            
            GameCommand cmd = null;
            if (currentBuildingId == "hut") cmd = new BuildHutCommand { x = pos.x, y = pos.y };
            else if (currentBuildingId == "storage") cmd = new BuildStorageCommand { x = pos.x, y = pos.y };
            else if (currentBuildingId == "guardTower") cmd = new BuildGuardTowerCommand { x = pos.x, y = pos.y };
            else if (currentBuildingId == "blacksmithsForge") cmd = new BuildBlacksmithsForgeCommand { x = pos.x, y = pos.y };
            
            if (cmd != null) {
                Diagnostics.RuntimeTrace.Log("BUILDING_PLACEMENT", $"Placed {currentBuildingId} at {pos.x}, {pos.y}");
                TownInteractionController.Instance.ExecuteCommand(cmd);
            }
        }

        private void CancelPlacement() {
            isPlacing = false;
            if (ghostObject != null) {
                Destroy(ghostObject);
                ghostObject = null;
            }
            Diagnostics.RuntimeTrace.Log("BUILDING_PLACEMENT", "Cancelled");
        }
    }
}
