using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class BuildMenuView : MonoBehaviour {
        public Text txtHut, txtStorage, txtGuardTower;

        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += (_) => Refresh(); }
        public void Refresh() {
            if (txtHut != null) txtHut.text = $"BUILD HUT {DefinitionDisplayService.FormatBuildingCost("Hut")}";
            if (txtStorage != null) txtStorage.text = $"BUILD STORAGE {DefinitionDisplayService.FormatBuildingCost("Storage")}";
            if (txtGuardTower != null) txtGuardTower.text = $"BUILD GUARD TOWER {DefinitionDisplayService.FormatBuildingCost("GuardTower")}";
        }
    }
}
