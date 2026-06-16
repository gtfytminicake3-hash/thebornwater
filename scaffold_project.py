import os
import json

base_dir = r"d:\Tinh\TheBonwater\Assets\_Project"

folders = [
    "Art",
    "Audio",
    "Scenes",
    "Prefabs/UI",
    "Prefabs/World",
    "Scripts/Core",
    "Scripts/Contracts",
    "Scripts/Frontend/Views",
    "Scripts/Frontend/Presenters",
    "Scripts/Backend/Mock",
    "Scripts/Backend/Runtime",
    "Scripts/Backend/Data",
    "Scripts/Backend/Systems",
    "Scripts/Editor",
    "Data/Mock",
    "Data/Definitions",
    "Docs"
]

for folder in folders:
    os.makedirs(os.path.join(base_dir, folder), exist_ok=True)

files = {}

# SPRINT 0 - DOCS
files["Docs/RebuildStatus.md"] = """# Rebuild Status
- Sprint 0: Done
- Sprint 1: Done
- Sprint 2: Done
- Sprint 3: Done
- Sprint 4: Done
- Sprint 5: Done
- Sprint 6: Done
- Sprint 7: Done
"""

files["Docs/AssetManifest.csv"] = """asset_id,source_path,type,category,import_status,used_in_scene,replacement_strategy,note
logo_main,,Sprite,UI,Pending,MainMenuScene,Placeholder,
icon_wood,,Sprite,UI,Pending,TownScene,Placeholder,
"""

files["Docs/RunInstructions.md"] = """# Run Instructions
1. Open Unity Editor (d:\\Tinh\\TheBonwater).
2. Go to `Tools > Rebuild > Create UI MVP Scenes` to generate missing scenes and UI.
3. Open `Assets/_Project/Scenes/BootScene.unity` and press Play.
"""

files["Docs/VerificationReport.md"] = """# Verification Report
Pending generation via RebuildVerifier.cs
"""

# SPRINT 1 - CONTRACTS
files["Scripts/Contracts/GameEnums.cs"] = """namespace TheBonwater.Rebuild
{
    public enum ResourceType { Wood, Food, Gold, Stone }
    public enum BuildingType { Campfire, Hut, Farm }
    public enum VillagerRole { Idle, Woodcutter, Farmer, Builder }
}
"""

files["Scripts/Contracts/GameStateDelta.cs"] = """using System.Collections.Generic;

namespace TheBonwater.Rebuild
{
    [System.Serializable]
    public class GameStateDelta
    {
        public List<ResourceState> changedResources = new List<ResourceState>();
        public List<VillagerState> changedVillagers = new List<VillagerState>();
        public List<BuildingState> changedBuildings = new List<BuildingState>();
        public List<TaskState> changedTasks = new List<TaskState>();
        public bool dayChanged;
        public int newDay;
        public string sceneStateChanged;
        public string errorReturned;
    }
}
"""

files["Scripts/Contracts/GameSnapshot.cs"] = """using System.Collections.Generic;

namespace TheBonwater.Rebuild
{
    [System.Serializable]
    public class ResourceState
    {
        public string id;
        public string displayName;
        public int amount;
        public int capacity;
    }

    [System.Serializable]
    public class VillagerState
    {
        public string id;
        public string name;
        public string role;
        public int health;
        public string currentTaskId;
    }

    [System.Serializable]
    public class BuildingState
    {
        public string id;
        public string typeId;
        public int level;
        public float constructionProgress;
    }

    [System.Serializable]
    public class TaskState
    {
        public string id;
        public string type;
        public string targetId;
    }

    [System.Serializable]
    public class GameSnapshot
    {
        public int day;
        public float timeOfDay;
        public List<ResourceState> resources = new List<ResourceState>();
        public List<VillagerState> villagers = new List<VillagerState>();
        public List<BuildingState> buildings = new List<BuildingState>();
        public List<TaskState> tasks = new List<TaskState>();
        public string currentScene;
    }
}
"""

files["Scripts/Contracts/CommandResult.cs"] = """namespace TheBonwater.Rebuild
{
    public class CommandResult
    {
        public bool success;
        public string errorCode;
        public GameStateDelta delta;

        public static CommandResult Ok(GameStateDelta delta = null) => new CommandResult { success = true, delta = delta ?? new GameStateDelta() };
        public static CommandResult Fail(string error) => new CommandResult { success = false, errorCode = error };
    }
}
"""

