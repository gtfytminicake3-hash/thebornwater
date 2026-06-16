using UnityEngine;
using UnityEngine.EventSystems;

namespace TheBonwater.Rebuild {
    public class MapDragController : MonoBehaviour, IDragHandler, IPointerDownHandler {
        public RectTransform targetTransform;
        private bool hasLogged = false;
        
        private void Start() {
            if (targetTransform == null) {
                var go = GameObject.Find("TownWorldRoot");
                if (go != null) targetTransform = go.GetComponent<RectTransform>();
            }
        }

        public void OnPointerDown(PointerEventData eventData) {
            // Needed to receive drag events
        }

        public void OnDrag(PointerEventData eventData) {
            if (targetTransform != null) {
                if (!hasLogged) {
                    Vector2 oldPos = targetTransform.anchoredPosition;
                    Vector2 newPos = oldPos + eventData.delta;
                    
                    RectTransform viewport = GetComponent<RectTransform>();
                    string vpSize = viewport != null ? $"{viewport.rect.width}x{viewport.rect.height}" : "unknown";
                    
                    UnityEngine.Debug.Log($"[MAP_DRAG] target={targetTransform.name} old=({oldPos.x},{oldPos.y}) new=({newPos.x},{newPos.y})");
                    UnityEngine.Debug.Log($"[MAP_DRAG] worldRootSize={targetTransform.rect.width}x{targetTransform.rect.height} viewportSize={vpSize}");
                    
                    Transform terrainLayer = targetTransform.Find("TerrainLayer");
                    if (terrainLayer != null && terrainLayer.childCount > 0) {
                        UnityEngine.Debug.Log($"[MAP_DRAG] terrainChildFound=true path={GetFullPath(terrainLayer.GetChild(0))}");
                    } else {
                        UnityEngine.Debug.LogError("MAP_PAN_HIERARCHY_ERROR: terrain/background is outside TownWorldRoot");
                    }
                    
                    hasLogged = true;
                }
                
                targetTransform.anchoredPosition += eventData.delta;
            }
        }
        
        private string GetFullPath(Transform t) {
            if (t == null) return "";
            if (t.parent == null) return t.name;
            return GetFullPath(t.parent) + "/" + t.name;
        }
    }
}
