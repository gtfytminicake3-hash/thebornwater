using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace TheBonwater.Rebuild
{
    public class QuestAchievementNotificationView : MonoBehaviour
    {
        public Text txtNotification;
        public Button btnDismiss;
        
        // Reference to the backend controller so we can dispatch commands
        public IGameBackend BackendController { get; set; }

        public void Bind(IGameBackend backend)
        {
            BackendController = backend;
            if (btnDismiss != null)
            {
                btnDismiss.onClick.RemoveAllListeners();
                btnDismiss.onClick.AddListener(OnDismissClicked);
            }
        }

        private void OnDismissClicked()
        {
            if (BackendController == null) return;

            GameCommand cmd = null;
            if (_currentlyDisplaying == "Achievement")
            {
                cmd = new DismissAchievementNotificationCommand();
            }
            else if (_currentlyDisplaying == "Quest")
            {
                cmd = new DismissQuestNotificationCommand();
            }

            if (cmd != null)
            {
                BackendController.Execute(cmd);
                if (TownInteractionController.Instance != null && GameServiceLocator.Backend == BackendController)
                {
                    TownInteractionController.Instance.RefreshUI();
                }
            }
        }

        private string _currentlyDisplaying = "";

        public void RenderState(GameSnapshot state)
        {
            if (state == null || state.questState == null)
            {
                gameObject.SetActive(false);
                return;
            }

            var qs = state.questState;

            // Priority: Achievement first, then Quest
            if (qs.pendingAchievementNotifications != null && qs.pendingAchievementNotifications.Count > 0)
            {
                _currentlyDisplaying = "Achievement";
                if (txtNotification != null) txtNotification.text = qs.pendingAchievementNotifications[0];
                gameObject.SetActive(true);
            }
            else if (qs.pendingQuestNotifications != null && qs.pendingQuestNotifications.Count > 0)
            {
                _currentlyDisplaying = "Quest";
                if (txtNotification != null) txtNotification.text = qs.pendingQuestNotifications[0];
                gameObject.SetActive(true);
            }
            else
            {
                _currentlyDisplaying = "";
                gameObject.SetActive(false);
            }
        }
    }
}
