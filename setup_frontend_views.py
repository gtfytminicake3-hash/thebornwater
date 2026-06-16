import os
import re

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project"

def write_csharp(path, content):
    full_path = os.path.join(base_dir, path)
    os.makedirs(os.path.dirname(full_path), exist_ok=True)
    with open(full_path, "w", encoding="utf-8") as f:
        f.write(content.strip() + "\n")

# 1. Update IGameBackend & LocalGameBackend to expose repo
backend_interface_path = os.path.join(base_dir, r"Scripts\Contracts\IGameBackend.cs")
if os.path.exists(backend_interface_path):
    with open(backend_interface_path, "r", encoding="utf-8") as f:
        code = f.read()
    if "TheBonwater.Rebuild.Data.DataRepository repo" not in code:
        code = code.replace("GameSnapshot GetSnapshot();", "GameSnapshot GetSnapshot();\n        TheBonwater.Rebuild.Data.DataRepository repo { get; }")
        with open(backend_interface_path, "w", encoding="utf-8") as f:
            f.write(code)

local_backend_path = os.path.join(base_dir, r"Scripts\Backend\Runtime\LocalGameBackend.cs")
with open(local_backend_path, "r", encoding="utf-8") as f:
    local_backend_code = f.read()
local_backend_code = local_backend_code.replace("private Data.DataRepository repo;", "public Data.DataRepository repo { get; private set; }")
with open(local_backend_path, "w", encoding="utf-8") as f:
    f.write(local_backend_code)

# 2. Create DefinitionDisplayService
service_csharp = """
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
            return $"Survive to Day {bal.objectiveSurviveDay}\\nBuild Huts: {{0}} / {bal.objectiveRequiredHuts}\\nKeep villagers alive";
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Runtime\DefinitionDisplayService.cs", service_csharp)

# 3. Update BuildMenuView
build_menu_csharp = """
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class BuildMenuView : MonoBehaviour {
        public Text txtHut, txtStorage, txtGuardTower;

        public void Refresh() {
            if (txtHut != null) txtHut.text = $"BUILD HUT {DefinitionDisplayService.FormatBuildingCost("Hut")}";
            if (txtStorage != null) txtStorage.text = $"BUILD STORAGE {DefinitionDisplayService.FormatBuildingCost("Storage")}";
            if (txtGuardTower != null) txtGuardTower.text = $"BUILD GUARD TOWER {DefinitionDisplayService.FormatBuildingCost("GuardTower")}";
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\BuildMenuView.cs", build_menu_csharp)

# 4. Update ResourceBarView
res_bar_csharp = """
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class ResourceBarView : MonoBehaviour {
        public Text txtTime;
        public Text txtWood;
        public Text txtFood;
        public Text txtIron;

        public void UpdateState(GameSnapshot snap) {
            if (snap == null) return;
            if (txtTime != null) txtTime.text = $"DAY {snap.day} - {snap.timeOfDay.ToUpper()}";
            
            string wName = DefinitionDisplayService.GetResourceName("wood").ToUpper();
            string fName = DefinitionDisplayService.GetResourceName("food").ToUpper();
            string iName = DefinitionDisplayService.GetResourceName("iron").ToUpper();

            if (txtWood != null) txtWood.text = $"{wName}: {snap.wood} / {snap.woodCapacity}";
            if (txtFood != null) txtFood.text = $"{fName}: {snap.food} / {snap.foodCapacity}";
            if (txtIron != null) txtIron.text = $"{iName}: {snap.iron} / {snap.ironCapacity}";
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\ResourceBarView.cs", res_bar_csharp)

# 5. Update VillagerListView
vil_list_csharp = """
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class VillagerListView : MonoBehaviour {
        public Text content;

        public void UpdateState(GameSnapshot snap) {
            if (content == null || snap == null) return;
            string text = "VILLAGERS\\n";
            foreach(var v in snap.villagers) {
                string status = v.hp <= 0 ? "DEAD" : $"HP {v.hp}";
                string effect = DefinitionDisplayService.FormatJobEffect(v.job);
                if (v.hp <= 0) effect = "";
                text += $"- {v.name} - {v.job} - {status} - {effect}\\n";
            }
            content.text = text;
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\VillagerListView.cs", vil_list_csharp)

# 6. Update BuildingListView
bld_list_csharp = """
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class BuildingListView : MonoBehaviour {
        public Text content;

        public void UpdateState(GameSnapshot snap) {
            if (content == null || snap == null) return;
            string text = "BUILDINGS\\n";
            foreach(var b in snap.buildings) {
                string name = DefinitionDisplayService.GetBuildingName(b.id);
                text += $"- {name} x{b.count}\\n";
            }
            foreach(var t in snap.tasks) {
                string bName = t.type.Replace("Build", "");
                bName = DefinitionDisplayService.GetBuildingName(bName);
                text += $"- {bName} under construction: {t.progress}%\\n";
            }
            content.text = text;
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\BuildingListView.cs", bld_list_csharp)

# 7. Update ObjectiveView
obj_csharp = """
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class ObjectiveView : MonoBehaviour {
        public Text content;

        public void UpdateState(GameSnapshot snap) {
            if (content == null || snap == null) return;
            if (snap.isGameOver) {
                content.text = "GAME OVER\\nAll villagers died.";
                content.color = Color.red;
                return;
            }
            if (snap.isObjectiveComplete) {
                content.text = "OBJECTIVE COMPLETE\\nVillage survived and built huts.";
                content.color = Color.green;
                return;
            }
            content.color = Color.white;
            string format = DefinitionDisplayService.GetObjectiveText();
            int hutCount = snap.buildings.Find(b => b.id == "Hut")?.count ?? 0;
            content.text = "OBJECTIVE\\n" + string.Format(format, hutCount) + "\\nStatus: IN PROGRESS";
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\ObjectiveView.cs", obj_csharp)

# 8. Update TaskLogView (EventLog)
log_csharp = """
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class TaskLogView : MonoBehaviour {
        public Text content;

        public void UpdateState(GameSnapshot snap) {
            if (content == null || snap == null) return;
            string text = "EVENT LOG\\n";
            foreach(var msg in snap.taskLogs.Take(8)) {
                text += msg + "\\n";
            }
            content.text = text;
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\TaskLogView.cs", log_csharp)

# 9. Update LastActionView
act_csharp = """
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class LastActionView : MonoBehaviour {
        public Text content;

        public void UpdateState(GameSnapshot snap) {
            if (content == null || snap == null) return;
            content.text = string.IsNullOrEmpty(snap.lastAction) ? "Ready." : snap.lastAction;
        }
    }
}
"""
write_csharp(r"Scripts\Frontend\Views\LastActionView.cs", act_csharp)

print("Updated View Scripts")
