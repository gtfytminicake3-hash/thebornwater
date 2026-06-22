using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class LocalCombatVisualizer : MonoBehaviour {
        public TownRuntimeVisualController visualController;
        
        public float combatRange = 30f;
        public float attackInterval = 0.8f;
        public float monsterSpeed = 22f;
        public float guardSpeed = 24f;
        public float villagerFleeSpeed = 10f; // Slower than monster
        
        private class ActiveCombat {
            public string enemyId;
            public string targetVillagerId;
            public float monsterAttackTimer;
            public Dictionary<string, float> guardAttackTimers = new Dictionary<string, float>();
            public bool loggedIntercept = false;
            public HashSet<string> loggedReached = new HashSet<string>();
            public HashSet<string> loggedFlee = new HashSet<string>();
        }

        private List<ActiveCombat> activeCombats = new List<ActiveCombat>();
        private Dictionary<string, float> towerGuardAttackTimers = new Dictionary<string, float>();

        private void Start() {
            if (visualController == null) {
                visualController = FindObjectOfType<TownRuntimeVisualController>();
            }
        }

        private void Update() {
            if (visualController == null || visualController.worldRoot == null) return;
            
            var snap = GameServiceLocator.Backend?.GetSnapshot();
            if (snap == null || snap.isGameOver) return;

            var activeEnemies = snap.enemies.Where(e => e.hp > 0 && e.status == "Active" && !e.removePending).ToList();

            foreach (var enemy in activeEnemies) {
                var combat = activeCombats.FirstOrDefault(c => c.enemyId == enemy.id);
                if (combat == null) {
                    combat = new ActiveCombat { enemyId = enemy.id, targetVillagerId = "", monsterAttackTimer = 0f };
                    activeCombats.Add(combat);
                }

                var monsterId = "monster:" + enemy.id;
                var monsterGo = visualController.worldRoot.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == monsterId);
                if (monsterGo == null) continue;

                // Sync visual position back to backend state for target validation
                Vector3 localPos = visualController.worldRoot.InverseTransformPoint(monsterGo.position);
                enemy.x = localPos.x;
                enemy.y = localPos.y;

                // 1. Re-evaluate target every frame to allow Guard hot-swapping
                var allAliveVillagers = snap.villagers.Where(v => v.hp > 0).ToList();
                if (allAliveVillagers.Count == 0) continue;

                var guards = allAliveVillagers.Where(v => v.job == "Guard").ToList();
                var towerGuards = allAliveVillagers.Where(v => v.job == "towerGuard").ToList();
                var nonGuards = allAliveVillagers.Where(v => v.job != "Guard" && v.job != "towerGuard").ToList();
                VillagerSnapshot targetSnap = null;

                if (guards.Count > 0) {
                    if (!combat.loggedIntercept) {
                        UnityEngine.Debug.Log("[Raid] Guards move to intercept.");
                        combat.loggedIntercept = true;
                    }
                    
                    // Pick closest guard as monster target
                    float minDist = float.MaxValue;
                    foreach (var g in guards) {
                        var gId = "villager:" + g.id;
                        var gGo = visualController.worldRoot.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == gId);
                        if (gGo != null) {
                            float d = Vector2.Distance(monsterGo.position, gGo.position);
                            if (d < minDist) { minDist = d; targetSnap = g; }
                        }
                    }
                    if (targetSnap == null) targetSnap = guards[0];
                } else {
                    // No melee guards available. Monster targets closest nonGuard.
                    float minNonGuardDist = float.MaxValue;
                    foreach (var ng in nonGuards) {
                        var ngId = "villager:" + ng.id;
                        var ngGo = visualController.worldRoot.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == ngId);
                        if (ngGo != null) {
                            // Non-guards flee
                            Vector3 fleeDirection = (ngGo.position - monsterGo.position).normalized;
                            if (fleeDirection.sqrMagnitude < 0.001f) {
                                fleeDirection = new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f), 0).normalized;
                            }
                            ngGo.position += fleeDirection * Time.deltaTime * villagerFleeSpeed;

                            // Clamp to playable area to avoid flying to infinity
                            float clampedX = Mathf.Clamp(ngGo.position.x, -1400f, 1400f);
                            float clampedY = Mathf.Clamp(ngGo.position.y, -900f, 900f);
                            ngGo.position = new Vector3(clampedX, clampedY, ngGo.position.z);

                            float d = Vector2.Distance(monsterGo.position, ngGo.position);
                            if (d < minNonGuardDist) {
                                minNonGuardDist = d;
                                targetSnap = ng;
                            }
                        }
                    }
                    
                    if (targetSnap == null) {
                        // If no nonGuards either, maybe target tower guards?
                        if (towerGuards.Count > 0) targetSnap = towerGuards[0];
                        else if (nonGuards.Count > 0) targetSnap = nonGuards[0];
                    }

                    if (targetSnap != null) {
                        if (combat.targetVillagerId != targetSnap.id) {
                            UnityEngine.Debug.Log($"[RaidAI] Monster retargeted nearest villager {targetSnap.id}.");
                            UnityEngine.Debug.Log($"[RaidAI] nonGuardFleeCount={nonGuards.Count} guardCount={guards.Count} monsterTarget={targetSnap.id} dist={minNonGuardDist}");
                            combat.targetVillagerId = targetSnap.id;
                        }
                    }
                }

                if (targetSnap == null) continue;
                
                var victimId = "villager:" + targetSnap.id;
                var victimGo = visualController.worldRoot.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == victimId);
                if (victimGo != null) {
                    float distToTarget = Vector2.Distance(monsterGo.position, victimGo.position);
                    if (distToTarget > combatRange) {
                        // Monster moves towards target
                        float speed = monsterSpeed;
                        if (string.Equals(enemy.monsterId, "Fast", System.StringComparison.OrdinalIgnoreCase)) speed = 32f;
                        else if (string.Equals(enemy.monsterId, "Tank", System.StringComparison.OrdinalIgnoreCase)) speed = 14f;
                        monsterGo.position = Vector3.MoveTowards(monsterGo.position, victimGo.position, Time.deltaTime * speed);
                    } else {
                        // Monster attacks target
                        combat.monsterAttackTimer += Time.deltaTime;
                        if (combat.monsterAttackTimer >= attackInterval) {
                            combat.monsterAttackTimer = 0f;
                            var hitCmd = new ResolveRaidCombatHitCommand {
                                enemyId = enemy.id,
                                targetVillagerId = targetSnap.id,
                                guardVillagerId = ""
                            };
                            TownInteractionController.Instance.ExecuteCommand(hitCmd);
                        }
                    }
                }

                // 2. All guards move towards and attack monster
                if (guards.Count > 0) {
                    Vector3[] offsets = new Vector3[] {
                        new Vector3(-15, 0, 0),
                        new Vector3(15, 0, 0),
                        new Vector3(0, 15, 0),
                        new Vector3(0, -15, 0),
                        new Vector3(-10, 10, 0),
                        new Vector3(10, 10, 0)
                    };

                    for (int i = 0; i < guards.Count; i++) {
                        var guard = guards[i];
                        if (!combat.guardAttackTimers.ContainsKey(guard.id)) {
                            combat.guardAttackTimers[guard.id] = 0f;
                        }

                        var guardGoId = "villager:" + guard.id;
                        var guardGo = visualController.worldRoot.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == guardGoId);
                        if (guardGo == null) continue;

                        Vector3 offset = offsets[i % offsets.Length];
                        Vector3 targetPos = monsterGo.position + offset;
                        
                        float distToMonster = Vector2.Distance(guardGo.position, monsterGo.position);
                        
                        if (distToMonster > combatRange) {
                            guardGo.position = Vector3.MoveTowards(guardGo.position, targetPos, Time.deltaTime * guardSpeed);
                        } else {
                            if (!combat.loggedReached.Contains(guard.id)) {
                                UnityEngine.Debug.Log($"[Raid] Guard {guard.id} reached monster.");
                                combat.loggedReached.Add(guard.id);
                            }

                            combat.guardAttackTimers[guard.id] += Time.deltaTime;
                            if (combat.guardAttackTimers[guard.id] >= attackInterval) {
                                combat.guardAttackTimers[guard.id] = 0f;
                                var hitCmd = new ResolveRaidCombatHitCommand {
                                    enemyId = enemy.id,
                                    targetVillagerId = "",
                                    guardVillagerId = guard.id
                                };
                                TownInteractionController.Instance.ExecuteCommand(hitCmd);
                            }
                        }
                    }
                }

            }

            // 3. TowerGuards attack the nearest active enemy from afar without moving
            if (activeEnemies.Count > 0) {
                var towerGuards = snap.villagers.Where(v => v.hp > 0 && v.job == "towerGuard").ToList();
                if (towerGuards.Count > 0) {
                    // Find the guard tower position for distance calculations
                    Vector2 towerPos = Vector2.zero;
                    var towerPlacement = snap.userPlacements.FirstOrDefault(p => p.id.StartsWith("building:guardTower:", System.StringComparison.OrdinalIgnoreCase));
                    if (towerPlacement != null) {
                        towerPos = new Vector2(towerPlacement.x, towerPlacement.y);
                    } else {
                        var constrPlacement = snap.userPlacements.FirstOrDefault(p => p.id.StartsWith("construction:guardTower:", System.StringComparison.OrdinalIgnoreCase));
                        if (constrPlacement != null) {
                            towerPos = new Vector2(constrPlacement.x, constrPlacement.y);
                        }
                    }

                    // Find nearest active enemy
                    EnemyState nearestEnemy = null;
                    float minDist = float.MaxValue;
                    foreach (var enemy in activeEnemies) {
                        float d = Vector2.Distance(towerPos, new Vector2(enemy.x, enemy.y));
                        if (d < minDist) {
                            minDist = d;
                            nearestEnemy = enemy;
                        }
                    }

                    if (nearestEnemy != null) {
                        foreach (var tg in towerGuards) {
                            if (!towerGuardAttackTimers.ContainsKey(tg.id)) {
                                towerGuardAttackTimers[tg.id] = 0f;
                            }
                            
                            towerGuardAttackTimers[tg.id] += Time.deltaTime;
                            if (towerGuardAttackTimers[tg.id] >= attackInterval) {
                                towerGuardAttackTimers[tg.id] = 0f;
                                var hitCmd = new ResolveRaidCombatHitCommand {
                                    enemyId = nearestEnemy.id,
                                    targetVillagerId = "",
                                    guardVillagerId = tg.id
                                };
                                TownInteractionController.Instance.ExecuteCommand(hitCmd);
                            }
                        }
                    }
                }
            }

            // Cleanup dead combats
            activeCombats.RemoveAll(c => !activeEnemies.Any(e => e.id == c.enemyId));
        }

        public void ResetAllCombats() {
            activeCombats.Clear();
        }
    }
}
