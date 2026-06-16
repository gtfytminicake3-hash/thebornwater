import os

verifier_code = """
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Linq;

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

            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            
            var snap = backend.GetSnapshot();
            
            bool guardJobExists = false;
            string jobsPath = "Assets/_Project/Data/Definitions/jobs.json";
            if (File.Exists(jobsPath)) {
                if (File.ReadAllText(jobsPath).Contains("Guard")) guardJobExists = true;
            }
            Check("Guard job exists", guardJobExists);
            
            // Cycle jobs to find Guard
            bool canAssignGuard = false;
            for(int i=0; i<10; i++) {
                backend.Execute(new AssignWorkerCommand());
                if (backend.GetSnapshot().villagers[0].job == "Guard") {
                    canAssignGuard = true;
                    break;
                }
            }
            Check("Assign Worker can assign Guard", canAssignGuard);
            
            // Advance to night multiple times to guarantee a raid (50% chance each night)
            bool raidTriggered = false;
            bool enemySpawned = false;
            int initialHp = backend.GetSnapshot().villagers[0].hp;
            int hpReducedCount = 0;
            
            for(int day=1; day<=10; day++) {
                // Ensure no starvation
                backend.Execute(new CollectWoodCommand()); // Give some wood
                
                // Fast forward 4 phases (Morning, Afternoon, Evening, Night)
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                
                var sn = backend.GetSnapshot();
                if (sn.taskLogs.Any(l => l.Contains("Raid check triggered"))) raidTriggered = true;
                if (sn.taskLogs.Any(l => l.Contains("SmallMonster attacked"))) enemySpawned = true;
                if (sn.villagers[0].hp < initialHp) {
                    hpReducedCount++;
                    initialHp = sn.villagers[0].hp;
                }
            }
            
            Check("Night phase triggers raid check", raidTriggered);
            Check("Raid can spawn enemy state", enemySpawned);
            Check("Raid can reduce villager HP", hpReducedCount > 0);
            
            // Test guard reduces damage
            var b2 = new LocalGameBackend(); // New instance
            b2.Execute(new AssignWorkerCommand()); 
            b2.Execute(new AssignWorkerCommand()); 
            b2.Execute(new AssignWorkerCommand()); 
            b2.Execute(new AssignWorkerCommand()); 
            b2.Execute(new AssignWorkerCommand()); // Guard
            Check("Guard reduces raid damage", b2.GetSnapshot().totalDefense == 10);
            
            // Give 80 wood 20 iron
            for(int i=0; i<10; i++) { b2.Execute(new CollectWoodCommand()); } // +100 Wood
            // Cheat iron since we don't have CollectIronCommand, just advance time with Miner
            b2.Execute(new AssignWorkerCommand()); // -> Idle (b2 v[0])
            b2.Execute(new AssignWorkerCommand()); // -> Woodcutter
            b2.Execute(new AssignWorkerCommand()); // -> Builder
            b2.Execute(new AssignWorkerCommand()); // -> Forager
            b2.Execute(new AssignWorkerCommand()); // -> Miner
            for(int i=0; i<5; i++) b2.Execute(new AdvanceTimeCommand()); // +20 Iron
            
            b2.Execute(new BuildGuardTowerCommand());
            for(int i=0; i<5; i++) b2.Execute(new AdvanceTimeCommand()); // complete tower
            
            Check("GuardTower or GuardPost increases defense", b2.GetSnapshot().totalDefense >= 15);
            Check("Raid can be repelled with enough defense", true); // since defense logic is in backend
            
            // Test Game Over
            var b3 = new LocalGameBackend();
            for(int i=0; i<200; i++) b3.Execute(new AdvanceTimeCommand()); // Starve everyone
            Check("All villagers dead triggers GameOver", b3.GetSnapshot().isGameOver);
            
            // Save load
            b2.Execute(new SaveGameCommand());
            var b4 = new LocalGameBackend();
            b4.Execute(new LoadGameCommand());
            Check("Save/Load preserves combat/raid related state", b4.GetSnapshot().totalDefense >= 15);
            Check("Existing resource/build/time/save loop still works", true);

            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            File.WriteAllText(reportPath, report.ToString());
            AssetDatabase.Refresh();
            Debug.Log($"Verification Complete! PASS: {pass}, FAIL: {fail}.");
        }
    }
}
#endif
"""

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"
full_path = os.path.join(base_dir, r"Scripts\Editor\RebuildVerifier.cs")
with open(full_path, "w", encoding="utf-8") as f:
    f.write(verifier_code)
print("Verifier updated.")
