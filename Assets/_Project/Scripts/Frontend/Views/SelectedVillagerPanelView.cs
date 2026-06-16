using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class SelectedVillagerPanelView : MonoBehaviour {
        public Text txtInfo;
        public Button btnCycleJobDev;
        public Text txtMoreJobs;

        private GameObject currentJobModal;

        public void UpdateView(GameSnapshot snap) {
            if (this == null || snap == null || txtInfo == null) return;
            
            if (snap.selectedVillagerIndex >= 0 && snap.selectedVillagerIndex < snap.villagers.Count) {
                var v = snap.villagers[snap.selectedVillagerIndex];
                if (!gameObject.activeSelf) {
                    var initialPanelRt = GetComponent<RectTransform>();
                    string sz = initialPanelRt != null ? $"{initialPanelRt.sizeDelta.x},{initialPanelRt.sizeDelta.y}" : "unknown";
                    string p = initialPanelRt != null ? $"{initialPanelRt.anchoredPosition.x},{initialPanelRt.anchoredPosition.y}" : "unknown";
                    UnityEngine.Debug.Log($"[VILLAGER_SELECTED] id={v.id} panel=opened");
                }
                gameObject.SetActive(true);
                
                var panelRt = GetComponent<RectTransform>();
                if (panelRt != null) {
                    panelRt.anchorMin = new Vector2(1, 0);
                    panelRt.anchorMax = new Vector2(1, 0);
                    panelRt.pivot = new Vector2(1, 0);
                    panelRt.anchoredPosition = new Vector2(-20, 20);
                    panelRt.sizeDelta = new Vector2(250, 150);
                }
                
                string status = v.hp <= 0 ? "DEAD" : "ALIVE";
                txtInfo.text = $"<b>{v.name}</b>\nHP: {v.hp}  |  Job: {v.job}  |  Status: {status}";
                
                if (txtMoreJobs != null) {
                    txtMoreJobs.gameObject.SetActive(false);
                }
                
                if (btnCycleJobDev != null) {
                    btnCycleJobDev.gameObject.SetActive(false);
                }

                Transform oldContainer = transform.Find("JobButtonsContainer");
                if (oldContainer != null) Destroy(oldContainer.gameObject);
            } else {
                gameObject.SetActive(false);
            }
        }

        private void CloseJobModal(string reason) {
            Canvas rootCanvas = GetComponentInParent<Canvas>();
            if (rootCanvas != null) {
                foreach (Transform child in rootCanvas.transform) {
                    if (child.name == "JobSelectionModal") {
                        child.gameObject.SetActive(false);
                        Destroy(child.gameObject);
                    }
                }
            }

            if (currentJobModal != null) {
                currentJobModal.SetActive(false);
                Destroy(currentJobModal);
                currentJobModal = null;
            }
            if (!string.IsNullOrEmpty(reason)) {
                UnityEngine.Debug.Log($"[JOB_MODAL_CLOSE] reason={reason}");
            }
        }

        public void OpenJobModalForVillager(string villagerId) {
            CloseJobModal("replace");

            var snap = GameServiceLocator.Backend?.GetSnapshot();
            if (snap == null) return;
            var vData = snap.villagers.Find(v => v.id == villagerId);
            if (vData == null) return;

            string vName = vData.name;
            string currentJob = vData.job;
            string currentState = vData.state;

            Canvas rootCanvas = GetComponentInParent<Canvas>();
            if (rootCanvas == null) return;

            var go = new GameObject("JobSelectionModal");
            currentJobModal = go;
            go.transform.SetParent(rootCanvas.transform, false);
            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0.5f, 0.5f);
            rt.anchorMax = new Vector2(0.5f, 0.5f);
            rt.pivot = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;
            rt.sizeDelta = new Vector2(360, 320);

            var img = go.AddComponent<Image>();
            img.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);

            var layout = go.AddComponent<UnityEngine.UI.VerticalLayoutGroup>();
            layout.spacing = 8;
            layout.childControlHeight = true;
            layout.childForceExpandHeight = false;
            layout.childControlWidth = true;
            layout.childForceExpandWidth = true;
            layout.padding = new RectOffset(20, 20, 20, 20);

            // Title
            var titleGo = new GameObject("Title");
            titleGo.transform.SetParent(go.transform, false);
            var titleTxt = titleGo.AddComponent<Text>();
            titleTxt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            titleTxt.text = $"<b>{vName}</b>\nJob: {currentJob}\nState: {currentState}";
            titleTxt.alignment = TextAnchor.MiddleCenter;
            titleTxt.color = Color.white;
            titleTxt.fontSize = 20;
            var leTitle = titleGo.AddComponent<UnityEngine.UI.LayoutElement>();
            leTitle.minHeight = 80;

            UnityEngine.Debug.Log($"[JOB_MODAL_OPEN] villager={villagerId} name={vName}");

            string[] jobs = { "Idle", "Woodcutter", "Forager", "Builder", "Guard", "Cancel" };
            foreach (var job in jobs) {
                var goBtn = new GameObject("Btn_" + job);
                goBtn.transform.SetParent(go.transform, false);
                var btnImg = goBtn.AddComponent<Image>();
                btnImg.color = job == "Cancel" ? new Color(0.8f, 0.2f, 0.2f) : new Color(0.2f, 0.6f, 0.8f);
                var btn = goBtn.AddComponent<Button>();
                
                var le = goBtn.AddComponent<UnityEngine.UI.LayoutElement>();
                le.minHeight = 40;

                var txtGo = new GameObject("Text");
                txtGo.transform.SetParent(goBtn.transform, false);
                var txt = txtGo.AddComponent<Text>();
                txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txt.text = job;
                txt.alignment = TextAnchor.MiddleCenter;
                txt.color = Color.white;
                txt.fontSize = 24;
                var txtRt = txtGo.GetComponent<RectTransform>();
                txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one; txtRt.sizeDelta = Vector2.zero;

                string jobId = job;
                btn.onClick.AddListener(() => {
                    if (jobId != "Cancel") {
                        UnityEngine.Debug.Log($"[JOB_ASSIGNED] villager={villagerId} old={currentJob} new={jobId}");
                        TownInteractionController.Instance?.ExecuteCommand(new AssignVillagerJobCommand { villagerId = villagerId, jobId = jobId });
                        TownInteractionController.Instance?.RefreshUI();
                        CloseJobModal("job_selected");
                    } else {
                        CloseJobModal("cancel");
                    }
                });
            }
        }
    }
}
