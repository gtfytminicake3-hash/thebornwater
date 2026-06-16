using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class LastActionView : MonoBehaviour {
        public Text txtLastAction;

        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateState; }
        public void UpdateState(GameSnapshot snap) {
            if (txtLastAction == null || snap == null) return;
            txtLastAction.text = string.IsNullOrEmpty(snap.lastAction) ? "Ready." : snap.lastAction;
        }
    }
}
