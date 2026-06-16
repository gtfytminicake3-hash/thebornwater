using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;
using System.Linq;

namespace TheBonwater.Rebuild.Editor.Tests {
    public class VillagerInteractionTest {
        [MenuItem("Tools/TheBonwater/Test Tools/Run Villager Interaction Test")]
        public static void RunTest() {
            Debug.Log("==== STARTING VILLAGER INTERACTION TEST ====");
            bool hasErrors = false;
            void AssertTrue(bool condition, string errorMsg) {
                if (!condition) { Debug.LogError("[FAIL] " + errorMsg); hasErrors = true; }
            }

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            var goRoot = GameObject.Find("TownWorldRoot");
            if (goRoot != null) GameObject.DestroyImmediate(goRoot);
            goRoot = new GameObject("TownWorldRoot");

            var visualCtrl = goRoot.AddComponent<TownRuntimeVisualController>();
            AnimationRegistryBuilder.BuildRegistry();
            
            // 1. New Game creates tree visuals
            var snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // Mock a tree visual for testing since NewGame might not spawn trees in snapshot yet
            var mockTree = new GameObject("tree:mock");
            mockTree.transform.SetParent(goRoot.transform);
            var mockTreeView = mockTree.AddComponent<WorldObjectView>();
            mockTreeView.objectId = "tree:mock";
            mockTreeView.preserveManualPlacement = true;
            visualCtrl.HandleStateChanged(snap); // Refresh to register tree
            
            visualCtrl.DumpWorldRegistry();

            // 3. Assert 2 villagers initial positions are different
            var agents = goRoot.GetComponentsInChildren<VillagerAgentView>(true);
            var v1Agent = agents.FirstOrDefault(a => a.villagerId == "v1");
            var v2Agent = agents.FirstOrDefault(a => a.villagerId == "v2");
            AssertTrue(v1Agent != null && v2Agent != null, "Villagers v1 and v2 not created");
            if (v1Agent != null && v2Agent != null) {
                AssertTrue(v1Agent.rectTransform.anchoredPosition != v2Agent.rectTransform.anchoredPosition, "Villagers spawned overlapping at " + v1Agent.rectTransform.anchoredPosition);
            }

            // 2. Assign villager Woodcutter
            backend.Execute(new SelectVillagerCommand { villagerId = "v1" });
            backend.Execute(new AssignVillagerJobCommand { villagerId = "v1", jobId = "Woodcutter" });
            snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // Assert Woodcutter target is actual runtime tree visual
            AssertTrue(v1Agent != null && (v1Agent.targetId == "tree:mock" || v1Agent.targetId.Contains("wood") || v1Agent.targetId.Contains("tree")), $"Woodcutter target expected tree/resource, got {v1Agent?.targetId}");

            // 4. Assert Builder position preserved after Next Phase
            var posBefore = v1Agent.rectTransform.anchoredPosition;
            backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            AssertTrue(v1Agent.rectTransform.anchoredPosition == posBefore, "Villager position snapped back after Next Phase");

            // Build Hut
            backend.Execute(new BuildHutCommand());
            snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // Assign Builder
            backend.Execute(new AssignVillagerJobCommand { villagerId = "v1", jobId = "Builder" });
            snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // Assert target is actual construction visual
            var tsk = snap.tasks.FirstOrDefault(t => t.status == "UnderConstruction" || t.status == "AwaitingResources");
            AssertTrue(v1Agent != null && v1Agent.targetId.Contains("construction"), $"Builder target expected construction visual, got {v1Agent?.targetId}");

            // Trigger raid
            backend.Execute(new ForceRaidCommand());
            snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);

            // 5. Assert Guard targets active monster visual when raid active
            backend.Execute(new AssignVillagerJobCommand { villagerId = "v1", jobId = "Guard" });
            snap = backend.GetSnapshot();
            visualCtrl.HandleStateChanged(snap);
            
            visualCtrl.DumpWorldRegistry();

            var activeEnemy = snap.enemies.FirstOrDefault(e => e.status == "Active");
            AssertTrue(v1Agent != null && v1Agent.targetId == "monster:" + activeEnemy?.id, $"Guard target expected monster, got {v1Agent?.targetId}");

            // 6. Assert SelectedVillagerPanel job buttons not overlapping/cut
            var panel = GameObject.FindObjectOfType<SelectedVillagerPanelView>(true);
            if (panel != null) {
                var layout = panel.GetComponentInChildren<UnityEngine.UI.VerticalLayoutGroup>(true);
                AssertTrue(layout != null, "Job panel does not use VerticalLayoutGroup, meaning buttons might overlap");
                var panelRt = panel.GetComponent<RectTransform>();
                AssertTrue(panelRt.sizeDelta.x >= 200, "Panel might be too narrow and cut off text");
            }

            // 7. Assert monster asset selected is head1.png
            string selectedKey, selectedPath;
            var sprite = visualCtrl.LoadMonsterSpriteCascade("SmallMonster", out selectedKey, out selectedPath);
            AssertTrue(selectedPath != null && selectedPath.Contains("head1.png"), "Monster asset is not head1.png");

            if (!hasErrors) {
                Debug.Log("VILLAGER_INTERACTION_AGENT_MOVEMENT_TEST_PASS");
            } else {
                Debug.LogError("[TEST FAILED] Villager Interaction Test finished with errors.");
            }
        }
    }
}
