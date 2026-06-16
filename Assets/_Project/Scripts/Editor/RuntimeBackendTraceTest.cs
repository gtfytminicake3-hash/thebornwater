using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using TheBonwater.Rebuild.Diagnostics;

namespace TheBonwater.Rebuild.Editor
{
    public static class RuntimeBackendTraceTest
    {
        [MenuItem("Tools/Rebuild/Run Runtime Trace Test")]
        public static void Run()
        {
            UnityEngine.Debug.Log("Starting RuntimeBackendTraceTest...");
            
            // 1. Clear trace log.
            RuntimeTrace.ClearLog();
            
            // 2. Start New Game.
            var savePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");
            if (File.Exists(savePath)) File.Delete(savePath);
            
            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            // 3. Build Hut.
            backend.Execute(new BuildHutCommand());
            
            // 4. Assign Job.
            backend.Execute(new AssignWorkerCommand());
            
            // 5. Advance time.
            backend.Execute(new AdvanceTimeCommand());
            
            // Check state before save
            var stateBefore = backend.GetSnapshot();
            int woodBefore = stateBefore.wood;
            int tasksBefore = stateBefore.tasks.Count;
            
            // 6. Save.
            backend.Execute(new SaveGameCommand());
            
            // 7. Destroy/reset backend instance.
            GameServiceLocator.RegisterBackend(null);
            backend = null;
            
            // 8. Create fresh backend instance. (Constructor auto-loads if file exists)
            var newBackend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(newBackend);
            
            // 9. Load (Optional, constructor already loaded it, but we can call it explicitly to test LoadGameCommand)
            newBackend.Execute(new LoadGameCommand());
            
            // 10. Assert state
            var stateAfter = newBackend.GetSnapshot();
            
            bool pass = true;
            if (stateAfter.wood != woodBefore) { pass = false; UnityEngine.Debug.LogError($"State mismatch: Wood {stateAfter.wood} != {woodBefore}"); }
            if (stateAfter.tasks.Count != tasksBefore) { pass = false; UnityEngine.Debug.LogError($"State mismatch: Tasks {stateAfter.tasks.Count} != {tasksBefore}"); }
            
            // Write to test log
            string testLogPath = "Logs/runtime_backend_trace_test.log";
            if (!Directory.Exists("Logs")) Directory.CreateDirectory("Logs");
            File.WriteAllText(testLogPath, $"Test Passed: {pass}\nState Preserved: Wood={stateAfter.wood}, Tasks={stateAfter.tasks.Count}\n");
            
            // Write MD report
            string mdReportPath = "Assets/_Project/Docs/RuntimeBackendTraceTestReport.md";
            string mdContent = $"# Runtime Backend Trace Test Report\n\n- **Passed:** {pass}\n- **State Preserved:** Wood={stateAfter.wood}, Tasks={stateAfter.tasks.Count}\n";
            File.WriteAllText(mdReportPath, mdContent);
            
            UnityEngine.Debug.Log($"RuntimeBackendTraceTest Passed: {pass}");
        }
    }
}
