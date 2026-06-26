#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;
using TheBonwater.Rebuild;

namespace TheBonwater.Rebuild.Editor {
    public static class MonsterSpawnScalingTest {
        
        [MenuItem("Tools/Rebuild/Tests/Run Monster Spawn Scaling Test")]
        public static void Run() {
            var report = new StringBuilder();
            report.AppendLine("# Monster Spawn Scaling Hotfix Test Report");
            report.AppendLine();
            
            int passCount = 0;
            int failCount = 0;
            
            void AssertTest(string testName, bool condition, string detail) {
                if (condition) {
                    passCount++;
                    report.AppendLine($"- [PASS] **{testName}**: {detail}");
                    UnityEngine.Debug.Log($"[PASS] {testName}: {detail}");
                } else {
                    failCount++;
                    report.AppendLine($"- [FAIL] **{testName}**: {detail}");
                    UnityEngine.Debug.LogError($"[FAIL] {testName}: {detail}");
                }
            }

            // Setup default mock spawn points for A-G
            void ResetMockPoints() {
                SpawnPointProvider.SetMockPoints(new List<SpawnPointProvider.SpawnPoint> {
                    new SpawnPointProvider.SpawnPoint { name = "EnemySpawn_Basic_01", position = new Vector2(-500f, -150f), enemyType = "Basic" },
                    new SpawnPointProvider.SpawnPoint { name = "EnemySpawn_Fast_01", position = new Vector2(-600f, 0f), enemyType = "Fast" },
                    new SpawnPointProvider.SpawnPoint { name = "EnemySpawn_Tank_01", position = new Vector2(500f, -150f), enemyType = "Tank" },
                    new SpawnPointProvider.SpawnPoint { name = "RaidSpawn_Left", position = new Vector2(-650f, 120f), enemyType = "" },
                    new SpawnPointProvider.SpawnPoint { name = "RaidSpawn_Right", position = new Vector2(650f, 120f), enemyType = "" }
                });
            }

            // Helper to capture debug logs
            List<string> RunWithLogCapture(System.Action action) {
                var captured = new List<string>();
                Application.LogCallback onLog = (logString, stackTrace, type) => {
                    captured.Add(logString);
                };
                Application.logMessageReceived += onLog;
                try {
                    action();
                } finally {
                    Application.logMessageReceived -= onLog;
                }
                return captured;
            }

            // ----------------------------------------------------
            // TEST A: Early Day (Day 1)
            // ----------------------------------------------------
            ResetMockPoints();
            var backendA = new LocalGameBackend();
            var snapA = backendA.GetSnapshot();
            snapA.day = 1;
            snapA.enemies.Clear();
            
            var logsA = RunWithLogCapture(() => {
                backendA.Execute(new ForceRaidCommand());
            });

            bool testAPass = snapA.enemies.Count == 1 && 
                             snapA.enemies[0].typeId == "SmallMonster" && 
                             logsA.Any(l => l.Contains("[Monster Spawn Audit] day=1 targetCount=1 activeBefore=0 activeAfter=1")) &&
                             logsA.Any(l => l.Contains("[Monster Spawn Audit] allowedTypes=SmallMonster")) &&
                             logsA.Any(l => l.Contains("[Monster Spawn Audit] spawned type=SmallMonster"));
            AssertTest("Test A — Early day (Day 1)", testAPass, $"TargetCount=1, ActiveBefore=0, ActiveAfter={snapA.enemies.Count}, type={snapA.enemies.FirstOrDefault()?.typeId}");

            // ----------------------------------------------------
            // TEST B: Day 9
            // ----------------------------------------------------
            ResetMockPoints();
            var backendB = new LocalGameBackend();
            var snapB = backendB.GetSnapshot();
            snapB.day = 9;
            snapB.enemies.Clear();

            var logsB = RunWithLogCapture(() => {
                backendB.Execute(new ForceRaidCommand());
            });

            bool testBPass = snapB.enemies.Count == 1 && 
                             snapB.enemies[0].typeId == "SmallMonster" && 
                             logsB.Any(l => l.Contains("[Monster Spawn Audit] day=9 targetCount=1 activeBefore=0 activeAfter=1")) &&
                             logsB.Any(l => l.Contains("[Monster Spawn Audit] allowedTypes=SmallMonster"));
            AssertTest("Test B — Day 9", testBPass, $"TargetCount=1, ActiveBefore=0, ActiveAfter={snapB.enemies.Count}, type={snapB.enemies.FirstOrDefault()?.typeId}");

            // ----------------------------------------------------
            // TEST C: Day 10
            // ----------------------------------------------------
            ResetMockPoints();
            var backendC = new LocalGameBackend();
            var snapC = backendC.GetSnapshot();
            snapC.day = 10;
            snapC.enemies.Clear();

            var logsC = RunWithLogCapture(() => {
                backendC.Execute(new ForceRaidCommand());
            });

            var allowedPool = new HashSet<string> { "SmallMonster", "Basic", "Fast", "Tank" };
            bool allTypesAllowedC = snapC.enemies.All(e => allowedPool.Contains(e.typeId));
            bool testCPass = snapC.enemies.Count == 2 && 
                             allTypesAllowedC && 
                             logsC.Any(l => l.Contains("[Monster Spawn Audit] day=10 targetCount=2 activeBefore=0 activeAfter=2")) &&
                             logsC.Any(l => l.Contains("[Monster Spawn Audit] allowedTypes=SmallMonster,Basic,Fast,Tank"));
            AssertTest("Test C — Day 10", testCPass, $"TargetCount=2, ActiveBefore=0, ActiveAfter={snapC.enemies.Count}, Types={string.Join(",", snapC.enemies.Select(e => e.typeId))}");

            // ----------------------------------------------------
            // TEST D: Day 20
            // ----------------------------------------------------
            ResetMockPoints();
            var backendD = new LocalGameBackend();
            var snapD = backendD.GetSnapshot();
            snapD.day = 20;
            snapD.enemies.Clear();

            var logsD = RunWithLogCapture(() => {
                backendD.Execute(new ForceRaidCommand());
            });

            bool allTypesAllowedD = snapD.enemies.All(e => allowedPool.Contains(e.typeId));
            bool testDPass = snapD.enemies.Count == 3 && 
                             allTypesAllowedD && 
                             logsD.Any(l => l.Contains("[Monster Spawn Audit] day=20 targetCount=3 activeBefore=0 activeAfter=3"));
            AssertTest("Test D — Day 20", testDPass, $"TargetCount=3, ActiveBefore=0, ActiveAfter={snapD.enemies.Count}");

            // ----------------------------------------------------
            // TEST E: Day 30
            // ----------------------------------------------------
            ResetMockPoints();
            var backendE = new LocalGameBackend();
            var snapE = backendE.GetSnapshot();
            snapE.day = 30;
            snapE.enemies.Clear();

            var logsE = RunWithLogCapture(() => {
                backendE.Execute(new ForceRaidCommand());
            });

            bool allTypesAllowedE = snapE.enemies.All(e => allowedPool.Contains(e.typeId));
            bool testEPass = snapE.enemies.Count == 4 && 
                             allTypesAllowedE && 
                             logsE.Any(l => l.Contains("[Monster Spawn Audit] day=30 targetCount=4 activeBefore=0 activeAfter=4"));
            AssertTest("Test E — Day 30", testEPass, $"TargetCount=4, ActiveBefore=0, ActiveAfter={snapE.enemies.Count}");

            // ----------------------------------------------------
            // TEST F: High Day Cap (Day 100)
            // ----------------------------------------------------
            ResetMockPoints();
            var backendF = new LocalGameBackend();
            var snapF = backendF.GetSnapshot();
            snapF.day = 100;
            snapF.enemies.Clear();

            var logsF = RunWithLogCapture(() => {
                backendF.Execute(new ForceRaidCommand());
            });

            bool testFPass = snapF.enemies.Count == 4 && 
                             logsF.Any(l => l.Contains("[Monster Spawn Audit] day=100 targetCount=4 activeBefore=0 activeAfter=4"));
            AssertTest("Test F — High day cap (Day 100)", testFPass, $"TargetCount=4, ActiveBefore=0, ActiveAfter={snapF.enemies.Count} (No unlimited scaling)");

            // ----------------------------------------------------
            // TEST G: Active Monster Cap
            // ----------------------------------------------------
            ResetMockPoints();
            var backendG = new LocalGameBackend();
            var snapG = backendG.GetSnapshot();
            snapG.day = 30; // target is 4
            snapG.enemies.Clear();
            
            // Add 4 active monsters beforehand
            for (int i = 0; i < 4; i++) {
                snapG.enemies.Add(new EnemyState {
                    id = $"pre_e_{i}",
                    typeId = "Basic",
                    hp = 10,
                    status = "Active",
                    removePending = false
                });
            }

            var logsG = RunWithLogCapture(() => {
                backendG.Execute(new ForceRaidCommand());
            });

            // Total should remain 4, no new spawns, log should say skipped reason=active_monster_cap
            bool testGPass = snapG.enemies.Count == 4 && 
                             logsG.Any(l => l.Contains("[Monster Spawn Audit] day=30 targetCount=4 activeBefore=4 activeAfter=4")) &&
                             logsG.Any(l => l.Contains("[Monster Spawn Audit] skipped reason=active_monster_cap"));
            AssertTest("Test G — Active monster cap", testGPass, $"Total enemies={snapG.enemies.Count}, Log contains skipped reason=active_monster_cap: {logsG.Any(l => l.Contains("skipped reason=active_monster_cap"))}");

            // ----------------------------------------------------
            // TEST H: Spawn Point Validation
            // ----------------------------------------------------
            // 1. Missing spawn point cap skip
            var backendH1 = new LocalGameBackend();
            var snapH1 = backendH1.GetSnapshot();
            snapH1.day = 10; // Target count is 2
            snapH1.enemies.Clear();

            // Set mock points to only 1 point
            SpawnPointProvider.SetMockPoints(new List<SpawnPointProvider.SpawnPoint> {
                new SpawnPointProvider.SpawnPoint { name = "EnemySpawn_Basic_01", position = new Vector2(-500f, -150f), enemyType = "Basic" }
            });

            var logsH1 = RunWithLogCapture(() => {
                backendH1.Execute(new ForceRaidCommand());
            });

            bool missingPointsLogged = logsH1.Any(l => l.Contains("[Monster Spawn Audit] skipped reason=no_valid_spawn_point"));
            bool spawnedOnlyOne = snapH1.enemies.Count == 1;

            // 2. No stacking if enough points exist
            ResetMockPoints();
            var backendH2 = new LocalGameBackend();
            var snapH2 = backendH2.GetSnapshot();
            snapH2.day = 30; // Target count is 4
            snapH2.enemies.Clear();

            backendH2.Execute(new ForceRaidCommand());
            var spawnedPositions = snapH2.enemies.Select(e => new Vector2(e.x, e.y)).ToList();
            bool positionsUnique = spawnedPositions.Distinct().Count() == spawnedPositions.Count;

            bool testHPass = missingPointsLogged && spawnedOnlyOne && positionsUnique;
            AssertTest("Test H — Spawn point validation", testHPass, $"Skipped reason logged={missingPointsLogged}, SpawnedOnlyOne={spawnedOnlyOne}, PositionsUnique={positionsUnique}");

            // Clean up
            SpawnPointProvider.ClearMockPoints();

            report.AppendLine();
            report.AppendLine($"**Total Pass**: {passCount}");
            report.AppendLine($"**Total Fail**: {failCount}");
            
            string path = "Assets/_Project/Docs/MonsterSpawnScalingTestReport.md";
            File.WriteAllText(path, report.ToString());
            UnityEngine.Debug.Log($"Monster Spawn Scaling Test run completed. Report written to {path}");
        }
    }
}
#endif
