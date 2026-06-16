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
            int hutCount = snap.buildings.Find(b => b.id == "Hut")?.count ?? 0;
            
            int currentAlive = snap.villagers.Count(v => v.hp > 0);
            int totalVillagers = snap.villagers.Count;
            
            string objText = $"Survive to Day {objState.surviveToDay}: {snap.day} / {objState.surviveToDay}\n" +
                             $"Build Huts: {hutCount} / {objState.requiredHuts}\n" +
                             $"Villagers alive: {currentAlive} / {totalVillagers}\n" +
                             $"Status: {objState.status}";

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
