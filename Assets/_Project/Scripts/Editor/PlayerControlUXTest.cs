using System.IO;
using System.Text;
using System.Linq;
using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild;

namespace TheBonwater.Rebuild.Editor {
    public static class PlayerControlUXTest {
        [MenuItem("Tools/Rebuild/Tests/Run Player Control UX Test")]
        public static void Run() {
            var report = new StringBuilder();
            report.AppendLine("# Sprint 13 Player Control UX Test Report");
            report.AppendLine("## Overview\nValidates job control logging, build action fail logging, and time advance logging.");
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

            // 2. Job Control
            backend.Execute(new AssignWorkerCommand());
            state = backend.GetSnapshot();
            Check("Job control can set Woodcutter", state.villagers[0].job == "Woodcutter");
            Check("Event log records job change", state.taskLogs.Any(l => l.Contains("changed job: Idle -> Woodcutter")));

            // 3. Build Hut Fail (No resources)
            state = backend.GetSnapshot(); // Wood is 50 default in LocalGameBackend?
            // Actually, starting wood is 50. Hut costs 50. Wait!
            // BuildHutCommand will succeed if wood is 50!
            // Let's build a Storage first to fail (Storage costs 100).
            backend.Execute(new BuildStorageCommand());
            state = backend.GetSnapshot();
            Check("Build Storage fails without resources", state.tasks.Count == 0);
            Check("Build failure logs reason", state.taskLogs.Any(l => l.Contains("Cannot build Storage: Not enough Wood")));

            // 4. Build Hut Success (Wood = 50)
            backend.Execute(new BuildHutCommand());
            state = backend.GetSnapshot();
            Check("Build Hut succeeds with enough resources", state.tasks.Count == 1);

            // 5. Time Advance
            backend.Execute(new AdvanceTimeCommand());
            state = backend.GetSnapshot();
            Check("Next Phase advances time clearly", state.taskLogs.Any(l => l.Contains("Time advanced: ")));

            report.AppendLine($"\n**Total Pass:** {pass}");
            report.AppendLine($"**Total Fail:** {fail}");

            string reportPath = "Assets/_Project/Docs/PlayerControlUXTestReport.md";
            File.WriteAllText(reportPath, report.ToString());
            UnityEngine.Debug.Log($"Player Control UX Test completed. Pass: {pass}, Fail: {fail}. Report saved to {reportPath}");
        }
    }
}
