using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class HealthBarView : MonoBehaviour {
        public string targetId;
        public string targetType;
        
        private int maxHp = -1;
        public int MaxHp => maxHp;
        
        private Image fillImage;
        private Image bgImage;

        public void Initialize(string id, string type, int fallbackMaxHp) {
            targetId = id;
            targetType = type;
            maxHp = fallbackMaxHp;

            var bg = new GameObject("HealthBarBg");
            bg.transform.SetParent(transform, false);
            var bgRt = bg.AddComponent<RectTransform>();
            bgRt.anchoredPosition = new Vector2(0, 30);
            bgRt.sizeDelta = new Vector2(40, 6);
            bgImage = bg.AddComponent<Image>();
            bgImage.color = new Color(0.2f, 0.2f, 0.2f, 0.8f);

            var fill = new GameObject("HealthBarFill");
            fill.transform.SetParent(bg.transform, false);
            var fillRt = fill.AddComponent<RectTransform>();
            fillRt.anchorMin = new Vector2(0, 0);
            fillRt.anchorMax = new Vector2(1, 1);
            fillRt.offsetMin = Vector2.zero;
            fillRt.offsetMax = Vector2.zero;
            fillImage = fill.AddComponent<Image>();
            fillImage.color = targetType == "enemy" ? Color.red : Color.green;

            Diagnostics.RuntimeTrace.Log("HP_BAR_ATTACH", $"target={targetId} type={targetType} maxHp={maxHp}");
        }

        public void UpdateHp(int currentHp) {
            if (maxHp <= 0) {
                maxHp = Mathf.Max(currentHp, 20); // Safety fallback
            }
            if (currentHp > maxHp) {
                maxHp = currentHp; // Adjust if max HP increases dynamically
            }
            
            float fillAmount = (float)currentHp / maxHp;
            
            if (fillImage != null) {
                var rt = fillImage.rectTransform;
                rt.anchorMax = new Vector2(Mathf.Clamp01(fillAmount), 1);
            }

            Diagnostics.RuntimeTrace.Log("HP_BAR_UPDATE", $"target={targetId} hp={currentHp}/{maxHp}");
        }
    }
}