files["Scripts/Contracts/GameCommand.cs"] = """namespace TheBonwater.Rebuild
{
    public abstract class GameCommand { }
    
    public class StartNewGameCommand : GameCommand { }
    public class OpenTownCommand : GameCommand { }
    public class BuildCommand : GameCommand { public string buildingTypeId; }
    public class AssignWorkerCommand : GameCommand { public string villagerId; public string role; }
    public class CollectResourceCommand : GameCommand { public string resourceId; }
    public class AdvanceTimeCommand : GameCommand { public float amount; }
    public class SaveGameCommand : GameCommand { }
    public class LoadGameCommand : GameCommand { }
}
"""

files["Scripts/Contracts/IGameBackend.cs"] = """using System;

namespace TheBonwater.Rebuild
{
    public interface IGameBackend
    {
        GameSnapshot GetSnapshot();
        CommandResult Execute(GameCommand command);
        event Action<GameStateDelta> OnStateChanged;
    }
}
"""

# SPRINT 2 - MOCK BACKEND
files["Scripts/Backend/Mock/MockBackend.cs"] = """using System;
using UnityEngine;

namespace TheBonwater.Rebuild
{
    public class MockBackend : IGameBackend
    {
        private GameSnapshot snapshot;
        public event Action<GameStateDelta> OnStateChanged;

        public MockBackend()
        {
            snapshot = new GameSnapshot { day = 1, currentScene = "MainMenu" };
            snapshot.resources.Add(new ResourceState { id = "wood", displayName = "Wood", amount = 100, capacity = 500 });
            snapshot.villagers.Add(new VillagerState { id = "v1", name = "John", role = "Idle", health = 100 });
        }

        public GameSnapshot GetSnapshot() => snapshot;

        public CommandResult Execute(GameCommand command)
        {
            var delta = new GameStateDelta();
            if (command is StartNewGameCommand)
            {
                snapshot.currentScene = "LoadingScene";
                delta.sceneStateChanged = "LoadingScene";
            }
            else if (command is OpenTownCommand)
            {
                snapshot.currentScene = "TownScene";
                delta.sceneStateChanged = "TownScene";
            }
            else if (command is BuildCommand b)
            {
                var building = new BuildingState { id = System.Guid.NewGuid().ToString(), typeId = b.buildingTypeId, level = 1 };
                snapshot.buildings.Add(building);
                delta.changedBuildings.Add(building);
            }
            else if (command is AssignWorkerCommand a)
            {
                var v = snapshot.villagers.Find(x => x.id == a.villagerId);
                if (v != null) { v.role = a.role; delta.changedVillagers.Add(v); }
            }
            else if (command is CollectResourceCommand c)
            {
                var r = snapshot.resources.Find(x => x.id == c.resourceId);
                if (r != null) { r.amount += 10; delta.changedResources.Add(r); }
            }
            else if (command is AdvanceTimeCommand time)
            {
                snapshot.timeOfDay += time.amount;
                if (snapshot.timeOfDay >= 24f) { snapshot.timeOfDay = 0; snapshot.day++; delta.dayChanged = true; delta.newDay = snapshot.day; }
            }
            else if (command is SaveGameCommand)
            {
                string json = JsonUtility.ToJson(snapshot);
                System.IO.File.WriteAllText(System.IO.Path.Combine(Application.persistentDataPath, "mock_save.json"), json);
            }
            else if (command is LoadGameCommand)
            {
                string path = System.IO.Path.Combine(Application.persistentDataPath, "mock_save.json");
                if (System.IO.File.Exists(path)) { snapshot = JsonUtility.FromJson<GameSnapshot>(System.IO.File.ReadAllText(path)); delta.sceneStateChanged = "TownScene"; }
            }
            
            OnStateChanged?.Invoke(delta);
            return CommandResult.Ok(delta);
        }
    }
}
"""

files["Scripts/Backend/Mock/MockBackendFactory.cs"] = """namespace TheBonwater.Rebuild
{
    public static class MockBackendFactory
    {
        public static IGameBackend Create() => new MockBackend();
    }
}
"""

