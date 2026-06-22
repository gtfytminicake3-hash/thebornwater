using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

namespace TheBonwater.Rebuild {
    public class SelectedVillagerPanelView : MonoBehaviour {
        public Text txtInfo;
        public Button btnCycleJobDev;
        public Text txtMoreJobs;

        private Transform jobButtonContainer;
        private string currentVillagerId;

        public void UpdateView(GameSnapshot snap) {
            if (this == null || snap == null || txtInfo == null) return;

            // Only update info text if panel is actively showing a villager job menu
            if (gameObject.activeSelf && !string.IsNullOrEmpty(currentVillagerId)) {
                var v = snap.villagers.Find(v => v.id == currentVillagerId);
                if (v != null) {
                    string statusStr = v.hp <= 0 ? "DEAD" : (v.job == "Idle" ? "Idle" : "Working");
                    string displayJob = v.job == "Idle" ? "Builder" : (v.job == "Miner" ? "Iron Miner" : v.job);
                    
                    string weaponName = "None";
                    string armorName = "None";
                    string toolName = "None";
                    var repo = GameServiceLocator.Backend?.repo;
                    if (repo != null) {
                        if (!string.IsNullOrEmpty(v.weaponId)) {
                            var eq = repo.GetEquipment(v.weaponId);
                            if (eq != null) weaponName = eq.displayName;
                        }
                        if (!string.IsNullOrEmpty(v.armorId)) {
                            var eq = repo.GetEquipment(v.armorId);
                            if (eq != null) armorName = eq.displayName;
                        }
                        if (!string.IsNullOrEmpty(v.toolId)) {
                            var eq = repo.GetEquipment(v.toolId);
                            if (eq != null) toolName = eq.displayName;
                        }
                    }
                    txtInfo.text = $"<b>{v.name}</b>\nHP: {v.hp}/100\nJob: {displayJob}\nState: {statusStr}\nWeapon: {weaponName}\nArmor: {armorName}\nTool: {toolName}";
                }
            } else {
                // No active job selection — hide the panel entirely
                gameObject.SetActive(false);
            }
        }

        private Transform GetOrCreateJobButtonContainer() {
            Transform existing = transform.Find("JobButtonsContainer");
            if (existing != null) {
                // Destroy old to rebuild
                Destroy(existing.gameObject);
            }

            var go = new GameObject("JobButtonsContainer");
            go.transform.SetParent(transform, false);

            var rt = go.AddComponent<RectTransform>();
            rt.anchorMin = new Vector2(0, 0);
            rt.anchorMax = new Vector2(1, 1);
            rt.pivot = new Vector2(0.5f, 0.5f);
            rt.anchoredPosition = Vector2.zero;
            rt.sizeDelta = new Vector2(-20, -(120)); // leave margins for header + bottom padding

            // Add ScrollRect for vertical scrolling
            var scrollRect = go.AddComponent<ScrollRect>();
            scrollRect.horizontal = false;
            scrollRect.vertical = true;
            scrollRect.movementType = ScrollRect.MovementType.Clamped;
            scrollRect.scrollSensitivity = 25;
            scrollRect.decelerationRate = 0.1f;

            // Create content child for scroll rect
            var contentGo = new GameObject("Content");
            contentGo.transform.SetParent(go.transform, false);
            var contentRt = contentGo.AddComponent<RectTransform>();
            contentRt.anchorMin = new Vector2(0, 1);
            contentRt.anchorMax = new Vector2(1, 1);
            contentRt.pivot = new Vector2(0, 1);
            contentRt.anchoredPosition = Vector2.zero;
            contentRt.sizeDelta = new Vector2(0, 1000);

            // Vertical layout on content
            var layout = contentGo.AddComponent<VerticalLayoutGroup>();
            layout.spacing = 6;
            layout.childControlHeight = true;
            layout.childForceExpandHeight = false;
            layout.childControlWidth = true;
            layout.childForceExpandWidth = true;
            layout.padding = new RectOffset(10, 10, 4, 4);

            // Add a ContentSizeFitter so layout expands automatically
            var fitter = contentGo.AddComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;

            // Wire up scroll rect
            scrollRect.content = contentRt;

            jobButtonContainer = contentGo.transform;
            return jobButtonContainer;
        }

