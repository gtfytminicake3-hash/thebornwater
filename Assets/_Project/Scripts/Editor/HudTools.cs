using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using TheBonwater.Rebuild;

namespace TheBonwater.Rebuild.EditorTools {
    public static class HudTools {
        [MenuItem("Tools/TheBonwater/UI/Create or Repair Top HUD Form")]
        public static void CreateOrRepairTopHudForm() {
            Canvas canvas = Object.FindObjectOfType<Canvas>();
            if (canvas == null) {
                Debug.LogError("No Canvas found in scene.");
                return;
            }

            Transform topHud = canvas.transform.Find("TopHudPanel");
            GameObject topHudGo;
            if (topHud == null) {
                topHudGo = new GameObject("TopHudPanel");
                topHud = topHudGo.transform;
                topHud.SetParent(canvas.transform, false);
                var rt = topHudGo.AddComponent<RectTransform>();
                rt.anchorMin = new Vector2(0.5f, 1f);
                rt.anchorMax = new Vector2(0.5f, 1f);
                rt.pivot = new Vector2(0.5f, 1f);
                rt.anchoredPosition = new Vector2(0, -10);
                rt.sizeDelta = new Vector2(800, 150);
                Undo.RegisterCreatedObjectUndo(topHudGo, "Create TopHudPanel");
            } else {
                topHudGo = topHud.gameObject;
            }

            Text timeText = GetOrCreateText(topHud, "HUD_TimeText", 0);
            Text resourceText = GetOrCreateText(topHud, "HUD_ResourceText", -25);
            Text popDefenseText = GetOrCreateText(topHud, "HUD_PopDefenseText", -50);
            Text objectiveText = GetOrCreateText(topHud, "HUD_ObjectiveText", -75);
            Text statusText = GetOrCreateText(topHud, "HUD_StatusText", -130);

            // Bind to TopResourceBarView if exists
            TopResourceBarView view = Object.FindObjectOfType<TopResourceBarView>();
            if (view != null) {
                Undo.RecordObject(view, "Bind HUD Texts");
                view.timeText = timeText;
                view.resourceText = resourceText;
                view.popDefenseText = popDefenseText;
                view.objectiveText = objectiveText;
                view.statusText = statusText;
                
                if (view.txtResources != null && view.txtResources.gameObject != timeText.gameObject) {
                    view.txtResources.gameObject.SetActive(false);
                }
            }

            if (!Application.isPlaying) {
                UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene());
            }

            Debug.Log("Top HUD Form created/repaired successfully.");
        }

        private static Text GetOrCreateText(Transform parent, string name, float yPos) {
            Transform t = parent.Find(name);
            Text txt;
            if (t != null) {
                txt = t.GetComponent<Text>();
                var rt = t.GetComponent<RectTransform>();
                if (rt != null) {
                    rt.anchoredPosition = new Vector2(0, yPos);
                    rt.sizeDelta = new Vector2(800, name == "HUD_ObjectiveText" ? 50 : 30);
                }
            } else {
                GameObject go = new GameObject(name);
                Undo.RegisterCreatedObjectUndo(go, $"Create {name}");
                go.transform.SetParent(parent, false);
                var rt = go.AddComponent<RectTransform>();
                rt.anchorMin = new Vector2(0.5f, 1f);
                rt.anchorMax = new Vector2(0.5f, 1f);
                rt.pivot = new Vector2(0.5f, 1f);
                rt.sizeDelta = new Vector2(800, name == "HUD_ObjectiveText" ? 50 : 30);
                rt.anchoredPosition = new Vector2(0, yPos);

                txt = go.AddComponent<Text>();
                txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txt.fontSize = 20;
                txt.alignment = TextAnchor.UpperCenter;
                txt.color = Color.white;
                txt.horizontalOverflow = HorizontalWrapMode.Overflow;
                txt.verticalOverflow = VerticalWrapMode.Overflow;
                
                var outline = go.AddComponent<Outline>();
                outline.effectColor = new Color(0,0,0,0.8f);
                outline.effectDistance = new Vector2(1, -1);
            }
            return txt;
        }
    }
}
