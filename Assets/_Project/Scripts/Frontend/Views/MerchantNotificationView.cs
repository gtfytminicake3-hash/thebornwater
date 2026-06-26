using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace TheBonwater.Rebuild {
    public class MerchantNotificationView : MonoBehaviour {
        public GameObject panel;
        public Text txtMessage;

        private bool? _lastMerchantPresent = null;
        private Coroutine _hideCoroutine = null;

        public void ResetState() {
            _lastMerchantPresent = null;
            if (_hideCoroutine != null) {
                StopCoroutine(_hideCoroutine);
                _hideCoroutine = null;
            }
            if (panel != null) {
                panel.SetActive(false);
            }
        }

        private void Awake() {
            // Panel starts hidden
            if (panel != null) {
                panel.SetActive(false);
            }
        }

        public void UpdateView(GameSnapshot snap) {
            if (snap == null || snap.tradeState == null) return;

            bool isPresent = snap.tradeState.isMerchantPresent;

            if (_lastMerchantPresent == null) {
                // First snapshot baseline: do not trigger notification
                _lastMerchantPresent = isPresent;
                return;
            }

            if (isPresent && !_lastMerchantPresent.Value) {
                // Transition false -> true: Merchant has arrived!
                ShowNotification("Merchant has arrived!");
            } else if (!isPresent && _lastMerchantPresent.Value) {
                // Transition true -> false: Merchant has departed.
                ShowNotification("Merchant has departed.");
            }

            _lastMerchantPresent = isPresent;
        }

        private void ShowNotification(string message) {
            if (panel != null) {
                panel.SetActive(true);
            }

            if (txtMessage != null) {
                txtMessage.text = message;
            }

            if (_hideCoroutine != null) {
                StopCoroutine(_hideCoroutine);
            }
            _hideCoroutine = StartCoroutine(HideAfterDelay(4.0f));
        }

        private IEnumerator HideAfterDelay(float delay) {
            yield return new WaitForSeconds(delay);
            if (panel != null) {
                panel.SetActive(false);
            }
            _hideCoroutine = null;
        }
    }
}
