using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace TheBonwater.Rebuild
{
    public class TitanBossPanelView : MonoBehaviour
    {
        public Text titleText;
        public Text statusText;
        public Text hpText;
        public Slider hpSlider;
        public Button btnAttackTitan;
        public Text explanationText;
        public GameObject titanAvatar;
        public Image titanAvatarImage;

        private List<string> currentGuardIds = new List<string>();

        private void Awake()
        {
            if (btnAttackTitan != null)
            {
                btnAttackTitan.onClick.RemoveAllListeners();
                btnAttackTitan.onClick.AddListener(OnAttackTitanClicked);
            }
        }

        public void RenderState(GameSnapshot state)
        {
            if (state == null || state.titanState == null || !state.titanState.isAwakened)
            {
                gameObject.SetActive(false);
                return;
            }

            gameObject.SetActive(true);

            if (titleText != null)
            {
                titleText.text = "Fallen Titan";
            }

            if (explanationText != null)
            {
                explanationText.text = "Each attack sends all ready Guards into one battle round.\nGuards damage the Titan. The Titan deals return damage.";
            }

            if (hpText != null)
            {
                hpText.text = $"HP: {state.titanState.hp}/{state.titanState.maxHp}";
            }

            if (hpSlider != null)
            {
                hpSlider.maxValue = state.titanState.maxHp;
                hpSlider.value = state.titanState.hp;
            }

            if (state.titanState.isDefeated)
            {
                if (btnAttackTitan != null)
                {
                    btnAttackTitan.interactable = false;
                }
                if (statusText != null)
                {
                    statusText.text = "Fallen Titan defeated. Endgame victory achieved.";
                }
                return;
            }

            currentGuardIds.Clear();
            if (state.villagers != null)
            {
                foreach (var v in state.villagers)
                {
                    if (v.hp > 0 && !v.isOnExpedition && IsGuardJob(v.job))
                    {
                        currentGuardIds.Add(v.id);
                    }
                }
            }

            if (btnAttackTitan != null)
            {
                if (currentGuardIds.Count == 0)
                {
                    btnAttackTitan.interactable = false;
                    if (statusText != null)
                    {
                        statusText.text = "No ready Guards. Assign villagers as Guards before attacking.";
                    }
                }
                else
                {
                    btnAttackTitan.interactable = true;
                    if (statusText != null)
                    {
                        if (!string.IsNullOrEmpty(state.titanState.lastBattleResult))
                        {
                            statusText.text = state.titanState.lastBattleResult;
                        }
                        else
                        {
                            statusText.text = $"{currentGuardIds.Count} Guards ready. Click Attack Titan to resolve one battle round.";
                        }
                    }
                }
            }
        }

        private void OnAttackTitanClicked()
        {
            if (currentGuardIds == null || currentGuardIds.Count == 0) return;
            var cmd = new AttackTitanCommand();
            cmd.attackerVillagerIds = new List<string>(currentGuardIds);
            if (TownInteractionController.Instance != null)
            {
                TownInteractionController.Instance.ExecuteCommand(cmd);
            }
        }

        private static bool IsGuardJob(string job)
        {
            if (string.IsNullOrEmpty(job)) return false;
            return string.Equals(job, "Guard", System.StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "guard", System.StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "guardTower", System.StringComparison.OrdinalIgnoreCase)
                || string.Equals(job, "towerGuard", System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
