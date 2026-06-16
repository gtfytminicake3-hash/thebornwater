using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class BuildingListView : MonoBehaviour {
        public Text txtBuildings;

        private void Start() {
            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.OnStateChanged += UpdateView;
                UpdateView(GameServiceLocator.Backend.GetSnapshot());
            }
        }

        public void UpdateView(GameSnapshot snapshot) {
            if (txtBuildings == null) return;
            string s = "Buildings:\n";
            if (snapshot.buildings != null) {
                foreach (var b in snapshot.buildings) {
                    if (b.count > 0) s += $"- {b.id}: {b.count}\n";
                }
            }
            if (snapshot.tasks != null && snapshot.tasks.Count > 0) {
                s += "\nConstructions:\n";
                foreach (var t in snapshot.tasks) {
                    if (t.status == "AwaitingResources") s += $"- {t.targetBuildingId} awaiting resources\n";
                    else s += $"- {t.targetBuildingId} under construction ({t.currentCompletion}/{t.finalCompletion})\n";
                }
            }
            txtBuildings.text = s;
        }
    }
}