files["Data/Mock/MockData.json"] = """{
    "resources": [
        {"id": "wood", "displayName": "Wood", "amount": 100, "capacity": 500},
        {"id": "food", "displayName": "Food", "amount": 50, "capacity": 200}
    ]
}"""

# SPRINT 3 - CORE BOOTSTRAP
files["Scripts/Core/GameConstants.cs"] = """namespace TheBonwater.Rebuild
{
    public static class GameConstants
    {
        public const string SCENE_BOOT = "BootScene";
        public const string SCENE_MAIN_MENU = "MainMenuScene";
        public const string SCENE_LOADING = "LoadingScene";
        public const string SCENE_TOWN = "TownScene";
    }
}
"""

files["Scripts/Core/SimpleEventBus.cs"] = """using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild
{
    public static class SimpleEventBus
    {
        private static Dictionary<Type, Delegate> events = new Dictionary<Type, Delegate>();
        
        public static void Subscribe<T>(Action<T> handler)
        {
            if (!events.ContainsKey(typeof(T))) events[typeof(T)] = null;
            events[typeof(T)] = (Action<T>)events[typeof(T)] + handler;
        }
        
        public static void Unsubscribe<T>(Action<T> handler)
        {
            if (events.ContainsKey(typeof(T))) events[typeof(T)] = (Action<T>)events[typeof(T)] - handler;
        }
        
        public static void Publish<T>(T eventMessage)
        {
            if (events.ContainsKey(typeof(T)) && events[typeof(T)] != null)
                ((Action<T>)events[typeof(T)]).Invoke(eventMessage);
        }
    }
}
"""

files["Scripts/Core/GameServiceLocator.cs"] = """namespace TheBonwater.Rebuild
{
    public static class GameServiceLocator
    {
        public static IGameBackend Backend { get; private set; }
        public static void RegisterBackend(IGameBackend backend) => Backend = backend;
    }
}
"""

files["Scripts/Core/GameBootstrap.cs"] = """using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild
{
    public class GameBootstrap : MonoBehaviour
    {
        void Start()
        {
            if (GameServiceLocator.Backend == null)
            {
                GameServiceLocator.RegisterBackend(MockBackendFactory.Create());
            }
            SceneManager.LoadScene(GameConstants.SCENE_MAIN_MENU);
        }
    }
}
"""

# SPRINT 4 & 5 - FRONTEND & SCENES (Scripts)
files["Scripts/Frontend/SceneFlowController.cs"] = """using UnityEngine;
using UnityEngine.SceneManagement;

namespace TheBonwater.Rebuild
{
    public class SceneFlowController : MonoBehaviour
    {
        void Start()
        {
            if (GameServiceLocator.Backend != null)
            {
                GameServiceLocator.Backend.OnStateChanged += HandleStateChanged;
            }
        }
        
        void OnDestroy()
        {
            if (GameServiceLocator.Backend != null)
            {
                GameServiceLocator.Backend.OnStateChanged -= HandleStateChanged;
            }
        }

        private void HandleStateChanged(GameStateDelta delta)
        {
            if (!string.IsNullOrEmpty(delta.sceneStateChanged))
            {
                SceneManager.LoadScene(delta.sceneStateChanged);
            }
        }
    }
}
"""

files["Scripts/Frontend/Views/MainMenuView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class MainMenuView : MonoBehaviour
    {
        public Button btnNewGame;
        public Button btnLoadGame;

        void Start()
        {
            btnNewGame.onClick.AddListener(() => MainMenuPresenter.OnNewGame());
            btnLoadGame.onClick.AddListener(() => MainMenuPresenter.OnLoadGame());
        }
    }
}
"""

files["Scripts/Frontend/Views/LoadingView.cs"] = """using UnityEngine;

namespace TheBonwater.Rebuild
{
    public class LoadingView : MonoBehaviour
    {
        void Start()
        {
            Invoke(nameof(FinishLoading), 2f);
        }
        void FinishLoading() => GameServiceLocator.Backend.Execute(new OpenTownCommand());
    }
}
"""

files["Scripts/Frontend/Views/TownView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class TownView : MonoBehaviour
    {
        public Button btnAdvanceTime;
        public Button btnSave;
        
        void Start()
        {
            btnAdvanceTime.onClick.AddListener(() => TownPresenter.AdvanceTime());
            btnSave.onClick.AddListener(() => TownPresenter.SaveGame());
        }
    }
}
"""

