using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    public abstract class GameCommand { }
    public class StartNewGameCommand : GameCommand { }
    public class AdvanceTimeCommand : GameCommand { }
    public class AssignWorkerCommand : GameCommand { }
    public class SaveGameCommand : GameCommand { }
    public class LoadGameCommand : GameCommand { }
    public class CollectWoodCommand : GameCommand { }
    public class BuildHutCommand : GameCommand { public float x; public float y; }
    public class BuildGuardTowerCommand : GameCommand { public float x; public float y; }
    public class BuildStorageCommand : GameCommand { public float x; public float y; }
    public class BuildBlacksmithsForgeCommand : GameCommand { public float x; public float y; }
    public class ForceRaidCommand : GameCommand {}
    public class SelectNextVillagerCommand : GameCommand {}
    public class SpawnVillagerCommand : GameCommand {}
    public class AssignVillagerJobCommand : GameCommand {
        public string villagerId;
        public string jobId;
    }
    public class SelectVillagerCommand : GameCommand {
        public string villagerId;
    }
    public class ResolveRaidCombatHitCommand : GameCommand { 
        public string enemyId; 
        public string guardVillagerId; 
        public string targetVillagerId; 
    }
    [System.Serializable]
    public class CraftEquipmentCommand : GameCommand {
        public string equipmentId;
        public int count = 1;
    }
    [System.Serializable]
    public class EquipVillagerEquipmentCommand : GameCommand {
        public string villagerId;
        public string slot; // Weapon, Armor, Tool
        public string equipmentId; // empty/null means unequip
    }
    [System.Serializable]
    public class UpgradeBuildingCommand : GameCommand {
        public string buildingPlacementId;
    }
    [System.Serializable]
    public class DiscoverWorldMapLocationCommand : GameCommand {
        public string locationId;
    }
    [System.Serializable]
    public class DispatchExpeditionCommand : GameCommand {
        public string targetLocationId;
        public List<string> villagerIds = new List<string>();
    }
    public class DismissExpeditionReportCommand : GameCommand {}
    public class DismissQuestNotificationCommand : GameCommand {}
    public class DismissAchievementNotificationCommand : GameCommand {}
    [System.Serializable]
    public class TradeCommand : GameCommand {
        public string offerId;
    }
    [System.Serializable]
    public class AttackTitanCommand : GameCommand {
        public List<string> attackerVillagerIds = new List<string>();
    }
}

