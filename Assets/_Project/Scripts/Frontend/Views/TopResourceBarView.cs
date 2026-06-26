using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class TopResourceBarView : MonoBehaviour {
        [Header("Legacy")]
        public Text txtResources;

        [Header("Fixed HUD Slots")]
        public Text timeText;
        public Text resourceText;
        public Text popDefenseText;
        public Text objectiveText;
        public Text statusText;

        private AutoTimeController autoTime;
        private string cachedDayPhase = "DAY 1 - MORNING";
        
        private string strWoodFoodIron = "";
        private string strPopDef = "";
        private string strObj = "";
        private string strStatus = "";

        private void SetTextLayout(Text text, float yPos, float height) {
            if (text == null) return;
            var rt = text.GetComponent<RectTransform>();
            if (rt != null) {
                rt.anchorMin = new Vector2(0.5f, 1f);
                rt.anchorMax = new Vector2(0.5f, 1f);
                rt.pivot = new Vector2(0.5f, 1f);
                rt.sizeDelta = new Vector2(rt.sizeDelta.x > 100f ? rt.sizeDelta.x : 600f, height);
                rt.anchoredPosition = new Vector2(rt.anchoredPosition.x, yPos);
            }
            text.alignment = TextAnchor.UpperCenter;
            text.horizontalOverflow = HorizontalWrapMode.Overflow;
            text.verticalOverflow = VerticalWrapMode.Overflow;
        }

        private void Start() {
            autoTime = FindObjectOfType<AutoTimeController>();
            if (autoTime != null) {
                Diagnostics.RuntimeTrace.Log("TIME_DISPLAY_BOUND", "source=AutoTimeController");
            }
            
            // Try to bind if references are missing
            if (timeText == null || resourceText == null) {
                Transform parent = txtResources != null ? txtResources.transform.parent : transform;
                
                timeText = GetOrCreateSlot(parent, "HUD_TimeText", -20);
                resourceText = GetOrCreateSlot(parent, "HUD_ResourceText", -40);
                popDefenseText = GetOrCreateSlot(parent, "HUD_PopDefenseText", -60);
                objectiveText = GetOrCreateSlot(parent, "HUD_ObjectiveText", -80);
                statusText = GetOrCreateSlot(parent, "HUD_StatusText", -135);
            }

            // Force correct vertical positions and heights at runtime
            if (timeText != null) SetTextLayout(timeText, -20, 20);
            if (resourceText != null) SetTextLayout(resourceText, -40, 20);
            if (popDefenseText != null) SetTextLayout(popDefenseText, -60, 20);
            if (objectiveText != null) SetTextLayout(objectiveText, -80, 50);
            if (statusText != null) SetTextLayout(statusText, -135, 20);

            if (txtResources != null && timeText != null && txtResources.gameObject != timeText.gameObject) {
                txtResources.gameObject.SetActive(false);
            }
            
            // HUD Layout Audit Logging
            var hudRoot = GameObject.Find("HUDRoot");
            if (hudRoot != null) {
                var parentName = hudRoot.transform.parent != null ? hudRoot.transform.parent.name : "null";
                UnityEngine.Debug.Log($"[HUDLayout] HUDRoot parent={parentName} scale={hudRoot.transform.localScale}");
                
                var worldRoot = GameObject.Find("TownWorldRoot");
                if (worldRoot == null) worldRoot = GameObject.Find("WorldRoot");
                bool isUnderWorldRoot = worldRoot != null && hudRoot.transform.IsChildOf(worldRoot.transform);
                UnityEngine.Debug.Log($"[HUDLayout] HUDRoot is under WorldRoot={isUnderWorldRoot}");
                
                if (isUnderWorldRoot) {
                    hudRoot.transform.SetParent(worldRoot.transform.parent, true); // move it out safely
                    UnityEngine.Debug.Log($"[HUDLayout] HUDRoot moved out of WorldRoot to {hudRoot.transform.parent.name}");
                }
            }

            if (timeText != null) {
                var rt = timeText.GetComponent<RectTransform>();
                UnityEngine.Debug.Log($"[HUDLayout] TopHUD anchoredPosition={rt.anchoredPosition} size={rt.sizeDelta} anchors={rt.anchorMin}/{rt.anchorMax}");
                UnityEngine.Debug.Log($"[HUDLayout] TopHUD safeMargin=24");
            }
        }
        
        private Text GetOrCreateSlot(Transform parent, string name, float yPos) {
            Transform t = parent.Find(name);
            if (t != null) return t.GetComponent<Text>();

            GameObject go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.5f, 1f);
            rt.anchorMax = new Vector2(0.5f, 1f);
            rt.pivot = new Vector2(0.5f, 1f);
            rt.sizeDelta = new Vector2(600, 20);
            rt.anchoredPosition = new Vector2(0, yPos);

            var txt = go.AddComponent<Text>();
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            txt.fontSize = 18;
            txt.alignment = TextAnchor.UpperCenter;
            txt.color = Color.white;
            txt.horizontalOverflow = HorizontalWrapMode.Overflow;
            txt.verticalOverflow = VerticalWrapMode.Overflow;
            
            var outline = go.AddComponent<Outline>();
            outline.effectColor = new Color(0,0,0,0.8f);
            outline.effectDistance = new Vector2(1, -1);
            
            return txt;
        }
        


        private void Update() {
            if (autoTime == null && TownInteractionController.Instance != null) {
                autoTime = TownInteractionController.Instance.GetComponent<AutoTimeController>();
                if (autoTime != null) Diagnostics.RuntimeTrace.Log("TIME_DISPLAY_BOUND", "source=AutoTimeController");
            }

            string timeStr = "";
            if (autoTime != null && autoTime.IsRunning) {
                timeStr = $" | {Mathf.CeilToInt(autoTime.TimeRemaining)}s";
            }

            if (timeText != null) {
                timeText.text = $"{cachedDayPhase}{timeStr}";
            }
        }

        public void UpdateView(GameSnapshot snap) {
            if (snap == null) return;
            string wName = DefinitionDisplayService.GetResourceName("wood").ToUpper();
            string fName = DefinitionDisplayService.GetResourceName("food").ToUpper();
            string iName = DefinitionDisplayService.GetResourceName("iron").ToUpper();
            string sName = DefinitionDisplayService.GetResourceName("steel").ToUpper();
            string cName = DefinitionDisplayService.GetResourceName("coal").ToUpper();
            
            cachedDayPhase = $"DAY {snap.day} - {snap.timeOfDay.ToUpper()}";
            
            strWoodFoodIron = $"{wName}: {snap.wood}/{snap.woodCapacity}   {fName}: {snap.food}/{snap.foodCapacity}   {iName}: {snap.iron}/{snap.ironCapacity}   {cName}: {snap.coal}/{snap.coalCapacity}   {sName}: {snap.steel}/{snap.steelCapacity}";
            
            int alivePop = 0;
            foreach(var v in snap.villagers) { if (v.hp > 0) alivePop++; }
            
            strPopDef = $"POP: {alivePop} / {snap.maxPopulation}    DEF: {snap.totalDefense} vs Raid";
            
            string objStatus = snap.gameStatus == "Playing" ? "Playing" : snap.gameStatus;
            
            strObj = $"Objective: {snap.objectiveText}";
            strStatus = $"Status: {objStatus}";

            if (resourceText != null) resourceText.text = strWoodFoodIron;
            if (popDefenseText != null) popDefenseText.text = strPopDef;
            if (objectiveText != null) objectiveText.text = strObj;
            if (statusText != null) statusText.text = strStatus;

            Diagnostics.RuntimeTrace.Log("DEFENSE_DISPLAY_UPDATE", $"defense={snap.totalDefense}");
        }
    }
}
