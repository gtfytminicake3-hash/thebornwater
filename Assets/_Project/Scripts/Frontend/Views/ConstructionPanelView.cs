using UnityEngine;
using UnityEngine.UI;
using System.Text;

namespace TheBonwater.Rebuild {
    public class ConstructionPanelView : MonoBehaviour {
        public Text txtTasks;

        public void UpdateView(GameSnapshot snap) {
            if (snap == null || txtTasks == null) return;
            
            StringBuilder sb = new StringBuilder("<b>CONSTRUCTION TASKS</b>\n");
            
            int renderedRows = 0;
            int snapshotTasksCount = snap.tasks.Count;

            foreach(var t in snap.tasks) {
                if (!string.IsNullOrEmpty(t.targetBuildingId) && (t.targetBuildingId == "hut" || t.targetBuildingId == "storage" || t.targetBuildingId == "guardTower")) {
                    string buildingName = DefinitionDisplayService.GetBuildingName(t.targetBuildingId);
                    if (buildingName == "Unknown Building") buildingName = t.targetBuildingId;
                    
                    string statusTxt = $"<b>{buildingName}</b>";
                    if (t.status == "AwaitingResources") statusTxt += " (Awaiting Resources)";
                    else if (t.status == "UnderConstruction") statusTxt += $" - {t.currentCompletion}/{t.finalCompletion}";
                    else statusTxt += $" - {t.status}";
                    
                    sb.AppendLine(statusTxt);
                    renderedRows++;
                    Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"ConstructionPanel row target={t.targetBuildingId} progress={t.currentCompletion}/{t.finalCompletion}");
                }
            }

            if (renderedRows == 0) {
                txtTasks.text = "No active construction tasks";
                gameObject.SetActive(false);
            } else {
                txtTasks.text = sb.ToString();
                gameObject.SetActive(true);
            }

            Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI", $"ConstructionPanel snapshotTasks={snapshotTasksCount} renderedRows={renderedRows}");
            
            bool hasConstructionTasks = snap.tasks.Exists(t => !string.IsNullOrEmpty(t.targetBuildingId));
            if (hasConstructionTasks && renderedRows == 0) {
                Diagnostics.RuntimeTrace.Log("GAMEPLAY_UI_ERROR", "snapshot has construction tasks but ConstructionPanel rendered 0 rows");
            }
        }
    }
}
