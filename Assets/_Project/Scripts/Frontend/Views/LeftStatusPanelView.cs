using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    public class LeftStatusPanelView : MonoBehaviour {
        public Text txtStatus;

        public void UpdateView(GameSnapshot snap) {
            if (snap == null || txtStatus == null) return;
            
            string text = "<b>VILLAGERS</b>\n";
            for(int i = 0; i < snap.villagers.Count; i++) {
                var v = snap.villagers[i];
                string status = v.hp <= 0 ? "DEAD" : $"HP {v.hp}";
                string marker = (i == snap.selectedVillagerIndex) ? "> " : "  ";
                text += $"{marker}{v.name} - {v.job} - {status}\n";
            }
            
            text += "\n<b>BUILDINGS</b>\n";
            var counts = new Dictionary<string, int>();
            foreach(var b in snap.buildings) {
                if (counts.ContainsKey(b.id)) counts[b.id] += b.count;
                else counts[b.id] = b.count;
            }
            
            foreach(var kvp in counts) {
                string dName = DefinitionDisplayService.GetBuildingName(kvp.Key);
                text += $"- {dName}: {kvp.Value}\n";
                Diagnostics.RuntimeTrace.Log("BUILDING_LIST", $"id={kvp.Key} count={kvp.Value}");
            }
            
            txtStatus.text = text;
        }
    }
}
