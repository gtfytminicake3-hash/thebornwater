import os

content = """#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

namespace TheBonwater.Rebuild.Editor
{
    [System.Serializable]
    public class TownLayoutDef {
        public TownObjectDef[] objects;
    }
    [System.Serializable]
    public class TownObjectDef {
        public string id;
        public string role;
        public string asset;
        public float x, y, width, height;
        public int layer;
    }

    public class RebuildSceneGenerator
    {
        [MenuItem("Tools/Rebuild/Create UI MVP Scenes")]
        public static void CreateScenes()
        {
            string basePath = "Assets/_Project/Scenes/";
            if (!AssetDatabase.IsValidFolder("Assets/_Project/Scenes"))
                AssetDatabase.CreateFolder("Assets/_Project", "Scenes");

            // --- BootScene ---
            var bootScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            var bootObj = new GameObject("Bootstrapper");
            bootObj.AddComponent<GameBootstrap>();
            EditorSceneManager.SaveScene(bootScene, basePath + "BootScene.unity");

            // --- MainMenuScene ---
            var mainScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            var mainCanvas = CreateCanvas("MainMenuUIRoot");
            
            var bgGo = new GameObject("DecodedAssetBackground");
            bgGo.transform.SetParent(mainCanvas.transform, false);
            var bgImg = bgGo.AddComponent<Image>();
            bgImg.raycastTarget = false;
            var bgRect = bgGo.GetComponent<RectTransform>();
            bgRect.anchorMin = Vector2.zero; bgRect.anchorMax = Vector2.one; bgRect.sizeDelta = Vector2.zero;
            bgImg.sprite = LoadDecodedSprite("Assets/_Project/ImportedDecoded/Texture2D/ForestFloor.png");

            var title = CreateText(mainCanvas.transform, "TOWN VISUAL PROTOTYPE", new Vector2(0, 300), 40);

            var btnNew = CreateButton(mainCanvas.transform, "NEW GAME", new Vector2(0, 50), new Vector2(300, 70));
            var btnLoad = CreateButton(mainCanvas.transform, "LOAD GAME", new Vector2(0, -50), new Vector2(300, 70));
            
            var loaderObj = new GameObject("MainMenuDirectLoader");
            var loader = loaderObj.AddComponent<TheBonwater.Rebuild.Frontend.MainMenuButtonDirectLoader>();
            loader.targetSceneName = "TownScene";

            UnityEditor.Events.UnityEventTools.AddVoidPersistentListener(btnNew.GetComponent<Button>().onClick, new UnityEngine.Events.UnityAction(loader.NewGame));
            UnityEditor.Events.UnityEventTools.AddVoidPersistentListener(btnLoad.GetComponent<Button>().onClick, new UnityEngine.Events.UnityAction(loader.LoadGame));
            
            EditorSceneManager.SaveScene(mainScene, basePath + "MainMenuScene.unity");

            // --- LoadingScene ---
            var loadScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            var loadCanvas = CreateCanvas("Canvas");
            loadCanvas.AddComponent<LoadingView>();
            var txtLoad = CreateText(loadCanvas.transform, "Loading...", new Vector2(0,0), 40);
            var sceneFlowLoad = new GameObject("SceneFlow");
            sceneFlowLoad.AddComponent<SceneFlowController>();
            EditorSceneManager.SaveScene(loadScene, basePath + "LoadingScene.unity");

            // --- TownScene ---
            var townScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            
            var townCanvas = CreateCanvas("TownUIRoot");
            
            var safeAreaGo = new GameObject("SafeAreaRoot");
            safeAreaGo.transform.SetParent(townCanvas.transform, false);
            var safeAreaRect = safeAreaGo.AddComponent<RectTransform>();
            safeAreaRect.anchorMin = Vector2.zero; safeAreaRect.anchorMax = Vector2.one; safeAreaRect.sizeDelta = Vector2.zero;

            // TownWorldPanel
            var worldPanelGo = new GameObject("TownWorldPanel");
            worldPanelGo.transform.SetParent(safeAreaGo.transform, false);
            var worldPanelRect = worldPanelGo.AddComponent<RectTransform>();
            worldPanelRect.anchorMin = Vector2.zero; worldPanelRect.anchorMax = Vector2.one; worldPanelRect.sizeDelta = Vector2.zero;

            // Load Layout JSON
            string jsonPath = "Assets/_Project/Data/Definitions/town_visual_layout.json";
            TownLayoutDef layout = null;
            if (File.Exists(jsonPath)) {
                layout = JsonUtility.FromJson<TownLayoutDef>(File.ReadAllText(jsonPath));
            }

            // TownWorldRoot inside TownWorldPanel
            var worldRootGo = new GameObject("TownWorldRoot");
            worldRootGo.transform.SetParent(worldPanelGo.transform, false);
            var worldRootRect = worldRootGo.AddComponent<RectTransform>();
            worldRootRect.anchoredPosition = new Vector2(0, 50);

            if (layout != null && layout.objects != null) {
                foreach(var obj in layout.objects) {
                    var go = new GameObject(obj.id);
                    var img = go.AddComponent<Image>();
                    img.raycastTarget = false;
                    
                    if (!string.IsNullOrEmpty(obj.asset)) {
                        img.sprite = LoadDecodedSprite(obj.asset);
                    } else {
                        // Fallback colors for rejected assets
                        if (obj.role == "bonfire") img.color = new Color(1f, 0.5f, 0f);
                        else if (obj.role == "hut") img.color = new Color(0.6f, 0.3f, 0.1f);
                        else if (obj.role == "house") img.color = new Color(0.5f, 0.5f, 0.5f);
                        else if (obj.role == "tower") img.color = new Color(0.3f, 0.3f, 0.3f);
                        else img.color = Color.magenta;
                    }

                    var rect = go.GetComponent<RectTransform>();
                    if (obj.role == "background") {
                        go.name = "TownBackground";
                        go.transform.SetParent(worldPanelGo.transform, false);
                        go.transform.SetSiblingIndex(0);
                        rect.anchorMin = Vector2.zero; rect.anchorMax = Vector2.one;
                        rect.sizeDelta = Vector2.zero;
                    } else {
                        go.transform.SetParent(worldRootGo.transform, false);
                        rect.anchoredPosition = new Vector2(obj.x, obj.y);
                        rect.sizeDelta = new Vector2(obj.width, obj.height);
                    }
                }
            }

            var townView = townCanvas.AddComponent<TownView>();

            // Resource Bar (y = 850)
            var resBar = new GameObject("ResourceBar");
            resBar.transform.SetParent(safeAreaGo.transform, false);
            var resRect = resBar.AddComponent<RectTransform>();
            resRect.anchoredPosition = new Vector2(0, 850);
            resRect.sizeDelta = new Vector2(1000, 60);
            var bgRes = resBar.AddComponent<Image>(); bgRes.color = new Color(0,0,0, 0.5f);
            
            var resView = resBar.AddComponent<ResourceBarView>();
            resView.txtResources = CreateText(resBar.transform, "Wood: 0   Food: 0   Iron: 0", Vector2.zero, 28).GetComponent<Text>();
            resView.txtResources.rectTransform.sizeDelta = new Vector2(1000, 60);

            // ActionButtonsPanel (y = -820)
            var actionPanel = new GameObject("ActionPanel");
            actionPanel.transform.SetParent(safeAreaGo.transform, false);
            var actRect = actionPanel.AddComponent<RectTransform>();
            actRect.anchoredPosition = new Vector2(0, -820);
            actRect.sizeDelta = new Vector2(1000, 120);

            var glg = actionPanel.AddComponent<GridLayoutGroup>();
            glg.cellSize = new Vector2(180, 50);
            glg.spacing = new Vector2(10, 10);
            glg.childAlignment = TextAnchor.MiddleCenter;

            resView.btnCollect = CreateButton(actionPanel.transform, "COLLECT WOOD", Vector2.zero, Vector2.zero).GetComponent<Button>();
            
            var menuView = actionPanel.AddComponent<BuildMenuView>();
            menuView.btnBuildHut = CreateButton(actionPanel.transform, "BUILD HUT", Vector2.zero, Vector2.zero).GetComponent<Button>();
            
            var vilView = actionPanel.AddComponent<VillagerListView>();
            vilView.btnAssign = CreateButton(actionPanel.transform, "ASSIGN WORKER", Vector2.zero, Vector2.zero).GetComponent<Button>();
            
            townView.btnAdvanceTime = CreateButton(actionPanel.transform, "ADVANCE TIME", Vector2.zero, Vector2.zero).GetComponent<Button>();
            townView.btnSave = CreateButton(actionPanel.transform, "SAVE", Vector2.zero, Vector2.zero).GetComponent<Button>();

            // DebugPanel (x = 320, y = -520)
            var dbgPanel = new GameObject("DebugPanel");
            dbgPanel.transform.SetParent(safeAreaGo.transform, false);
            var dbgRect = dbgPanel.AddComponent<RectTransform>();
            dbgRect.anchoredPosition = new Vector2(320, -520);
            dbgRect.sizeDelta = new Vector2(350, 250);
            var dbgImg = dbgPanel.AddComponent<Image>(); dbgImg.color = new Color(0,0,0,0.5f);
            
            var dbgView = dbgPanel.AddComponent<DebugStateView>();
            dbgView.txtDebug = CreateText(dbgPanel.transform, "Debug State...", Vector2.zero, 18).GetComponent<Text>();
            dbgView.txtDebug.rectTransform.sizeDelta = new Vector2(330, 230);

            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");

            Debug.Log("Clean Town Visual Slice generated successfully!");
        }

        private static Sprite LoadDecodedSprite(string path)
        {
            if (!File.Exists(path)) return null;
            var importer = AssetImporter.GetAtPath(path) as TextureImporter;
            if (importer != null && importer.textureType != TextureImporterType.Sprite) {
                importer.textureType = TextureImporterType.Sprite;
                importer.SaveAndReimport();
            }
            return AssetDatabase.LoadAssetAtPath<Sprite>(path);
        }

        private static GameObject CreateCamera()
        {
            var go = new GameObject("Main Camera");
            go.tag = "MainCamera";
            var cam = go.AddComponent<Camera>();
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = new Color(0.1f, 0.1f, 0.1f);
            return go;
        }

        private static GameObject CreateCanvas(string name)
        {
            var go = new GameObject(name);
            var canvas = go.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            var scaler = go.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1080, 1920);
            scaler.matchWidthOrHeight = 0.5f;
            
            go.AddComponent<GraphicRaycaster>();
            
            if (Object.FindObjectOfType<EventSystem>() == null)
            {
                var eventSystem = new GameObject("EventSystem");
                eventSystem.AddComponent<EventSystem>();
                eventSystem.AddComponent<StandaloneInputModule>();
            }
            return go;
        }

        private static GameObject CreateButton(Transform parent, string name, Vector2 pos, Vector2 size)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            if (size != Vector2.zero) rect.sizeDelta = size;
            var img = go.AddComponent<Image>();
            img.color = new Color(0.2f, 0.6f, 0.8f);
            go.AddComponent<Button>();
            
            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(go.transform, false);
            var txtRect = txtGo.AddComponent<RectTransform>();
            txtRect.anchorMin = Vector2.zero; txtRect.anchorMax = Vector2.one;
            txtRect.sizeDelta = Vector2.zero;
            var txt = txtGo.AddComponent<Text>();
            txt.text = name;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.color = Color.white;
            txt.fontSize = 20;
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");

            return go;
        }

        private static GameObject CreateText(Transform parent, string content, Vector2 pos, int fontSize)
        {
            var go = new GameObject("Text");
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            rect.sizeDelta = new Vector2(400, 100);
            var txt = go.AddComponent<Text>();
            txt.text = content;
            txt.color = Color.white;
            txt.fontSize = fontSize;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            return go;
        }
    }
}
#endif
"""

with open(r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildSceneGenerator.cs", "w", encoding="utf-8") as f:
    f.write(content)

print("Updated RebuildSceneGenerator.cs via python!")
