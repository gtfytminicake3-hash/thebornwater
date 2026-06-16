using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace TheBonwater.Rebuild {
    public class TaskLogView : MonoBehaviour {
        public Text txtLog;

        public void UpdateView(GameSnapshot snap) {
            if (txtLog == null || snap == null) return;
            string text = "<b>EVENT LOG</b>\n";
            foreach(var msg in snap.taskLogs.Skip(System.Math.Max(0, snap.taskLogs.Count - 8))) {
                text += msg + "\n";
            }
            txtLog.text = text;
        }
    }
}
