using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    [Serializable]
    public class GameSnapshot {
        public int day = 1;
        public string timeOfDay = "Morning";
        public int wood;
        public int iron;
        public int food;
        public int steel;
        public int woodCapacity = 250;
        public int ironCapacity = 250;
        public int foodCapacity = 100;
        public int steelCapacity = 50;
        public int coal;
        public int coalCapacity = 50;
        public int maxPopulation = 2;
        
        public int selectedVillagerIndex = 0;
        public string selectedVillagerId = "v1";
        public List<VillagerSnapshot> villagers = new List<VillagerSnapshot>();
        public List<BuildingSnapshot> buildings = new List<BuildingSnapshot>();
        public List<EnemyState> enemies = new List<EnemyState>();
        public List<TaskSnapshot> tasks = new List<TaskSnapshot>();
        public List<PlacedObject> userPlacements = new List<PlacedObject>();
        
        public int totalDefense;
        public int consecutiveDaysWithoutFood;
        public bool isGameOver;
        public bool isObjectiveComplete;
        public string gameStatus = "Playing";
        public string objectiveText = "Survive to Day 3 and build 2 Huts";
        public string lastAction = "";
        public List<string> taskLogs = new List<string>();
        public int lastRaidDay = -1;
        public bool isRaidImminentToday = false;
        public ObjectiveState objectiveState = new ObjectiveState();
        public List<EquipmentStack> equipmentStock = new List<EquipmentStack>();
        public WorldMapState worldMapState = new WorldMapState();
        public List<string> pendingExpeditionReports = new List<string>();
        public TradeState tradeState = new TradeState();
        public QuestState questState = new QuestState();
        public TitanState titanState = new TitanState();
    }

    [Serializable]
    public class TitanState {
        public bool isAwakened = false;
        public bool isDefeated = false;
        public bool endgameVictoryAchieved = false;
        public int hp = 500;
        public int maxHp = 500;
        public string lastBattleResult = "";
    }

    [Serializable]
    public class QuestState {
        public string activeQuestId = "";
        public List<string> completedQuestIds = new List<string>();
        public bool tutorialCompleted;
        public List<string> unlockedAchievementIds = new List<string>();
        public List<string> pendingQuestNotifications = new List<string>();
        public List<string> pendingAchievementNotifications = new List<string>();
        public int completedExpeditionCountForQuest;
        public int completedTradeCountForQuest;
    }

    [Serializable]
    public class ObjectiveState {
        public int surviveToDay = 3;
        public int requiredHuts = 2;
        public bool villagersMustStayAlive = true;
        public string status = "IN_PROGRESS"; // "IN_PROGRESS", "COMPLETED", "FAILED"
        public int currentMilestoneIndex = 1;
        public string fidelityLabel = "PROTOTYPE_FALLBACK";
        public string decodedValueSource = "Objective prototype, not original confirmed";
    }

    [Serializable]
    public class PlacedObject {
        public string id;
        public float x;
        public float y;
        public int level = 1;
    }

    [Serializable]
    public class ResourceAmount {
        public string resourceId;
        public int amount;
    }

    [Serializable]
    public class TaskSnapshot {
        public string id;
        public string type;
        public string targetBuildingId;
        public string targetPlacementId = "";
        
        // Construction fields
        public string status; // "AwaitingResources", "UnderConstruction", "Completed"
        public List<ResourceAmount> requiredResources = new List<ResourceAmount>();
        public List<ResourceAmount> depositedResources = new List<ResourceAmount>();
        public bool isResourcesComplete;
        public int currentCompletion;
        public int finalCompletion;
        
        // Evidence classification
        public string fidelityClassification;
        public string finalCompletionEvidence = "UNKNOWN_OR_MISSING";
        public string finalCompletionSource = "UNKNOWN_OR_MISSING";
        public string depositSequenceEvidence = "UNKNOWN_DEPOSIT_SEQUENCE";
    }

    [Serializable]
    public class VillagerSnapshot {
        public string id;
        public string name;
        public string job;
        public int hp = 100;
        public string state = "Idle";
        public string targetId = "";
        public string targetType = "";
        public string weaponId = "";
        public string armorId = "";
        public string toolId = "";
        public bool isOnExpedition;
        public string expeditionId = "";
    }

    [Serializable]
    public class BuildingSnapshot {
        public string id;
        public int count;
    }

    [Serializable]
    public class EnemyState {
        public string id;
        public string typeId;
        public string monsterId;
        public string displayName;
        public int hp;
        public int maxHp;
        public int attack;
        public float x;
        public float y;
        public float nx;
        public float ny;
        public string status;
        public bool removePending;
        public int spawnPhase;
        public bool clearAtNextPhase;
    }

    [Serializable]
    public class EquipmentStack {
        public string equipmentId;
        public int count;
    }

    [Serializable]
    public class WorldMapState {
        public List<WorldMapLocationState> locations = new List<WorldMapLocationState>();
        public List<ExpeditionState> activeExpeditions = new List<ExpeditionState>();
    }

    [Serializable]
    public class WorldMapLocationState {
        public string id;
        public string displayName;
        public string type;
        public int x;
        public int y;
        public string spritePath;
        public bool isDiscovered;
        public bool isMajorLocation;
        public int dangerLevel;
        public string rewardType;
        public int rewardAmount;
        public string unlockRequirement;
        public string notes;
    }

    [Serializable]
    public class ExpeditionState {
        public string id;
        public string targetLocationId;
        public List<string> villagerIds = new List<string>();
        public List<VillagerPreviousJob> previousJobs = new List<VillagerPreviousJob>();
        public int phasesRemaining;
        public string rewardType;
        public int rewardAmount;
        public float injuryChance;
        public string status;
    }

    [Serializable]
    public class VillagerPreviousJob {
        public string villagerId;
        public string jobId;
    }

    [Serializable]
    public class TradeState {
        public bool isMerchantPresent = false;
        public int daysUntilNextMerchant = 2;
        public int merchantDaysRemaining = 0;
    }
}
