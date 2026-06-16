using UnityEngine; using UnityEngine.UI;
namespace TheBonwater.Rebuild {
    public class TownView : MonoBehaviour {
        public Text txtDayTime;
        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateView; }
        private void UpdateView(GameSnapshot snap) { if (txtDayTime != null) txtDayTime.text = $"Day {snap.day} - {snap.timeOfDay}"; }
    }
}
