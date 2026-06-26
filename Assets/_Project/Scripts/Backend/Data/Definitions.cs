using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild.Data
{
    [Serializable]
    public class DefinitionBase {
        public string id;
        public string displayName;
        public string assetKey;
        public string animationKey;
        public string status;
        public List<string> sourceEvidence = new List<string>();
        
        // Legacy fields for backward compat during transition
        public string source;
        public string confidence;
        public string fidelity;
        public string symbolEvidence;
        public string behaviorEvidence;
        public string balanceEvidence;
    }

    [Serializable]
    public class ResourceDefinition : DefinitionBase {
        public int initialAmount;
        public int capacity;
    }

    [Serializable]
    public class JobDefinition : DefinitionBase {
        public string productionResourceId;
        public int productionPerPhase;
        public int constructionProgressPerPhase;
        public int defense;
    }

    [Serializable]
    public class BuildingCost {
        public string resourceId;
        public int amount;
    }

    [Serializable]
    public class BuildingDefinition : DefinitionBase {
        public Dictionary<string, int> costs = new Dictionary<string, int>();
        public int constructionRequired;
        public string constructionAssetKey;
        public int housingBonus;
        public int capacityBonus;
        public int defense;
        public bool countsForObjective;
    }

    [Serializable]
    public class EnemyDefinition : DefinitionBase {
        public int hp;
        public int attack;
        public float raidWeight;
    }

    [Serializable]
    public class EquipmentDefinition : DefinitionBase {
        public string category; // Tool, Weapon, Armor
        public string slot; // Tool, Weapon, Armor
        public int attackBonus;
        public int defenseBonus;
        public int jobBonus;
        public Dictionary<string, int> costs = new Dictionary<string, int>();
        public string requiredBuilding;
        public string visualAssetKey;
    }

    [Serializable]
    public class BalanceDefinition {
        public int foodConsumptionPerVillagerPerDay;
        public int starvationHpDamagePerDay;
        public float raidChanceAtNight;
        public int woodPenaltyOnUnblockedRaid;
        public int objectiveSurviveDay;
        public int objectiveRequiredHuts;
    }

    [Serializable]
    public class ObjectiveDefinition : DefinitionBase {
        public int targetDay;
        public int targetHutCount;
    }

    [Serializable]
    public class AssetMapDefinition {
        public Dictionary<string, string> assets = new Dictionary<string, string>();
    }
    
    [Serializable]
    public class AnimationMapDefinition {
        public Dictionary<string, string> animations = new Dictionary<string, string>();
    }

    [Serializable]
    public class BuildMenuDefinition {
        public List<BuildMenuItem> menuItems = new List<BuildMenuItem>();
    }
    
    [Serializable]
    public class BuildMenuItem {
        public string id;
        public string iconAssetId;
        public string buildingId;
        public string status;
    }

    [Serializable]
    public class WorldObjectListDefinition {
        public List<WorldObjectDefinition> objects = new List<WorldObjectDefinition>();
    }

    [Serializable]
    public class WorldObjectDefinition : DefinitionBase {
    }

    [Serializable]
    public class TownVisualLayoutDefinition {
        public List<VisualLayoutNode> placements = new List<VisualLayoutNode>();
        public List<VisualLayoutObject> objects = new List<VisualLayoutObject>();
    }

    [Serializable]
    public class VisualLayoutObject {
        public string id;
        public string role;
        public string asset;
        public float x, y, width, height;
        public int layer;
        public bool preserveAspect;
        public bool fillScreen;
        public bool anchorBottom;
        public bool tile;
    }

    [Serializable]
    public class VisualLayoutNode {
        public string id; // Matches registry key, e.g. building:bonfire:0
        public float x;
        public float y;
        public float scale = 1f;
    }

    [Serializable]
    public class WorldMapLocationDefinition {
        public string id;
        public string displayName;
        public string type;
        public int x;
        public int y;
        public string spritePath;
        public bool discoveredAtStart;
        public bool isMajorLocation;
        public int dangerLevel;
        public string rewardType;
        public int rewardAmount;
        public string unlockRequirement;
        public string notes;
    }
}
