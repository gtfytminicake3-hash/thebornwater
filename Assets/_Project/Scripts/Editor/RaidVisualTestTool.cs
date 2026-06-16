using UnityEngine;
using UnityEditor;
using TheBonwater.Rebuild.Data;
using System.Linq;

namespace TheBonwater.Rebuild.Editor.Tests {
    public class RaidVisualTestTool {
        [MenuItem("Tools/TheBonwater/Test Tools/Trigger Raid Visual Test")]
        public static void TriggerRaidTest() {
            var backend = GameServiceLocator.Backend as LocalGameBackend;
            if (backend == null) {
                Debug.LogError("[RAID_VISUAL_TEST] LocalGameBackend not found. Please enter Play Mode first.");
                return;
            }

            Debug.Log("[RAID_VISUAL_TEST] triggered");
            
            // Force create a monster without changing the phase
            var state = backend.GetSnapshot();
            
            EnemyState enemy = new EnemyState { 
                id = "test_raid_" + Time.frameCount, 
                typeId = "SmallMonster", 
                displayName = "Test Monster", 
                hp = 30, 
                attack = 15, 
                status = "Active", 
                spawnPhase = state.day, 
                clearAtNextPhase = true, 
                removePending = false 
            };
            
            state.enemies.Add(enemy);
            
            // Log exactly what user wants
            Debug.Log($"[MONSTER_VISUAL_SPAWN] id={enemy.id} type={enemy.typeId} status={enemy.status}");
            
            // Force Visuals to refresh by broadcasting state change
            var visualCtrl = GameObject.FindObjectOfType<TownRuntimeVisualController>();
            if (visualCtrl != null) {
                visualCtrl.HandleStateChanged(state);
            } else {
                Debug.LogWarning("[RAID_VISUAL_TEST] TownRuntimeVisualController not found in scene.");
            }
        }
    }
}
