using System.IO;
using System.Text;
using System.Linq;
using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild;

namespace TheBonwater.Rebuild.Editor {
    public static class ThreeDayGameplayLoopTest {
        [MenuItem("Tools/Rebuild/Tests/Run Three-Day Loop Test")]
        public static void Run() {
            var report = new StringBuilder();
            report.AppendLine("# Sprint 12 Core Gameplay Loop Test Report");
            report.AppendLine("## Overview\nValidates the complete 3-day survival objective and logic flow, including resource auto-deposit and job production.");
            int pass = 0, fail = 0;

            void Check(string name, bool condition) {
                if (condition) { pass++; report.AppendLine($"- [PASS] {name}"); }
                else { fail++; report.AppendLine($"- [FAIL] {name}"); }
            }

            // 1. Setup Backend
            var savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (File.Exists(savePath)) File.Delete(savePath);
            var backend = new LocalGameBackend();
            var state = backend.GetSnapshot();

            Check("New Game Initialized", state.day == 1 && state.wood == 50);

            // Assign V1 to Woodcutter
            backend.Execute(new AssignWorkerCommand()); // v1 -> Woodcutter
            state = backend.GetSnapshot();
            Check("V1 assigned to Woodcutter", state.villagers[0].job == "Woodcutter");

            // Assign V2 to Builder
            backend.Execute(new AssignWorkerCommand()); // v2 -> Woodcutter
            backend.Execute(new AssignWorkerCommand()); // v2 -> Builder
            state = backend.GetSnapshot();
            Check("V2 assigned to Builder", state.villagers[1].job == "Builder");

            // Advance Time to get Wood
            backend.Execute(new AdvanceTimeCommand()); // Morning -> Afternoon
            state = backend.GetSnapshot();
            Check("Wood produced on time advance", state.wood > 50);

            // Build Hut 1
            backend.Execute(new BuildHutCommand());
            state = backend.GetSnapshot();
            Check("Hut 1 Blueprint placed", state.tasks.Count == 1 && state.wood >= 10);

            // Advance Time until Hut 1 Complete
            while(state.tasks.Count > 0 && state.day < 2) {
                backend.Execute(new AdvanceTimeCommand());
                state = backend.GetSnapshot();
            }
            Check("Hut 1 Built", state.buildings.Any(b => b.id == "Hut" && b.count >= 1));

            // Build Hut 2
            backend.Execute(new BuildHutCommand());
            
            // Advance Time until Day 3
            while (state.day < 3) {
                backend.Execute(new AdvanceTimeCommand());
                state = backend.GetSnapshot();
                if (state.isGameOver) break;
            }

            Check("Survived to Day 3", state.day >= 3 && !state.isGameOver);
            Check("At least one villager alive", state.villagers.Any(v => v.hp > 0));
            
            int finalHutCount = state.buildings.FirstOrDefault(b => b.id == "Hut")?.count ?? 0;
            Check($"Hut 2 Built (Total: {finalHutCount})", finalHutCount >= 2);
            Check("Objective Status COMPLETED", state.objectiveState.status == "COMPLETED" && state.isObjectiveComplete);

            // Test Persistence
            backend.Execute(new SaveGameCommand());
            var newBackend = new LocalGameBackend();
            newBackend.Execute(new LoadGameCommand());
            var loadedState = newBackend.GetSnapshot();

            Check("Loaded state preserved Day", loadedState.day == state.day);
            Check("Loaded state preserved Wood", loadedState.wood == state.wood);
            Check("Loaded state preserved Jobs", loadedState.villagers[0].job == state.villagers[0].job);
            Check("Loaded state preserved Objective", loadedState.objectiveState.status == "COMPLETED");
            Check("Loaded state preserved Buildings", loadedState.buildings.FirstOrDefault(b => b.id == "Hut")?.count == finalHutCount);

            report.AppendLine($"\n**Total Pass:** {pass}");
            report.AppendLine($"**Total Fail:** {fail}");

            string reportPath = "Assets/_Project/Docs/ThreeDayGameplayLoopTestReport.md";
            File.WriteAllText(reportPath, report.ToString());
            UnityEngine.Debug.Log($"Three-Day Loop Test completed. Pass: {pass}, Fail: {fail}. Report saved to {reportPath}");
        }
    }
}