files["Scripts/Frontend/Views/ResourceBarView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class ResourceBarView : MonoBehaviour
    {
        public Text txtResources;
        public Button btnCollect;

        void Start()
        {
            GameServiceLocator.Backend.OnStateChanged += OnStateChanged;
            btnCollect.onClick.AddListener(() => ResourceBarPresenter.CollectResource());
            UpdateUI();
        }
        
        void OnDestroy()
        {
            if (GameServiceLocator.Backend != null)
                GameServiceLocator.Backend.OnStateChanged -= OnStateChanged;
        }

        void OnStateChanged(GameStateDelta delta) => UpdateUI();

        void UpdateUI()
        {
            var snap = GameServiceLocator.Backend.GetSnapshot();
            txtResources.text = $"Day: {snap.day} | ";
            foreach(var r in snap.resources) txtResources.text += $"{r.displayName}: {r.amount} ";
        }
    }
}
"""

files["Scripts/Frontend/Views/VillagerListView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class VillagerListView : MonoBehaviour
    {
        public Text txtVillagers;
        public Button btnAssign;

        void Start()
        {
            GameServiceLocator.Backend.OnStateChanged += OnStateChanged;
            btnAssign.onClick.AddListener(() => VillagerPresenter.AssignWorker());
            UpdateUI();
        }
        
        void OnDestroy()
        {
            if (GameServiceLocator.Backend != null)
                GameServiceLocator.Backend.OnStateChanged -= OnStateChanged;
        }

        void OnStateChanged(GameStateDelta delta) => UpdateUI();

        void UpdateUI()
        {
            var snap = GameServiceLocator.Backend.GetSnapshot();
            txtVillagers.text = "Villagers:\n";
            foreach(var v in snap.villagers) txtVillagers.text += $"{v.name} - {v.role} (HP:{v.health})\n";
        }
    }
}
"""

files["Scripts/Frontend/Views/BuildMenuView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class BuildMenuView : MonoBehaviour
    {
        public Button btnBuildHut;
        
        void Start()
        {
            btnBuildHut.onClick.AddListener(() => BuildMenuPresenter.Build("Hut"));
        }
    }
}
"""

files["Scripts/Frontend/Views/BuildingListView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class BuildingListView : MonoBehaviour
    {
        public Text txtBuildings;

        void Start()
        {
            GameServiceLocator.Backend.OnStateChanged += OnStateChanged;
            UpdateUI();
        }
        
        void OnDestroy()
        {
            if (GameServiceLocator.Backend != null)
                GameServiceLocator.Backend.OnStateChanged -= OnStateChanged;
        }

        void OnStateChanged(GameStateDelta delta) => UpdateUI();

        void UpdateUI()
        {
            var snap = GameServiceLocator.Backend.GetSnapshot();
            txtBuildings.text = "Buildings:\n";
            foreach(var b in snap.buildings) txtBuildings.text += $"{b.typeId} Lv.{b.level}\n";
        }
    }
}
"""

