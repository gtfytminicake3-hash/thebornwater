using System.Collections.Generic;
using System.Linq;

namespace TheBonwater.Rebuild.Backend.Runtime
{
    public static class QuestEvaluator
    {
        public class QuestDefinition
        {
            public string id;
            public string title;
            public string description;
            public bool isTutorial;
            public string nextQuestId;
        }

        public class AchievementDefinition
        {
            public string id;
            public string title;
            public string description;
        }

        public static readonly List<QuestDefinition> Quests = new List<QuestDefinition>
        {
            new QuestDefinition { id = "quest_gather_wood_80", title = "Gather Wood", description = "Gather 80 Wood to start building.", isTutorial = true, nextQuestId = "quest_build_hut_1" },
            new QuestDefinition { id = "quest_build_hut_1", title = "Build a Hut", description = "Build 1 Hut to provide shelter.", isTutorial = true, nextQuestId = "quest_assign_woodcutter_1" },
            new QuestDefinition { id = "quest_assign_woodcutter_1", title = "Assign Woodcutter", description = "Assign 1 Villager to be a Woodcutter.", isTutorial = true, nextQuestId = "quest_discover_location_1" },
            new QuestDefinition { id = "quest_discover_location_1", title = "Discover Location", description = "Discover 1 World Map location.", isTutorial = true, nextQuestId = "quest_complete_expedition_1" },
            new QuestDefinition { id = "quest_complete_expedition_1", title = "Complete Expedition", description = "Complete 1 Expedition.", isTutorial = true, nextQuestId = "quest_complete_trade_1" },
            new QuestDefinition { id = "quest_complete_trade_1", title = "Complete Trade", description = "Complete 1 Trade with Merchant.", isTutorial = true, nextQuestId = "" }
        };

        public static readonly List<AchievementDefinition> Achievements = new List<AchievementDefinition>
        {
            new AchievementDefinition { id = "achievement_first_hut", title = "First Shelter", description = "Built the first hut." },
            new AchievementDefinition { id = "achievement_first_expedition", title = "Explorer", description = "Completed the first expedition." },
            new AchievementDefinition { id = "achievement_first_trade", title = "Trader", description = "Completed the first trade." },
            new AchievementDefinition { id = "achievement_survived_week", title = "One Week Survivor", description = "Survived for 7 days." }
            // achievement_first_raid_survived is DEFERRED — lastRaidDay is set at raid start, not after surviving.
        };

        public static void Evaluate(GameSnapshot state)
        {
            if (state == null || state.questState == null) return;
            var qs = state.questState;

            // Initialize if empty and not completed
            if (string.IsNullOrEmpty(qs.activeQuestId) && !qs.tutorialCompleted && qs.completedQuestIds.Count == 0)
            {
                qs.activeQuestId = "quest_gather_wood_80";
            }

            // Evaluate Active Quest
            if (!string.IsNullOrEmpty(qs.activeQuestId))
            {
                var q = Quests.FirstOrDefault(x => x.id == qs.activeQuestId);
                if (q != null && IsQuestComplete(q.id, state))
                {
                    CompleteQuest(qs, q);
                }
            }

            // Evaluate Achievements
            EvaluateAchievements(state);
        }

        private static bool IsQuestComplete(string questId, GameSnapshot state)
        {
            switch (questId)
            {
                case "quest_gather_wood_80":
                    return state.wood >= 80;
                case "quest_build_hut_1":
                    return state.buildings.Any(b => b.id == "hut" && b.count >= 1);
                case "quest_assign_woodcutter_1":
                    return state.villagers.Any(v => v.hp > 0 && v.job == "Woodcutter");
                case "quest_discover_location_1":
                    // We check if any location other than home is discovered.
                    return state.worldMapState.locations.Any(l => l.isDiscovered && l.id != "home");
                case "quest_complete_expedition_1":
                    return state.questState.completedExpeditionCountForQuest >= 1;
                case "quest_complete_trade_1":
                    return state.questState.completedTradeCountForQuest >= 1;
            }
            return false;
        }

        private static void CompleteQuest(QuestState qs, QuestDefinition q)
        {
            qs.completedQuestIds.Add(q.id);
            qs.pendingQuestNotifications.Add($"Quest Completed: {q.title}");
            qs.activeQuestId = q.nextQuestId;

            if (string.IsNullOrEmpty(qs.activeQuestId))
            {
                qs.tutorialCompleted = true;
                qs.pendingQuestNotifications.Add("Tutorial Completed!");
            }
        }

        private static void EvaluateAchievements(GameSnapshot state)
        {
            var qs = state.questState;

            CheckAndUnlockAchievement(qs, "achievement_first_hut", () => state.buildings.Any(b => b.id == "hut" && b.count >= 1));
            CheckAndUnlockAchievement(qs, "achievement_first_expedition", () => qs.completedExpeditionCountForQuest >= 1);
            CheckAndUnlockAchievement(qs, "achievement_first_trade", () => qs.completedTradeCountForQuest >= 1);
            CheckAndUnlockAchievement(qs, "achievement_survived_week", () => state.day > 7);
            
            // achievement_first_raid_survived is DEFERRED — lastRaidDay is set at raid start,
            // not after surviving. No reliable survivor-only signal exists yet.
        }

        private static void CheckAndUnlockAchievement(QuestState qs, string achievementId, System.Func<bool> condition)
        {
            if (qs.unlockedAchievementIds.Contains(achievementId)) return;

            if (condition())
            {
                qs.unlockedAchievementIds.Add(achievementId);
                var a = Achievements.FirstOrDefault(x => x.id == achievementId);
                if (a != null)
                {
                    qs.pendingAchievementNotifications.Add($"Achievement Unlocked: {a.title}");
                }
            }
        }

        public static string GetQuestProgressText(string questId, GameSnapshot state)
        {
            switch (questId)
            {
                case "quest_gather_wood_80":
                    return $"{System.Math.Min(state.wood, 80)} / 80";
                case "quest_build_hut_1":
                    int hutCount = state.buildings.FirstOrDefault(b => b.id == "hut")?.count ?? 0;
                    return $"{System.Math.Min(hutCount, 1)} / 1";
                case "quest_assign_woodcutter_1":
                    int wcCount = state.villagers.Count(v => v.hp > 0 && v.job == "Woodcutter");
                    return $"{System.Math.Min(wcCount, 1)} / 1";
                case "quest_discover_location_1":
                    int discCount = state.worldMapState.locations.Count(l => l.isDiscovered && l.id != "home");
                    return $"{System.Math.Min(discCount, 1)} / 1";
                case "quest_complete_expedition_1":
                    return $"{System.Math.Min(state.questState.completedExpeditionCountForQuest, 1)} / 1";
                case "quest_complete_trade_1":
                    return $"{System.Math.Min(state.questState.completedTradeCountForQuest, 1)} / 1";
            }
            return "";
        }
    }
}
