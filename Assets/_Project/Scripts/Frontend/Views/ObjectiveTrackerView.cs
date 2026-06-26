using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild
{
    public class ObjectiveTrackerView : MonoBehaviour
    {
        public Text txtObjectives;
        
        public void RenderState(GameSnapshot state)
        {
            if (state == null) return;
            
            // Objective tracker handles both Milestone (if any) and Quest.
            string objectiveStr = "";
            
            if (state.objectiveState != null && state.objectiveState.status != "COMPLETED")
            {
                objectiveStr += "MILESTONE\n" + state.objectiveText + "\n\n";
            }
            
            if (state.questState != null && !string.IsNullOrEmpty(state.questState.activeQuestId))
            {
                var qs = state.questState;
                var q = TheBonwater.Rebuild.Backend.Runtime.QuestEvaluator.Quests.Find(x => x.id == qs.activeQuestId);
                if (q != null)
                {
                    string progress = TheBonwater.Rebuild.Backend.Runtime.QuestEvaluator.GetQuestProgressText(q.id, state);
                    objectiveStr += $"CURRENT QUEST\n{q.title}\n{q.description}";
                    if (!string.IsNullOrEmpty(progress))
                    {
                        objectiveStr += $"\nProgress: {progress}";
                    }
                }
            }
            else if (state.questState != null && state.questState.tutorialCompleted)
            {
                objectiveStr += "TUTORIAL COMPLETED";
            }
            
            if (txtObjectives != null)
            {
                txtObjectives.text = objectiveStr;
            }
        }
    }
}