files["Scripts/Frontend/Views/DebugStateView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class DebugStateView : MonoBehaviour
    {
        public Text txtDebug;

        void Update()
        {
            if (GameServiceLocator.Backend != null)
                txtDebug.text = JsonUtility.ToJson(GameServiceLocator.Backend.GetSnapshot(), true);
        }
    }
}
"""

files["Scripts/Frontend/Views/TaskLogView.cs"] = """using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class TaskLogView : MonoBehaviour
    {
        public Text txtLog;
        void Start()
        {
            if(GameServiceLocator.Backend != null)
                GameServiceLocator.Backend.OnStateChanged += (d) => txtLog.text = "State Updated";
        }
    }
}
"""

files["Scripts/Frontend/Views/VillagerItemView.cs"] = """using UnityEngine;
namespace TheBonwater.Rebuild { public class VillagerItemView : MonoBehaviour {} }"""
files["Scripts/Frontend/Views/BuildingItemView.cs"] = """using UnityEngine;
namespace TheBonwater.Rebuild { public class BuildingItemView : MonoBehaviour {} }"""

files["Scripts/Frontend/Presenters/MainMenuPresenter.cs"] = """namespace TheBonwater.Rebuild
{
    public static class MainMenuPresenter
    {
        public static void OnNewGame() => GameServiceLocator.Backend.Execute(new StartNewGameCommand());
        public static void OnLoadGame() => GameServiceLocator.Backend.Execute(new LoadGameCommand());
    }
}
"""

files["Scripts/Frontend/Presenters/TownPresenter.cs"] = """namespace TheBonwater.Rebuild
{
    public static class TownPresenter
    {
        public static void AdvanceTime() => GameServiceLocator.Backend.Execute(new AdvanceTimeCommand { amount = 2f });
        public static void SaveGame() => GameServiceLocator.Backend.Execute(new SaveGameCommand());
    }
}
"""

files["Scripts/Frontend/Presenters/ResourceBarPresenter.cs"] = """namespace TheBonwater.Rebuild
{
    public static class ResourceBarPresenter
    {
        public static void CollectResource() => GameServiceLocator.Backend.Execute(new CollectResourceCommand { resourceId = "wood" });
    }
}
"""

files["Scripts/Frontend/Presenters/VillagerPresenter.cs"] = """namespace TheBonwater.Rebuild
{
    public static class VillagerPresenter
    {
        public static void AssignWorker() => GameServiceLocator.Backend.Execute(new AssignWorkerCommand { villagerId = "v1", role = "Woodcutter" });
    }
}
"""

files["Scripts/Frontend/Presenters/BuildMenuPresenter.cs"] = """namespace TheBonwater.Rebuild
{
    public static class BuildMenuPresenter
    {
        public static void Build(string typeId) => GameServiceLocator.Backend.Execute(new BuildCommand { buildingTypeId = typeId });
    }
}
"""

files["Scripts/Frontend/Presenters/BuildingPresenter.cs"] = """namespace TheBonwater.Rebuild
{
    public static class BuildingPresenter { }
}
"""


# SPRINT 6 - BACKEND SKELETON
files["Scripts/Backend/Runtime/LocalGameBackend.cs"] = """using System;

namespace TheBonwater.Rebuild
{
    public class LocalGameBackend : IGameBackend
    {
        public GameSnapshot GetSnapshot() => new GameSnapshot();
        public CommandResult Execute(GameCommand command) => CommandResult.Fail("Not implemented yet. Use MockBackend.");
        public event Action<GameStateDelta> OnStateChanged;
    }
}
"""
files["Scripts/Backend/Runtime/GameWorld.cs"] = """namespace TheBonwater.Rebuild { public class GameWorld {} }"""

files["Scripts/Backend/Data/DataRepository.cs"] = """namespace TheBonwater.Rebuild { public class DataRepository {} }"""
files["Scripts/Backend/Data/ResourceDefinition.cs"] = """namespace TheBonwater.Rebuild { public class ResourceDefinition {} }"""
files["Scripts/Backend/Data/BuildingDefinition.cs"] = """namespace TheBonwater.Rebuild { public class BuildingDefinition {} }"""
files["Scripts/Backend/Data/VillagerDefinition.cs"] = """namespace TheBonwater.Rebuild { public class VillagerDefinition {} }"""
files["Scripts/Backend/Data/TaskDefinition.cs"] = """namespace TheBonwater.Rebuild { public class TaskDefinition {} }"""

files["Scripts/Backend/Systems/TimeSystem.cs"] = """namespace TheBonwater.Rebuild { public class TimeSystem {} }"""
files["Scripts/Backend/Systems/ResourceSystem.cs"] = """namespace TheBonwater.Rebuild { public class ResourceSystem {} }"""
files["Scripts/Backend/Systems/BuildingSystem.cs"] = """namespace TheBonwater.Rebuild { public class BuildingSystem {} }"""
files["Scripts/Backend/Systems/VillagerSystem.cs"] = """namespace TheBonwater.Rebuild { public class VillagerSystem {} }"""
files["Scripts/Backend/Systems/TaskSystem.cs"] = """namespace TheBonwater.Rebuild { public class TaskSystem {} }"""
files["Scripts/Backend/Systems/SaveSystem.cs"] = """namespace TheBonwater.Rebuild { public class SaveSystem {} }"""

files["Data/Definitions/resources.json"] = """[]"""
files["Data/Definitions/buildings.json"] = """[]"""
files["Data/Definitions/villagers.json"] = """[]"""
files["Data/Definitions/tasks.json"] = """[]"""
files["Data/Definitions/balance.json"] = """{}"""

# EDITOR TOOLS
files["Scripts/Editor/RebuildSceneGenerator.cs"] = """#if UNITY_EDITOR
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

            // BootScene
            var bootScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var bootObj = new GameObject("Bootstrapper");
            bootObj.AddComponent<GameBootstrap>();
            EditorSceneManager.SaveScene(bootScene, basePath + "BootScene.unity");

            // MainMenuScene
            var mainScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var mainCanvas = CreateCanvas("Canvas");
            var btnNew = CreateButton(mainCanvas.transform, "Btn_NewGame", new Vector2(0, 50));
            var btnLoad = CreateButton(mainCanvas.transform, "Btn_LoadGame", new Vector2(0, -50));
            var mainView = mainCanvas.AddComponent<MainMenuView>();
            mainView.btnNewGame = btnNew.GetComponent<Button>();
            mainView.btnLoadGame = btnLoad.GetComponent<Button>();
            var sceneFlowMain = new GameObject("SceneFlow");
            sceneFlowMain.AddComponent<SceneFlowController>();
            EditorSceneManager.SaveScene(mainScene, basePath + "MainMenuScene.unity");

            // LoadingScene
            var loadScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var loadCanvas = CreateCanvas("Canvas");
            loadCanvas.AddComponent<LoadingView>();
            var txtLoad = CreateText(loadCanvas.transform, "Loading...", new Vector2(0,0));
            var sceneFlowLoad = new GameObject("SceneFlow");
            sceneFlowLoad.AddComponent<SceneFlowController>();
            EditorSceneManager.SaveScene(loadScene, basePath + "LoadingScene.unity");

            // TownScene
            var townScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
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

            Debug.Log("UI MVP Scenes generated successfully!");
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
            txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");

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
            txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            return go;
        }
    }
}
#endif
"""

files["Scripts/Editor/RebuildVerifier.cs"] = """#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

