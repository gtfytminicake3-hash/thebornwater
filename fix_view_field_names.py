import os

base_dir = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Frontend\Views"

def modify(filename, old_str, new_str):
    path = os.path.join(base_dir, filename)
    with open(path, "r", encoding="utf-8") as f:
        content = f.read()
    with open(path, "w", encoding="utf-8") as f:
        f.write(content.replace(old_str, new_str))

# ResourceBarView
res_bar_path = os.path.join(base_dir, "ResourceBarView.cs")
with open(res_bar_path, "w", encoding="utf-8") as f:
    f.write("""
using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class ResourceBarView : MonoBehaviour {
        public Text txtResources;

        private void Start() { if (TownInteractionController.Instance != null) TownInteractionController.Instance.OnStateChanged += UpdateState; }

        public void UpdateState(GameSnapshot snap) {
            if (snap == null || txtResources == null) return;
            string wName = DefinitionDisplayService.GetResourceName("wood").ToUpper();
            string fName = DefinitionDisplayService.GetResourceName("food").ToUpper();
            string iName = DefinitionDisplayService.GetResourceName("iron").ToUpper();
            
            txtResources.text = $"DAY {snap.day} - {snap.timeOfDay.ToUpper()}\\n{wName}: {snap.wood} / {snap.woodCapacity}    {fName}: {snap.food} / {snap.foodCapacity}    {iName}: {snap.iron} / {snap.ironCapacity}";
        }
    }
}
""".strip() + "\n")

# LastActionView
modify("LastActionView.cs", "public Text content;", "public Text txtLastAction;")
modify("LastActionView.cs", "content.text", "txtLastAction.text")
modify("LastActionView.cs", "if (content == null", "if (txtLastAction == null")

# ObjectiveView
modify("ObjectiveView.cs", "public Text content;", "public Text txtObjective;")
modify("ObjectiveView.cs", "content.text", "txtObjective.text")
modify("ObjectiveView.cs", "content.color", "txtObjective.color")
modify("ObjectiveView.cs", "if (content == null", "if (txtObjective == null")

# VillagerListView
modify("VillagerListView.cs", "public Text content;", "public Text txtVillagers;")
modify("VillagerListView.cs", "content.text", "txtVillagers.text")
modify("VillagerListView.cs", "if (content == null", "if (txtVillagers == null")

# BuildingListView
modify("BuildingListView.cs", "public Text content;", "public Text txtBuildings;")
modify("BuildingListView.cs", "content.text", "txtBuildings.text")
modify("BuildingListView.cs", "if (content == null", "if (txtBuildings == null")

# TaskLogView
modify("TaskLogView.cs", "public Text content;", "public Text txtLog;")
modify("TaskLogView.cs", "content.text", "txtLog.text")
modify("TaskLogView.cs", "if (content == null", "if (txtLog == null")

print("Restored field names")
