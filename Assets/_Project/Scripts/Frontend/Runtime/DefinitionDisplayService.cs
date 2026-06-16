using TheBonwater.Rebuild.Data;
using System.Text;

namespace TheBonwater.Rebuild
{
    public static class DefinitionDisplayService
    {
        public static DataRepository Repo => GameServiceLocator.Backend?.repo;

        public static string FormatBuildingCost(string buildingId) {
            if (Repo == null) return "(- COST)";
            var def = Repo.GetBuilding(buildingId);
            if (def == null || def.costs == null || def.costs.Count == 0) return "(FREE)";
            
            StringBuilder sb = new StringBuilder();
            sb.Append("(-");
            bool first = true;
            foreach(var kvp in def.costs) {
                if (!first) sb.Append(", -");
                var resDef = Repo.GetResource(kvp.Key);
                string resName = resDef?.displayName ?? kvp.Key;
                sb.Append($"{kvp.Value} {resName.ToUpper()}");
                first = false;
            }
            sb.Append(")");
            return sb.ToString();
        }

        public static string FormatJobEffect(string jobId) {
            if (Repo == null) return "";
            var def = Repo.GetJob(jobId);
            if (def == null) return "";

            if (def.productionPerPhase > 0) {
                string resName = Repo.GetResource(def.productionResourceId)?.displayName ?? def.productionResourceId;
                return $"+{def.productionPerPhase} {resName}/phase";
            }
            if (def.constructionProgressPerPhase > 0) return $"+{def.constructionProgressPerPhase}% Build/phase";
            if (def.defense > 0) return $"Defense +{def.defense}";
            return "";
        }

        public static string GetResourceName(string resId) => Repo?.GetResource(resId)?.displayName ?? resId;
        public static string GetEnemyName(string enemyId) => Repo?.GetEnemy(enemyId)?.displayName ?? enemyId;
        public static string GetBuildingName(string buildingId) => Repo?.GetBuilding(buildingId)?.displayName ?? buildingId;
        
        public static string GetObjectiveText() {
            if (Repo == null) return "Survive";
            var bal = Repo.Balance;
            if (bal == null) return "Survive";
            return $"Survive to Day {bal.objectiveSurviveDay}\nBuild Huts: {{0}} / {bal.objectiveRequiredHuts}\nKeep villagers alive";
        }
    }
}
