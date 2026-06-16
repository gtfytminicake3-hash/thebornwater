using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class TopResourceBarView : MonoBehaviour {
        public Text txtResources;
        private AutoTimeController autoTime;
        private string cachedDayPhase = "DAY 1 - MORNING";
        private string cachedResources = "";

        private void Start() {
            autoTime = FindObjectOfType<AutoTimeController>();
            if (autoTime != null) {
                Diagnostics.RuntimeTrace.Log("TIME_DISPLAY_BOUND", "source=AutoTimeController");
            }
        }

        private void Update() {
            if (txtResources == null) return;
            
            if (autoTime == null && TownInteractionController.Instance != null) {
                autoTime = TownInteractionController.Instance.GetComponent<AutoTimeController>();
                if (autoTime != null) Diagnostics.RuntimeTrace.Log("TIME_DISPLAY_BOUND", "source=AutoTimeController");
            }

            string timeStr = "";
            if (autoTime != null && autoTime.IsRunning) {
                timeStr = $" | {Mathf.CeilToInt(autoTime.TimeRemaining)}s";
            }

            txtResources.text = $"{cachedDayPhase}{timeStr}\n{cachedResources}";
        }

        public void UpdateView(GameSnapshot snap) {
            if (snap == null) return;
            string wName = DefinitionDisplayService.GetResourceName("wood").ToUpper();
            string fName = DefinitionDisplayService.GetResourceName("food").ToUpper();
            string iName = DefinitionDisplayService.GetResourceName("iron").ToUpper();
            
            cachedDayPhase = $"DAY {snap.day} - {snap.timeOfDay.ToUpper()}";
            cachedResources = $"{wName}: {snap.wood} / {snap.woodCapacity}    {fName}: {snap.food} / {snap.foodCapacity}    {iName}: {snap.iron} / {snap.ironCapacity}";

            if (snap.wood < 0 || snap.wood > snap.woodCapacity) Diagnostics.RuntimeTrace.Log("WARNING", $"Wood is out of bounds: {snap.wood}/{snap.woodCapacity}");
            if (snap.food < 0 || snap.food > snap.foodCapacity) Diagnostics.RuntimeTrace.Log("WARNING", $"Food is out of bounds: {snap.food}/{snap.foodCapacity}");
            if (snap.iron < 0 || snap.iron > snap.ironCapacity) Diagnostics.RuntimeTrace.Log("WARNING", $"Iron is out of bounds: {snap.iron}/{snap.ironCapacity}");
        }
    }
}
