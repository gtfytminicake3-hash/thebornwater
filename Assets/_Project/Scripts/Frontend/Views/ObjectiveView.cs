using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class ObjectiveView : MonoBehaviour {
        public Text txtObjective;

        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateState; }
        public void UpdateState(GameSnapshot snap) {
            if (txtObjective == null || snap == null) return;
            
            var objState = snap.objectiveState;
            int hutCount = snap.buildings.Find(b => string.Equals(b.id, "Hut", System.StringComparison.OrdinalIgnoreCase))?.count ?? 0;
            
            int currentAlive = snap.villagers.Count(v => v.hp > 0);
            int totalVillagers = snap.villagers.Count;
            
            string objText = "";
            if (objState.currentMilestoneIndex == 1) {
                objText = $"Survive to Day {objState.surviveToDay}: {snap.day} / {objState.surviveToDay}\n" +
                                 $"Build Huts: {hutCount} / {objState.requiredHuts}\n" +
                                 $"Villagers alive: {currentAlive} / {totalVillagers}\n" +
                                 $"Status: {objState.status}";
            } else {
                // Split multi-line backend objectiveText cleanly or display directly
                objText = $"Objective: {snap.objectiveText}\n" +
                                 $"Villagers alive: {currentAlive} / {totalVillagers}\n" +
                                 $"Status: {objState.status}";
            }

            txtObjective.text = objText;

            if (objState.status == "FAILED") {
                txtObjective.color = Color.red;
            }
            else if (objState.status == "COMPLETED") {
                txtObjective.color = Color.green;
            }
            else {
                txtObjective.color = Color.white;
            }
        }
    }
}
