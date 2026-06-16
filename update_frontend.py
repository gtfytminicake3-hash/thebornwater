import os

frontend_code = """using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Linq;

namespace TheBonwater.Rebuild
{
    public class TownInteractionController : MonoBehaviour
    {
        public static TownInteractionController Instance;

        public Button btnCollectWood;
        public Button btnBuildHut;
        public Button btnAssignWorker;
        public Button btnAdvanceTime;
        public Button btnSave;
        public Button btnLoad;

        public delegate void StateChangedHandler(GameSnapshot snapshot);
        public event StateChangedHandler OnStateChanged;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            if (GameServiceLocator.Backend == null)
            {
                GameServiceLocator.RegisterBackend(new MockBackend());
            }

            if (btnCollectWood != null) btnCollectWood.onClick.AddListener(() => ExecuteCommand(new CollectWoodCommand()));
            if (btnBuildHut != null) btnBuildHut.onClick.AddListener(() => ExecuteCommand(new BuildHutCommand()));
            if (btnAssignWorker != null) btnAssignWorker.onClick.AddListener(() => ExecuteCommand(new AssignWorkerCommand()));
            if (btnAdvanceTime != null) btnAdvanceTime.onClick.AddListener(() => ExecuteCommand(new AdvanceTimeCommand()));
            if (btnSave != null) btnSave.onClick.AddListener(() => ExecuteCommand(new SaveGameCommand()));
            if (btnLoad != null) btnLoad.onClick.AddListener(() => ExecuteCommand(new LoadGameCommand()));

            RefreshUI();
        }

        public void ExecuteCommand(GameCommand cmd)
        {
            GameServiceLocator.Backend.Execute(cmd);
            RefreshUI();
        }

        public void RefreshUI()
        {
            var snap = GameServiceLocator.Backend.GetSnapshot();
            OnStateChanged?.Invoke(snap);
            
            // Visual spawn for buildings
            var worldRoot = GameObject.Find("TownWorldRoot");
            if (worldRoot != null)
            {
                var hutSnap = snap.buildings.Find(b => b.id == "Hut");
                if (hutSnap != null)
                {
                    int currentHuts = 0;
                    foreach(Transform child in worldRoot.transform)
                    {
                        if (child.name.StartsWith("HutVisual_Runtime")) currentHuts++;
                    }

                    for(int i = currentHuts; i < hutSnap.count; i++)
                    {
                        var go = new GameObject($"HutVisual_Runtime_{i+1}");
                        go.transform.SetParent(worldRoot.transform, false);
                        var img = go.AddComponent<Image>();
                        img.color = new Color(0.6f, 0.3f, 0.1f); // Brown placeholder
                        img.raycastTarget = false;
                        var rect = go.GetComponent<RectTransform>();
                        rect.anchoredPosition = new Vector2(-250 + (i * 100), 50 + (i * 20));
                        rect.sizeDelta = new Vector2(100, 100);
                        go.transform.SetSiblingIndex(2);
                    }
                }
            }
        }
    }

    public class TownView : MonoBehaviour
    {
        public Text txtDayTime;

        private void Start()
        {
            if (TownInteractionController.Instance != null)
                TownInteractionController.Instance.OnStateChanged += UpdateView;
        }

        private void UpdateView(GameSnapshot snap)
        {
            if (txtDayTime != null)
                txtDayTime.text = $"Day {snap.day} - {snap.timeOfDay}";
        }
    }

    public class ResourceBarView : MonoBehaviour
    {
        public Text txtResources;

        private void Start()
        {
            if (TownInteractionController.Instance != null)
                TownInteractionController.Instance.OnStateChanged += UpdateView;
        }

        private void UpdateView(GameSnapshot snap)
        {
            if (txtResources != null)
            {
                txtResources.text = $"Wood: {snap.wood} / {snap.woodCapacity}   " +
                                    $"Food: {snap.food} / {snap.foodCapacity}   " +
                                    $"Iron: {snap.iron} / {snap.ironCapacity}";
            }
        }
    }

    public class VillagerListView : MonoBehaviour
    {
        public Text txtVillagers;

        private void Start()
        {
            if (TownInteractionController.Instance != null)
                TownInteractionController.Instance.OnStateChanged += UpdateView;
        }

        private void UpdateView(GameSnapshot snap)
        {
            if (txtVillagers != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine("VILLAGERS");
                foreach(var v in snap.villagers)
                {
                    sb.AppendLine($"{v.name} | Job: {v.job} | HP: {v.hp}");
                }
                txtVillagers.text = sb.ToString();
            }
        }
    }

    public class BuildingListView : MonoBehaviour
    {
        public Text txtBuildings;

        private void Start()
        {
            if (TownInteractionController.Instance != null)
                TownInteractionController.Instance.OnStateChanged += UpdateView;
        }

        private void UpdateView(GameSnapshot snap)
        {
            if (txtBuildings != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine("BUILDINGS");
                foreach(var b in snap.buildings)
                {
                    sb.AppendLine($"{b.id} x{b.count}");
                }
                txtBuildings.text = sb.ToString();
            }
        }
    }

    public class TaskLogView : MonoBehaviour
    {
        public Text txtLog;

        private void Start()
        {
            if (TownInteractionController.Instance != null)
                TownInteractionController.Instance.OnStateChanged += UpdateView;
        }

        private void UpdateView(GameSnapshot snap)
        {
            if (txtLog != null)
            {
                var sb = new StringBuilder();
                sb.AppendLine("TASK LOG");
                foreach(var log in snap.taskLogs)
                {
                    sb.AppendLine($"- {log}");
                }
                txtLog.text = sb.ToString();
            }
        }
    }

    public class DebugStateView : MonoBehaviour
    {
        public Text txtDebug;

        private void Start()
        {
            if (TownInteractionController.Instance != null)
                TownInteractionController.Instance.OnStateChanged += UpdateView;
        }

        private void UpdateView(GameSnapshot snap)
        {
            if (txtDebug != null)
            {
                txtDebug.text = "Debug Raw Snapshot\\n" + JsonUtility.ToJson(snap, true);
            }
        }
    }
}
"""

with open(r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Frontend\TownInteractionController.cs", "w", encoding="utf-8") as f:
    f.write(frontend_code)

print("Updated TownInteractionController and Views via python!")
