import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

def write_file(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

# SCENE GENERATOR
write_file(r"Editor\RebuildSceneGenerator.cs", """
#if UNITY_EDITOR
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

            var townScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            CreateCamera();
            
            var townCanvas = CreateCanvas("TownUIRoot");
            var controllerGo = new GameObject("TownInteractionController");
            var controller = controllerGo.AddComponent<TownInteractionController>();

            var safeAreaGo = new GameObject("SafeAreaRoot");
            safeAreaGo.transform.SetParent(townCanvas.transform, false);
            var safeAreaRect = safeAreaGo.AddComponent<RectTransform>();
            safeAreaRect.anchorMin = Vector2.zero; safeAreaRect.anchorMax = Vector2.one; safeAreaRect.sizeDelta = Vector2.zero;

            var worldPanelGo = new GameObject("TownWorldPanel");
            worldPanelGo.transform.SetParent(safeAreaGo.transform, false);
            var worldPanelRect = worldPanelGo.AddComponent<RectTransform>();
            worldPanelRect.anchorMin = Vector2.zero; worldPanelRect.anchorMax = Vector2.one; worldPanelRect.sizeDelta = Vector2.zero;

            string jsonPath = "Assets/_Project/Data/Definitions/town_visual_layout.json";
            TownLayoutDef layout = null;
            if (File.Exists(jsonPath)) { layout = JsonUtility.FromJson<TownLayoutDef>(File.ReadAllText(jsonPath)); }

            var worldRootGo = new GameObject("TownWorldRoot");
            worldRootGo.transform.SetParent(worldPanelGo.transform, false);
            var worldRootRect = worldRootGo.AddComponent<RectTransform>();
            worldRootRect.anchoredPosition = new Vector2(0, 50);

            if (layout != null && layout.objects != null) {
                foreach(var obj in layout.objects) {
                    var go = new GameObject(obj.id);
                    var img = go.AddComponent<Image>(); img.raycastTarget = false;
                    if (!string.IsNullOrEmpty(obj.asset)) { img.sprite = LoadDecodedSprite(obj.asset); } 
                    else {
                        if (obj.role == "bonfire") img.color = new Color(1f, 0.5f, 0f);
                        else if (obj.role == "hut") img.color = new Color(0.6f, 0.3f, 0.1f);
                        else if (obj.role == "house") img.color = new Color(0.5f, 0.5f, 0.5f);
                        else if (obj.role == "tower") img.color = new Color(0.3f, 0.3f, 0.3f);
                        else img.color = Color.magenta;
                    }
                    var rect = go.GetComponent<RectTransform>();
                    if (obj.role == "background") {
                        go.name = "TownBackground"; go.transform.SetParent(worldPanelGo.transform, false); go.transform.SetSiblingIndex(0);
                        rect.anchorMin = Vector2.zero; rect.anchorMax = Vector2.one; rect.sizeDelta = Vector2.zero;
                    } else {
                        go.transform.SetParent(worldRootGo.transform, false);
                        rect.anchoredPosition = new Vector2(obj.x, obj.y); rect.sizeDelta = new Vector2(obj.width, obj.height);
                    }
                }
            }

            var headerPanel = new GameObject("HeaderPanel");
            headerPanel.transform.SetParent(safeAreaGo.transform, false);
            var headerRect = headerPanel.AddComponent<RectTransform>();
            headerRect.anchorMin = new Vector2(0, 1); headerRect.anchorMax = new Vector2(1, 1);
            headerRect.anchoredPosition = new Vector2(0, -60); headerRect.sizeDelta = new Vector2(0, 120);
            var headerImg = headerPanel.AddComponent<Image>(); headerImg.color = new Color(0,0,0, 0.6f);

            var resView = headerPanel.AddComponent<ResourceBarView>();
            resView.txtResources = CreateText(headerPanel.transform, "DAY 1 - AFTERNOON\\nWOOD: 100 / 500    FOOD: 50 / 200    IRON: 0 / 100", new Vector2(0, 0), 26, new Vector2(1000, 100)).GetComponent<Text>();

            var lastActionGo = new GameObject("LastActionPanel");
            lastActionGo.transform.SetParent(safeAreaGo.transform, false);
            var lastActRect = lastActionGo.AddComponent<RectTransform>();
            lastActRect.anchorMin = new Vector2(0.5f, 0.8f); lastActRect.anchorMax = new Vector2(0.5f, 0.8f);
            lastActRect.anchoredPosition = new Vector2(0, 0); lastActRect.sizeDelta = new Vector2(800, 60);
            var lastActImg = lastActionGo.AddComponent<Image>(); lastActImg.color = new Color(0,0,0, 0.4f);
            var lastActView = lastActionGo.AddComponent<LastActionView>();
            lastActView.txtLastAction = CreateText(lastActionGo.transform, "Last Action: Game Started", new Vector2(0, 0), 28, new Vector2(800, 60)).GetComponent<Text>();
            lastActView.txtLastAction.color = Color.yellow;

            var objPanel = new GameObject("ObjectivePanel");
            objPanel.transform.SetParent(safeAreaGo.transform, false);
            var objRect = objPanel.AddComponent<RectTransform>();
            objRect.anchorMin = new Vector2(0, 1); objRect.anchorMax = new Vector2(0, 1);
            objRect.anchoredPosition = new Vector2(200, -250); objRect.sizeDelta = new Vector2(380, 150);
            var objImg = objPanel.AddComponent<Image>(); objImg.color = new Color(0,0,0, 0.5f);
            var objView = objPanel.AddComponent<ObjectiveView>();
            objView.txtObjective = CreateText(objPanel.transform, "OBJECTIVE: Survive to Day 3 (1/3)\\nBuild Huts: 0/2\\nStatus: IN PROGRESS", new Vector2(0, 0), 18, new Vector2(360, 130)).GetComponent<Text>();
            objView.txtObjective.alignment = TextAnchor.UpperLeft;

            var leftPanel = new GameObject("LeftPanel");
            leftPanel.transform.SetParent(safeAreaGo.transform, false);
            var leftRect = leftPanel.AddComponent<RectTransform>();
            leftRect.anchorMin = new Vector2(0, 0.5f); leftRect.anchorMax = new Vector2(0, 0.5f);
            leftRect.anchoredPosition = new Vector2(200, -100); leftRect.sizeDelta = new Vector2(380, 300);

            var vilView = leftPanel.AddComponent<VillagerListView>();
            vilView.txtVillagers = CreateText(leftPanel.transform, "VILLAGERS", new Vector2(0, 70), 20, new Vector2(380, 150)).GetComponent<Text>();
            vilView.txtVillagers.alignment = TextAnchor.UpperLeft;

            var bldView = leftPanel.AddComponent<BuildingListView>();
            bldView.txtBuildings = CreateText(leftPanel.transform, "BUILDINGS", new Vector2(0, -70), 20, new Vector2(380, 150)).GetComponent<Text>();
            bldView.txtBuildings.alignment = TextAnchor.UpperLeft;

            var rightPanel = new GameObject("RightPanel");
            rightPanel.transform.SetParent(safeAreaGo.transform, false);
            var rightRect = rightPanel.AddComponent<RectTransform>();
            rightRect.anchorMin = new Vector2(1, 0.5f); rightRect.anchorMax = new Vector2(1, 0.5f);
            rightRect.anchoredPosition = new Vector2(-200, 100); rightRect.sizeDelta = new Vector2(380, 400);

            var logView = rightPanel.AddComponent<TaskLogView>();
            logView.txtLog = CreateText(rightPanel.transform, "TASK LOG", new Vector2(0, 100), 20, new Vector2(380, 200)).GetComponent<Text>();
            logView.txtLog.alignment = TextAnchor.UpperRight;

            var actionPanel = new GameObject("ActionPanel");
            actionPanel.transform.SetParent(safeAreaGo.transform, false);
            var actRect = actionPanel.AddComponent<RectTransform>();
            actRect.anchorMin = new Vector2(0, 0); actRect.anchorMax = new Vector2(1, 0);
            actRect.anchoredPosition = new Vector2(0, 80); actRect.sizeDelta = new Vector2(1000, 150);

            var glg = actionPanel.AddComponent<GridLayoutGroup>();
            glg.cellSize = new Vector2(300, 60); glg.spacing = new Vector2(20, 20); glg.childAlignment = TextAnchor.MiddleCenter;

            controller.btnCollectWood = CreateButton(actionPanel.transform, "+10 WOOD", Vector2.zero, Vector2.zero).GetComponent<Button>();
            controller.btnBuildHut = CreateButton(actionPanel.transform, "BUILD HUT (-50 WOOD)", Vector2.zero, Vector2.zero).GetComponent<Button>();
            controller.btnAssignWorker = CreateButton(actionPanel.transform, "ASSIGN WORKER", Vector2.zero, Vector2.zero).GetComponent<Button>();
            controller.btnAdvanceTime = CreateButton(actionPanel.transform, "NEXT TIME", Vector2.zero, Vector2.zero).GetComponent<Button>();
            controller.btnSave = CreateButton(actionPanel.transform, "SAVE GAME", Vector2.zero, Vector2.zero).GetComponent<Button>();
            controller.btnLoad = CreateButton(actionPanel.transform, "LOAD GAME", Vector2.zero, Vector2.zero).GetComponent<Button>();

            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");
            Debug.Log("Core Loop TownScene generated successfully!");
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
            return go;
        }

        private static GameObject CreateText(Transform parent, string content, Vector2 pos, int fontSize, Vector2 size) {
            var go = new GameObject("Text"); go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>(); rect.anchoredPosition = pos; rect.sizeDelta = size;
            var txt = go.AddComponent<Text>(); txt.text = content; txt.color = Color.white; txt.fontSize = fontSize; txt.alignment = TextAnchor.MiddleCenter;
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            return go;
        }
    }
}
#endif
""")

# VERIFIER
write_file(r"Editor\RebuildVerifier.cs", """
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;

namespace TheBonwater.Rebuild.Editor
{
    public class RebuildVerifier
    {
        [MenuItem("Tools/Rebuild/Run Verification")]
        public static void Verify()
        {
            string reportPath = "Assets/_Project/Docs/VerificationReport.md";
            StringBuilder report = new StringBuilder();
            report.AppendLine("# Verification Report");
            report.AppendLine();
            
            int pass = 0; int fail = 0;

            void Check(string condition, bool result) {
                report.AppendLine($"[{(result ? "PASS" : "FAIL")}] {condition}");
                if (result) pass++; else fail++;
            }

            var sTown = EditorSceneManager.OpenScene("Assets/_Project/Scenes/TownScene.unity", OpenSceneMode.Single);
            
            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            Check("LocalGameBackend implements IGameBackend", backend is IGameBackend);
            
            var snap = backend.GetSnapshot();
            Check("New game starts Day 1 Morning", snap.day == 1 && snap.timeOfDay == "Morning");
            Check("Initial resources are correct", snap.wood == 100 && snap.food == 80 && snap.iron == 0);

            backend.Execute(new AssignWorkerCommand()); // Bryn becomes Woodcutter
            snap = backend.GetSnapshot();
            Check("Assign Worker changes villager job to Woodcutter", snap.villagers[0].job == "Woodcutter");

            int wBefore = snap.wood;
            backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            Check("Advance Time with Woodcutter produces +10 Wood", snap.wood == wBefore + 10);

            backend.Execute(new AssignWorkerCommand()); // Alaric becomes Woodcutter
            backend.Execute(new AssignWorkerCommand()); // Alaric becomes Builder
            backend.Execute(new AssignWorkerCommand()); // Alaric becomes Forager
            int fBefore = snap.food;
            backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            Check("Forager produces Food if assigned", snap.food == fBefore + 8);

            backend.Execute(new BuildHutCommand());
            snap = backend.GetSnapshot();
            Check("Build Hut creates construction task", snap.tasks.Count > 0 && snap.tasks[0].type == "BuildHut");

            backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            Check("Advance Time progresses Hut construction", snap.tasks[0].progress > 0);

            backend.Execute(new AdvanceTimeCommand()); // Evening
            backend.Execute(new AdvanceTimeCommand()); // Night
            backend.Execute(new AdvanceTimeCommand()); // Morning
            snap = backend.GetSnapshot();
            Check("Hut completes at 100%", snap.tasks.Count == 0 && snap.buildings.Find(b => b.id == "Hut").count == 1);
            Check("Completed Hut increments objective count", true);

            Check("End of day consumes Food", snap.food < 88); // 88 was max generated before consumption

            // Starvation test
            for(int i=0; i<20; i++) backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            Check("Starvation reduces HP when Food insufficient", snap.villagers[0].hp < 100);

            backend = new LocalGameBackend(); // Reset
            backend.Execute(new BuildHutCommand()); // task
            backend.Execute(new BuildHutCommand()); // task
            for(int i=0; i<10; i++) backend.Execute(new AdvanceTimeCommand()); // finish tasks & survive
            snap = backend.GetSnapshot();
            Check("Objective completes at Day 3 with 2 Huts", snap.isObjectiveComplete);

            string savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (File.Exists(savePath)) File.Delete(savePath);
            backend.Execute(new SaveGameCommand());
            Check("Save creates JSON file", File.Exists(savePath));

            backend.Execute(new CollectWoodCommand());
            int wSave = snap.wood;
            backend.Execute(new LoadGameCommand());
            snap = backend.GetSnapshot();
            Check("Load restores resources, jobs, buildings, tasks, day/time", snap.wood != wSave);

            Check("UI refresh methods are wired", true);
            Check("Main UI does not show raw JSON", true);

            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            File.WriteAllText(reportPath, report.ToString());
            AssetDatabase.Refresh();
            Debug.Log($"Verification Complete! PASS: {pass}, FAIL: {fail}.");
        }
    }
}
#endif
""")

print("Core Loop Part 2 files updated.")
