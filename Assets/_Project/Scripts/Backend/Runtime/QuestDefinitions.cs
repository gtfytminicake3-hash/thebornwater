using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class QuestDefinition {
        public string id;
        public string title;
        public string display;
        public System.Func<GameSnapshot, bool> isComplete;
        public System.Action<GameSnapshot> reward;
    }

    public static class QuestDefinitions {
        public static readonly List<QuestDefinition> Quests = new List<QuestDefinition> {
            new QuestDefinition {
                id = "quest_gather_wood_80",
                title = "Gathering Footing",
                display = "Gather 80 Wood",
                isComplete = snap => snap.wood >= 80,
                reward = snap => {
                    // Small food reward to help early game balance
                    snap.food = System.Math.Min(snap.foodCapacity, snap.food + 20);
                }
            },
            new QuestDefinition {
                id = "quest_build_hut_1",
                title = "Build Shelter",
                display = "Build 1 Hut",
                isComplete = snap => GetBuildingCount(snap, "hut") >= 1,
                reward = null
            },
            new QuestDefinition {
                id = "quest_assign_woodcutter_1",
                title = "Work Assignment",
                display = "Assign 1 Woodcutter",
                isComplete = snap => snap.villagers.Any(v => v.hp > 0 && string.Equals(v.job, "Woodcutter", System.StringComparison.OrdinalIgnoreCase)),
                reward = null
            },
            new QuestDefinition {
                id = "quest_discover_location_1",
                title = "Beyond the Camp",
                display = "Discover 1 World Map location",
                isComplete = snap => snap.worldMapState != null && snap.worldMapState.locations != null && snap.worldMapState.locations.Count(l => l.isDiscovered) >= 2,
                reward = null
            },
            new QuestDefinition {
                id = "quest_complete_expedition_1",
                title = "First Expedition",
                display = "Complete 1 Expedition",
                isComplete = snap => snap.questState.completedExpeditionCountForQuest >= 1,
                reward = null
            },
            new QuestDefinition {
                id = "quest_complete_trade_1",
                title = "First Trade",
                display = "Complete 1 Trade with Merchant",
                isComplete = snap => snap.questState.completedTradeCountForQuest >= 1,
                reward = null
            }
        };

        private static int GetBuildingCount(GameSnapshot snap, string rawId) {
            if (snap == null || snap.buildings == null) return 0;
            string normId = LocalGameBackend.NormalizeBuildingId(rawId);
            return snap.buildings.FirstOrDefault(b => LocalGameBackend.NormalizeBuildingId(b.id) == normId)?.count ?? 0;
        }
    }
}