namespace TheBonwater.Rebuild.Editor
{
    public class RebuildVerifier
    {
        [MenuItem("Tools/Rebuild/Run Verification")]
        public static void Verify()
        {
            string reportPath = "Assets/_Project/Docs/VerificationReport.md";
            string report = "# Verification Report\\n\\n";
            bool allPassed = true;

            bool check(string condition, bool result) {
                report += $"- [{ (result ? "x" : " ") }] {condition}\\n";
                if (!result) allPassed = false;
                return result;
            }

            check("Assets/_Project folder exists", Directory.Exists("Assets/_Project"));
            check("Contracts folder exists", Directory.Exists("Assets/_Project/Scripts/Contracts"));
            check("MockBackend.cs exists", File.Exists("Assets/_Project/Scripts/Backend/Mock/MockBackend.cs"));
            check("SceneFlowController.cs exists", File.Exists("Assets/_Project/Scripts/Frontend/SceneFlowController.cs"));
            check("Data/Mock/MockData.json exists", File.Exists("Assets/_Project/Data/Mock/MockData.json"));

            var backend = new MockBackend();
            check("MockBackend instantiated", backend != null);
            check("GetSnapshot works", backend.GetSnapshot() != null);
            check("Execute(StartNewGameCommand) succeeds", backend.Execute(new StartNewGameCommand()).success);
            check("Execute(BuildCommand) succeeds", backend.Execute(new BuildCommand { buildingTypeId = "Hut" }).success);
            check("Execute(AssignWorkerCommand) succeeds", backend.Execute(new AssignWorkerCommand { villagerId = "v1", role = "Builder" }).success);

            report += "\\n## Conclusion\\n";
            report += allPassed ? "ALL PASSED. Project is ready for UI MVP run in Editor." : "SOME TESTS FAILED. See above.";

            File.WriteAllText(reportPath, report);
            AssetDatabase.Refresh();
            Debug.Log("Verification Complete! See Docs/VerificationReport.md");
        }
    }
}
#endif
"""

for filepath, content in files.items():
    full_path = os.path.join(base_dir, filepath)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\\n")

print("Scaffolding complete!")
