#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using TheBonwater.Rebuild;
using System.IO;
using System.Linq;

namespace TheBonwater.Rebuild.Editor {
    public static class EndToEndSmokeTest {
        [MenuItem("Tools/Rebuild/Run End-to-End Smoke Test")]
        public static void Run() {
            UnityEngine.Debug.Log("Starting EndToEndSmokeTest.Run...");
            string reportPath = "Assets/_Project/Docs/OriginalFidelity/EndToEndSmokeTestReport.md";
            string log = "# EndToEnd Smoke Test Report\n\n";
            log += "Smoke test method name: TheBonwater.Rebuild.Editor.EndToEndSmokeTest.Run\n";
            log += "Unity command used: \"D:\\UnityGame\\UnityEditer\\6000.3.17f1\\Editor\\Unity.exe\" -projectPath \"D:\\Tinh\\TheBonwater\" -batchmode -quit -executeMethod TheBonwater.Rebuild.Editor.EndToEndSmokeTest.Run -logFile \"D:\\Tinh\\TheBonwater\\Logs\\unity_e2e_smoke_pass01.log\"\n";
            log += "Unity log path: D:\\Tinh\\TheBonwater\\Logs\\unity_e2e_smoke_pass01.log\n\n";
            
            log += "## Actual assertions:\n";
            int failCount = 0;

            void Assert(string name, bool condition, string expected, string actual) {
                if (condition) log += $"- {name}\n  - Expected: {expected}\n  - Actual: {actual}\n  - Result: PASS\n";
                else { log += $"- {name}\n  - Expected: {expected}\n  - Actual: {actual}\n  - Result: FAIL\n"; failCount++; }
            }

            try {
                // 1. Initialize backend
                string savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
                if (File.Exists(savePath)) File.Delete(savePath);
                
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();
                Assert("Backend Initialization", state != null, "Not Null", state != null ? "Not Null" : "Null");

                int initialHutCount = state.buildings.Find(b => b.id == "Hut")?.count ?? 0;

                // 2. HUD Check
                string hudCode = File.ReadAllText("Assets/_Project/Scripts/Frontend/TownInteractionController.cs");
                Assert("Debug Buttons in HUD", !hudCode.Contains("btnCollectWood"), "True", (!hudCode.Contains("btnCollectWood")).ToString());

                // Snapshot BEFORE
                log += "\nSnapshot before BuildHutCommand:\n```json\n" + JsonUtility.ToJson(state, true) + "\n```\n";

                // 3. Use BuildHutCommand
                backend.Execute(new BuildHutCommand());
                state = backend.GetSnapshot();
                
                // Snapshot AFTER
                log += "\nSnapshot after BuildHutCommand:\n```json\n" + JsonUtility.ToJson(state, true) + "\n```\n";

                // 4. Assert completed Hut count does not increase immediately
                int newHutCount = state.buildings.Find(b => b.id == "Hut")?.count ?? 0;
                Assert("Hut Count Immediate Increase", newHutCount == initialHutCount, initialHutCount.ToString(), newHutCount.ToString());

                // 5. Assert construction task exists
                var task = state.tasks.FirstOrDefault(t => t.targetBuildingId == "Hut");
                Assert("Construction Task Creation", task != null, "Not Null", task != null ? "Not Null" : "Null");
                if (task != null) {
                    Assert("Task Status", task.status == "AwaitingResources", "AwaitingResources", task.status);
                }

                // 6. Editor test tool deposit
                if (task != null) {
                    backend.DepositResource(task.id);
                    state = backend.GetSnapshot();
                    task = state.tasks.FirstOrDefault(t => t.id == task.id);
                    Assert("Test Deposit Success", task != null && task.isResourcesComplete, "True", (task != null && task.isResourcesComplete).ToString());
                    log += "\nSnapshot after test deposit:\n```json\n" + JsonUtility.ToJson(state, true) + "\n```\n";
                }

                // 7. Editor test tool progress
                if (task != null) {
                    backend.UpdateConstruction(task.id, 50);
                    state = backend.GetSnapshot();
                    task = state.tasks.FirstOrDefault(t => t.id == task.id);
                    Assert("Test Progress 1 (50)", task != null && task.currentCompletion == 50, "50", (task != null ? task.currentCompletion.ToString() : "Null"));
                    
                    backend.UpdateConstruction(task.id, 50);
                    state = backend.GetSnapshot();
                    log += "\nSnapshot after test progress:\n```json\n" + JsonUtility.ToJson(state, true) + "\n```\n";
                }

                // 8. Assert completed Hut appears
                newHutCount = state.buildings.Find(b => b.id == "Hut")?.count ?? 0;
                Assert("Hut Completed After Progress", newHutCount > initialHutCount && state.tasks.Count == 0, "True", (newHutCount > initialHutCount && state.tasks.Count == 0).ToString());

                // 9. Save state
                savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
                backend.Execute(new SaveGameCommand());
                Assert("Save File Exists", File.Exists(savePath), "True", File.Exists(savePath).ToString());

                // 10. Load state
                var backend2 = new LocalGameBackend();
                backend2.Execute(new LoadGameCommand());
                var state2 = backend2.GetSnapshot();
                Assert("Load Preserves Hut Count", state2.buildings.Find(b => b.id == "Hut")?.count == newHutCount, newHutCount.ToString(), (state2.buildings.Find(b => b.id == "Hut")?.count ?? -1).ToString());
                
                log += "\nSnapshot after save/load:\n```json\n" + JsonUtility.ToJson(state2, true) + "\n```\n";

                File.WriteAllText(reportPath, log);
                UnityEngine.Debug.Log($"Smoke test completed. Failures: {failCount}");

                if (failCount > 0) EditorApplication.Exit(1);
            }
            catch (System.Exception ex) {
                UnityEngine.Debug.LogError(ex.ToString());
                File.WriteAllText(reportPath, log + "\n\nCRASH:\n" + ex.ToString());
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