        private void CloseJobPanel() {
            currentVillagerId = null;
            Transform container = transform.Find("JobButtonsContainer");
            if (container != null) {
                Destroy(container.gameObject);
            }
            gameObject.SetActive(false);
            UnityEngine.Debug.Log("[JOB_PANEL_CLOSE]");
        }

        public void OpenJobModalForVillager(string villagerId) {
            var snap = GameServiceLocator.Backend?.GetSnapshot();
            if (snap == null) return;
            var vData = snap.villagers.Find(v => v.id == villagerId);
            if (vData == null) return;

            // Clean previous state
            Transform oldContainer = transform.Find("JobButtonsContainer");
            if (oldContainer != null) Destroy(oldContainer.gameObject);

            currentVillagerId = villagerId;
            string vName = vData.name;
            string currentJob = vData.job;

            // Set panel active — scene-owned RectTransform is preserved
            gameObject.SetActive(true);

            // Update villager info
            string statusStr = vData.hp <= 0 ? "DEAD" : (currentJob == "Idle" ? "Idle" : "Working");
            string displayJob = currentJob == "Idle" ? "Builder" : currentJob;
            if (currentJob == "Miner") displayJob = "Iron Miner";
            
            string weaponName = "None";
            string armorName = "None";
            string toolName = "None";
            var repo = GameServiceLocator.Backend?.repo;
            if (repo != null) {
                if (!string.IsNullOrEmpty(vData.weaponId)) {
                    var eq = repo.GetEquipment(vData.weaponId);
                    if (eq != null) weaponName = eq.displayName;
                }
                if (!string.IsNullOrEmpty(vData.armorId)) {
                    var eq = repo.GetEquipment(vData.armorId);
                    if (eq != null) armorName = eq.displayName;
                }
                if (!string.IsNullOrEmpty(vData.toolId)) {
                    var eq = repo.GetEquipment(vData.toolId);
                    if (eq != null) toolName = eq.displayName;
                }
            }
            txtInfo.text = $"<b>{vName}</b>\nHP: {vData.hp}/100\nJob: {displayJob}\nState: {statusStr}\nWeapon: {weaponName}\nArmor: {armorName}\nTool: {toolName}";

            if (txtMoreJobs != null) txtMoreJobs.gameObject.SetActive(false);
            if (btnCycleJobDev != null) btnCycleJobDev.gameObject.SetActive(false);

            // Build job list
            List<string> jobs = new List<string> { "Builder", "Woodcutter", "Forager", "Farmer", "Iron Miner", "Coal Miner", "Guard" };

            int forges = snap.buildings.Find(b => b.id == "blacksmithsForge")?.count ?? 0;
            if (forges > 0) jobs.Add("Blacksmith");

            int towers = snap.buildings.Find(b => b.id == "guardTower")?.count ?? 0;
            if (towers > 0) jobs.Add("Tower Guard");

            jobs.Add("Cancel");

            // Create scrollable button container
            Transform container = GetOrCreateJobButtonContainer();

            UnityEngine.Debug.Log($"[JOB_PANEL_OPEN] villager={villagerId} name={vName}");

            foreach (var job in jobs) {
                var goBtn = new GameObject("Btn_" + job);
                goBtn.transform.SetParent(container, false);

                var btnImg = goBtn.AddComponent<Image>();
                if (job == "Cancel") {
                    btnImg.color = new Color(0.8f, 0.2f, 0.2f);
                } else if (job == currentJob || (currentJob == "Idle" && job == "Builder") || (job == "Iron Miner" && currentJob == "Miner") || (job == "Coal Miner" && currentJob == "coalMiner") || (job == "Tower Guard" && currentJob == "towerGuard")) {
                    btnImg.color = new Color(0.2f, 0.7f, 0.3f);
                } else {
                    btnImg.color = new Color(0.25f, 0.5f, 0.85f);
                }

                var btn = goBtn.AddComponent<Button>();
                btn.navigation = new Navigation { mode = Navigation.Mode.None };

                var le = goBtn.AddComponent<LayoutElement>();
                le.minHeight = 42;

                var txtGo = new GameObject("Text");
                txtGo.transform.SetParent(goBtn.transform, false);
                var txt = txtGo.AddComponent<Text>();
                txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txt.text = job;
                txt.alignment = TextAnchor.MiddleCenter;
                txt.color = Color.white;
                txt.fontSize = 22;
                var txtRt = txtGo.GetComponent<RectTransform>();
                txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one; txtRt.sizeDelta = Vector2.zero;

                string jobId;
                if (job == "Tower Guard") jobId = "towerGuard";
                else if (job == "Coal Miner") jobId = "coalMiner";
                else if (job == "Iron Miner") jobId = "Miner";
                else jobId = job;

                btn.onClick.AddListener(() => {
                    if (job != "Cancel") {
                        UnityEngine.Debug.Log($"[JOB_ASSIGNED] villager={villagerId} old={currentJob} new={jobId}");
                        TownInteractionController.Instance?.ExecuteCommand(new AssignVillagerJobCommand { villagerId = villagerId, jobId = jobId });
                        TownInteractionController.Instance?.RefreshUI();
                    }
                    CloseJobPanel();
                });
            }

            // 1. Compatible equipment equip/unequip options
            List<string> compatibleEquips = new List<string>();
            string compatibleWeapon = "";
            string compatibleTool = "";

            if (string.Equals(currentJob, "Guard", StringComparison.OrdinalIgnoreCase)) compatibleWeapon = "sword";
            else if (string.Equals(currentJob, "towerGuard", StringComparison.OrdinalIgnoreCase)) compatibleWeapon = "bow";
            else if (string.Equals(currentJob, "Miner", StringComparison.OrdinalIgnoreCase) || string.Equals(currentJob, "coalMiner", StringComparison.OrdinalIgnoreCase)) compatibleTool = "pickaxe";
            else if (string.Equals(currentJob, "Builder", StringComparison.OrdinalIgnoreCase) || string.Equals(currentJob, "Blacksmith", StringComparison.OrdinalIgnoreCase)) compatibleTool = "hammer";
            else if (string.Equals(currentJob, "Woodcutter", StringComparison.OrdinalIgnoreCase)) compatibleTool = "woodAxe";

            if (!string.IsNullOrEmpty(compatibleWeapon)) compatibleEquips.Add(compatibleWeapon);
            if (!string.IsNullOrEmpty(compatibleTool)) compatibleEquips.Add(compatibleTool);

            compatibleEquips.Add("leatherArmor");
            compatibleEquips.Add("ironArmor");

            foreach (var eqId in compatibleEquips) {
                var eqDef = repo?.GetEquipment(eqId);
                if (eqDef == null) continue;

                bool isEquipped = string.Equals(vData.weaponId, eqId, StringComparison.OrdinalIgnoreCase) ||
                                  string.Equals(vData.armorId, eqId, StringComparison.OrdinalIgnoreCase) ||
                                  string.Equals(vData.toolId, eqId, StringComparison.OrdinalIgnoreCase);

                int stockCount = 0;
                var backendInstance = GameServiceLocator.Backend;
                if (backendInstance != null) {
                    var backendSnap = backendInstance.GetSnapshot();
                    if (backendSnap != null && backendSnap.equipmentStock != null) {
                        var stack = backendSnap.equipmentStock.Find(s => s.equipmentId.Equals(eqId, StringComparison.OrdinalIgnoreCase));
                        if (stack != null) stockCount = stack.count;
                    }
                }

                string btnText = "";
                Color btnColor;
                string slotName = eqDef.slot;

                if (isEquipped) {
                    btnText = "Unequip " + eqDef.displayName;
                    btnColor = new Color(0.7f, 0.4f, 0.1f);
                } else {
                    btnText = $"Equip {eqDef.displayName} (Stock: {stockCount})";
                    btnColor = (stockCount > 0) ? new Color(0.2f, 0.6f, 0.4f) : new Color(0.5f, 0.5f, 0.5f);
                }

                var goBtn = new GameObject("Btn_Equip_" + eqId);
                goBtn.transform.SetParent(container, false);
                var btnImg = goBtn.AddComponent<Image>();
                btnImg.color = btnColor;

                var btn = goBtn.AddComponent<Button>();
                btn.navigation = new Navigation { mode = Navigation.Mode.None };
                
                var le = goBtn.AddComponent<LayoutElement>();
                le.minHeight = 36;

                var txtGo = new GameObject("Text");
                txtGo.transform.SetParent(goBtn.transform, false);
                var txt = txtGo.AddComponent<Text>();
                txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                txt.text = btnText;
                txt.alignment = TextAnchor.MiddleCenter;
                txt.color = Color.white;
                txt.fontSize = 18;
                var txtRt = txtGo.GetComponent<RectTransform>();
                txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one; txtRt.sizeDelta = Vector2.zero;

                btn.onClick.AddListener(() => {
                    string targetEquipId = isEquipped ? "" : eqId;
                    UnityEngine.Debug.Log($"[EQUIP_CMD_TRIGGER] villager={villagerId} slot={slotName} id={targetEquipId}");
                    TownInteractionController.Instance?.ExecuteCommand(new EquipVillagerEquipmentCommand {
                        villagerId = villagerId,
                        slot = slotName,
                        equipmentId = targetEquipId
                    });
                    TownInteractionController.Instance?.RefreshUI();
                    CloseJobPanel();
                });
            }

            if (forges > 0) {
                var dividerGo = new GameObject("Divider");
                dividerGo.transform.SetParent(container, false);
                var divImg = dividerGo.AddComponent<Image>();
                divImg.color = new Color(0.4f, 0.4f, 0.4f);
                var divLe = dividerGo.AddComponent<LayoutElement>();
                divLe.minHeight = 6;

                List<string> craftableIds = new List<string> { "sword", "bow", "pickaxe", "hammer", "woodAxe", "leatherArmor", "ironArmor" };

                foreach (var eqId in craftableIds) {
                    var eqDef = repo?.GetEquipment(eqId);
                    if (eqDef == null) continue;

                    List<string> costStrings = new List<string>();
                    foreach (var cost in eqDef.costs) {
                        costStrings.Add($"{cost.Key}:{cost.Value}");
                    }
                    string costText = string.Join(", ", costStrings);

                    var goBtn = new GameObject("Btn_Craft_" + eqId);
                    goBtn.transform.SetParent(container, false);
                    var btnImg = goBtn.AddComponent<Image>();
                    btnImg.color = new Color(0.5f, 0.3f, 0.7f);

                    var btn = goBtn.AddComponent<Button>();
                    btn.navigation = new Navigation { mode = Navigation.Mode.None };
                    
                    var le = goBtn.AddComponent<LayoutElement>();
                    le.minHeight = 36;

                    var txtGo = new GameObject("Text");
                    txtGo.transform.SetParent(goBtn.transform, false);
                    var txt = txtGo.AddComponent<Text>();
                    txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
                    txt.text = $"Craft {eqDef.displayName} ({costText})";
                    txt.alignment = TextAnchor.MiddleCenter;
                    txt.color = Color.white;
                    txt.fontSize = 16;
                    var txtRt = txtGo.GetComponent<RectTransform>();
                    txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one; txtRt.sizeDelta = Vector2.zero;

                    btn.onClick.AddListener(() => {
                        UnityEngine.Debug.Log($"[CRAFT_CMD_TRIGGER] id={eqId}");
                        TownInteractionController.Instance?.ExecuteCommand(new CraftEquipmentCommand {
                            equipmentId = eqId,
                            count = 1
                        });
                        TownInteractionController.Instance?.RefreshUI();
                        CloseJobPanel();
                    });
                }
            }
        }
    }
}
