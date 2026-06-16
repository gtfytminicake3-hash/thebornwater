using UnityEngine; using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class DebugStateView : MonoBehaviour {
        public Text txtDebug;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) {
            if (txtDebug != null) txtDebug.text = "Debug Raw Snapshot\n" + JsonUtility.ToJson(snap, true);
        }
    }
}
