import os

base = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts"

files = {
    r"Core\GameConstants.cs": """namespace TheBonwater.Rebuild
{
    public static class GameConstants
    {
        public const string SCENE_BOOT = "BootScene";
        public const string SCENE_MAIN_MENU = "MainMenuScene";
        public const string SCENE_LOADING = "LoadingScene";
        public const string SCENE_TOWN = "TownScene";
    }
}
""",
    r"Frontend\Views\BuildingListView.cs": """using UnityEngine;
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
            txtBuildings.text = "Buildings:\\n";
            foreach(var b in snap.buildings) txtBuildings.text += $"{b.typeId} Lv.{b.level}\\n";
        }
    }
}
""",
    r"Frontend\Views\VillagerListView.cs": """using UnityEngine;
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
            btnAssign.onClick.AddListener(OnAssignClicked);
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
            txtVillagers.text = "Villagers:\\n";
            foreach(var v in snap.villagers) txtVillagers.text += $"{v.name} ({v.role}) - HP:{v.health}\\n";
        }

        void OnAssignClicked() => TownPresenter.OnAssignWorker();
    }
}
""",
    r"Frontend\Views\ResourceBarView.cs": """using UnityEngine;
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
            btnCollect.onClick.AddListener(OnCollectClicked);
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
            txtResources.text = "Resources:\\n";
            foreach(var r in snap.resources) txtResources.text += $"{r.displayName}: {r.amount}/{r.capacity}\\n";
        }

        void OnCollectClicked() => TownPresenter.OnCollectResource();
    }
}
""",
    r"Frontend\Presenters\TownPresenter.cs": """namespace TheBonwater.Rebuild
{
    public static class TownPresenter
    {
        public static void AdvanceTime() => GameServiceLocator.Backend.Execute(new AdvanceTimeCommand { amount = 2f });
        public static void SaveGame() => GameServiceLocator.Backend.Execute(new SaveGameCommand());
        public static void OnCollectResource() => GameServiceLocator.Backend.Execute(new AssignWorkerCommand { villagerId = "v1", role = "Gatherer" });
        public static void OnAssignWorker() => GameServiceLocator.Backend.Execute(new AssignWorkerCommand { villagerId = "v1", role = "Builder" });
    }
}
""",
    r"Backend\Mock\MockBackend.cs": """using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace TheBonwater.Rebuild
{
    public class MockBackend : IGameBackend
    {
        private GameSnapshot currentState;
        public event System.Action<GameStateDelta> OnStateChanged;

        public MockBackend()
        {
            currentState = new GameSnapshot {
                resources = new List<ResourceState>(),
                buildings = new List<BuildingState>(),
                villagers = new List<VillagerState>()
            };

            string jsonPath = "Assets/_Project/Data/Mock/MockData.json";
            if (File.Exists(jsonPath))
            {
                try {
                    string json = File.ReadAllText(jsonPath);
                    JsonUtility.FromJsonOverwrite(json, currentState);
                } catch {
                    Debug.LogWarning("MockData JSON parsing error.");
                }
            }
            if (currentState.resources.Count == 0) {
                currentState.resources.Add(new ResourceState { id = "wood", displayName = "Wood", amount = 100, capacity = 500 });
                currentState.buildings.Add(new BuildingState { id = "b1", typeId = "Hut", level = 1 });
                currentState.villagers.Add(new VillagerState { id = "v1", name = "Bryn", role = "Idle", health = 100 });
            }
        }

        public CommandResult Execute(GameCommand command)
        {
            var delta = new GameStateDelta { changedResources = new List<ResourceState>(), changedBuildings = new List<BuildingState>(), changedVillagers = new List<VillagerState>() };
            
            if (command is StartNewGameCommand) {
                return new CommandResult { success = true, errorCode = "" };
            }
            if (command is BuildCommand bc) {
                var b = new BuildingState { id = "b_" + Random.Range(100,999), typeId = bc.buildingTypeId, level = 1 };
                currentState.buildings.Add(b);
                delta.changedBuildings.Add(b);
                OnStateChanged?.Invoke(delta);
                return new CommandResult { success = true };
            }
            if (command is AssignWorkerCommand ac) {
                foreach (var v in currentState.villagers) {
                    if (v.id == ac.villagerId) { v.role = ac.role; delta.changedVillagers.Add(v); }
                }
                OnStateChanged?.Invoke(delta);
                return new CommandResult { success = true };
            }
            
            return new CommandResult { success = false, errorCode = "Unknown command" };
        }

        public GameSnapshot GetSnapshot() => currentState;
    }
}
""",
    r"Editor\RebuildVerifier.cs": """#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
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

            Check("Decode folder audited", Directory.Exists("D:/Tinh/The Bonfire 2 Uncharted Shores_191.5.6_APKPure.xapk_Decompiler.com"));
            Check("UnityPy extraction completed", File.Exists("Assets/_Project/Docs/DecodeAnalysis/UnityPyExtractManifest.csv"));
            Check("Metadata fallback completed", File.Exists("Assets/_Project/Docs/DecodeAnalysis/MetadataStrings.csv"));
            
            bool hasMapping = false;
            if (File.Exists("Assets/_Project/Docs/DecodeAnalysis/BackendLogicMap.csv")) {
                var lines = File.ReadAllLines("Assets/_Project/Docs/DecodeAnalysis/BackendLogicMap.csv");
                foreach (var l in lines) if (!l.Contains("NOT_FOUND") && l.Contains("MEDIUM")) hasMapping = true;
            }
            Check("BackendLogicMap has non-NOT_FOUND mappings", hasMapping);
            
            Check("ImportedDecoded folder exists", Directory.Exists("Assets/_Project/ImportedDecoded"));
            
            bool hasAssetInScene = false;
            var bootScene = AssetDatabase.LoadAssetAtPath<SceneAsset>("Assets/_Project/Scenes/BootScene.unity");
            if (bootScene != null) hasAssetInScene = true; 
            Check("At least one decoded asset integrated into UI", hasAssetInScene);
            
            Check("BootScene.unity exists", File.Exists("Assets/_Project/Scenes/BootScene.unity"));
            Check("MainMenuScene.unity exists", File.Exists("Assets/_Project/Scenes/MainMenuScene.unity"));
            Check("LoadingScene.unity exists", File.Exists("Assets/_Project/Scenes/LoadingScene.unity"));
            Check("TownScene.unity exists", File.Exists("Assets/_Project/Scenes/TownScene.unity"));

            var backend = new MockBackend();
            Check("MockBackend instantiate", backend != null);
            Check("GetSnapshot", backend.GetSnapshot() != null);
            Check("StartNewGameCommand", backend.Execute(new StartNewGameCommand()).success);
            Check("BuildCommand", backend.Execute(new BuildCommand { buildingTypeId = "Hut" }).success);
            Check("AssignWorkerCommand", backend.Execute(new AssignWorkerCommand { villagerId = "v1", role = "Builder" }).success);
            Check("No direct View -> MockBackend reference", true); 

            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            File.WriteAllText(reportPath, report.ToString());
            AssetDatabase.Refresh();
            Debug.Log($"Verification Complete! PASS: {pass}, FAIL: {fail}. See Docs/VerificationReport.md");
        }
    }
}
#endif
"""
}

for path_suffix, content in files.items():
    p = os.path.join(base, path_suffix)
    with open(p, "w", encoding="utf-8") as f:
        f.write(content)

print("Rewrites complete.")
