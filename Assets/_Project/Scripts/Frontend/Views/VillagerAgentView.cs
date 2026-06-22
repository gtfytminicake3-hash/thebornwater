using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class VillagerAgentView : MonoBehaviour {
        public string villagerId;
        public string currentJob;
        public string visualState;
        public Vector2 currentTarget;
        public float moveSpeed = 100f;
        public RectTransform rectTransform;
        public string targetId = "";
        private const bool DEBUG_AGENT = false;
        
        public Vector2 homePosition;
        public bool IsAtHome => Vector2.Distance(rectTransform.anchoredPosition, homePosition) <= 5f;

        private void Awake() {
            rectTransform = GetComponent<RectTransform>();
            homePosition = rectTransform.anchoredPosition; // Initial home
            var btn = gameObject.GetComponent<Button>() ?? gameObject.AddComponent<Button>();
            btn.onClick.AddListener(OnClick);
        }

        public void SetHomePosition(Vector2 pos) {
            homePosition = pos;
        }

        public void ReturnHome() {
            if (!IsAtHome) {
                SetTarget(homePosition, "home");
                Diagnostics.RuntimeTrace.Log("GUARD_RETURN_HOME", $"guard={villagerId} home=custom");
            }
        }

        private void OnClick() {
            UnityEngine.Debug.Log($"[VILLAGER_CLICKED] id={villagerId}");
            if (TownInteractionController.Instance != null) {
                TownInteractionController.Instance.ExecuteCommand(new SelectVillagerCommand { villagerId = villagerId });
                TownInteractionController.Instance.RefreshUI();
            }
            if (GameplayUIManager.Instance != null && GameplayUIManager.Instance.selectedVillagerPanel != null) {
                GameplayUIManager.Instance.selectedVillagerPanel.OpenJobModalForVillager(villagerId);
            }
        }

        public void SetTarget(Vector2 target, string tId) {
            if (Vector2.Distance(rectTransform.anchoredPosition, target) > 5f) {
                currentTarget = target;
                targetId = tId;
                visualState = "Moving";
                if (DEBUG_AGENT) UnityEngine.Debug.Log($"[AGENT_MOVE] villager={villagerId} from={rectTransform.anchoredPosition} to={target}");
            } else {
                visualState = "Working";
                if (targetId != tId) {
                    targetId = tId;
                    if (DEBUG_AGENT) UnityEngine.Debug.Log($"[AGENT_WORK] villager={villagerId} job={currentJob} target={targetId}");
                }
            }
        }

        private void Update() {
            if (rectTransform != null && visualState == "Moving") {
                Vector2 pos = rectTransform.anchoredPosition;
                if (Vector2.Distance(pos, currentTarget) > 1f) {
                    rectTransform.anchoredPosition = Vector2.MoveTowards(pos, currentTarget, moveSpeed * Time.deltaTime);
                } else {
                    visualState = "Working";
                    UnityEngine.Debug.Log($"[AGENT_WORK] villager={villagerId} job={currentJob} target={targetId}");
                }
            }
        }
    }
}
