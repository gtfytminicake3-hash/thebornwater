import os

content = """#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace TheBonwater.Rebuild.Editor
{
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
            bgImg.sprite = LoadDecodedSprite("Assets/_Project/ImportedDecoded/Sprite/academy.png");

            var btnNew = CreateButton(mainCanvas.transform, "NEW GAME", new Vector2(0, 50), new Vector2(300, 70));
            btnNew.name = "Btn_NewGame";
            var btnLoad = CreateButton(mainCanvas.transform, "LOAD GAME", new Vector2(0, -50), new Vector2(300, 70));
            btnLoad.name = "Btn_LoadGame";
            
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
            var sceneFlowTown = new GameObject("SceneFlow");
            sceneFlowTown.AddComponent<SceneFlowController>();

            // 1. TownWorldRoot (Visual Prototype)
            var worldRootGo = new GameObject("TownWorldRoot");
            worldRootGo.transform.SetParent(townCanvas.transform, false);
            var worldRootRect = worldRootGo.AddComponent<RectTransform>();
            worldRootRect.anchorMin = Vector2.zero; worldRootRect.anchorMax = Vector2.one; worldRootRect.sizeDelta = Vector2.zero;

            // Background
            var townBg = CreateVisualObject(worldRootGo.transform, "TownBackground", "Assets/_Project/ImportedDecoded/Texture2D/ForestFloor.png", true);
            
            // Buildings (Y: 50 to 150)
            CreateVisualObject(worldRootGo.transform, "Building_Bonfire", "Assets/_Project/ImportedDecoded/Sprite/bonfire.png", false, new Vector2(0, 100));
            CreateVisualObject(worldRootGo.transform, "Building_Hut", "Assets/_Project/ImportedDecoded/Sprite/hut.png", false, new Vector2(-200, 120));
            CreateVisualObject(worldRootGo.transform, "Building_House", "Assets/_Project/ImportedDecoded/Sprite/house.png", false, new Vector2(250, 80));
            CreateVisualObject(worldRootGo.transform, "Building_Tower", "Assets/_Project/ImportedDecoded/Sprite/guardTower.png", false, new Vector2(400, 200));

            // Villagers (Y: -50 to 50)
            CreateVisualObject(worldRootGo.transform, "Villager_1", "Assets/_Project/ImportedDecoded/Texture2D/man 1.png", false, new Vector2(-100, 0));
            CreateVisualObject(worldRootGo.transform, "Villager_2", "Assets/_Project/ImportedDecoded/Texture2D/woman.png", false, new Vector2(100, -20));

            // Resources
            CreateVisualObject(worldRootGo.transform, "ResourceNode_Tree", "Assets/_Project/ImportedDecoded/Texture2D/tree.png", false, new Vector2(-400, 150));
            CreateVisualObject(worldRootGo.transform, "ResourceNode_WoodDrop", "Assets/_Project/ImportedDecoded/Texture2D/wood.png", false, new Vector2(-350, -50));


            // 2. UI Layout
            var townView = townCanvas.AddComponent<TownView>();

            // Label
            var txtLoaded = CreateText(townCanvas.transform, "TOWN SCENE LOADED", new Vector2(0, 450), 32);
            txtLoaded.GetComponent<Text>().color = Color.green;

            // Resource Bar (Top)
            var resBar = new GameObject("ResourceBar");
            resBar.transform.SetParent(townCanvas.transform, false);
            var resRect = resBar.AddComponent<RectTransform>();
            resRect.anchorMin = new Vector2(0, 1); resRect.anchorMax = new Vector2(1, 1);
            resRect.anchoredPosition = new Vector2(0, -50);
            
            var bgRes = resBar.AddComponent<Image>(); bgRes.color = new Color(0,0,0, 0.5f);
            var resView = resBar.AddComponent<ResourceBarView>();
            resView.txtResources = CreateText(resBar.transform, "Wood: 0  Food: 0  Iron: 0", new Vector2(0, 0), 24).GetComponent<Text>();

            // Action Buttons Panel (Bottom)
            var actionPanel = new GameObject("ActionButtonsPanel");
            actionPanel.transform.SetParent(townCanvas.transform, false);
            var actRect = actionPanel.AddComponent<RectTransform>();
            actRect.anchorMin = new Vector2(0, 0); actRect.anchorMax = new Vector2(1, 0);
            actRect.anchoredPosition = new Vector2(0, 60);

            var hlg = actionPanel.AddComponent<HorizontalLayoutGroup>();
            hlg.childAlignment = TextAnchor.MiddleCenter;
            hlg.spacing = 10;
            hlg.childControlWidth = false; hlg.childControlHeight = false;

            resView.btnCollect = CreateButton(actionPanel.transform, "COLLECT WOOD", Vector2.zero, new Vector2(180, 50)).GetComponent<Button>();
            
            var menuView = actionPanel.AddComponent<BuildMenuView>();
            menuView.btnBuildHut = CreateButton(actionPanel.transform, "BUILD HUT", Vector2.zero, new Vector2(180, 50)).GetComponent<Button>();
            
            var vilView = actionPanel.AddComponent<VillagerListView>();
            vilView.txtVillagers = CreateText(townCanvas.transform, "Villagers:", new Vector2(-400, 300), 20).GetComponent<Text>(); // Left side
            vilView.btnAssign = CreateButton(actionPanel.transform, "ASSIGN WORKER", Vector2.zero, new Vector2(180, 50)).GetComponent<Button>();
            
            townView.btnAdvanceTime = CreateButton(actionPanel.transform, "ADVANCE TIME", Vector2.zero, new Vector2(180, 50)).GetComponent<Button>();
            townView.btnSave = CreateButton(actionPanel.transform, "SAVE", Vector2.zero, new Vector2(180, 50)).GetComponent<Button>();

            // Debug Panel (Bottom-Right)
            var dbgPanel = new GameObject("DebugPanel");
            dbgPanel.transform.SetParent(townCanvas.transform, false);
            var dbgRect = dbgPanel.AddComponent<RectTransform>();
            dbgRect.anchorMin = new Vector2(1, 0); dbgRect.anchorMax = new Vector2(1, 0);
            dbgRect.anchoredPosition = new Vector2(-200, 200);
            dbgRect.sizeDelta = new Vector2(350, 250);
            var dbgImg = dbgPanel.AddComponent<Image>(); dbgImg.color = new Color(0,0,0,0.5f);
            
            var dbgView = dbgPanel.AddComponent<DebugStateView>();
            dbgView.txtDebug = CreateText(dbgPanel.transform, "Debug State\\nSnapshot:...", new Vector2(0, 0), 16).GetComponent<Text>();

            // Other lists
            var bldView = townCanvas.AddComponent<BuildingListView>();
            bldView.txtBuildings = CreateText(townCanvas.transform, "Buildings:", new Vector2(-400, 100), 20).GetComponent<Text>();

            var logView = townCanvas.AddComponent<TaskLogView>();
            logView.txtLog = CreateText(townCanvas.transform, "Logs", new Vector2(-400, -100), 20).GetComponent<Text>();

            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");

            Debug.Log("Town Visual Prototype generated successfully!");
        }

        private static GameObject CreateVisualObject(Transform parent, string name, string assetPath, bool isBackground, Vector2 pos = default)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var img = go.AddComponent<Image>();
            img.raycastTarget = false;
            
            var sprite = LoadDecodedSprite(assetPath);
            if (sprite != null) {
                img.sprite = sprite;
                img.SetNativeSize();
            } else {
                img.color = new Color(Random.value, Random.value, Random.value, 1f);
                go.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);
            }

            var rect = go.GetComponent<RectTransform>();
            if (isBackground) {
                rect.anchorMin = Vector2.zero; rect.anchorMax = Vector2.one;
                rect.sizeDelta = Vector2.zero;
            } else {
                rect.anchoredPosition = pos;
            }
            return go;
        }

        private static Sprite LoadDecodedSprite(string path)
        {
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
            go.AddComponent<CanvasScaler>();
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
            rect.sizeDelta = size;
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
