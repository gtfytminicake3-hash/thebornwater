import sys

file_path = r"D:\Tinh\TheBonwater\Assets\_Project\Scripts\Editor\RebuildSceneGenerator.cs"

with open(file_path, "r", encoding="utf-8") as f:
    content = f.read()

replacement = """            // --- 3. HUD ROOT ---
            var hudRootGo = new GameObject("HUDRoot");
            hudRootGo.transform.SetParent(safeAreaGo.transform, false);
            var hudRect = hudRootGo.AddComponent<RectTransform>();
            hudRect.anchorMin = Vector2.zero; hudRect.anchorMax = Vector2.one;
            hudRect.sizeDelta = Vector2.zero;
            
            var uiManager = hudRootGo.AddComponent<GameplayUIManager>();

            // DebugPanel Toggle
            var btnToggleDebug = CreateButton(hudRootGo.transform, "DEV TOOLS", new Vector2(-120, -50), new Vector2(100, 40));
            var toggleRect = btnToggleDebug.GetComponent<RectTransform>();
            toggleRect.anchorMin = new Vector2(1, 1); toggleRect.anchorMax = new Vector2(1, 1);

            // --- 4. DEBUG PANEL ---
            var debugPanel = new GameObject("DebugPanel");
            debugPanel.transform.SetParent(hudRootGo.transform, false);
            var debugRect = debugPanel.AddComponent<RectTransform>();
            debugRect.anchorMin = new Vector2(1, 0); debugRect.anchorMax = new Vector2(1, 1);
            debugRect.sizeDelta = new Vector2(250, 0);
            debugRect.anchoredPosition = new Vector2(-125, 0);
            var debugImg = debugPanel.AddComponent<Image>();
            debugImg.color = new Color(0, 0, 0, 0.7f);
            debugPanel.SetActive(false); // Hidden by default

            btnToggleDebug.GetComponent<Button>().onClick.AddListener(() => {
                debugPanel.SetActive(!debugPanel.activeSelf);
            });

            int dbgY = -150;
            controller.btnAssignWorker = CreateButton(debugPanel.transform, "ASSIGN JOB", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;
            controller.btnSelectVillager = CreateButton(debugPanel.transform, "SELECT NEXT VILLAGER", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;
            controller.btnSave = CreateButton(debugPanel.transform, "SAVE", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;
            controller.btnLoad = CreateButton(debugPanel.transform, "LOAD", new Vector2(0, dbgY), new Vector2(200, 40)).GetComponent<Button>(); dbgY -= 60;

            // --- 5. TOP PANEL (HUD) ---
            var topPanel = new GameObject("TopResourceBar");
            topPanel.transform.SetParent(hudRootGo.transform, false);
            var topRect = topPanel.AddComponent<RectTransform>();
            topRect.anchorMin = new Vector2(0, 1); topRect.anchorMax = new Vector2(1, 1);
            topRect.sizeDelta = new Vector2(0, 60); topRect.anchoredPosition = new Vector2(0, -30);
            var topImg = topPanel.AddComponent<Image>(); topImg.color = new Color(0, 0, 0, 0.7f);

            var resView = topPanel.AddComponent<TopResourceBarView>();
            resView.txtResources = CreateText(topPanel.transform, "DAY 1 - AFTERNOON\nWOOD: 100 / 500    FOOD: 50 / 200    IRON: 0 / 100", new Vector2(0, 0), 22, new Vector2(1000, 60)).GetComponent<Text>();
            uiManager.topResourceBar = resView;

            // --- 6. LEFT PANEL (HUD) ---
            var leftPanel = new GameObject("LeftStatusPanel");
            leftPanel.transform.SetParent(hudRootGo.transform, false);
            var leftRect = leftPanel.AddComponent<RectTransform>();
            leftRect.anchorMin = new Vector2(0, 0); leftRect.anchorMax = new Vector2(0, 1);
            leftRect.sizeDelta = new Vector2(200, -60); leftRect.anchoredPosition = new Vector2(100, 0);
            var leftImg = leftPanel.AddComponent<Image>(); leftImg.color = new Color(0, 0, 0, 0.4f);

            var leftStatus = leftPanel.AddComponent<LeftStatusPanelView>();
            leftStatus.txtStatus = CreateText(leftPanel.transform, "STATUS", new Vector2(0, 0), 16, new Vector2(180, 0)).GetComponent<Text>();
            var leftTxtRect = leftStatus.txtStatus.GetComponent<RectTransform>();
            leftTxtRect.anchorMin = Vector2.zero; leftTxtRect.anchorMax = Vector2.one; leftTxtRect.sizeDelta = Vector2.zero;
            leftStatus.txtStatus.alignment = TextAnchor.UpperLeft;
            uiManager.leftStatusPanel = leftStatus;

            // --- 7. BOTTOM ACTION BAR ---
            var bottomPanel = new GameObject("BottomActionBar");
            bottomPanel.transform.SetParent(hudRootGo.transform, false);
            var bottomRect = bottomPanel.AddComponent<RectTransform>();
            bottomRect.anchorMin = new Vector2(0.3f, 0); bottomRect.anchorMax = new Vector2(0.7f, 0);
            bottomRect.sizeDelta = new Vector2(0, 100); bottomRect.anchoredPosition = new Vector2(0, 50);

            var btnOpenBuildMenu = new GameObject("BtnOpenBuildMenu");
            btnOpenBuildMenu.transform.SetParent(bottomPanel.transform, false);
            var btnBuildRect = btnOpenBuildMenu.AddComponent<RectTransform>();
            btnBuildRect.sizeDelta = new Vector2(80, 80);
            btnBuildRect.anchoredPosition = new Vector2(-60, 0);
            var btnBuildImg = btnOpenBuildMenu.AddComponent<Image>();
            
            var buildSp = LoadDecodedSprite("Assets/_Project/ImportedDecoded/Texture2D/build3.png");
            if (buildSp != null) { btnBuildImg.sprite = buildSp; btnBuildImg.color = Color.white; }
            else { btnBuildImg.color = Color.gray; }
            var btnBuildCmp = btnOpenBuildMenu.AddComponent<Button>();

            var btnNextPhaseGo = CreateButton(bottomPanel.transform, "Next Phase", new Vector2(60, 0), new Vector2(120, 50));
            var nextTxt = btnNextPhaseGo.GetComponentInChildren<Text>();
            nextTxt.fontSize = 16;
            var tooltipGo = CreateText(bottomPanel.transform, "TEMPORARY_DEV_UI: Next Phase", new Vector2(60, -35), 10, new Vector2(150, 20));
            tooltipGo.GetComponent<Text>().color = Color.yellow;
            controller.btnNextPhase = btnNextPhaseGo.GetComponent<Button>();

            // --- 8. BUILD MENU POPUP (HUD) ---
            var buildMenuPanel = new GameObject("BuildMenuPanel");
            buildMenuPanel.transform.SetParent(hudRootGo.transform, false);
            var menuRect = buildMenuPanel.AddComponent<RectTransform>();
            menuRect.anchorMin = new Vector2(0.5f, 0); menuRect.anchorMax = new Vector2(0.5f, 0);
            menuRect.sizeDelta = new Vector2(400, 300);
            menuRect.anchoredPosition = new Vector2(0, 250);
            var menuImg = buildMenuPanel.AddComponent<Image>();
            menuImg.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
            buildMenuPanel.SetActive(false); // Hidden initially

            var bmv = buildMenuPanel.AddComponent<BuildMenuPanelView>();
            uiManager.buildMenuPanel = bmv;

            var txtMenuTitle = CreateText(buildMenuPanel.transform, "BUILD MENU", new Vector2(0, 120), 20, new Vector2(300, 40));
            var btnCloseMenu = CreateButton(buildMenuPanel.transform, "X", new Vector2(160, 120), new Vector2(40, 40));
            btnCloseMenu.GetComponent<Button>().onClick.AddListener(() => buildMenuPanel.SetActive(false));
            btnBuildCmp.onClick.AddListener(() => buildMenuPanel.SetActive(!buildMenuPanel.activeSelf));

            var contentRoot = new GameObject("ContentRoot");
            contentRoot.transform.SetParent(buildMenuPanel.transform, false);
            var contentRect = contentRoot.AddComponent<RectTransform>();
            contentRect.anchorMin = new Vector2(0, 0); contentRect.anchorMax = new Vector2(1, 1);
            contentRect.offsetMax = new Vector2(0, -60);
            var vlg = contentRoot.AddComponent<VerticalLayoutGroup>();
            vlg.childAlignment = TextAnchor.UpperCenter;
            vlg.spacing = 10;
            vlg.childControlHeight = false; vlg.childControlWidth = false;
            bmv.contentRoot = contentRoot.transform;

            // --- 9. CONSTRUCTION PANEL ---
            var consPanel = new GameObject("ConstructionPanel");
            consPanel.transform.SetParent(hudRootGo.transform, false);
            var consRect = consPanel.AddComponent<RectTransform>();
            consRect.anchorMin = new Vector2(1, 0.5f); consRect.anchorMax = new Vector2(1, 0.5f);
            consRect.sizeDelta = new Vector2(250, 300); consRect.anchoredPosition = new Vector2(-125, 0);
            var consImg = consPanel.AddComponent<Image>(); consImg.color = new Color(0, 0, 0, 0.4f);
            var consView = consPanel.AddComponent<ConstructionPanelView>();
            consView.txtTasks = CreateText(consPanel.transform, "CONSTRUCTION TASKS", new Vector2(0, 0), 16, new Vector2(230, 280)).GetComponent<Text>();
            consView.txtTasks.alignment = TextAnchor.UpperLeft;
            uiManager.constructionPanel = consView;

            // --- 10. SELECTED VILLAGER PANEL ---
            var selVillPanel = new GameObject("SelectedVillagerPanel");
            selVillPanel.transform.SetParent(hudRootGo.transform, false);
            var selRect = selVillPanel.AddComponent<RectTransform>();
            selRect.anchorMin = new Vector2(1, 0); selRect.anchorMax = new Vector2(1, 0);
            selRect.sizeDelta = new Vector2(300, 200); selRect.anchoredPosition = new Vector2(-150, 100);
            var selImg = selVillPanel.AddComponent<Image>(); selImg.color = new Color(0.1f, 0.2f, 0.3f, 0.8f);
            var selView = selVillPanel.AddComponent<SelectedVillagerPanelView>();
            selView.txtInfo = CreateText(selVillPanel.transform, "INFO", new Vector2(0, 40), 18, new Vector2(280, 100)).GetComponent<Text>();
            
            selView.btnAssignBuilder = CreateButton(selVillPanel.transform, "Assign Builder", new Vector2(-70, -30), new Vector2(130, 30)).GetComponent<Button>();
            selView.btnAssignBuilder.GetComponentInChildren<Text>().fontSize = 12;
            selView.btnAssignWoodcutter = CreateButton(selVillPanel.transform, "Assign Woodcutter", new Vector2(70, -30), new Vector2(130, 30)).GetComponent<Button>();
            selView.btnAssignWoodcutter.GetComponentInChildren<Text>().fontSize = 12;
            selView.btnAssignGuard = CreateButton(selVillPanel.transform, "Assign Guard", new Vector2(-70, -70), new Vector2(130, 30)).GetComponent<Button>();
            selView.btnAssignGuard.GetComponentInChildren<Text>().fontSize = 12;
            selView.btnClearIdle = CreateButton(selVillPanel.transform, "Clear/Idle", new Vector2(70, -70), new Vector2(130, 30)).GetComponent<Button>();
            selView.btnClearIdle.GetComponentInChildren<Text>().fontSize = 12;

            uiManager.selectedVillagerPanel = selView;

            // --- 11. EVENT LOG (HUD) ---
            var logPanel = new GameObject("EventLogPanel");
            logPanel.transform.SetParent(hudRootGo.transform, false);
            var logRect = logPanel.AddComponent<RectTransform>();
            logRect.anchorMin = new Vector2(1, 0); logRect.anchorMax = new Vector2(1, 0);
            logRect.sizeDelta = new Vector2(300, 150); logRect.anchoredPosition = new Vector2(-150, 275);
            var tView = logPanel.AddComponent<TaskLogView>();
            tView.txtLog = CreateText(logPanel.transform, "Event Log...", new Vector2(0, 0), 14, new Vector2(280, 130)).GetComponent<Text>();
            tView.txtLog.alignment = TextAnchor.LowerLeft;
            uiManager.eventLogPanel = tView;

            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");
            UnityEngine.Debug.Log("Core Loop TownScene generated successfully!");"""

start_idx = content.find('            // --- 3. HUD ROOT ---')
end_idx = content.find('            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");') + len('            EditorSceneManager.SaveScene(townScene, basePath + "TownScene.unity");\n            UnityEngine.Debug.Log("Core Loop TownScene generated successfully!");')

if start_idx != -1 and end_idx != -1:
    new_content = content[:start_idx] + replacement + content[end_idx:]
    with open(file_path, "w", encoding="utf-8") as f:
        f.write(new_content)
    print("Successfully replaced.")
else:
    print(f"Could not find markers. Start={start_idx}, End={end_idx}")
