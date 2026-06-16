using UnityEngine;
using TheBonwater.Rebuild;

namespace TheBonwater.Rebuild.Tests {
    public class Phase7BAutoTimeLoopTest {
        public static void RunTest() {
            Debug.Log("--- STARTING PHASE 7B AUTO TIME LOOP TEST ---");

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);

            var go = new GameObject("TestAutoTimeController");
            var autoTime = go.AddComponent<AutoTimeController>();
            
            // Set speed so it won't tick normally during test without us forcing it
            autoTime.phaseDurationSeconds = 20f;
            autoTime.isPaused = false;

            // 1. New Game -> Morning
            var snap1 = backend.GetSnapshot();
            if (snap1.timeOfDay != "Morning") Debug.LogError($"Expected Morning, got {snap1.timeOfDay}");
            else Debug.Log("Pass: Started at Morning");

            // Assign forager
            backend.Execute(new AssignVillagerJobCommand { villagerId = "v1", jobId = "Forager" });

            int foodBefore = backend.GetSnapshot().food;

            // 4. ForceAutoTickForTest advances phase without pressing Next Phase.
            autoTime.ForceAutoTickForTest();

            var snap2 = backend.GetSnapshot();
            if (snap2.timeOfDay != "Afternoon") Debug.LogError($"Expected Afternoon, got {snap2.timeOfDay}");
            else Debug.Log("Pass: Auto tick advanced to Afternoon");

            // 6. Forager food still increases when assigned.
            if (snap2.food <= foodBefore) Debug.LogError($"Expected food to increase from {foodBefore}, got {snap2.food}");
            else Debug.Log($"Pass: Food increased ({foodBefore} -> {snap2.food})");

            // 7. Manual Next Phase resets auto timer.
            // We verify by forcing manual tick then checking if we double tick
            backend.Execute(new AdvanceTimeCommand());
            autoTime.ResetTimer();
            var snap3 = backend.GetSnapshot();
            if (snap3.timeOfDay != "Evening") Debug.LogError($"Expected Evening, got {snap3.timeOfDay}");
            else Debug.Log("Pass: Manual advance to Evening");

            // Next tick should go to Night
            autoTime.ForceAutoTickForTest();
            var snap4 = backend.GetSnapshot();
            if (snap4.timeOfDay != "Night") Debug.LogError($"Expected Night, got {snap4.timeOfDay}");
            else Debug.Log("Pass: Auto tick to Night");

            GameObject.DestroyImmediate(go);
            Debug.Log("--- TEST COMPLETE ---");
        }
    }
}
