using UnityEngine;
using TheBonwater.Rebuild.Diagnostics;

namespace TheBonwater.Rebuild {
    public class AutoTimeController : MonoBehaviour {
        public float phaseDurationSeconds = 20f;
        public float speedMultiplier = 1f;
        public bool isPaused = true;

        private float currentTimer = 0f;

        public float TimeRemaining => Mathf.Max(0, phaseDurationSeconds - currentTimer);
        public float PhaseProgress01 => Mathf.Clamp01(currentTimer / phaseDurationSeconds);
        public bool IsRunning => !isPaused;

        private void Update() {
            if (isPaused) return;

            currentTimer += Time.deltaTime * speedMultiplier;

            if (currentTimer >= phaseDurationSeconds) {
                currentTimer -= phaseDurationSeconds;
                
                var backend = GameServiceLocator.Backend;
                if (backend != null) {
                    var snapBefore = backend.GetSnapshot();
                    string oldPhase = snapBefore.timeOfDay;
                    int oldDay = snapBefore.day;

                    if (TownInteractionController.Instance != null) {
                        TownInteractionController.Instance.ExecuteCommand(new AdvanceTimeCommand());
                    } else {
                        backend.Execute(new AdvanceTimeCommand());
                    }

                    var snapAfter = backend.GetSnapshot();
                    string newPhase = snapAfter.timeOfDay;
                    int newDay = snapAfter.day;

                    RuntimeTrace.Log("TIME_AUTO_TICK", $"from={oldPhase} to={newPhase} day={newDay}");
                }
            }
        }

        public void ResetTimer() {
            currentTimer = 0f;
        }

        public void Play() {
            if (isPaused) {
                isPaused = false;
                RuntimeTrace.Log("TIME_AUTO_STARTED", "");
            }
        }

        public void Pause(string reason) {
            if (!isPaused) {
                isPaused = true;
                RuntimeTrace.Log("TIME_AUTO_PAUSED", $"reason={reason}");
            }
        }

        public void Stop() {
            if (!isPaused) {
                isPaused = true;
                RuntimeTrace.Log("TIME_AUTO_STOPPED", "");
            }
            ResetTimer();
        }

        public void ForceAutoTickForTest() {
            currentTimer = phaseDurationSeconds;
            Update();
        }
    }
}
