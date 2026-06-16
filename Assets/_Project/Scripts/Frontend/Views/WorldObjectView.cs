using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class WorldObjectView : MonoBehaviour {
        public string objectId;
        public string objectType;
        public string assetKey;
        public string taskId;
        public string targetBuildingId;
        public bool managedByBackend = true;
        public bool preserveManualPlacement = false;
        
        [HideInInspector] public Image image;
        [HideInInspector] public RectTransform rectTransform;

        private void Awake() {
            image = GetComponent<Image>();
            rectTransform = GetComponent<RectTransform>();
        }
    }
}
