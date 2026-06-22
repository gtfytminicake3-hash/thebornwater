using UnityEngine;
using UnityEngine.EventSystems;

namespace TheBonwater.Rebuild {
    public class MapPanZoomController : MonoBehaviour {
        public float zoomSpeed = 0.5f;
        public float minZoom = 0.5f;
        public float maxZoom = 4f;
        public float panSpeed = 2f;

        private Vector2 lastPanPosition;
        private int panFingerId = -1;
        private bool isPanning = false;

        private RectTransform worldRoot;

        private void Start() {
            var townCtrl = FindObjectOfType<TownRuntimeVisualController>();
            if (townCtrl != null && townCtrl.worldRoot != null) {
                worldRoot = townCtrl.worldRoot.GetComponent<RectTransform>();
            } else {
                var go = GameObject.Find("TownWorldRoot");
                if (go == null) go = GameObject.Find("WorldRoot");
                if (go != null) worldRoot = go.GetComponent<RectTransform>();
            }
        }

        private void Update() {
            if (worldRoot == null) return;

            HandleMouse();
            HandleTouch();
        }

        private void HandleMouse() {
            // Zoom
            float scrollA = Input.mouseScrollDelta.y;
            float scrollB = Input.GetAxis("Mouse ScrollWheel");
            float scroll = Mathf.Abs(scrollA) > 0.001f ? scrollA : scrollB * 10f;

            if (Mathf.Abs(scroll) > 0.001f) {
                float oldScale = worldRoot.localScale.x;
                float newScale = Mathf.Clamp(oldScale + scroll * zoomSpeed, minZoom, maxZoom);
                worldRoot.localScale = new Vector3(newScale, newScale, 1f);

                UnityEngine.Debug.Log($"[MapZoom] scroll={scroll} oldScale={oldScale} newScale={newScale} worldRoot={worldRoot.name}");
            }

            // Pan
            if (Input.GetMouseButtonDown(0)) {
                if (EventSystem.current == null || !EventSystem.current.IsPointerOverGameObject()) {
                    isPanning = true;
                    lastPanPosition = Input.mousePosition;
                }
            } else if (Input.GetMouseButtonUp(0)) {
                isPanning = false;
            }

            if (isPanning && Input.GetMouseButton(0)) {
                Vector2 delta = (Vector2)Input.mousePosition - lastPanPosition;
                lastPanPosition = Input.mousePosition;
                
                worldRoot.anchoredPosition += delta * panSpeed;
            }
        }

        private void HandleTouch() {
            if (Input.touchCount == 1) {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began) {
                    if (EventSystem.current == null || !EventSystem.current.IsPointerOverGameObject(touch.fingerId)) {
                        panFingerId = touch.fingerId;
                    }
                } else if (touch.phase == TouchPhase.Moved && touch.fingerId == panFingerId) {
                    Vector2 delta = touch.deltaPosition;
                    worldRoot.anchoredPosition += delta * panSpeed;
                } else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled) {
                    if (touch.fingerId == panFingerId) {
                        panFingerId = -1;
                    }
                }
            } else if (Input.touchCount == 2) {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                if (EventSystem.current != null && (EventSystem.current.IsPointerOverGameObject(touchZero.fingerId) || EventSystem.current.IsPointerOverGameObject(touchOne.fingerId))) return;

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

                float oldScale = worldRoot.localScale.x;
                float newScale = Mathf.Clamp(oldScale - deltaMagnitudeDiff * zoomSpeed * 0.01f, minZoom, maxZoom);
                worldRoot.localScale = new Vector3(newScale, newScale, 1f);
                
                panFingerId = -1; // Reset panning if zooming
                isPanning = false;
            }
        }
    }
}
