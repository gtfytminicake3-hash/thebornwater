using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class VillagerListView : MonoBehaviour {
        public Text txtVillagers;

        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateState; }
        public void UpdateState(GameSnapshot snap) {
            if (txtVillagers == null || snap == null) return;
            string text = "VILLAGERS\n";
            for(int i = 0; i < snap.villagers.Count; i++) {
                var v = snap.villagers[i];
                string status = v.hp <= 0 ? "DEAD" : $"HP {v.hp}";
                string effect = DefinitionDisplayService.FormatJobEffect(v.job);
                if (v.hp <= 0) effect = "";
                string selectedMarker = (i == snap.selectedVillagerIndex) ? "(SELECTED) " : "";
                text += $"- {selectedMarker}{v.name} - {v.job} - {status} - {effect}\n";
            }
            txtVillagers.text = text;
        }
    }
}
