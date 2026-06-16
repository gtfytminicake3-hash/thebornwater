#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.Text;
using System.IO;

namespace TheBonwater.Rebuild.Editor
{
    public class PlaytestBaselineRunner
    {
        [MenuItem("Tools/TheBonwater/Run Playtest Baseline")]
        public static void RunBaseline()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("# PlaytestBaselineResult");
            report.AppendLine("**Date**: " + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            report.AppendLine();
            report.AppendLine("## Automated Baseline Checks");
            report.AppendLine();

            int pass = 0;
            int fail = 0;

            void Check(string name, bool result)
            {
                report.AppendLine($"- [{(result ? "PASS" : "FAIL")}] {name}");
                if (result) pass++; else fail++;
            }

            // ---- Backend Tests ----
            var backend = new LocalGameBackend();
            var snap = backend.GetSnapshot();

            Check("New Game initializes resources from definitions", snap.wood > 0 && snap.iron >= 0);
            Check("New Game starts with villagers", snap.villagers.Count > 0);
            Check("Day starts at 1", snap.day == 1);
            Check("Time starts at Morning", snap.timeOfDay == "Morning");
            Check("Not game over initially", !snap.isGameOver);
            Check("Not objective complete initially", !snap.isObjectiveComplete);

            // Build Hut
            backend.Execute(new BuildHutCommand());
            snap = backend.GetSnapshot();
            var hutTask = snap.tasks.Find(t => t.targetBuildingId == "Hut");
            Check("Build Hut creates construction task", hutTask != null);
            Check("Hut is not instant-complete", snap.buildings.Find(b => b.id == "Hut") == null);

            // Try assign job
            backend.Execute(new AssignWorkerCommand());
            snap = backend.GetSnapshot();
            Check("AssignWorker changes job from Idle", snap.villagers.Exists(v => v.job != "Idle"));

            // Advance time
            backend.Execute(new AdvanceTimeCommand());
            snap = backend.GetSnapshot();
            Check("Time advances to Afternoon", snap.timeOfDay == "Afternoon");

            // Save / Load
            backend.Execute(new SaveGameCommand());
            var backend2 = new LocalGameBackend();
            var snap2 = backend2.GetSnapshot();
            Check("Save preserves day", snap2.day == snap.day);
            Check("Save preserves wood", snap2.wood == snap.wood);

            // No MockBackend check
            string mainMenuCode = File.ReadAllText("Assets/_Project/Scripts/Frontend/MainMenuController.cs");
            string townCode = File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs");
            Check("MainMenu uses LocalGameBackend, not MockBackend", mainMenuCode.Contains("new LocalGameBackend()"));
            Check("TownScene uses LocalGameBackend, not MockBackend", townCode.Contains("new LocalGameBackend()"));

            // No debug HUD buttons
            Check("No +10 Wood debug button in HUD", !townCode.Contains("btnCollectWood"));
            Check("No Force Raid debug button in HUD", !townCode.Contains("btnForceRaid"));

            report.AppendLine();
            report.AppendLine($"**Total PASS**: {pass}");
            report.AppendLine($"**Total FAIL**: {fail}");
            report.AppendLine();
            if (fail == 0) report.AppendLine("**Result**: ALL PASS — Baseline playtest flow verified.");
            else report.AppendLine("**Result**: SOME FAILURES — Review failures above.");

            string reportPath = "Assets/_Project/Docs/PlaytestBaselineResult.md";
            File.WriteAllText(reportPath, report.ToString());
            AssetDatabase.Refresh();
            UnityEngine.Debug.Log($"Playtest Baseline completed. PASS: {pass}, FAIL: {fail}.");
        }
    }
}
#endif
