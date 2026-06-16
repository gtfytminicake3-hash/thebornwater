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
            
            // Assign DecodedAssetBackground
            var bgGo = new GameObject("DecodedAssetBackground");
            bgGo.transform.SetParent(mainCanvas.transform, false);
            var bgImg = bgGo.AddComponent<Image>();
            var bgRect = bgGo.GetComponent<RectTransform>();
            bgRect.anchorMin = Vector2.zero; bgRect.anchorMax = Vector2.one; bgRect.sizeDelta = Vector2.zero;
            
            string academyPath = "Assets/_Project/ImportedDecoded/Sprite/academy.png";
            var importer = AssetImporter.GetAtPath(academyPath) as TextureImporter;
            if (importer != null && importer.textureType != TextureImporterType.Sprite) {
                importer.textureType = TextureImporterType.Sprite;
                importer.SaveAndReimport();
            }
            var academySprite = AssetDatabase.LoadAssetAtPath<Sprite>(academyPath);
            if (academySprite != null) {
                bgImg.sprite = academySprite;
                Debug.Log("[Rebuild] academy.png successfully assigned to DecodedAssetBackground!");
            }

            var btnNew = CreateButton(mainCanvas.transform, "Btn_NewGame", new Vector2(0, 50));
            var btnLoad = CreateButton(mainCanvas.transform, "Btn_LoadGame", new Vector2(0, -50));
            var mainView = mainCanvas.AddComponent<MainMenuView>();
            mainView.btnNewGame = btnNew.GetComponent<Button>();
            mainView.btnLoadGame = btnLoad.GetComponent<Button>();
            var sceneFlowMain = new GameObject("SceneFlow");
            sceneFlowMain.AddComponent<SceneFlowController>();
            EditorSceneManager.SaveScene(mainScene, basePath + "MainMenuScene.unity");

            // --- LoadingScene ---
            var loadScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            var loadCanvas = CreateCanvas("Canvas");
            loadCanvas.AddComponent<LoadingView>();
            var txtLoad = CreateText(loadCanvas.transform, "Loading...", new Vector2(0,0));
            var sceneFlowLoad = new GameObject("SceneFlow");
            sceneFlowLoad.AddComponent<SceneFlowController>();
            EditorSceneManager.SaveScene(loadScene, basePath + "LoadingScene.unity");

            // --- TownScene ---
            var townScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            var townCanvas = CreateCanvas("TownUIRoot");
            var sceneFlowTown = new GameObject("SceneFlow");
            sceneFlowTown.AddComponent<SceneFlowController>();

            var townView = townCanvas.AddComponent<TownView>();
            townView.btnAdvanceTime = CreateButton(townCanvas.transform, "Btn_AdvanceTime", new Vector2(300, 200)).GetComponent<Button>();
            townView.btnSave = CreateButton(townCanvas.transform, "Btn_Save", new Vector2(300, 100)).GetComponent<Button>();

            var resView = townCanvas.AddComponent<ResourceBarView>();
            resView.txtResources = CreateText(townCanvas.transform, "Resources: 0", new Vector2(0, 300)).GetComponent<Text>();
            resView.btnCollect = CreateButton(townCanvas.transform, "Btn_CollectWood", new Vector2(0, 250)).GetComponent<Button>();

            var vilView = townCanvas.AddComponent<VillagerListView>();
            vilView.txtVillagers = CreateText(townCanvas.transform, "Villagers:", new Vector2(-300, 100)).GetComponent<Text>();
            vilView.btnAssign = CreateButton(townCanvas.transform, "Btn_Assign", new Vector2(-300, -100)).GetComponent<Button>();

            var bldView = townCanvas.AddComponent<BuildingListView>();
            bldView.txtBuildings = CreateText(townCanvas.transform, "Buildings:", new Vector2(-100, 100)).GetComponent<Text>();

            var menuView = townCanvas.AddComponent<BuildMenuView>();
            menuView.btnBuildHut = CreateButton(townCanvas.transform, "Btn_BuildHut", new Vector2(100, -200)).GetComponent<Button>();

            var dbgView = townCanvas.AddComponent<DebugStateView>();
            dbgView.txtDebug = CreateText(townCanvas.transform, "Debug State", new Vector2(300, -200)).GetComponent<Text>();

            var logView = townCanvas.AddComponent<TaskLogView>();
            logView.txtLog = CreateText(townCanvas.transform, "Logs", new Vector2(0, -300)).GetComponent<Text>();

            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");

            Debug.Log("UI MVP Scenes generated successfully with Cameras and InputSystem!");
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
                // Fix Input System Exception: Use New Input System UI Module
                var inputModuleType = System.Type.GetType("UnityEngine.InputSystem.UI.InputSystemUIInputModule, Unity.InputSystem");
                if (inputModuleType != null) {
                    eventSystem.AddComponent(inputModuleType);
                } else {
                    Debug.LogWarning("InputSystemUIInputModule not found. Input might not work if legacy is disabled.");
                }
            }
            return go;
        }

        private static GameObject CreateButton(Transform parent, string name, Vector2 pos)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            rect.sizeDelta = new Vector2(160, 30);
            go.AddComponent<Image>();
            go.AddComponent<Button>();
            
            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(go.transform, false);
            var txtRect = txtGo.AddComponent<RectTransform>();
            txtRect.anchoredPosition = Vector2.zero;
            txtRect.sizeDelta = new Vector2(160, 30);
            var txt = txtGo.AddComponent<Text>();
            txt.text = name;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.color = Color.black;
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");

            return go;
        }

        private static GameObject CreateText(Transform parent, string content, Vector2 pos)
        {
            var go = new GameObject("Text");
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            rect.sizeDelta = new Vector2(200, 100);
            var txt = go.AddComponent<Text>();
            txt.text = content;
            txt.color = Color.white;
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
