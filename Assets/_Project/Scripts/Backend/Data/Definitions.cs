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
    }

    [Serializable]
    public class VisualLayoutNode {
        public string id; // Matches registry key, e.g. building:bonfire:0
        public float x;
        public float y;
        public float scale = 1f;
    }
}
