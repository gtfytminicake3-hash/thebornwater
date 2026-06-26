using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TheBonwater.Rebuild.Data;

namespace TheBonwater.Rebuild {
    public class SelectedVillagerPanelView : MonoBehaviour {
        public Text txtInfo;
        public Button btnCycleJobDev;
        public Text txtMoreJobs;
        public GameObject blacksmithCraftPanel;

        private Transform jobButtonContainer;
        private string currentVillagerId;

        private void Start() {
            // Start hidden at runtime until a villager is selected
            gameObject.SetActive(false);
            if (blacksmithCraftPanel == null) {
                UnityEngine.Debug.LogError("[SelectedVillagerPanel] BlacksmithCraftPanel is missing or not assigned to SelectedVillagerPanelView in the scene!");
            } else {
                blacksmithCraftPanel.SetActive(false);
            }
        }

        public void UpdateView(GameSnapshot snap) {
            if (this == null || snap == null || txtInfo == null) return;

            // Only update info text if panel is actively showing a villager job menu
            if (gameObject.activeSelf && !string.IsNullOrEmpty(currentVillagerId)) {
                var v = snap.villagers.Find(v => v.id == currentVillagerId);
                if (v != null) {
                    string statusStr = v.hp <= 0 ? "DEAD" : (v.job == "Idle" ? "Idle" : "Working");
                    string displayJob = v.job;
                    if (string.Equals(v.job, "Idle", StringComparison.OrdinalIgnoreCase)) displayJob = "Builder";
                    else if (string.Equals(v.job, "Miner", StringComparison.OrdinalIgnoreCase)) displayJob = "Iron Miner";
                    else if (string.Equals(v.job, "coalMiner", StringComparison.OrdinalIgnoreCase)) displayJob = "Coal Miner";
                    else if (string.Equals(v.job, "towerGuard", StringComparison.OrdinalIgnoreCase)) displayJob = "Tower Guard";
                    else if (string.Equals(v.job, "farmer", StringComparison.OrdinalIgnoreCase)) displayJob = "Farmer";
                    
                    var repo = GameServiceLocator.Backend?.repo;

                    string weaponName = "None";
                    if (!string.IsNullOrEmpty(v.weaponId)) {
                        weaponName = $"{v.weaponId} (missing definition)";
                        if (repo != null) {
                            var eq = repo.GetEquipment(v.weaponId);
                            if (eq != null) weaponName = eq.displayName;
                        }
                    }

                    string armorName = "None";
                    if (!string.IsNullOrEmpty(v.armorId)) {
                        armorName = $"{v.armorId} (missing definition)";
                        if (repo != null) {
                            var eq = repo.GetEquipment(v.armorId);
                            if (eq != null) armorName = eq.displayName;
                        }
                    }

                    string toolName = "None";
                    if (!string.IsNullOrEmpty(v.toolId)) {
                        toolName = $"{v.toolId} (missing definition)";
                        if (repo != null) {
                            var eq = repo.GetEquipment(v.toolId);
                            if (eq != null) toolName = eq.displayName;
                        }
                    }

                    int atk = 10;
                    int def = 10;
                    int toolBonus = 0;
                    int workOutput = 0;

                    var backend = GameServiceLocator.Backend as LocalGameBackend;
                    if (backend != null) {
                        atk = backend.GetVillagerAttackForDisplay(v);
                        def = backend.GetVillagerDefenseForDisplay(v);
                        toolBonus = backend.GetVillagerToolBonusForDisplay(v, v.job);
                        workOutput = backend.GetVillagerWorkOutputForDisplay(v);
                    } else {
                        // Safe fallback calculations if cast fails or backend is not LocalGameBackend
                        if (repo != null) {
                            var jobDef = repo.GetJob(v.job);
                            int baseAtk = (jobDef != null && jobDef.defense > 0) ? jobDef.defense : 10;
                            atk = baseAtk;
                            if (!string.IsNullOrEmpty(v.weaponId)) {
                                var eq = repo.GetEquipment(v.weaponId);
                                if (eq != null && string.Equals(eq.category, "Weapon", StringComparison.OrdinalIgnoreCase)) {
                                    atk += eq.attackBonus;
                                }
                            }

                            int baseDef = 10;
                            def = baseDef;
                            if (!string.IsNullOrEmpty(v.armorId)) {
                                var eq = repo.GetEquipment(v.armorId);
                                if (eq != null && string.Equals(eq.category, "Armor", StringComparison.OrdinalIgnoreCase)) {
                                    def += eq.defenseBonus;
                                }
                            }

                            if (!string.IsNullOrEmpty(v.toolId)) {
                                var eq = repo.GetEquipment(v.toolId);
                                if (eq != null && string.Equals(eq.category, "Tool", StringComparison.OrdinalIgnoreCase)) {
                                    string jobId = v.job;
                                    if (string.Equals(jobId, "Woodcutter", StringComparison.OrdinalIgnoreCase) && string.Equals(eq.id, "woodAxe", StringComparison.OrdinalIgnoreCase)) {
                                        toolBonus = eq.jobBonus;
                                    } else if ((string.Equals(jobId, "Miner", StringComparison.OrdinalIgnoreCase) || string.Equals(jobId, "coalMiner", StringComparison.OrdinalIgnoreCase)) 
                                         && string.Equals(eq.id, "pickaxe", StringComparison.OrdinalIgnoreCase)) {
                                        toolBonus = eq.jobBonus;
                                    } else if ((string.Equals(jobId, "Builder", StringComparison.OrdinalIgnoreCase) || string.Equals(jobId, "Blacksmith", StringComparison.OrdinalIgnoreCase)) 
                                         && string.Equals(eq.id, "hammer", StringComparison.OrdinalIgnoreCase)) {
                                        toolBonus = eq.jobBonus;
                                    }
                                }
                            }

                            if (string.Equals(v.job, "Builder", StringComparison.OrdinalIgnoreCase)) {
                                workOutput = 25 + toolBonus;
                            } else if (string.Equals(v.job, "Woodcutter", StringComparison.OrdinalIgnoreCase)) {
                                int baseProd = repo.GetJob("Woodcutter")?.productionPerPhase ?? 10;
                                if (baseProd <= 0) baseProd = 10;
                                workOutput = baseProd + toolBonus;
                            } else if (string.Equals(v.job, "Miner", StringComparison.OrdinalIgnoreCase)) {
                                int baseProd = repo.GetJob("Miner")?.productionPerPhase ?? 3;
                                if (baseProd <= 0) baseProd = 3;
                                workOutput = baseProd + toolBonus;
                            } else if (string.Equals(v.job, "coalMiner", StringComparison.OrdinalIgnoreCase)) {
                                int baseProd = repo.GetJob("coalMiner")?.productionPerPhase ?? 1;
                                if (baseProd <= 0) baseProd = 1;
                                workOutput = baseProd + toolBonus;
                            } else if (string.Equals(v.job, "Forager", StringComparison.OrdinalIgnoreCase)) {
                                int baseProd = repo.GetJob("Forager")?.productionPerPhase ?? 4;
                                if (baseProd <= 0) baseProd = 4;
                                workOutput = baseProd;
                            } else if (string.Equals(v.job, "farmer", StringComparison.OrdinalIgnoreCase) || string.Equals(v.job, "Farmer", StringComparison.OrdinalIgnoreCase)) {
                                int baseProd = repo.GetJob("farmer")?.productionPerPhase ?? 6;
                                if (baseProd <= 0) baseProd = 6;
                                workOutput = baseProd;
                            }
                        }
                    }

                    txtInfo.text = $"<b>{v.name}</b>\n" +
                                   $"HP: {v.hp}/100\n" +
                                   $"Job: {displayJob}\n" +
                                   $"State: {statusStr}\n\n" +
                                   $"<b>STATS</b>\n" +
                                   $"ATK: {atk}\n" +
                                   $"DEF: {def}\n" +
                                   $"Tool: +{toolBonus}\n";

                    if (string.Equals(v.job, "Builder", StringComparison.OrdinalIgnoreCase) || 
                        string.Equals(v.job, "Woodcutter", StringComparison.OrdinalIgnoreCase) || 
                        string.Equals(v.job, "Miner", StringComparison.OrdinalIgnoreCase) || 
                        string.Equals(v.job, "coalMiner", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(v.job, "Forager", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(v.job, "farmer", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(v.job, "Farmer", StringComparison.OrdinalIgnoreCase)) {
                        txtInfo.text += $"Work: {workOutput}/tick\n";
                    }

                    txtInfo.text += $"\n<b>EQUIPMENT</b>\n" +
                                    $"Weapon: {weaponName}\n" +
                                    $"Armor: {armorName}\n" +
                                    $"Tool: {toolName}";

                    // Toggle BlacksmithCraftPanel visibility dynamically
                    if (blacksmithCraftPanel != null) {
                        int forges = snap.buildings.Find(b => b.id == "blacksmithsForge")?.count ?? 0;
                        bool isBlacksmith = string.Equals(v.job, "Blacksmith", StringComparison.OrdinalIgnoreCase);
                        blacksmithCraftPanel.SetActive(isBlacksmith && forges > 0);
                    }
                }
            } else {
                // If inactive, hide blacksmith panel too
                if (blacksmithCraftPanel != null) {
                    blacksmithCraftPanel.SetActive(false);
                }
            }
        }

        private Transform GetOptionsScrollContent() {
            // Find existing OptionsScrollArea
            Transform scrollArea = transform.Find("OptionsScrollArea");
            if (scrollArea == null) scrollArea = transform.Find("JobButtonsContainer");

            if (scrollArea == null) {
                UnityEngine.Debug.LogWarning("[SelectedVillagerPanel] OptionsScrollArea child was missing at runtime, creating fallback container.");
                
                var go = new GameObject("OptionsScrollArea");
                go.transform.SetParent(transform, false);
                var rt = go.AddComponent<RectTransform>();
                rt.anchorMin = new Vector2(0, 0);
                rt.anchorMax = new Vector2(1, 0);
                rt.pivot = new Vector2(0.5f, 0f);
                rt.anchoredPosition = new Vector2(0, 10);
                rt.sizeDelta = new Vector2(-20, 85);
                
                scrollArea = go.transform;
            }

            var scrollRect = scrollArea.GetComponent<ScrollRect>();
            if (scrollRect == null) {
                scrollRect = scrollArea.gameObject.AddComponent<ScrollRect>();
            }
            scrollRect.horizontal = false;
            scrollRect.vertical = true;
            scrollRect.movementType = ScrollRect.MovementType.Clamped;
            scrollRect.scrollSensitivity = 25;
            scrollRect.decelerationRate = 0.1f;
            scrollRect.viewport = scrollArea.GetComponent<RectTransform>();

            var mask = scrollArea.GetComponent<RectMask2D>();
            if (mask == null) {
                mask = scrollArea.gameObject.AddComponent<RectMask2D>();
            }

            Transform content = scrollArea.Find("Content");
            if (content == null) {
                UnityEngine.Debug.LogWarning("[SelectedVillagerPanel] Content child was missing inside OptionsScrollArea at runtime, creating fallback content container.");
                
                var contentGo = new GameObject("Content");
                contentGo.transform.SetParent(scrollArea, false);
                var contentRt = contentGo.AddComponent<RectTransform>();
                contentRt.anchorMin = new Vector2(0, 1);
                contentRt.anchorMax = new Vector2(1, 1);
                contentRt.pivot = new Vector2(0, 1);
                contentRt.anchoredPosition = Vector2.zero;
                contentRt.sizeDelta = new Vector2(0, 200);

                var layout = contentGo.AddComponent<VerticalLayoutGroup>();
                layout.spacing = 6;
                layout.childControlHeight = true;
                layout.childForceExpandHeight = false;
                layout.childControlWidth = true;
                layout.childForceExpandWidth = true;
                layout.padding = new RectOffset(10, 10, 4, 4);

                var fitter = contentGo.AddComponent<ContentSizeFitter>();
                fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                
                scrollRect.content = contentRt;
                content = contentGo.transform;
            } else {
                var contentRt = content.GetComponent<RectTransform>();
                if (contentRt != null) {
                    scrollRect.content = contentRt;

                    var layout = content.GetComponent<VerticalLayoutGroup>();
                    if (layout == null) {
                        layout = content.gameObject.AddComponent<VerticalLayoutGroup>();
                        layout.spacing = 6;
                        layout.childControlHeight = true;
                        layout.childForceExpandHeight = false;
                        layout.childControlWidth = true;
                        layout.childForceExpandWidth = true;
                        layout.padding = new RectOffset(10, 10, 4, 4);
                    }
                    var fitter = content.GetComponent<ContentSizeFitter>();
                    if (fitter == null) {
                        fitter = content.gameObject.AddComponent<ContentSizeFitter>();
                        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                    }
                }
            }

            jobButtonContainer = content;
            return jobButtonContainer;
        }

        private Transform GetCraftScrollContent() {
            if (blacksmithCraftPanel == null) return null;

            Transform scrollArea = blacksmithCraftPanel.transform.Find("CraftScrollArea");
            if (scrollArea == null) {
                UnityEngine.Debug.LogWarning("[SelectedVillagerPanel] CraftScrollArea child was missing at runtime inside BlacksmithCraftPanel, creating fallback container.");
                
                var go = new GameObject("CraftScrollArea");
                go.transform.SetParent(blacksmithCraftPanel.transform, false);
                var rt = go.AddComponent<RectTransform>();
                rt.anchorMin = Vector2.zero;
                rt.anchorMax = Vector2.one;
                rt.pivot = new Vector2(0.5f, 0.5f);
                rt.anchoredPosition = new Vector2(0, -20);
                rt.sizeDelta = new Vector2(-20, -70);
                
                scrollArea = go.transform;
            }

            var scrollRect = scrollArea.GetComponent<ScrollRect>();
            if (scrollRect == null) {
                scrollRect = scrollArea.gameObject.AddComponent<ScrollRect>();
            }
            scrollRect.horizontal = false;
            scrollRect.vertical = true;
            scrollRect.movementType = ScrollRect.MovementType.Clamped;
            scrollRect.scrollSensitivity = 25;
            scrollRect.viewport = scrollArea.GetComponent<RectTransform>();

            var mask = scrollArea.GetComponent<RectMask2D>();
            if (mask == null) {
                mask = scrollArea.gameObject.AddComponent<RectMask2D>();
            }

            Transform content = scrollArea.Find("Content");
            if (content == null) {
                UnityEngine.Debug.LogWarning("[SelectedVillagerPanel] Content child was missing inside CraftScrollArea at runtime, creating fallback content container.");
                
                var contentGo = new GameObject("Content");
                contentGo.transform.SetParent(scrollArea, false);
                var contentRt = contentGo.AddComponent<RectTransform>();
                contentRt.anchorMin = new Vector2(0, 1);
                contentRt.anchorMax = new Vector2(1, 1);
                contentRt.pivot = new Vector2(0, 1);
                contentRt.anchoredPosition = Vector2.zero;
                contentRt.sizeDelta = new Vector2(0, 300);

                var layout = contentGo.AddComponent<VerticalLayoutGroup>();
                layout.spacing = 6;
                layout.childControlHeight = true;
                layout.childForceExpandHeight = false;
                layout.childControlWidth = true;
                layout.childForceExpandWidth = true;
                layout.padding = new RectOffset(10, 10, 4, 4);

                var fitter = contentGo.AddComponent<ContentSizeFitter>();
                fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                
                scrollRect.content = contentRt;
                content = contentGo.transform;
            } else {
                var contentRt = content.GetComponent<RectTransform>();
                if (contentRt != null) {
                    scrollRect.content = contentRt;

                    var layout = content.GetComponent<VerticalLayoutGroup>();
                    if (layout == null) {
                        layout = content.gameObject.AddComponent<VerticalLayoutGroup>();
                        layout.spacing = 6;
                        layout.childControlHeight = true;
                        layout.childForceExpandHeight = false;
                        layout.childControlWidth = true;
                        layout.childForceExpandWidth = true;
                        layout.padding = new RectOffset(10, 10, 4, 4);
                    }
                    var fitter = content.GetComponent<ContentSizeFitter>();
                    if (fitter == null) {
                        fitter = content.gameObject.AddComponent<ContentSizeFitter>();
                        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                    }
                }
            }

            return content;
        }

        private void CloseJobPanel() {
            currentVillagerId = null;
            // Clear only dynamic children inside options content
            Transform container = GetOptionsScrollContent();
            if (container != null) {
                foreach (Transform child in container) {
                    Destroy(child.gameObject);
                }
            }
            // Clear only dynamic children inside craft content
            Transform craftContainer = GetCraftScrollContent();
            if (craftContainer != null) {
                foreach (Transform child in craftContainer) {
                    Destroy(child.gameObject);
                }
            }
            gameObject.SetActive(false);
            if (blacksmithCraftPanel != null) {
                blacksmithCraftPanel.SetActive(false);
            }
            UnityEngine.Debug.Log("[JOB_PANEL_CLOSE]");
        }

        private void CreateSectionHeader(Transform parent, string title) {
            var go = new GameObject("Header_" + title);
            go.transform.SetParent(parent, false);
            
            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 20;

            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(go.transform, false);
            var txtRt = txtGo.AddComponent<RectTransform>();
            txtRt.anchorMin = Vector2.zero;
            txtRt.anchorMax = Vector2.one;
            txtRt.sizeDelta = Vector2.zero;

            var txt = txtGo.AddComponent<Text>();
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            if (txt.font == null) txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            txt.text = title.ToUpper();
            txt.alignment = TextAnchor.MiddleLeft;
            txt.color = Color.yellow;
            txt.fontSize = 14;
            txt.fontStyle = FontStyle.Bold;
        }

        public void OpenJobModalForVillager(string villagerId) {
            var snap = GameServiceLocator.Backend?.GetSnapshot();
            if (snap == null) return;
            var vData = snap.villagers.Find(v => v.id == villagerId);
            if (vData == null) return;

            currentVillagerId = villagerId;
            string vName = vData.name;
            string currentJob = vData.job;

            // Set panel active — scene-owned RectTransform is preserved
            gameObject.SetActive(true);

            // Update view to format details using correct stat format
            UpdateView(snap);

            if (txtMoreJobs != null) txtMoreJobs.gameObject.SetActive(false);
            if (btnCycleJobDev != null) btnCycleJobDev.gameObject.SetActive(false);

            // Retrieve existing options scroll content
            Transform container = GetOptionsScrollContent();

            // Clear ONLY dynamic button/header children, do NOT destroy OptionsScrollArea or Content
            foreach (Transform child in container) {
                Destroy(child.gameObject);
            }

            UnityEngine.Debug.Log($"[OPTIONS_PANEL_OPEN] villager={villagerId} name={vName}");

            Font font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            if (font == null) font = Resources.GetBuiltinResource<Font>("Arial.ttf");

            // --- 1. JOBS SECTION ---
            CreateSectionHeader(container, "Jobs");

            List<string> jobs = new List<string> { "Builder", "Woodcutter", "Forager", "Farmer", "Iron Miner", "Coal Miner", "Guard" };

            int forges = snap.buildings.Find(b => b.id == "blacksmithsForge")?.count ?? 0;
            if (forges > 0) jobs.Add("Blacksmith");

            int towers = snap.buildings.Find(b => b.id == "guardTower")?.count ?? 0;
            if (towers > 0) jobs.Add("Tower Guard");

            foreach (var job in jobs) {
                var jobBtnGo = new GameObject("Btn_" + job);
                jobBtnGo.transform.SetParent(container, false);

                var jobBtnImg = jobBtnGo.AddComponent<Image>();
                if (job == currentJob || (currentJob == "Idle" && job == "Builder") || (job == "Iron Miner" && currentJob == "Miner") || (job == "Coal Miner" && currentJob == "coalMiner") || (job == "Tower Guard" && currentJob == "towerGuard")) {
                    jobBtnImg.color = new Color(0.2f, 0.7f, 0.3f);
                } else {
                    jobBtnImg.color = new Color(0.25f, 0.5f, 0.85f);
                }

                var jobBtn = jobBtnGo.AddComponent<Button>();
                jobBtn.navigation = new Navigation { mode = Navigation.Mode.None };

                var jobLe = jobBtnGo.AddComponent<LayoutElement>();
                jobLe.minHeight = 42;

                var jobTxtGo = new GameObject("Text");
                jobTxtGo.transform.SetParent(jobBtnGo.transform, false);
                var jobTxt = jobTxtGo.AddComponent<Text>();
                jobTxt.font = font;
                jobTxt.text = job;
                jobTxt.alignment = TextAnchor.MiddleCenter;
                jobTxt.color = Color.white;
                jobTxt.fontSize = 22;
                var jobTxtRt = jobTxtGo.GetComponent<RectTransform>();
                jobTxtRt.anchorMin = Vector2.zero; jobTxtRt.anchorMax = Vector2.one; jobTxtRt.sizeDelta = Vector2.zero;

                string jobId;
                if (job == "Tower Guard") jobId = "towerGuard";
                else if (job == "Coal Miner") jobId = "coalMiner";
                else if (job == "Iron Miner") jobId = "Miner";
                else jobId = job;

                jobBtn.onClick.AddListener(() => {
                    UnityEngine.Debug.Log($"[JOB_ASSIGNED] villager={villagerId} old={currentJob} new={jobId}");
                    TownInteractionController.Instance?.ExecuteCommand(new AssignVillagerJobCommand { villagerId = villagerId, jobId = jobId });
                    TownInteractionController.Instance?.RefreshUI();
                    CloseJobPanel();
                });
            }

            var repo = GameServiceLocator.Backend?.repo;

            // --- 2. WEAPON SECTION ---
            string compatibleWeapon = "";
            if (string.Equals(currentJob, "Guard", StringComparison.OrdinalIgnoreCase)) compatibleWeapon = "sword";
            else if (string.Equals(currentJob, "towerGuard", StringComparison.OrdinalIgnoreCase)) compatibleWeapon = "bow";

            if (!string.IsNullOrEmpty(compatibleWeapon)) {
                CreateSectionHeader(container, "Weapons");
                CreateEquipButton(container, compatibleWeapon, vData, repo, villagerId);
            }

            // --- 3. TOOL SECTION ---
            string compatibleTool = "";
            if (string.Equals(currentJob, "Miner", StringComparison.OrdinalIgnoreCase) || string.Equals(currentJob, "coalMiner", StringComparison.OrdinalIgnoreCase)) compatibleTool = "pickaxe";
            else if (string.Equals(currentJob, "Builder", StringComparison.OrdinalIgnoreCase) || string.Equals(currentJob, "Blacksmith", StringComparison.OrdinalIgnoreCase)) compatibleTool = "hammer";
            else if (string.Equals(currentJob, "Woodcutter", StringComparison.OrdinalIgnoreCase)) compatibleTool = "woodAxe";

            if (!string.IsNullOrEmpty(compatibleTool)) {
                CreateSectionHeader(container, "Tools");
                CreateEquipButton(container, compatibleTool, vData, repo, villagerId);
            }

            // --- 4. ARMOR SECTION ---
            CreateSectionHeader(container, "Armor");
            CreateEquipButton(container, "leatherArmor", vData, repo, villagerId);
            CreateEquipButton(container, "ironArmor", vData, repo, villagerId);

            // --- 5. UNEQUIP SECTION ---
            bool hasAnyEquipped = !string.IsNullOrEmpty(vData.weaponId) || !string.IsNullOrEmpty(vData.armorId) || !string.IsNullOrEmpty(vData.toolId);
            if (hasAnyEquipped) {
                CreateSectionHeader(container, "Unequip");
                if (!string.IsNullOrEmpty(vData.weaponId)) {
                    var eq = repo?.GetEquipment(vData.weaponId);
                    if (eq != null) CreateUnequipButton(container, "Weapon", eq.displayName, villagerId);
                }
                if (!string.IsNullOrEmpty(vData.toolId)) {
                    var eq = repo?.GetEquipment(vData.toolId);
                    if (eq != null) CreateUnequipButton(container, "Tool", eq.displayName, villagerId);
                }
                if (!string.IsNullOrEmpty(vData.armorId)) {
                    var eq = repo?.GetEquipment(vData.armorId);
                    if (eq != null) CreateUnequipButton(container, "Armor", eq.displayName, villagerId);
                }
            }

            // Standalone close button
            var cancelBtnGo = new GameObject("Btn_Cancel");
            cancelBtnGo.transform.SetParent(container, false);
            var cancelBtnImg = cancelBtnGo.AddComponent<Image>();
            cancelBtnImg.color = new Color(0.8f, 0.2f, 0.2f);
            var cancelBtn = cancelBtnGo.AddComponent<Button>();
            cancelBtn.navigation = new Navigation { mode = Navigation.Mode.None };
            var cancelLe = cancelBtnGo.AddComponent<LayoutElement>();
            cancelLe.minHeight = 42;

            var cancelTxtGo = new GameObject("Text");
            cancelTxtGo.transform.SetParent(cancelBtnGo.transform, false);
            var cancelTxt = cancelTxtGo.AddComponent<Text>();
            cancelTxt.font = font;
            cancelTxt.text = "Close Panel";
            cancelTxt.alignment = TextAnchor.MiddleCenter;
            cancelTxt.color = Color.white;
            cancelTxt.fontSize = 22;
            var cancelTxtRt = cancelTxtGo.GetComponent<RectTransform>();
            cancelTxtRt.anchorMin = Vector2.zero; cancelTxtRt.anchorMax = Vector2.one; cancelTxtRt.sizeDelta = Vector2.zero;

            cancelBtn.onClick.AddListener(() => {
                CloseJobPanel();
            });

            // --- 6. BLACKSMITH CRAFT PANEL POPULATION ---
            bool isBlacksmith = string.Equals(currentJob, "Blacksmith", StringComparison.OrdinalIgnoreCase);
            
            UnityEngine.Debug.Log($"[Blacksmith UI] Selected villager={vName} job={currentJob}");

            if (isBlacksmith && forges > 0) {
                if (blacksmithCraftPanel == null) {
                    UnityEngine.Debug.LogError("[SelectedVillagerPanel] BlacksmithCraftPanel field reference is missing or not assigned in the scene.");
                    UnityEngine.Debug.Log("[Blacksmith UI] BlacksmithCraftPanel missing from scene.");
                } else {
                    Transform craftContent = GetCraftScrollContent();
                    if (craftContent != null) {
                        // Clear ONLY craft buttons, do NOT destroy BlacksmithCraftPanel or CraftScrollArea
                        foreach (Transform child in craftContent) {
                            Destroy(child.gameObject);
                        }

                        List<string> craftableIds = new List<string> { "sword", "bow", "pickaxe", "hammer", "woodAxe", "leatherArmor", "ironArmor" };

                        foreach (var eqId in craftableIds) {
                            var eqDef = repo?.GetEquipment(eqId);
                            if (eqDef == null) continue;

                            List<string> costStrings = new List<string>();
                            foreach (var cost in eqDef.costs) {
                                costStrings.Add($"{cost.Key}:{cost.Value}");
                            }
                            string costText = string.Join(", ", costStrings);

                            var craftBtnGo = new GameObject("Btn_Craft_" + eqId);
                            craftBtnGo.transform.SetParent(craftContent, false);
                            var craftBtnImg = craftBtnGo.AddComponent<Image>();
                            craftBtnImg.color = new Color(0.5f, 0.3f, 0.7f); // Purple Craft

                            var craftBtn = craftBtnGo.AddComponent<Button>();
                            craftBtn.navigation = new Navigation { mode = Navigation.Mode.None };
                            
                            var craftLe = craftBtnGo.AddComponent<LayoutElement>();
                            craftLe.minHeight = 36;
                            craftLe.preferredHeight = 36;

                            var craftTxtGo = new GameObject("Text");
                            craftTxtGo.transform.SetParent(craftBtnGo.transform, false);
                            var craftTxt = craftTxtGo.AddComponent<Text>();
                            craftTxt.font = font;
                            craftTxt.text = $"Craft {eqDef.displayName} ({costText})";
                            craftTxt.alignment = TextAnchor.MiddleCenter;
                            craftTxt.color = Color.white;
                            craftTxt.fontSize = 16;
                            var craftTxtRt = craftTxtGo.GetComponent<RectTransform>();
                            craftTxtRt.anchorMin = Vector2.zero; craftTxtRt.anchorMax = Vector2.one; craftTxtRt.sizeDelta = Vector2.zero;

                            craftBtn.onClick.AddListener(() => {
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
                    
                    blacksmithCraftPanel.SetActive(true);
                    UnityEngine.Debug.Log("[Blacksmith UI] Should show forge panel=True");
                    UnityEngine.Debug.Log("[Blacksmith UI] BlacksmithCraftPanel active=True");
                }
            } else {
                if (blacksmithCraftPanel != null) {
                    blacksmithCraftPanel.SetActive(false);
                }
                UnityEngine.Debug.Log("[Blacksmith UI] Should show forge panel=False");
            }
        }

        private void CreateEquipButton(Transform container, string eqId, VillagerSnapshot vData, DataRepository repo, string villagerId) {
            var eqDef = repo?.GetEquipment(eqId);
            if (eqDef == null) return;

            bool isEquipped = string.Equals(vData.weaponId, eqId, StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(vData.armorId, eqId, StringComparison.OrdinalIgnoreCase) ||
                              string.Equals(vData.toolId, eqId, StringComparison.OrdinalIgnoreCase);

            if (isEquipped) return;

            int stockCount = 0;
            var backendInstance = GameServiceLocator.Backend;
            if (backendInstance != null) {
                var backendSnap = backendInstance.GetSnapshot();
                if (backendSnap != null && backendSnap.equipmentStock != null) {
                    var stack = backendSnap.equipmentStock.Find(s => s.equipmentId.Equals(eqId, StringComparison.OrdinalIgnoreCase));
                    if (stack != null) stockCount = stack.count;
                }
            }

            string btnText = $"Equip {eqDef.displayName} (Stock: {stockCount})";
            Color btnColor = (stockCount > 0) ? new Color(0.2f, 0.6f, 0.4f) : new Color(0.5f, 0.5f, 0.5f);
            string slotName = eqDef.slot;

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
            if (txt.font == null) txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            txt.text = btnText;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.color = Color.white;
            txt.fontSize = 18;
            var txtRt = txtGo.GetComponent<RectTransform>();
            txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one; txtRt.sizeDelta = Vector2.zero;

            btn.onClick.AddListener(() => {
                UnityEngine.Debug.Log($"[EQUIP_CMD_TRIGGER] villager={villagerId} slot={slotName} id={eqId}");
                TownInteractionController.Instance?.ExecuteCommand(new EquipVillagerEquipmentCommand {
                    villagerId = villagerId,
                    slot = slotName,
                    equipmentId = eqId
                });
                TownInteractionController.Instance?.RefreshUI();
                CloseJobPanel();
            });
        }

        private void CreateUnequipButton(Transform container, string slotName, string displayName, string villagerId) {
            var goBtn = new GameObject("Btn_Unequip_" + slotName);
            goBtn.transform.SetParent(container, false);
            var btnImg = goBtn.AddComponent<Image>();
            btnImg.color = new Color(0.7f, 0.4f, 0.1f);

            var btn = goBtn.AddComponent<Button>();
            btn.navigation = new Navigation { mode = Navigation.Mode.None };
            
            var le = goBtn.AddComponent<LayoutElement>();
            le.minHeight = 36;

            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(goBtn.transform, false);
            var txt = txtGo.AddComponent<Text>();
            txt.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            if (txt.font == null) txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            txt.text = $"Unequip {displayName}";
            txt.alignment = TextAnchor.MiddleCenter;
            txt.color = Color.white;
            txt.fontSize = 18;
            var txtRt = txtGo.GetComponent<RectTransform>();
            txtRt.anchorMin = Vector2.zero; txtRt.anchorMax = Vector2.one; txtRt.sizeDelta = Vector2.zero;

            btn.onClick.AddListener(() => {
                UnityEngine.Debug.Log($"[EQUIP_CMD_TRIGGER] villager={villagerId} slot={slotName} id=");
                TownInteractionController.Instance?.ExecuteCommand(new EquipVillagerEquipmentCommand {
                    villagerId = villagerId,
                    slot = slotName,
                    equipmentId = ""
                });
                TownInteractionController.Instance?.RefreshUI();
                CloseJobPanel();
            });
        }
    }
}
