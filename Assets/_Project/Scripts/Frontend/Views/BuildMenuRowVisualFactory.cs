using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public static class BuildMenuRowVisualFactory
    {
        public static Sprite LoadSprite(string assetPath)
        {
            if (string.IsNullOrEmpty(assetPath)) return null;
            
            try {
                if (System.IO.File.Exists(assetPath)) {
                    var bytes = System.IO.File.ReadAllBytes(assetPath);
                    var tex = new Texture2D(2, 2);
                    if (tex.LoadImage(bytes)) {
                        return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
                    }
                }
            }
            catch (System.Exception ex) {
                UnityEngine.Debug.LogWarning($"[BuildMenuRowVisualFactory] Failed to load sprite at {assetPath} via System.IO: {ex.Message}");
            }
            
#if UNITY_EDITOR
            try {
                var loadedSprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
                if (loadedSprite != null) return loadedSprite;
                
                var tex2d = UnityEditor.AssetDatabase.LoadAssetAtPath<Texture2D>(assetPath);
                if (tex2d != null) {
                    return Sprite.Create(tex2d, new Rect(0, 0, tex2d.width, tex2d.height), new Vector2(0.5f, 0.5f));
                }
            }
            catch (System.Exception ex) {
                UnityEngine.Debug.LogWarning($"[BuildMenuRowVisualFactory] Failed to load sprite at {assetPath} via AssetDatabase: {ex.Message}");
            }
#endif
            return null;
        }

        public static GameObject CreateRow(
            Transform parent,
            string goName,
            string displayName,
            string costText,
            string statusText,
            Color statusColor,
            Sprite iconSprite,
            bool isUpgrade,
            bool isEditorPreview,
            Font font,
            System.Action onClickAction = null)
        {
            var rowGo = new GameObject(goName);
            rowGo.transform.SetParent(parent, false);
            
            var rect = rowGo.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(300, 60);

            var le = rowGo.AddComponent<LayoutElement>();
            le.preferredHeight = 60f;

            var img = rowGo.AddComponent<Image>();
            img.color = isUpgrade ? new Color(0.35f, 0.25f, 0.15f, 0.95f) : new Color(0.3f, 0.3f, 0.3f, 0.95f);

            var btn = rowGo.AddComponent<Button>();
            btn.navigation = new Navigation { mode = Navigation.Mode.None };
            
            if (!isEditorPreview && onClickAction != null)
            {
                btn.onClick.AddListener(() => onClickAction());
            }

            // Create Icon GameObject (Always created so layout is uniform)
            var iconGo = new GameObject("Icon");
            iconGo.transform.SetParent(rowGo.transform, false);
            var iRect = iconGo.AddComponent<RectTransform>();
            iRect.anchorMin = new Vector2(0f, 0.5f);
            iRect.anchorMax = new Vector2(0f, 0.5f);
            iRect.sizeDelta = new Vector2(60f, 60f);
            iRect.anchoredPosition = new Vector2(40f, 0f);

            var iImg = iconGo.AddComponent<Image>();
            if (iconSprite != null)
            {
                iImg.sprite = iconSprite;
                iImg.color = Color.white;
            }
            else
            {
                iImg.sprite = null;
                // Visible dark gray fallback box
                iImg.color = new Color(0.2f, 0.2f, 0.2f, 1f);
            }
            iImg.preserveAspect = true;
            iImg.raycastTarget = false;

            // Create Text GameObject (always offset by 80 to make room for icon)
            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(rowGo.transform, false);
            var tRect = txtGo.AddComponent<RectTransform>();
            tRect.anchorMin = Vector2.zero;
            tRect.anchorMax = Vector2.one;
            tRect.offsetMin = new Vector2(80f, 0f);
            tRect.offsetMax = Vector2.zero;

            var txt = txtGo.AddComponent<Text>();
            txt.font = font;
            txt.text = $"<b>{displayName}</b>\n{costText}";
            txt.alignment = TextAnchor.MiddleLeft;
            txt.color = Color.white;
            txt.fontSize = 20;
            txt.supportRichText = true;
            txt.raycastTarget = false;

            // Create StatusText GameObject
            var stGo = new GameObject("StatusText");
            stGo.transform.SetParent(rowGo.transform, false);
            var stRect = stGo.AddComponent<RectTransform>();
            stRect.anchorMin = Vector2.zero;
            stRect.anchorMax = Vector2.one;
            stRect.offsetMin = Vector2.zero;
            stRect.offsetMax = new Vector2(-10f, 0f);

            var stTxt = stGo.AddComponent<Text>();
            stTxt.font = font;
            stTxt.text = statusText;
            stTxt.alignment = TextAnchor.MiddleRight;
            stTxt.color = statusColor;
            stTxt.fontSize = 16;
            stTxt.supportRichText = true;
            stTxt.raycastTarget = false;

            return rowGo;
        }
    }
}
