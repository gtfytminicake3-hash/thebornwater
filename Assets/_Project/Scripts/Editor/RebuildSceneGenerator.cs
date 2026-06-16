#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;
using System.IO;
using TheBonwater.Rebuild.Diagnostics;

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
        public bool preserveAspect;
        public bool fillScreen;
        public bool anchorBottom;
        public bool tile;
    }

    public class RebuildSceneGenerator
    {
        [MenuItem("Tools/Rebuild/Create UI MVP Scenes")]
        
        [MenuItem("Tools/Rebuild/Create MainMenu Scene")]
        public static void CreateMainMenuScene() {
            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            var canvas = CreateCanvas("MainMenuRoot");
            
            var goCtrl = new GameObject("MainMenuController");
            var ctrl = goCtrl.AddComponent<MainMenuController>();
            
            var panel = new GameObject("Panel");
            panel.transform.SetParent(canvas.transform, false);
            var rect = panel.AddComponent<RectTransform>();
            rect.anchorMin = Vector2.zero; rect.anchorMax = Vector2.one; rect.sizeDelta = Vector2.zero;
                        var img = panel.AddComponent<Image>();
            var bgSprite = LoadDecodedSprite("Assets/_Project/ImportedDecoded/Sprite/1st cutsceneBG.png");
            if (bgSprite != null) { img.sprite = bgSprite; img.color = Color.white; } 
            else { img.color = new Color(0.1f, 0.2f, 0.3f); }
            
            CreateText(panel.transform, "THE BONWATER", new Vector2(0, 300), 48, new Vector2(800, 100));
            
            ctrl.btnNewGame = CreateButton(panel.transform, "NEW GAME", new Vector2(0, 100), new Vector2(300, 80)).GetComponent<Button>();
            ctrl.btnContinue = CreateButton(panel.transform, "CONTINUE", new Vector2(0, 0), new Vector2(300, 80)).GetComponent<Button>();
            
            EditorSceneManager.SaveScene(scene, "Assets/_Project/Scenes/MainMenuScene.unity");
            UnityEngine.Debug.Log("MainMenuScene generated successfully!");
        }

        [MenuItem("Tools/Rebuild/Create Town Scene")]
        public static void CreateScenes()
        {
            string basePath = "Assets/_Project/Scenes/";
            if (!AssetDatabase.IsValidFolder("Assets/_Project/Scenes"))
                AssetDatabase.CreateFolder("Assets/_Project", "Scenes");

            var townScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            
            var townCanvas = CreateCanvas("TownUIRoot");
            var controllerGo = new GameObject("TownInteractionController");
            var controller = controllerGo.AddComponent<TownInteractionController>();
            controllerGo.AddComponent<TownRuntimeVisualController>();

            var safeAreaGo = new GameObject("SafeAreaRoot");
            safeAreaGo.transform.SetParent(townCanvas.transform, false);
            var safeAreaRect = safeAreaGo.AddComponent<RectTransform>();
            safeAreaRect.anchorMin = Vector2.zero; safeAreaRect.anchorMax = Vector2.one; safeAreaRect.sizeDelta = Vector2.zero;

            var worldPanelGo = new GameObject("TownViewportPanel");
            worldPanelGo.transform.SetParent(safeAreaGo.transform, false);
            var worldPanelRect = worldPanelGo.AddComponent<RectTransform>();
            worldPanelRect.anchorMin = Vector2.zero; worldPanelRect.anchorMax = Vector2.one; worldPanelRect.sizeDelta = Vector2.zero;
            var worldPanelImg = worldPanelGo.AddComponent<Image>();
            worldPanelImg.color = Color.clear; // Transparent but raycastable

            string jsonPath = "Assets/_Project/Data/Definitions/town_visual_layout.json";
            TownLayoutDef layout = null;
            if (File.Exists(jsonPath)) { layout = JsonUtility.FromJson<TownLayoutDef>(File.ReadAllText(jsonPath)); }

            var worldRootGo = new GameObject("TownWorldRoot");
            worldRootGo.transform.SetParent(worldPanelGo.transform, false);
            var worldRootRect = worldRootGo.AddComponent<RectTransform>();
            // Make TownWorldRoot large enough to pan
            worldRootRect.sizeDelta = new Vector2(3000, 2000);
            worldRootRect.anchoredPosition = new Vector2(0, 0);

            // Create Layer roots
            string[] layerNames = new string[] { "TerrainLayer", "DecorationLayer", "ConstructionLayer", "BuildingLayer", "VillagerLayer", "MonsterLayer" };
            foreach (var layerName in layerNames) {
                var layerGo = new GameObject(layerName);
                layerGo.transform.SetParent(worldRootGo.transform, false);
                var layerRect = layerGo.AddComponent<RectTransform>();
                layerRect.anchorMin = Vector2.zero; layerRect.anchorMax = Vector2.one; layerRect.sizeDelta = Vector2.zero;
            }

            if (layout != null && layout.objects != null) {
                var sortedObjs = layout.objects.OrderBy(o => o.layer).ToList();
                foreach(var obj in sortedObjs) {
                    var go = new GameObject(obj.id);
                    // Decide target parent
                    Transform targetParent = worldRootGo.transform.Find("DecorationLayer");
                    if (obj.role == "sky" || obj.role == "scene_bg" || obj.role == "terrain") {
                        targetParent = worldRootGo.transform.Find("TerrainLayer");
                    }
                    if (targetParent == null) targetParent = worldRootGo.transform;

                    go.transform.SetParent(targetParent, false);
                    var img = go.AddComponent<Image>(); img.raycastTarget = false;
                    
                    if (!string.IsNullOrEmpty(obj.asset)) {
                        var sp = LoadDecodedSprite(obj.asset);
                        if (sp != null) { 
                            img.sprite = sp; img.color = Color.white; 
                            RuntimeTrace.Log("VISUAL_BINDING", $"asset={obj.asset} exists=true loaded=true role={obj.role}");
                        }
                        else { 
                            RuntimeTrace.Log("ERROR", $"Missing visual asset path={obj.asset}");
                            SetFallbackColor(img, obj.role); 
                        }
                    } else {
                        SetFallbackColor(img, obj.role);
                    }
                    
                    var rect = go.GetComponent<RectTransform>();
                    
                    if (obj.role == "sky") {
                        // Sky background - full screen, preserve aspect
                        rect.anchorMin = Vector2.zero; rect.anchorMax = Vector2.one; rect.sizeDelta = Vector2.zero;
                        if (obj.preserveAspect && img.sprite != null) {
                            go.AddComponent<AspectRatioFitter>().aspectMode = AspectRatioFitter.AspectMode.FitInParent;
                        }
                    } else if (obj.role == "scene_bg") {
                        // Scene background - anchored to bottom
                        rect.anchorMin = new Vector2(0, 0); rect.anchorMax = new Vector2(1, 0);
                        rect.anchoredPosition = new Vector2(obj.x, obj.y);
                        rect.sizeDelta = new Vector2(0, obj.height);
                        if (obj.preserveAspect && img.sprite != null) {
                            go.AddComponent<AspectRatioFitter>().aspectMode = AspectRatioFitter.AspectMode.FitInParent;
                        }
                    } else if (obj.role == "terrain") {
                        // Terrain floor - anchored to bottom
                        rect.anchorMin = new Vector2(0, 0); rect.anchorMax = new Vector2(1, 0);
                        rect.anchoredPosition = new Vector2(obj.x, obj.y);
                        rect.sizeDelta = new Vector2(0, obj.height);
                    } else {
                        // Entity, tree, furniture - parent to world root for depth sorting
                        rect.anchoredPosition = new Vector2(obj.x, obj.y);
                        rect.sizeDelta = new Vector2(obj.width, obj.height);
                    }
                }
            }

            // Make TownViewportPanel draggable, it controls TownWorldRoot
            var dragCtrl = worldPanelGo.AddComponent<MapDragController>();
            dragCtrl.targetTransform = worldRootRect;

            // --- 3. HUD ROOT ---
            var hudRootGo = new GameObject("HUDRoot");
            hudRootGo.transform.SetParent(safeAreaGo.transform, false);
            var hudRect = hudRootGo.AddComponent<RectTransform>();
            hudRect.anchorMin = Vector2.zero; hudRect.anchorMax = Vector2.one;
            hudRect.sizeDelta = Vector2.zero;
            
            var uiManager = hudRootGo.AddComponent<GameplayUIManager>();

            // DebugPanel Toggle
            var btnToggleDebug = CreateButton(hudRootGo.transform, "DEV TOOLS", new Vector2(-120, -50), new Vector2(100, 40));
            var toggleRect = btnToggleDebug.GetComponent<RectTransform>();
            toggleRect.anchorMin = new Vector2(1, 1); toggleRect.anchorMax = new Vector2(1, 1);

            // --- 4. DEBUG PANEL ---
            var debugPanel = new GameObject("DebugPanel");
            debugPanel.transform.SetParent(hudRootGo.transform, false);
            var debugRect = debugPanel.AddComponent<RectTransform>();
            debugRect.anchorMin = new Vector2(1, 0); debugRect.anchorMax = new Vector2(1, 1);
            debugRect.sizeDelta = new Vector2(250, 0);
            debugRect.anchoredPosition = new Vector2(-125, 0);
            var debugImg = debugPanel.AddComponent<Image>();
            debugImg.color = new Color(0, 0, 0, 0.7f);
            debugPanel.SetActive(false); // Hidden by default

            btnToggleDebug.GetComponent<Button>().onClick.AddListener(() => {
                debugPanel.SetActive(!debugPanel.activeSelf);
            });

            int dbgY = -150;
            controller.btnAssignWorker = CreateButton(debugPanel.transform, "ASSIGN JOB", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;
            controller.btnSelectVillager = CreateButton(debugPanel.transform, "SELECT NEXT VILLAGER", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;
            controller.btnSave = CreateButton(debugPanel.transform, "SAVE", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;
            controller.btnLoad = CreateButton(debugPanel.transform, "LOAD", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;

            // --- 5. TOP PANEL (HUD) ---
            var topPanel = new GameObject("TopResourceBar");
            topPanel.transform.SetParent(hudRootGo.transform, false);
            var topRect = topPanel.AddComponent<RectTransform>();
            topRect.anchorMin = new Vector2(0, 1); topRect.anchorMax = new Vector2(1, 1);
            topRect.sizeDelta = new Vector2(0, 60); topRect.anchoredPosition = new Vector2(0, -30);
            var topImg = topPanel.AddComponent<Image>(); topImg.color = new Color(0, 0, 0, 0.7f);

            var resView = topPanel.AddComponent<TopResourceBarView>();
            resView.txtResources = CreateText(topPanel.transform, "DAY 1 - AFTERNOON\nWOOD: 100 / 500    FOOD: 50 / 200    IRON: 0 / 100", new Vector2(0, 0), 22, new Vector2(1000, 60)).GetComponent<Text>();
            uiManager.topResourceBar = resView;

            // --- 6. LEFT PANEL (HUD) ---
            var leftPanel = new GameObject("LeftStatusPanel");
            leftPanel.transform.SetParent(hudRootGo.transform, false);
            var leftRect = leftPanel.AddComponent<RectTransform>();
            leftRect.anchorMin = new Vector2(0, 0); leftRect.anchorMax = new Vector2(0, 1);
            leftRect.sizeDelta = new Vector2(200, -60); leftRect.anchoredPosition = new Vector2(100, 0);
            var leftImg = leftPanel.AddComponent<Image>(); leftImg.color = new Color(0, 0, 0, 0.4f);

            var leftStatus = leftPanel.AddComponent<LeftStatusPanelView>();
            leftStatus.txtStatus = CreateText(leftPanel.transform, "STATUS", new Vector2(0, 0), 16, new Vector2(180, 0)).GetComponent<Text>();
            var leftTxtRect = leftStatus.txtStatus.GetComponent<RectTransform>();
            leftTxtRect.anchorMin = Vector2.zero; leftTxtRect.anchorMax = Vector2.one; leftTxtRect.sizeDelta = Vector2.zero;
            leftStatus.txtStatus.alignment = TextAnchor.UpperLeft;
            uiManager.leftStatusPanel = leftStatus;

            // --- 7. BOTTOM ACTION BAR ---
            var bottomPanel = new GameObject("BottomActionBar");
            bottomPanel.transform.SetParent(hudRootGo.transform, false);
            var bottomRect = bottomPanel.AddComponent<RectTransform>();
            bottomRect.anchorMin = new Vector2(0.2f, 0); bottomRect.anchorMax = new Vector2(0.8f, 0);
            bottomRect.sizeDelta = new Vector2(0, 100); bottomRect.anchoredPosition = new Vector2(0, 50);

            var btnOpenBuildMenu = new GameObject("BtnOpenBuildMenu");
            btnOpenBuildMenu.transform.SetParent(bottomPanel.transform, false);
            var btnBuildRect = btnOpenBuildMenu.AddComponent<RectTransform>();
            btnBuildRect.sizeDelta = new Vector2(80, 80);
            btnBuildRect.anchoredPosition = new Vector2(-120, 0);
            var btnBuildImg = btnOpenBuildMenu.AddComponent<Image>();
            
            var buildSp = LoadDecodedSprite("Assets/_Project/ImportedDecoded/Texture2D/build3.png");
            if (buildSp != null) { btnBuildImg.sprite = buildSp; btnBuildImg.color = Color.white; }
            else { btnBuildImg.color = Color.gray; }
            var btnBuildCmp = btnOpenBuildMenu.AddComponent<Button>();

            var buildTxtGo = new GameObject("Text");
            buildTxtGo.transform.SetParent(btnOpenBuildMenu.transform, false);
            var buildTxtRect = buildTxtGo.AddComponent<RectTransform>();
            buildTxtRect.anchorMin = Vector2.zero; buildTxtRect.anchorMax = Vector2.one;
            buildTxtRect.sizeDelta = Vector2.zero;
            var buildTxt = buildTxtGo.AddComponent<Text>();
            buildTxt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            buildTxt.alignment = TextAnchor.MiddleCenter;
            buildTxt.color = Color.black;
            buildTxt.text = "Build";
            buildTxt.fontSize = 20;

            var btnNextPhaseGo = CreateButton(bottomPanel.transform, "Next Phase", new Vector2(0, 0), new Vector2(120, 50));
            var nextTxt = btnNextPhaseGo.GetComponentInChildren<Text>();
            nextTxt.fontSize = 16;
            var tooltipGo = CreateText(bottomPanel.transform, "TEMPORARY_DEV_UI: Next Phase", new Vector2(0, -35), 10, new Vector2(150, 20));
            tooltipGo.GetComponent<Text>().color = Color.yellow;
            controller.btnNextPhase = btnNextPhaseGo.GetComponent<Button>();

            var btnSaveGo = CreateButton(bottomPanel.transform, "Save", new Vector2(120, 0), new Vector2(80, 50));
            var saveTooltipGo = CreateText(bottomPanel.transform, "TEMPORARY_DEV_UI: Save", new Vector2(120, -35), 10, new Vector2(120, 20));
            saveTooltipGo.GetComponent<Text>().color = Color.yellow;
            controller.btnSave = btnSaveGo.GetComponent<Button>();

            var btnLoadGo = CreateButton(bottomPanel.transform, "Load", new Vector2(210, 0), new Vector2(80, 50));
            var loadTooltipGo = CreateText(bottomPanel.transform, "TEMPORARY_DEV_UI: Load", new Vector2(210, -35), 10, new Vector2(120, 20));
            loadTooltipGo.GetComponent<Text>().color = Color.yellow;
            controller.btnLoad = btnLoadGo.GetComponent<Button>();

            // --- 8. BUILD MENU POPUP (HUD) ---
            var buildMenuPanel = new GameObject("BuildMenuPanel");
            buildMenuPanel.transform.SetParent(hudRootGo.transform, false);
            var menuRect = buildMenuPanel.AddComponent<RectTransform>();
            menuRect.anchorMin = new Vector2(0.5f, 0.5f); menuRect.anchorMax = new Vector2(0.5f, 0.5f);
            menuRect.sizeDelta = new Vector2(320, 300);
            menuRect.anchoredPosition = new Vector2(0, 0);
            var menuImg = buildMenuPanel.AddComponent<Image>();
            menuImg.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
            menuImg.raycastTarget = true;
            buildMenuPanel.SetActive(false); // Hidden initially

            var bmv = buildMenuPanel.AddComponent<BuildMenuPanelView>();
            uiManager.buildMenuPanel = bmv;

            var header = new GameObject("HeaderCloseArea");
            header.transform.SetParent(buildMenuPanel.transform, false);
            var headerRect = header.AddComponent<RectTransform>();
            headerRect.anchorMin = new Vector2(0, 1); headerRect.anchorMax = new Vector2(1, 1);
            headerRect.pivot = new Vector2(0.5f, 1f);
            headerRect.sizeDelta = new Vector2(0, 48); 
            headerRect.anchoredPosition = new Vector2(0, 0);
            var headerImg = header.AddComponent<Image>();
            headerImg.color = new Color(0.15f, 0.15f, 0.15f, 1f);
            headerImg.raycastTarget = true;

            var txtMenuTitle = CreateText(header.transform, "BUILD MENU", new Vector2(-20, -24), 20, new Vector2(200, 40));
            var btnCloseMenu = CreateButton(header.transform, "X", new Vector2(140, -24), new Vector2(36, 36));
            btnCloseMenu.name = "BtnCloseBuildMenu";
            btnCloseMenu.GetComponent<Image>().raycastTarget = true;
            btnCloseMenu.transform.SetAsLastSibling();

            var contentRoot = new GameObject("BuildMenuContentRoot");
            contentRoot.transform.SetParent(buildMenuPanel.transform, false);
            var contentRect = contentRoot.AddComponent<RectTransform>();
            contentRect.anchorMin = new Vector2(0, 1); contentRect.anchorMax = new Vector2(1, 1);
            contentRect.pivot = new Vector2(0.5f, 1f);
            contentRect.sizeDelta = new Vector2(0, 230);
            contentRect.anchoredPosition = new Vector2(0, -55);
            bmv.contentRoot = contentRoot.transform;

            // --- 9. CONSTRUCTION PANEL ---
            var consPanel = new GameObject("ConstructionPanel");
            consPanel.transform.SetParent(hudRootGo.transform, false);
            var consRect = consPanel.AddComponent<RectTransform>();
            consRect.anchorMin = new Vector2(1, 0.5f); consRect.anchorMax = new Vector2(1, 0.5f);
            consRect.sizeDelta = new Vector2(250, 300); consRect.anchoredPosition = new Vector2(-125, 0);
            var consImg = consPanel.AddComponent<Image>(); consImg.color = new Color(0, 0, 0, 0.4f);
            var consView = consPanel.AddComponent<ConstructionPanelView>();
            consView.txtTasks = CreateText(consPanel.transform, "CONSTRUCTION TASKS", new Vector2(0, 0), 16, new Vector2(230, 280)).GetComponent<Text>();
            consView.txtTasks.alignment = TextAnchor.UpperLeft;
            uiManager.constructionPanel = consView;

            // --- 10. SELECTED VILLAGER PANEL ---
            var selVillPanel = new GameObject("SelectedVillagerPanel");
            selVillPanel.transform.SetParent(hudRootGo.transform, false);
            var selRect = selVillPanel.AddComponent<RectTransform>();
            selRect.anchorMin = new Vector2(1, 0); selRect.anchorMax = new Vector2(1, 0);
            selRect.sizeDelta = new Vector2(300, 200); selRect.anchoredPosition = new Vector2(-150, 100);
            var selImg = selVillPanel.AddComponent<Image>(); selImg.color = new Color(0.1f, 0.2f, 0.3f, 0.8f);
            var selView = selVillPanel.AddComponent<SelectedVillagerPanelView>();
            selView.txtInfo = CreateText(selVillPanel.transform, "INFO", new Vector2(0, 40), 18, new Vector2(280, 100)).GetComponent<Text>();
            
            selView.btnCycleJobDev = CreateButton(selVillPanel.transform, "Assign Worker (TEMP)", new Vector2(0, -20), new Vector2(160, 30)).GetComponent<Button>();
            selView.btnCycleJobDev.GetComponentInChildren<Text>().fontSize = 12;
            selView.txtMoreJobs = CreateText(selVillPanel.transform, "More job actions: N/A", new Vector2(0, -60), 12, new Vector2(200, 20)).GetComponent<Text>();

            uiManager.selectedVillagerPanel = selView;

            // --- 11. EVENT LOG (HUD) ---
            var logPanel = new GameObject("EventLogPanel");
            logPanel.transform.SetParent(hudRootGo.transform, false);
            var logRect = logPanel.AddComponent<RectTransform>();
            logRect.anchorMin = new Vector2(1, 0); logRect.anchorMax = new Vector2(1, 0);
            logRect.sizeDelta = new Vector2(300, 150); logRect.anchoredPosition = new Vector2(-150, 275);
            var tView = logPanel.AddComponent<TaskLogView>();
            tView.txtLog = CreateText(logPanel.transform, "Event Log...", new Vector2(0, 0), 14, new Vector2(280, 130)).GetComponent<Text>();
            tView.txtLog.alignment = TextAnchor.LowerLeft;
            uiManager.eventLogPanel = tView;

            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");
            UnityEngine.Debug.Log("Core Loop TownScene generated successfully!");
        }

        private static Sprite LoadDecodedSprite(string path) {
            if (!File.Exists(path)) return null;
            var importer = AssetImporter.GetAtPath(path) as TextureImporter;
            if (importer != null && importer.textureType != TextureImporterType.Sprite) {
                importer.textureType = TextureImporterType.Sprite; importer.SaveAndReimport();
            }
            return AssetDatabase.LoadAssetAtPath<Sprite>(path);
        }

        private static GameObject CreateCamera() {
            var go = new GameObject("Main Camera"); go.tag = "MainCamera";
            var cam = go.AddComponent<Camera>(); cam.clearFlags = CameraClearFlags.SolidColor; cam.backgroundColor = new Color(0.1f, 0.1f, 0.1f);
            return go;
        }

        private static GameObject CreateCanvas(string name) {
            var go = new GameObject(name);
            var canvas = go.AddComponent<Canvas>(); canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            var scaler = go.AddComponent<CanvasScaler>(); scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1080, 1920); scaler.matchWidthOrHeight = 0.5f;
            go.AddComponent<GraphicRaycaster>();
            if (Object.FindObjectOfType<EventSystem>() == null) {
                var eventSystem = new GameObject("EventSystem"); eventSystem.AddComponent<EventSystem>(); eventSystem.AddComponent<StandaloneInputModule>();
            }
            return go;
        }

        private static GameObject CreateButton(Transform parent, string name, Vector2 pos, Vector2 size) {
            var go = new GameObject(name); go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>(); rect.anchoredPosition = pos; if (size != Vector2.zero) rect.sizeDelta = size;
            var img = go.AddComponent<Image>(); img.color = new Color(0.2f, 0.6f, 0.8f); go.AddComponent<Button>();
            var txtGo = new GameObject("Text"); txtGo.transform.SetParent(go.transform, false);
            var txtRect = txtGo.AddComponent<RectTransform>(); txtRect.anchorMin = Vector2.zero; txtRect.anchorMax = Vector2.one; txtRect.sizeDelta = Vector2.zero;
            var txt = txtGo.AddComponent<Text>(); txt.text = name; txt.alignment = TextAnchor.MiddleCenter; txt.color = Color.white; txt.fontSize = 24;
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            txt.resizeTextForBestFit = true;
            txt.resizeTextMinSize = 10;
            txt.resizeTextMaxSize = 24;
            txt.horizontalOverflow = HorizontalWrapMode.Wrap;
            txt.verticalOverflow = VerticalWrapMode.Truncate;
            return go;
        }

        private static GameObject CreateText(Transform parent, string content, Vector2 pos, int fontSize, Vector2 size) {
            var go = new GameObject("Text"); go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>(); rect.anchoredPosition = pos; rect.sizeDelta = size;
            var txt = go.AddComponent<Text>(); txt.text = content; txt.color = Color.white; txt.fontSize = fontSize; txt.alignment = TextAnchor.MiddleCenter;
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            return go;
        }

        private static void SetFallbackColor(Image img, string role) {
            if (role == "sky") img.color = new Color(0.5f, 0.7f, 0.9f); // Neutral sky blue
            else if (role == "scene_bg") img.color = new Color(0.2f, 0.4f, 0.2f); // Neutral dark green
            else if (role == "terrain") img.color = new Color(0.4f, 0.3f, 0.2f); // Neutral dirt brown
            else img.color = new Color(0.5f, 0.5f, 0.5f, 0.5f); // Semi-transparent grey
        }
    }
}
#endif

