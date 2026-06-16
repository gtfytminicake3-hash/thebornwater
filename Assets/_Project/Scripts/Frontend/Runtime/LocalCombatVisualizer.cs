using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class LocalCombatVisualizer : MonoBehaviour {
        public TownRuntimeVisualController visualController;
        public float combatDuration = 2.0f;
        
        private class ActiveCombat {
            public VillagerAgentView guard;
            public WorldObjectView monsterView;
            public HealthBarView monsterHpBar;
            public HealthBarView guardHpBar;
            public float timer;
            public int initialMonsterHp;
            public int targetMonsterHp;
            public int initialGuardHp;
            public int targetGuardHp;
        }

        private List<ActiveCombat> activeCombats = new List<ActiveCombat>();

        private void Start() {
            if (visualController == null) {
                visualController = FindObjectOfType<TownRuntimeVisualController>();
            }
        }

        private void Update() {
            if (visualController == null || visualController.worldRoot == null) return;
            
            var guards = visualController.worldRoot.GetComponentsInChildren<VillagerAgentView>()
                .Where(v => v.currentJob == "Guard" && v.visualState == "Working" && v.targetId.StartsWith("monster:"));

            foreach (var guard in guards) {
                // Check if already in combat
                if (activeCombats.Any(c => c.guard == guard)) continue;

                var monsterId = guard.targetId; // "monster:e_2"
                var rawId = monsterId.Split(':')[1];
                var monsterGo = visualController.worldRoot.GetComponentsInChildren<Transform>(true).FirstOrDefault(t => t.name == monsterId);
                
                if (monsterGo != null) {
                    var monsterHpBar = monsterGo.GetComponentInChildren<HealthBarView>();
                    var guardHpBar = guard.GetComponentInChildren<HealthBarView>();
                    
                    var snap = GameServiceLocator.Backend?.GetSnapshot();
                    var mData = snap?.enemies.Find(e => e.id == rawId);
                    var vData = snap?.villagers.Find(v => v.id == guard.villagerId);

                    int finalEnemyHp = mData != null ? mData.hp : 0;
                    int finalGuardHp = vData != null ? vData.hp : 100;
                    
                    int startEnemyHp = monsterHpBar != null ? monsterHpBar.MaxHp : 20;
                    int startGuardHp = guardHpBar != null ? guardHpBar.MaxHp : 100;
                    
                    activeCombats.Add(new ActiveCombat {
                        guard = guard,
                        monsterView = monsterGo.GetComponent<WorldObjectView>(),
                        monsterHpBar = monsterHpBar,
                        guardHpBar = guardHpBar,
                        timer = 0f,
                        initialMonsterHp = startEnemyHp,
                        targetMonsterHp = finalEnemyHp,
                        initialGuardHp = startGuardHp,
                        targetGuardHp = finalGuardHp
                    });

                    Diagnostics.RuntimeTrace.Log("GUARD_TARGET_ENEMY", $"guard={guard.villagerId} enemy={rawId}");
                }
            }

            for (int i = activeCombats.Count - 1; i >= 0; i--) {
                var combat = activeCombats[i];
                combat.timer += Time.deltaTime;
                float progress = Mathf.Clamp01(combat.timer / combatDuration);

                int currentEnemyHp = Mathf.RoundToInt(Mathf.Lerp(combat.initialMonsterHp, combat.targetMonsterHp, progress));
                int currentGuardHp = Mathf.RoundToInt(Mathf.Lerp(combat.initialGuardHp, combat.targetGuardHp, progress));

                if (combat.monsterHpBar != null) combat.monsterHpBar.UpdateHp(currentEnemyHp);
                if (combat.guardHpBar != null) combat.guardHpBar.UpdateHp(currentGuardHp);

                if (progress >= 1f) {
                    var rawId = combat.monsterView.objectId.Split(':')[1];
                    Diagnostics.RuntimeTrace.Log("GUARD_ENEMY_DEFEATED", $"guard={combat.guard.villagerId} enemy={rawId}");
                    
                    visualController.suppressedEnemyVisualIds.Add(rawId);
                    Diagnostics.RuntimeTrace.Log("ENEMY_VISUAL_SUPPRESSED", $"enemy={rawId}");
                    
                    if (combat.monsterView != null && combat.monsterView.gameObject != null) {
                        Destroy(combat.monsterView.gameObject);
                    }

                    combat.guard.ReturnHome();
                    activeCombats.RemoveAt(i);
                }
            }
        }

        public void ResetAllCombats() {
            activeCombats.Clear();
        }
    }
}
