#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

namespace TheBonwater.Rebuild.Editor
{
    public static class EnsureSceneOwnedUIPanels
    {
        private static readonly string ScenePath = "Assets/_Project/Scenes/TownScene.unity";

        [MenuItem("Tools/TheBonwater/Ensure Scene-Owned UI Panels")]
        public static void Execute()
        {
            // 1. Ensure TownScene is open
            if (!UnityEngine.SceneManagement.SceneManager.GetActiveScene().name.StartsWith("TownScene"))
            {
                bool opened = false;
                if (File.Exists(ScenePath))
                {
                    EditorSceneManager.OpenScene(ScenePath);
                    opened = true;
                }
                if (!opened)
                {
                    if (!Application.isBatchMode)
                    {
                        EditorUtility.DisplayDialog("Error", "Could not find or open TownScene.unity at: " + ScenePath, "OK");
                    }
                    return;
                }
            }

            // 2. Find or create TownUIRoot
            var townUIRootGo = GameObject.Find("TownUIRoot");
            if (townUIRootGo == null)
            {
                townUIRootGo = CreateCanvas("TownUIRoot");
                UnityEngine.Debug.Log("[RECOVERY] Created missing TownUIRoot");
            }

            // 3. Find or create SafeAreaRoot under TownUIRoot
            var safeAreaTransform = townUIRootGo.transform.Find("SafeAreaRoot");
            GameObject safeAreaGo;
            if (safeAreaTransform == null)
            {
                safeAreaGo = new GameObject("SafeAreaRoot");
                safeAreaGo.transform.SetParent(townUIRootGo.transform, false);
                var safeRect = safeAreaGo.AddComponent<RectTransform>();
                safeRect.anchorMin = Vector2.zero;
                safeRect.anchorMax = Vector2.one;
                safeRect.sizeDelta = Vector2.zero;
                safeRect.pivot = new Vector2(0.5f, 0.5f);
                safeRect.anchoredPosition = Vector2.zero;
                UnityEngine.Debug.Log("[RECOVERY] Created missing SafeAreaRoot");
            }
            else
            {
                safeAreaGo = safeAreaTransform.gameObject;
            }

            // 4. Find HUDRoot in the scene
            var hudRootGo = GameObject.Find("HUDRoot");
            if (hudRootGo != null)
            {
                var parentName = hudRootGo.transform.parent != null ? hudRootGo.transform.parent.name : "null";
                UnityEngine.Debug.Log($"[RECOVERY] Preserved existing HUDRoot parent={parentName}");
                
                // Ensure GameplayUIManager is attached
                if (hudRootGo.GetComponent<GameplayUIManager>() == null)
                {
                    hudRootGo.AddComponent<GameplayUIManager>();
                    UnityEngine.Debug.Log("[RECOVERY] Added GameplayUIManager component to existing HUDRoot");
                }
            }
            else
            {
                // Recreate HUDRoot directly under SafeAreaRoot
                hudRootGo = new GameObject("HUDRoot");
                hudRootGo.transform.SetParent(safeAreaGo.transform, false);
                var hudRect = hudRootGo.AddComponent<RectTransform>();
                hudRect.anchorMin = Vector2.zero;
                hudRect.anchorMax = Vector2.one;
                hudRect.sizeDelta = Vector2.zero;
                hudRect.pivot = new Vector2(0.5f, 0.5f);
                hudRect.anchoredPosition = Vector2.zero;
                hudRootGo.AddComponent<GameplayUIManager>();
                UnityEngine.Debug.Log("[RECOVERY] Created missing HUDRoot under SafeAreaRoot");
            }

            var uiManager = hudRootGo.GetComponent<GameplayUIManager>();

            int createdCount = 0;
            int preservedCount = 0;

            // Helper to get or default font
            Font font = GetDefaultFont();

            // --- 5. TOP RESOURCE BAR ---
            var topBarGo = FindChildByNames(hudRootGo.transform, new[] { "TopResourceBar" });
            if (topBarGo == null)
            {
                topBarGo = new GameObject("TopResourceBar");
                topBarGo.transform.SetParent(hudRootGo.transform, false);
                var rect = topBarGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0, 1);
                rect.anchorMax = new Vector2(1, 1);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(0, 60);
                rect.anchoredPosition = new Vector2(0, -30);

                var img = topBarGo.AddComponent<Image>();
                img.color = new Color(0, 0, 0, 0.7f);

                var view = topBarGo.AddComponent<TopResourceBarView>();
                var txtGo = CreateTextObject(topBarGo.transform, "Text", "DAY 1 - AFTERNOON\nWOOD: 100 / 500    FOOD: 50 / 200    IRON: 0 / 100", 22, new Vector2(1000, 60), Vector2.zero, font);
                view.txtResources = txtGo.GetComponent<Text>();

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing TopResourceBar");
            }
            else
            {
                // Ensure components
                var view = topBarGo.GetComponent<TopResourceBarView>();
                if (view == null) view = topBarGo.AddComponent<TopResourceBarView>();
                
                var txtTransform = topBarGo.transform.Find("Text");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(topBarGo.transform, "Text", "DAY 1 - AFTERNOON\nWOOD: 100 / 500    FOOD: 50 / 200    IRON: 0 / 100", 22, new Vector2(1000, 60), Vector2.zero, font);
                    view.txtResources = txtGo.GetComponent<Text>();
                }
                else if (view.txtResources == null)
                {
                    view.txtResources = txtTransform.GetComponent<Text>();
                }
                preservedCount++;
            }
            uiManager.topResourceBar = topBarGo.GetComponent<TopResourceBarView>();

            // --- 6. LEFT STATUS PANEL ---
            var leftPanelGo = FindChildByNames(hudRootGo.transform, new[] { "LeftStatusPanel" });
            if (leftPanelGo == null)
            {
                leftPanelGo = new GameObject("LeftStatusPanel");
                leftPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = leftPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0, 0);
                rect.anchorMax = new Vector2(0, 1);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(200, -60);
                rect.anchoredPosition = new Vector2(100, 0);

                var img = leftPanelGo.AddComponent<Image>();
                img.color = new Color(0, 0, 0, 0.4f);

                var view = leftPanelGo.AddComponent<LeftStatusPanelView>();
                var txtGo = CreateTextObject(leftPanelGo.transform, "Text", "STATUS", 16, Vector2.zero, Vector2.zero, font);
                var txtRect = txtGo.GetComponent<RectTransform>();
                txtRect.anchorMin = Vector2.zero;
                txtRect.anchorMax = Vector2.one;
                txtRect.sizeDelta = Vector2.zero;
                view.txtStatus = txtGo.GetComponent<Text>();
                view.txtStatus.alignment = TextAnchor.UpperLeft;

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing LeftStatusPanel");
            }
            else
            {
                var view = leftPanelGo.GetComponent<LeftStatusPanelView>();
                if (view == null) view = leftPanelGo.AddComponent<LeftStatusPanelView>();

                var txtTransform = leftPanelGo.transform.Find("Text");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(leftPanelGo.transform, "Text", "STATUS", 16, Vector2.zero, Vector2.zero, font);
                    var txtRect = txtGo.GetComponent<RectTransform>();
                    txtRect.anchorMin = Vector2.zero;
                    txtRect.anchorMax = Vector2.one;
                    txtRect.sizeDelta = Vector2.zero;
                    view.txtStatus = txtGo.GetComponent<Text>();
                    view.txtStatus.alignment = TextAnchor.UpperLeft;
                }
                else if (view.txtStatus == null)
                {
                    view.txtStatus = txtTransform.GetComponent<Text>();
                }
                preservedCount++;
            }
            uiManager.leftStatusPanel = leftPanelGo.GetComponent<LeftStatusPanelView>();

            // --- 7. BUILD MENU PANEL ---
            // "Main panels and viewports must be scene-owned and visible/editable in Edit Mode. Runtime may only populate dynamic child content."
            var buildMenuGo = FindChildByNames(hudRootGo.transform, new[] { "BuildMenuPanel" });
            if (buildMenuGo == null)
            {
                buildMenuGo = new GameObject("BuildMenuPanel");
                buildMenuGo.transform.SetParent(hudRootGo.transform, false);
                var rect = buildMenuGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 0.5f);
                rect.anchorMax = new Vector2(0.5f, 0.5f);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(320, 300);
                rect.anchoredPosition = new Vector2(0, 0);

                var img = buildMenuGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
                img.raycastTarget = true;

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing BuildMenuPanel");
            }
            else
            {
                preservedCount++;
            }

            var bmView = buildMenuGo.GetComponent<BuildMenuPanelView>();
            if (bmView == null) bmView = buildMenuGo.AddComponent<BuildMenuPanelView>();

            // Ensure BuildMenuPanel image color is visible and semi-transparent
            var panelImg = buildMenuGo.GetComponent<Image>();
            if (panelImg == null) panelImg = buildMenuGo.AddComponent<Image>();
            panelImg.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
            panelImg.raycastTarget = true;

            // Ensure HeaderCloseArea exists
            var headerTransform = buildMenuGo.transform.Find("HeaderCloseArea");
            if (headerTransform == null)
            {
                var headerGo = new GameObject("HeaderCloseArea");
                headerGo.transform.SetParent(buildMenuGo.transform, false);
                var hRect = headerGo.AddComponent<RectTransform>();
                hRect.anchorMin = new Vector2(0, 1);
                hRect.anchorMax = new Vector2(1, 1);
                hRect.pivot = new Vector2(0.5f, 1f);
                hRect.sizeDelta = new Vector2(0, 48);
                hRect.anchoredPosition = new Vector2(0, 0);
                var hImg = headerGo.AddComponent<Image>();
                hImg.color = new Color(0.15f, 0.15f, 0.15f, 1f);
                hImg.raycastTarget = true;

                CreateTextObject(headerGo.transform, "Text", "BUILD MENU", 20, new Vector2(200, 40), new Vector2(-20, -24), font);
                CreateButtonObject(headerGo.transform, "BtnCloseBuildMenu", "X", new Vector2(140, -24), new Vector2(36, 36), font);
            }

            // Ensure BuildMenuViewport exists under BuildMenuPanel
            var viewportTransform = buildMenuGo.transform.Find("BuildMenuViewport");
            GameObject viewportGo;
            if (viewportTransform == null)
            {
                viewportGo = new GameObject("BuildMenuViewport");
                viewportGo.transform.SetParent(buildMenuGo.transform, false);
                var vpRect = viewportGo.AddComponent<RectTransform>();
                vpRect.anchorMin = new Vector2(0, 1);
                vpRect.anchorMax = new Vector2(1, 1);
                vpRect.pivot = new Vector2(0.5f, 1f);
                vpRect.sizeDelta = new Vector2(0, 230);
                vpRect.anchoredPosition = new Vector2(0, -55);
                UnityEngine.Debug.Log("[RECOVERY] Created missing BuildMenuViewport");
            }
            else
            {
                viewportGo = viewportTransform.gameObject;
            }

            // Ensure BuildMenuViewport image background exists so the viewport is visible in Edit Mode
            var vpImg = viewportGo.GetComponent<Image>();
            if (vpImg == null) vpImg = viewportGo.AddComponent<Image>();
            vpImg.color = new Color(0.15f, 0.15f, 0.15f, 0.5f);
            vpImg.raycastTarget = true;

            // Ensure RectMask2D exists on BuildMenuViewport
            var mask = viewportGo.GetComponent<RectMask2D>();
            if (mask == null) mask = viewportGo.AddComponent<RectMask2D>();

            // Ensure ScrollRect exists on BuildMenuViewport
            var scroll = viewportGo.GetComponent<ScrollRect>();
            if (scroll == null) scroll = viewportGo.AddComponent<ScrollRect>();
            scroll.horizontal = false;
            scroll.vertical = true;
            scroll.movementType = ScrollRect.MovementType.Clamped;
            scroll.scrollSensitivity = 25f;
            scroll.decelerationRate = 0.1f;
            scroll.viewport = viewportGo.GetComponent<RectTransform>();

            // Ensure BuildMenuContentRoot exists
            var contentTransform = viewportGo.transform.Find("BuildMenuContentRoot");
            if (contentTransform == null)
            {
                contentTransform = buildMenuGo.transform.Find("BuildMenuContentRoot");
                if (contentTransform != null)
                {
                    // Reparent existing ContentRoot under viewport
                    contentTransform.SetParent(viewportGo.transform, false);
                    UnityEngine.Debug.Log("[RECOVERY] Reparented BuildMenuContentRoot under BuildMenuViewport");
                }
            }

            GameObject contentRootGo;
            if (contentTransform == null)
            {
                contentRootGo = new GameObject("BuildMenuContentRoot");
                contentRootGo.transform.SetParent(viewportGo.transform, false);
                var cRect = contentRootGo.AddComponent<RectTransform>();
                cRect.anchorMin = new Vector2(0, 1);
                cRect.anchorMax = new Vector2(1, 1);
                cRect.pivot = new Vector2(0.5f, 1f);
                cRect.sizeDelta = new Vector2(0, 0);
                cRect.anchoredPosition = Vector2.zero;
                contentTransform = contentRootGo.transform;
                UnityEngine.Debug.Log("[RECOVERY] Created missing BuildMenuContentRoot");
            }
            else
            {
                contentRootGo = contentTransform.gameObject;
                if (contentRootGo.transform.parent != viewportGo.transform)
                {
                    contentRootGo.transform.SetParent(viewportGo.transform, false);
                }
            }

            // Ensure ContentRoot has correct RectTransform stretch anchors to work inside scroll view
            var crRect = contentRootGo.GetComponent<RectTransform>();
            crRect.anchorMin = new Vector2(0, 1);
            crRect.anchorMax = new Vector2(1, 1);
            crRect.pivot = new Vector2(0.5f, 1f);
            crRect.anchoredPosition = Vector2.zero;
            crRect.sizeDelta = new Vector2(0, 0);

            // Add auto-layout to ContentRoot if missing
            var vlg = contentRootGo.GetComponent<VerticalLayoutGroup>();
            if (vlg == null) vlg = contentRootGo.AddComponent<VerticalLayoutGroup>();
            vlg.spacing = 6;
            vlg.childControlHeight = true;
            vlg.childForceExpandHeight = false;
            vlg.childControlWidth = true;
            vlg.childForceExpandWidth = true;
            vlg.padding = new RectOffset(10, 10, 4, 4);

            var csf = contentRootGo.GetComponent<ContentSizeFitter>();
            if (csf == null) csf = contentRootGo.AddComponent<ContentSizeFitter>();
            csf.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            csf.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;

            // Wire ScrollRect references
            scroll.content = crRect;

            // Wire View's contentRoot
            bmView.contentRoot = contentTransform;

            // Validate layout and apply safe default repair if invalid/invisible
            if (!Application.isPlaying)
            {
                bool needsRepair = false;

                // Condition 1: BuildMenuPanel is inactive
                if (!buildMenuGo.activeSelf)
                {
                    needsRepair = true;
                    UnityEngine.Debug.LogWarning("[EnsureSceneOwnedUIPanels] BuildMenuPanel activeSelf is false (hidden); forcing to active.");
                }

                // Condition 2: BuildMenuPanel size is invalid
                var bmRect = buildMenuGo.GetComponent<RectTransform>();
                if (bmRect != null && (bmRect.sizeDelta.x <= 1f || bmRect.sizeDelta.y <= 1f))
                {
                    needsRepair = true;
                }

                // Condition 3: Viewport is inactive or has invalid size
                var vpRect = viewportGo.GetComponent<RectTransform>();
                if (!viewportGo.activeSelf || (vpRect != null && vpRect.sizeDelta.y <= 1f))
                {
                    needsRepair = true;
                }

                // Condition 4: ContentRoot is inactive or has wrong pivot (should anchor at top)
                var crRectLocal = contentRootGo.GetComponent<RectTransform>();
                if (!contentRootGo.activeSelf || (crRectLocal != null && crRectLocal.pivot.y < 0.99f))
                {
                    needsRepair = true;
                }

                if (needsRepair)
                {
                    UnityEngine.Debug.LogWarning("[EnsureSceneOwnedUIPanels] BuildMenu edit preview layout was invalid; applying safe visible default.");

                    // 1. Repair BuildMenuPanel
                    buildMenuGo.SetActive(true);
                    if (bmRect != null)
                    {
                        bmRect.anchorMin = new Vector2(0.5f, 0.5f);
                        bmRect.anchorMax = new Vector2(0.5f, 0.5f);
                        bmRect.pivot = new Vector2(0.5f, 0.5f);
                        bmRect.sizeDelta = new Vector2(320, 300);
                        bmRect.anchoredPosition = new Vector2(0, 0);
                        bmRect.localScale = Vector3.one;
                    }

                    panelImg = buildMenuGo.GetComponent<Image>();
                    if (panelImg != null)
                    {
                        panelImg.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
                        panelImg.enabled = true;
                    }

                    // 2. Repair BuildMenuViewport
                    viewportGo.SetActive(true);
                    if (vpRect != null)
                    {
                        vpRect.anchorMin = new Vector2(0, 1);
                        vpRect.anchorMax = new Vector2(1, 1);
                        vpRect.pivot = new Vector2(0.5f, 1f);
                        vpRect.sizeDelta = new Vector2(0, 230);
                        vpRect.anchoredPosition = new Vector2(0, -55);
                        vpRect.localScale = Vector3.one;
                    }

                    vpImg = viewportGo.GetComponent<Image>();
                    if (vpImg != null)
                    {
                        vpImg.color = new Color(0.15f, 0.15f, 0.15f, 0.5f);
                        vpImg.enabled = true;
                    }

                    // 3. Repair BuildMenuContentRoot
                    contentRootGo.SetActive(true);
                    if (crRectLocal != null)
                    {
                        crRectLocal.anchorMin = new Vector2(0, 1);
                        crRectLocal.anchorMax = new Vector2(1, 1);
                        crRectLocal.pivot = new Vector2(0.5f, 1f);
                        crRectLocal.anchoredPosition = Vector2.zero;
                        crRectLocal.sizeDelta = new Vector2(0, 0);
                        crRectLocal.localScale = Vector3.one;
                    }

                    // Ensure ScrollRect is wired
                    if (scroll != null)
                    {
                        scroll.viewport = vpRect;
                        scroll.content = crRectLocal;
                    }
                }
                else
                {
                    // Always make sure they are active in Edit Mode
                    buildMenuGo.SetActive(true);
                    viewportGo.SetActive(true);
                    contentRootGo.SetActive(true);
                }
            }

            // Create Editor Preview Placeholders in Edit Mode
            if (!Application.isPlaying)
            {
                // Clear old EditorPreview_* rows first to avoid duplicates or blocking
                var toDestroy = new System.Collections.Generic.List<GameObject>();
                foreach (Transform child in contentRootGo.transform)
                {
                    if (child != null && child.name.StartsWith("EditorPreview_"))
                    {
                        toDestroy.Add(child.gameObject);
                    }
                }
                foreach (var childGo in toDestroy)
                {
                    Object.DestroyImmediate(childGo);
                }

                // Create a local repo instance for retrieving correct definitions
                var repo = new TheBonwater.Rebuild.Data.DataRepository();
                repo.LoadAll();

                // Define preview items: (Name, BuildingId, IsUpgrade, StatusText, StatusColor)
                var previewItems = new[]
                {
                    (name: "EditorPreview_Build_Hut", bId: "hut", isUpgrade: false, status: "Available", statusColor: Color.green),
                    (name: "EditorPreview_Build_Storage", bId: "storage", isUpgrade: false, status: "Available", statusColor: Color.green),
                    (name: "EditorPreview_Build_GuardTower", bId: "guardTower", isUpgrade: false, status: "Not enough resources", statusColor: Color.red),
                    (name: "EditorPreview_Build_BlacksmithForge", bId: "blacksmithsForge", isUpgrade: false, status: "Not enough resources", statusColor: Color.red),
                    (name: "EditorPreview_Upgrade_HutLv2", bId: "hut", isUpgrade: true, status: "Preview / Needs completed Hut", statusColor: new Color(0.7f, 0.7f, 0.7f)),
                    (name: "EditorPreview_Upgrade_StorageLv2", bId: "storage", isUpgrade: true, status: "Preview / Needs completed Storage", statusColor: new Color(0.7f, 0.7f, 0.7f))
                };

                foreach (var item in previewItems)
                {
                    // Get display details
                    string displayName = "";
                    string costText = "";

                    if (item.isUpgrade)
                    {
                        var bdef = repo.GetBuilding(item.bId);
                        displayName = item.bId == "hut" ? "Upgrade Hut Lv2" : "Upgrade Storage Lv2";
                        if (bdef != null && bdef.costs != null)
                        {
                            var costParts = new System.Collections.Generic.List<string>();
                            foreach (var kvp in bdef.costs)
                            {
                                costParts.Add($"{System.Char.ToUpper(kvp.Key[0]) + kvp.Key.Substring(1)}: {kvp.Value * 2}");
                            }
                            costText = string.Join(", ", costParts);
                        }
                    }
                    else
                    {
                        displayName = repo.GetBuilding(item.bId)?.displayName ?? item.bId;
                        costText = EditorFormatBuildingCost(repo, item.bId);
                    }

                    // Create icon if mapping exists
                    string iconAssetId = null;
                    if (repo.BuildMenu != null && repo.BuildMenu.menuItems != null)
                    {
                        var mi = repo.BuildMenu.menuItems.Find(x => x.buildingId == item.bId);
                        if (mi != null) iconAssetId = mi.iconAssetId;
                    }

                    string assetPath = null;
                    if (!string.IsNullOrEmpty(iconAssetId) && repo.AssetMap != null && repo.AssetMap.assets != null && repo.AssetMap.assets.ContainsKey(iconAssetId))
                    {
                        assetPath = repo.AssetMap.assets[iconAssetId];
                    }

                    Sprite iconSp = BuildMenuRowVisualFactory.LoadSprite(assetPath);
                    if (iconSp == null)
                    {
                        UnityEngine.Debug.LogWarning($"[EnsureSceneOwnedUIPanels] Sprite load failed in Edit Mode for building ID: '{item.bId}'. " +
                            $"Expected asset key/path: '{assetPath}'. " +
                            $"Attempted loading methods: System.IO.File and AssetDatabase. " +
                            $"Fallback used: solid dark-gray icon background.");
                    }

                    // Use the shared visual factory to build exactly identical UI rows
                    BuildMenuRowVisualFactory.CreateRow(
                        contentRootGo.transform,
                        item.name,
                        displayName,
                        costText,
                        item.status,
                        item.statusColor,
                        iconSp,
                        item.isUpgrade,
                        true,
                        font
                    );
                }

                // Force layout rebuild in Edit Mode so VerticalLayoutGroup organizes preview rows immediately
                LayoutRebuilder.ForceRebuildLayoutImmediate(contentRootGo.GetComponent<RectTransform>());
                if (viewportGo != null)
                {
                    LayoutRebuilder.ForceRebuildLayoutImmediate(viewportGo.GetComponent<RectTransform>());
                }
            }

            // Mark the scene dirty to preserve the changes
            if (!Application.isPlaying)
            {
                EditorUtility.SetDirty(buildMenuGo);
                EditorUtility.SetDirty(viewportGo);
                EditorUtility.SetDirty(contentRootGo);
                if (bmView != null) EditorUtility.SetDirty(bmView);
                EditorSceneManager.MarkSceneDirty(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            }

            uiManager.buildMenuPanel = bmView;

            // --- 8. CONSTRUCTION PANEL ---
            var consPanelGo = FindChildByNames(hudRootGo.transform, new[] { "ConstructionPanel", "ConstructionTasksPanel" });
            if (consPanelGo == null)
            {
                consPanelGo = new GameObject("ConstructionPanel");
                consPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = consPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 0.5f);
                rect.anchorMax = new Vector2(1, 0.5f);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(250, 300);
                rect.anchoredPosition = new Vector2(-125, 0);

                var img = consPanelGo.AddComponent<Image>();
                img.color = new Color(0, 0, 0, 0.4f);

                var view = consPanelGo.AddComponent<ConstructionPanelView>();
                var txtGo = CreateTextObject(consPanelGo.transform, "Text", "CONSTRUCTION TASKS", 16, new Vector2(230, 280), Vector2.zero, font);
                view.txtTasks = txtGo.GetComponent<Text>();
                view.txtTasks.alignment = TextAnchor.UpperLeft;

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing ConstructionPanel");
            }
            else
            {
                var view = consPanelGo.GetComponent<ConstructionPanelView>();
                if (view == null) view = consPanelGo.AddComponent<ConstructionPanelView>();

                var txtTransform = consPanelGo.transform.Find("Text");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(consPanelGo.transform, "Text", "CONSTRUCTION TASKS", 16, new Vector2(230, 280), Vector2.zero, font);
                    view.txtTasks = txtGo.GetComponent<Text>();
                    view.txtTasks.alignment = TextAnchor.UpperLeft;
                }
                else if (view.txtTasks == null)
                {
                    view.txtTasks = txtTransform.GetComponent<Text>();
                }
                preservedCount++;
            }
            uiManager.constructionPanel = consPanelGo.GetComponent<ConstructionPanelView>();

            // --- 9. SELECTED VILLAGER PANEL ---
            var selPanelGo = FindChildByNames(hudRootGo.transform, new[] { "SelectedVillagerPanel", "VillagerOptionsPanel", "JobOptionsPanel" });
            if (selPanelGo == null)
            {
                selPanelGo = new GameObject("SelectedVillagerPanel");
                selPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = selPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 0);
                rect.anchorMax = new Vector2(1, 0);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(300, 200);
                rect.anchoredPosition = new Vector2(-150, 100);

                var img = selPanelGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.2f, 0.3f, 0.8f);

                var view = selPanelGo.AddComponent<SelectedVillagerPanelView>();
                var txtGo = CreateTextObject(selPanelGo.transform, "Text", "INFO", 18, new Vector2(280, 100), new Vector2(0, 40), font);
                view.txtInfo = txtGo.GetComponent<Text>();

                var btnGo = CreateButtonObject(selPanelGo.transform, "Assign Worker (TEMP)", "Assign Worker (TEMP)", new Vector2(0, -20), new Vector2(160, 30), font);
                var btnTxt = btnGo.GetComponentInChildren<Text>();
                if (btnTxt != null) btnTxt.fontSize = 12;
                view.btnCycleJobDev = btnGo.GetComponent<Button>();

                var moreGo = CreateTextObject(selPanelGo.transform, "Text", "More job actions: N/A", 12, new Vector2(200, 20), new Vector2(0, -60), font);
                view.txtMoreJobs = moreGo.GetComponent<Text>();

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing SelectedVillagerPanel");
            }
            else
            {
                var view = selPanelGo.GetComponent<SelectedVillagerPanelView>();
                if (view == null) view = selPanelGo.AddComponent<SelectedVillagerPanelView>();

                var infoTransform = selPanelGo.transform.Find("Text");
                if (infoTransform != null && view.txtInfo == null)
                {
                    view.txtInfo = infoTransform.GetComponent<Text>();
                }
                else if (infoTransform == null && view.txtInfo == null)
                {
                    var txtGo = CreateTextObject(selPanelGo.transform, "Text", "INFO", 18, new Vector2(280, 100), new Vector2(0, 40), font);
                    view.txtInfo = txtGo.GetComponent<Text>();
                }

                var btnTransform = selPanelGo.transform.Find("Assign Worker (TEMP)");
                if (btnTransform != null && view.btnCycleJobDev == null)
                {
                    view.btnCycleJobDev = btnTransform.GetComponent<Button>();
                }
                else if (btnTransform == null && view.btnCycleJobDev == null)
                {
                    var btnGo = CreateButtonObject(selPanelGo.transform, "Assign Worker (TEMP)", "Assign Worker (TEMP)", new Vector2(0, -20), new Vector2(160, 30), font);
                    var btnTxt = btnGo.GetComponentInChildren<Text>();
                    if (btnTxt != null) btnTxt.fontSize = 12;
                    view.btnCycleJobDev = btnGo.GetComponent<Button>();
                }

                preservedCount++;
            }
            uiManager.selectedVillagerPanel = selPanelGo.GetComponent<SelectedVillagerPanelView>();

            // Ensure child scroll views exist inside SelectedVillagerPanel in Edit Mode
            bool wasMissing = false;
            bool wasInvalid = false;

            var optionsScrollGo = selPanelGo.transform.Find("OptionsScrollArea");
            if (optionsScrollGo == null)
            {
                wasMissing = true;
                var osGo = new GameObject("OptionsScrollArea");
                osGo.transform.SetParent(selPanelGo.transform, false);
                var rt = osGo.AddComponent<RectTransform>();
                rt.anchorMin = new Vector2(0, 0);
                rt.anchorMax = new Vector2(1, 0);
                rt.pivot = new Vector2(0.5f, 0f);
                rt.anchoredPosition = new Vector2(0, 10);
                rt.sizeDelta = new Vector2(-20, 85);

                optionsScrollGo = osGo.transform;
            }
            else
            {
                var rt = optionsScrollGo.GetComponent<RectTransform>();
                if (rt != null)
                {
                    bool invalidRect = rt.sizeDelta.y <= 0f || rt.sizeDelta.x == 0f || 
                                       rt.anchorMin != new Vector2(0, 0) || 
                                       rt.anchorMax != new Vector2(1, 0) ||
                                       rt.pivot != new Vector2(0.5f, 0f) ||
                                       !optionsScrollGo.gameObject.activeSelf;
                    if (invalidRect)
                    {
                        wasInvalid = true;
                        rt.anchorMin = new Vector2(0, 0);
                        rt.anchorMax = new Vector2(1, 0);
                        rt.pivot = new Vector2(0.5f, 0f);
                        rt.anchoredPosition = new Vector2(0, 10);
                        rt.sizeDelta = new Vector2(-20, 85);
                        optionsScrollGo.gameObject.SetActive(true);
                    }
                }
            }

            var optionsScrollRect = optionsScrollGo.GetComponent<ScrollRect>();
            if (optionsScrollRect == null)
            {
                optionsScrollRect = optionsScrollGo.gameObject.AddComponent<ScrollRect>();
            }
            optionsScrollRect.horizontal = false;
            optionsScrollRect.vertical = true;
            optionsScrollRect.movementType = ScrollRect.MovementType.Clamped;
            optionsScrollRect.scrollSensitivity = 25;
            optionsScrollRect.decelerationRate = 0.1f;
            optionsScrollRect.viewport = optionsScrollGo.GetComponent<RectTransform>();

            var optionsMask = optionsScrollGo.GetComponent<RectMask2D>();
            if (optionsMask == null)
            {
                optionsMask = optionsScrollGo.gameObject.AddComponent<RectMask2D>();
            }

            var optionsContentGo = optionsScrollGo.Find("Content");
            if (optionsContentGo == null)
            {
                var contentGo = new GameObject("Content");
                contentGo.transform.SetParent(optionsScrollGo, false);
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

                optionsScrollRect.content = contentRt;
                optionsContentGo = contentGo.transform;
            }
            else
            {
                var contentRt = optionsContentGo.GetComponent<RectTransform>();
                if (contentRt != null)
                {
                    optionsScrollRect.content = contentRt;

                    var layout = optionsContentGo.GetComponent<VerticalLayoutGroup>();
                    if (layout == null)
                    {
                        layout = optionsContentGo.gameObject.AddComponent<VerticalLayoutGroup>();
                        layout.spacing = 6;
                        layout.childControlHeight = true;
                        layout.childForceExpandHeight = false;
                        layout.childControlWidth = true;
                        layout.childForceExpandWidth = true;
                        layout.padding = new RectOffset(10, 10, 4, 4);
                    }
                    var fitter = optionsContentGo.GetComponent<ContentSizeFitter>();
                    if (fitter == null)
                    {
                        fitter = optionsContentGo.gameObject.AddComponent<ContentSizeFitter>();
                        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
                    }
                }
            }

            if (wasMissing)
            {
                UnityEngine.Debug.Log("[SelectedVillager UI] Restored missing OptionsScrollArea.");
            }
            else if (wasInvalid)
            {
                UnityEngine.Debug.Log("[SelectedVillager UI] Repaired invalid OptionsScrollArea layout.");
            }

            // Verify and reconstruct expected children under Content
            string[] expectedNames = new string[] {
                "Header_Jobs",
                "Btn_Builder",
                "Btn_Woodcutter",
                "Btn_Forager",
                "Btn_Farmer",
                "Btn_Iron Miner",
                "Btn_Coal Miner",
                "Btn_Guard",
                "Header_Tools",
                "Btn_Equip_hammer",
                "Btn_Equip_leatherArmor",
                "Btn_Equip_ironArmor",
                "Btn_Cancel"
            };

            foreach (var name in expectedNames)
            {
                Transform found = FindDeepChild(selPanelGo.transform, name);
                if (found != null)
                {
                    if (found.parent != optionsContentGo)
                    {
                        found.SetParent(optionsContentGo, false);
                        UnityEngine.Debug.Log($"[RECOVERY] Reparented existing '{name}' under OptionsScrollArea Content.");
                    }
                }
                else
                {
                    if (name.StartsWith("Header_"))
                    {
                        string title = name.Substring("Header_".Length);
                        CreateEditModeSectionHeader(optionsContentGo, title, font);
                    }
                    else
                    {
                        string label = name.Substring("Btn_".Length);
                        if (name == "Btn_Cancel") label = "Close Panel";
                        else if (name.StartsWith("Btn_Equip_")) {
                            string eqId = name.Substring("Btn_Equip_".Length);
                            string displayName = eqId;
                            if (eqId == "hammer") displayName = "Hammer";
                            else if (eqId == "leatherArmor") displayName = "Leather Armor";
                            else if (eqId == "ironArmor") displayName = "Iron Armor";
                            label = $"Equip {displayName} (Stock: 0)";
                        }
                        CreateEditModeButton(optionsContentGo, name, label, font);
                    }
                }
            }

            UnityEngine.Debug.Log("[SelectedVillager UI] OptionsScrollArea ready.");


            // --- 10. BLACKSMITH CRAFT PANEL ---
            bool blacksmithMissing = false;
            bool blacksmithInvalid = false;

            var blacksmithCraftGo = GameObject.Find("BlacksmithCraftPanel");
            if (blacksmithCraftGo == null)
            {
                blacksmithMissing = true;
                blacksmithCraftGo = new GameObject("BlacksmithCraftPanel");
                blacksmithCraftGo.transform.SetParent(hudRootGo.transform, false);
                var rect = blacksmithCraftGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 0);
                rect.anchorMax = new Vector2(1, 0);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(300, 250);
                rect.anchoredPosition = new Vector2(-460, 125); // default next to SelectedVillagerPanel

                var img = blacksmithCraftGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.1f, 0.15f, 0.9f);

                CreateTextObject(blacksmithCraftGo.transform, "Title", "BLACKSMITH CRAFT", 18, new Vector2(280, 30), new Vector2(0, 100), font);

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing BlacksmithCraftPanel");
            }
            else
            {
                var rect = blacksmithCraftGo.GetComponent<RectTransform>();
                if (rect != null)
                {
                    bool invalidRect = rect.sizeDelta.y <= 0f || rect.sizeDelta.x == 0f ||
                                       rect.anchorMin != new Vector2(1, 0) ||
                                       rect.anchorMax != new Vector2(1, 0) ||
                                       rect.pivot != new Vector2(0.5f, 0.5f);
                    if (invalidRect)
                    {
                        blacksmithInvalid = true;
                        rect.anchorMin = new Vector2(1, 0);
                        rect.anchorMax = new Vector2(1, 0);
                        rect.pivot = new Vector2(0.5f, 0.5f);
                        rect.sizeDelta = new Vector2(300, 250);
                        rect.anchoredPosition = new Vector2(-460, 125);
                    }
                }
                var parentName = blacksmithCraftGo.transform.parent != null ? blacksmithCraftGo.transform.parent.name : "null";
                UnityEngine.Debug.Log($"[RECOVERY] Preserved existing BlacksmithCraftPanel parent={parentName}");
                preservedCount++;
            }

            if (blacksmithMissing)
            {
                UnityEngine.Debug.Log("[Blacksmith UI] Restored missing BlacksmithCraftPanel.");
            }
            else if (blacksmithInvalid)
            {
                UnityEngine.Debug.Log("[Blacksmith UI] Repaired invalid BlacksmithCraftPanel layout.");
            }

            // Ensure child scroll views exist inside BlacksmithCraftPanel in Edit Mode
            var craftScrollGo = blacksmithCraftGo.transform.Find("CraftScrollArea");
            if (craftScrollGo == null)
            {
                var csGo = new GameObject("CraftScrollArea");
                csGo.transform.SetParent(blacksmithCraftGo.transform, false);
                var sRect = csGo.AddComponent<RectTransform>();
                sRect.anchorMin = Vector2.zero;
                sRect.anchorMax = Vector2.one;
                sRect.pivot = new Vector2(0.5f, 0.5f);
                sRect.anchoredPosition = new Vector2(0, -20);
                sRect.sizeDelta = new Vector2(-20, -70);

                craftScrollGo = csGo.transform;
            }

            var craftScrollRect = craftScrollGo.GetComponent<ScrollRect>();
            if (craftScrollRect == null)
            {
                craftScrollRect = craftScrollGo.gameObject.AddComponent<ScrollRect>();
            }
            craftScrollRect.horizontal = false;
            craftScrollRect.vertical = true;
            craftScrollRect.movementType = ScrollRect.MovementType.Clamped;
            craftScrollRect.scrollSensitivity = 25;
            craftScrollRect.viewport = craftScrollGo.GetComponent<RectTransform>();

            var craftMask = craftScrollGo.GetComponent<RectMask2D>();
            if (craftMask == null)
            {
                craftMask = craftScrollGo.gameObject.AddComponent<RectMask2D>();
            }

            var craftContentGo = craftScrollGo.Find("Content");
            if (craftContentGo == null)
            {
                var contentGo = new GameObject("Content");
                contentGo.transform.SetParent(craftScrollGo, false);
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

                craftScrollRect.content = contentRt;
            }
            else
            {
                var contentRt = craftContentGo.GetComponent<RectTransform>();
                if (contentRt != null)
                {
                    craftScrollRect.content = contentRt;

                    var layout = craftContentGo.GetComponent<VerticalLayoutGroup>();
                    if (layout == null)
                    {
                        layout = craftContentGo.gameObject.AddComponent<VerticalLayoutGroup>();
                        layout.spacing = 6;
                        layout.childControlHeight = true;
                        layout.childForceExpandHeight = false;
                        layout.childControlWidth = true;
                        layout.childForceExpandWidth = true;
                        layout.padding = new RectOffset(10, 10, 4, 4);
                    }
                    var fitter = craftContentGo.GetComponent<ContentSizeFitter>();
                    if (fitter == null)
                    {
                        fitter = craftContentGo.gameObject.AddComponent<ContentSizeFitter>();
                        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
                    }
                }
            }

            // Ensure both panels are active/visible by default in Edit Mode (so the user can drag them)
            selPanelGo.SetActive(true);
            blacksmithCraftGo.SetActive(true);

            // Assign BlacksmithCraftPanel field reference to SelectedVillagerPanelView
            var selView = selPanelGo.GetComponent<SelectedVillagerPanelView>();
            if (selView != null)
            {
                selView.blacksmithCraftPanel = blacksmithCraftGo;
                if (!Application.isPlaying)
                {
                    EditorUtility.SetDirty(selView);
                    EditorUtility.SetDirty(selPanelGo);
                    EditorUtility.SetDirty(blacksmithCraftGo);
                }
            }
            UnityEngine.Debug.Log("[Blacksmith UI] BlacksmithCraftPanel ready.");

            // --- 11. EVENT LOG PANEL ---
            var logPanelGo = FindChildByNames(hudRootGo.transform, new[] { "EventLogPanel" });
            if (logPanelGo == null)
            {
                logPanelGo = new GameObject("EventLogPanel");
                logPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = logPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 0);
                rect.anchorMax = new Vector2(1, 0);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(300, 150);
                rect.anchoredPosition = new Vector2(-150, 275);

                var view = logPanelGo.AddComponent<TaskLogView>();
                var txtGo = CreateTextObject(logPanelGo.transform, "Text", "Event Log...", 14, new Vector2(280, 130), Vector2.zero, font);
                view.txtLog = txtGo.GetComponent<Text>();
                view.txtLog.alignment = TextAnchor.LowerLeft;

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing EventLogPanel");
            }
            else
            {
                var view = logPanelGo.GetComponent<TaskLogView>();
                if (view == null) view = logPanelGo.AddComponent<TaskLogView>();

                var txtTransform = logPanelGo.transform.Find("Text");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(logPanelGo.transform, "Text", "Event Log...", 14, new Vector2(280, 130), Vector2.zero, font);
                    view.txtLog = txtGo.GetComponent<Text>();
                    view.txtLog.alignment = TextAnchor.LowerLeft;
                }
                else if (view.txtLog == null)
                {
                    view.txtLog = txtTransform.GetComponent<Text>();
                }
                preservedCount++;
            }
            uiManager.eventLogPanel = logPanelGo.GetComponent<TaskLogView>();

            // --- 12. DEBUG PANEL ---
            var debugPanelGo = FindChildByNames(hudRootGo.transform, new[] { "DebugPanel", "BottomDevControls" });
            if (debugPanelGo == null)
            {
                debugPanelGo = new GameObject("DebugPanel");
                debugPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = debugPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 0);
                rect.anchorMax = new Vector2(1, 1);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(250, 0);
                rect.anchoredPosition = new Vector2(-125, 0);

                var img = debugPanelGo.AddComponent<Image>();
                img.color = new Color(0, 0, 0, 0.7f);
                debugPanelGo.SetActive(false); // Default hidden

                CreateButtonObject(debugPanelGo.transform, "ASSIGN JOB", "ASSIGN JOB", new Vector2(0, -150), new Vector2(200, 40), font);
                CreateButtonObject(debugPanelGo.transform, "SELECT NEXT VILLAGER", "SELECT NEXT VILLAGER", new Vector2(0, -210), new Vector2(200, 40), font);
                CreateButtonObject(debugPanelGo.transform, "SAVE", "SAVE", new Vector2(0, -270), new Vector2(200, 40), font);
                CreateButtonObject(debugPanelGo.transform, "LOAD", "LOAD", new Vector2(0, -330), new Vector2(200, 40), font);

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing DebugPanel");
            }
            else
            {
                // Ensure debug buttons exist
                string[] btnNames = { "ASSIGN JOB", "SELECT NEXT VILLAGER", "SAVE", "LOAD" };
                float dbgY = -150f;
                foreach (var bName in btnNames)
                {
                    var btnTransform = debugPanelGo.transform.Find(bName);
                    if (btnTransform == null)
                    {
                        CreateButtonObject(debugPanelGo.transform, bName, bName, new Vector2(0, dbgY), new Vector2(200, 40), font);
                    }
                    dbgY -= 60f;
                }
                preservedCount++;
            }

            // Toggle debug panel trigger in HUDRoot
            var btnToggleDebugTransform = hudRootGo.transform.Find("DEV TOOLS");
            if (btnToggleDebugTransform == null)
            {
                var go = CreateButtonObject(hudRootGo.transform, "DEV TOOLS", "DEV TOOLS", new Vector2(-120, -50), new Vector2(100, 40), font);
                var toggleRect = go.GetComponent<RectTransform>();
                toggleRect.anchorMin = new Vector2(1, 1);
                toggleRect.anchorMax = new Vector2(1, 1);
                btnToggleDebugTransform = go.transform;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing DEV TOOLS toggle button");
            }

            var toggleBtn = btnToggleDebugTransform.GetComponent<Button>();
            if (toggleBtn != null && debugPanelGo != null)
            {
                toggleBtn.onClick.RemoveAllListeners();
                var dbgRef = debugPanelGo;
                toggleBtn.onClick.AddListener(() => {
                    dbgRef.SetActive(!dbgRef.activeSelf);
                });
            }

            // --- 13. BOTTOM ACTION BAR ---
            var bottomBarGo = FindChildByNames(hudRootGo.transform, new[] { "BottomActionBar" });
            if (bottomBarGo == null)
            {
                bottomBarGo = new GameObject("BottomActionBar");
                bottomBarGo.transform.SetParent(hudRootGo.transform, false);
                var rect = bottomBarGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.2f, 0);
                rect.anchorMax = new Vector2(0.8f, 0);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(0, 100);
                rect.anchoredPosition = new Vector2(0, 50);

                // Build Button
                var btnBuildGo = new GameObject("BtnOpenBuildMenu");
                btnBuildGo.transform.SetParent(bottomBarGo.transform, false);
                var btnBuildRect = btnBuildGo.AddComponent<RectTransform>();
                btnBuildRect.sizeDelta = new Vector2(80, 80);
                btnBuildRect.anchoredPosition = new Vector2(-120, 0);
                var btnBuildImg = btnBuildGo.AddComponent<Image>();
                Sprite buildSp = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/_Project/ImportedDecoded/Texture2D/build3.png");
                if (buildSp != null) { btnBuildImg.sprite = buildSp; btnBuildImg.color = Color.white; }
                else { btnBuildImg.color = Color.gray; }
                btnBuildGo.AddComponent<Button>();

                var buildTxtGo = CreateTextObject(btnBuildGo.transform, "Text", "Build", 20, Vector2.zero, Vector2.zero, font);
                var buildTxtRect = buildTxtGo.GetComponent<RectTransform>();
                buildTxtRect.anchorMin = Vector2.zero;
                buildTxtRect.anchorMax = Vector2.one;
                buildTxtRect.sizeDelta = Vector2.zero;
                buildTxtGo.GetComponent<Text>().color = Color.black;

                // Next Phase
                var btnNext = CreateButtonObject(bottomBarGo.transform, "Next Phase", "Next Phase", new Vector2(0, 0), new Vector2(120, 50), font);
                var nextTxt = btnNext.GetComponentInChildren<Text>();
                if (nextTxt != null) nextTxt.fontSize = 16;
                var tooltipGo = CreateTextObject(bottomBarGo.transform, "Text", "TEMPORARY_DEV_UI: Next Phase", 10, new Vector2(150, 20), new Vector2(0, -35), font);
                tooltipGo.GetComponent<Text>().color = Color.yellow;

                // Save
                CreateButtonObject(bottomBarGo.transform, "Save", "Save", new Vector2(120, 0), new Vector2(80, 50), font);
                var saveTooltipGo = CreateTextObject(bottomBarGo.transform, "Text", "TEMPORARY_DEV_UI: Save", 10, new Vector2(120, 20), new Vector2(120, -35), font);
                saveTooltipGo.GetComponent<Text>().color = Color.yellow;

                // Load
                CreateButtonObject(bottomBarGo.transform, "Load", "Load", new Vector2(210, 0), new Vector2(80, 50), font);
                var loadTooltipGo = CreateTextObject(bottomBarGo.transform, "Text", "TEMPORARY_DEV_UI: Load", 10, new Vector2(120, 20), new Vector2(210, -35), font);
                loadTooltipGo.GetComponent<Text>().color = Color.yellow;

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing BottomActionBar");
            }
            else
            {
                // Ensure Build Menu Button exists under BottomActionBar
                var btnBuildTransform = bottomBarGo.transform.Find("BtnOpenBuildMenu");
                if (btnBuildTransform == null)
                {
                    var btnBuildGo = new GameObject("BtnOpenBuildMenu");
                    btnBuildGo.transform.SetParent(bottomBarGo.transform, false);
                    var btnBuildRect = btnBuildGo.AddComponent<RectTransform>();
                    btnBuildRect.sizeDelta = new Vector2(80, 80);
                    btnBuildRect.anchoredPosition = new Vector2(-120, 0);
                    var btnBuildImg = btnBuildGo.AddComponent<Image>();
                    Sprite buildSp = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/_Project/ImportedDecoded/Texture2D/build3.png");
                    if (buildSp != null) { btnBuildImg.sprite = buildSp; btnBuildImg.color = Color.white; }
                    else { btnBuildImg.color = Color.gray; }
                    btnBuildGo.AddComponent<Button>();

                    var buildTxtGo = CreateTextObject(btnBuildGo.transform, "Text", "Build", 20, Vector2.zero, Vector2.zero, font);
                    var buildTxtRect = buildTxtGo.GetComponent<RectTransform>();
                    buildTxtRect.anchorMin = Vector2.zero;
                    buildTxtRect.anchorMax = Vector2.one;
                    buildTxtRect.sizeDelta = Vector2.zero;
                    buildTxtGo.GetComponent<Text>().color = Color.black;
                }

                // Ensure action buttons exist
                if (bottomBarGo.transform.Find("Next Phase") == null)
                {
                    var btnNext = CreateButtonObject(bottomBarGo.transform, "Next Phase", "Next Phase", new Vector2(0, 0), new Vector2(120, 50), font);
                    var nextTxt = btnNext.GetComponentInChildren<Text>();
                    if (nextTxt != null) nextTxt.fontSize = 16;
                    var tooltipGo = CreateTextObject(bottomBarGo.transform, "Text", "TEMPORARY_DEV_UI: Next Phase", 10, new Vector2(150, 20), new Vector2(0, -35), font);
                    tooltipGo.GetComponent<Text>().color = Color.yellow;
                }
                if (bottomBarGo.transform.Find("Save") == null)
                {
                    CreateButtonObject(bottomBarGo.transform, "Save", "Save", new Vector2(120, 0), new Vector2(80, 50), font);
                    var saveTooltipGo = CreateTextObject(bottomBarGo.transform, "Text", "TEMPORARY_DEV_UI: Save", 10, new Vector2(120, 20), new Vector2(120, -35), font);
                    saveTooltipGo.GetComponent<Text>().color = Color.yellow;
                }
                if (bottomBarGo.transform.Find("Load") == null)
                {
                    CreateButtonObject(bottomBarGo.transform, "Load", "Load", new Vector2(210, 0), new Vector2(80, 50), font);
                    var loadTooltipGo = CreateTextObject(bottomBarGo.transform, "Text", "TEMPORARY_DEV_UI: Load", 10, new Vector2(120, 20), new Vector2(210, -35), font);
                    loadTooltipGo.GetComponent<Text>().color = Color.yellow;
                }

                preservedCount++;
            }

            // --- 13. INTERACTION CONTROLLER BINDINGS ---
            var interactionGo = GameObject.Find("TownInteractionController");
            if (interactionGo != null)
            {
                var controller = interactionGo.GetComponent<TownInteractionController>();
                if (controller != null)
                {
                    if (debugPanelGo != null)
                    {
                        var btnAssign = debugPanelGo.transform.Find("ASSIGN JOB")?.GetComponent<Button>();
                        if (btnAssign != null) controller.btnAssignWorker = btnAssign;

                        var btnSelect = debugPanelGo.transform.Find("SELECT NEXT VILLAGER")?.GetComponent<Button>();
                        if (btnSelect != null) controller.btnSelectVillager = btnSelect;
                    }

                    if (bottomBarGo != null)
                    {
                        var btnNext = bottomBarGo.transform.Find("Next Phase")?.GetComponent<Button>();
                        if (btnNext != null) controller.btnNextPhase = btnNext;

                        var btnSave = bottomBarGo.transform.Find("Save")?.GetComponent<Button>();
                        if (btnSave != null) controller.btnSave = btnSave;

                        var btnLoad = bottomBarGo.transform.Find("Load")?.GetComponent<Button>();
                        if (btnLoad != null) controller.btnLoad = btnLoad;
                    }
                    UnityEngine.Debug.Log("[RECOVERY] Successfully bound button controls to TownInteractionController");
                }
            }

            // --- 13.5. WORLD MAP PANEL ---
            var worldMapPanelGo = GameObject.Find("WorldMapPanel");
            bool layoutRepaired = false;
            if (worldMapPanelGo == null)
            {
                worldMapPanelGo = new GameObject("WorldMapPanel");
                worldMapPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = worldMapPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 0.5f);
                rect.anchorMax = new Vector2(0.5f, 0.5f);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(1100, 600);
                rect.anchoredPosition = Vector2.zero;

                var img = worldMapPanelGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.1f, 0.15f, 0.95f);

                createdCount++;
                layoutRepaired = true;
                UnityEngine.Debug.Log("[WorldMap UI] Restored missing WorldMapPanel.");
            }
            else
            {
                var rect = worldMapPanelGo.GetComponent<RectTransform>();
                if (rect != null)
                {
                    bool invalidRect = rect.sizeDelta.x != 1100f || rect.sizeDelta.y != 600f ||
                                       rect.anchorMin != new Vector2(0.5f, 0.5f) ||
                                       rect.anchorMax != new Vector2(0.5f, 0.5f) ||
                                       rect.pivot != new Vector2(0.5f, 0.5f);
                    if (invalidRect)
                    {
                        rect.anchorMin = new Vector2(0.5f, 0.5f);
                        rect.anchorMax = new Vector2(0.5f, 0.5f);
                        rect.pivot = new Vector2(0.5f, 0.5f);
                        rect.sizeDelta = new Vector2(1100, 600);
                        rect.anchoredPosition = Vector2.zero;
                        layoutRepaired = true;
                    }
                }
                preservedCount++;
            }

            var wmpView = worldMapPanelGo.GetComponent<WorldMapPanelView>();
            if (wmpView == null) wmpView = worldMapPanelGo.AddComponent<WorldMapPanelView>();

            // Ensure Header exists under WorldMapPanel
            var wmHeaderTransform = worldMapPanelGo.transform.Find("Header");
            GameObject wmHeaderGo;
            if (wmHeaderTransform == null)
            {
                wmHeaderGo = new GameObject("Header");
                wmHeaderGo.transform.SetParent(worldMapPanelGo.transform, false);
                var hRect = wmHeaderGo.AddComponent<RectTransform>();
                hRect.anchorMin = new Vector2(0, 1);
                hRect.anchorMax = new Vector2(1, 1);
                hRect.pivot = new Vector2(0.5f, 1f);
                hRect.sizeDelta = new Vector2(0, 50);
                hRect.anchoredPosition = Vector2.zero;
                var hImg = wmHeaderGo.AddComponent<Image>();
                hImg.color = new Color(0.15f, 0.15f, 0.2f, 1f);
                
                CreateTextObject(wmHeaderGo.transform, "TitleText", "WORLD MAP", 22, new Vector2(300, 40), Vector2.zero, font);
                CreateButtonObject(wmHeaderGo.transform, "CloseButton", "X", new Vector2(-15, 0), new Vector2(40, 40), font);
            }
            else
            {
                wmHeaderGo = wmHeaderTransform.gameObject;
            }

            var wmCloseBtn = wmHeaderGo.transform.Find("CloseButton")?.GetComponent<Button>();
            if (wmCloseBtn != null) {
                wmpView.btnClose = wmCloseBtn;
                ClearPersistentListeners(wmCloseBtn, "CloseButton");
                var wmCloseBtnRect = wmCloseBtn.GetComponent<RectTransform>();
                if (wmCloseBtnRect != null)
                {
                    if (wmCloseBtnRect.anchorMin != new Vector2(1, 0.5f) || wmCloseBtnRect.anchorMax != new Vector2(1, 0.5f) ||
                        wmCloseBtnRect.pivot != new Vector2(1, 0.5f) || wmCloseBtnRect.anchoredPosition.x != -15f)
                    {
                        wmCloseBtnRect.anchorMin = new Vector2(1, 0.5f);
                        wmCloseBtnRect.anchorMax = new Vector2(1, 0.5f);
                        wmCloseBtnRect.pivot = new Vector2(1, 0.5f);
                        wmCloseBtnRect.anchoredPosition = new Vector2(-15, 0);
                        layoutRepaired = true;
                    }
                }
            }

            // Ensure Body exists under WorldMapPanel
            var wmBodyTransform = worldMapPanelGo.transform.Find("Body");
            GameObject wmBodyGo;
            if (wmBodyTransform == null)
            {
                wmBodyGo = new GameObject("Body");
                wmBodyGo.transform.SetParent(worldMapPanelGo.transform, false);
                var bRect = wmBodyGo.AddComponent<RectTransform>();
                bRect.anchorMin = Vector2.zero;
                bRect.anchorMax = Vector2.one;
                bRect.pivot = new Vector2(0.5f, 0.5f);
                bRect.sizeDelta = new Vector2(0, -100);
                bRect.anchoredPosition = Vector2.zero;
            }
            else
            {
                wmBodyGo = wmBodyTransform.gameObject;
            }

            // Ensure MapViewport exists under Body
            var wmViewportTransform = wmBodyGo.transform.Find("MapViewport");
            GameObject wmViewportGo;
            if (wmViewportTransform == null)
            {
                wmViewportGo = new GameObject("MapViewport");
                wmViewportGo.transform.SetParent(wmBodyGo.transform, false);
                var vpRect = wmViewportGo.AddComponent<RectTransform>();
                vpRect.anchorMin = new Vector2(0, 0.5f);
                vpRect.anchorMax = new Vector2(0, 0.5f);
                vpRect.pivot = new Vector2(0f, 0.5f);
                vpRect.sizeDelta = new Vector2(520, 480);
                vpRect.anchoredPosition = new Vector2(10, 0);

                var wmVpImg = wmViewportGo.AddComponent<Image>();
                wmVpImg.color = new Color(0.12f, 0.12f, 0.18f, 0.5f);
                wmViewportGo.AddComponent<RectMask2D>();
                
                var wmScroll = wmViewportGo.AddComponent<ScrollRect>();
                wmScroll.horizontal = true;
                wmScroll.vertical = true;
                wmScroll.movementType = ScrollRect.MovementType.Clamped;
                wmScroll.scrollSensitivity = 25f;
            }
            else
            {
                wmViewportGo = wmViewportTransform.gameObject;
                var vpRect = wmViewportGo.GetComponent<RectTransform>();
                if (vpRect != null)
                {
                    if (vpRect.anchorMin != new Vector2(0, 0.5f) || vpRect.anchorMax != new Vector2(0, 0.5f) ||
                        vpRect.pivot != new Vector2(0f, 0.5f) || vpRect.anchoredPosition.x != 10f || vpRect.sizeDelta.x != 520f)
                    {
                        vpRect.anchorMin = new Vector2(0, 0.5f);
                        vpRect.anchorMax = new Vector2(0, 0.5f);
                        vpRect.pivot = new Vector2(0f, 0.5f);
                        vpRect.sizeDelta = new Vector2(520, 480);
                        vpRect.anchoredPosition = new Vector2(10, 0);
                        layoutRepaired = true;
                    }
                }
            }

            var wmScrollRect = wmViewportGo.GetComponent<ScrollRect>();

            // Ensure MapContent exists under MapViewport
            var wmContentTransform = wmViewportGo.transform.Find("MapContent");
            GameObject wmContentGo;
            if (wmContentTransform == null)
            {
                wmContentGo = new GameObject("MapContent");
                wmContentGo.transform.SetParent(wmViewportGo.transform, false);
                var cRect = wmContentGo.AddComponent<RectTransform>();
                cRect.anchorMin = new Vector2(0, 1);
                cRect.anchorMax = new Vector2(0, 1);
                cRect.pivot = new Vector2(0f, 1f);
                cRect.sizeDelta = new Vector2(500, 500);
                cRect.anchoredPosition = Vector2.zero;
            }
            else
            {
                wmContentGo = wmContentTransform.gameObject;
            }

            if (wmScrollRect != null)
            {
                wmScrollRect.viewport = wmViewportGo.GetComponent<RectTransform>();
                wmScrollRect.content = wmContentGo.GetComponent<RectTransform>();
            }

            // Ensure Background exists under MapContent
            var wmBgTransform = wmContentGo.transform.Find("Background");
            GameObject wmBgGo;
            if (wmBgTransform == null)
            {
                wmBgGo = new GameObject("Background");
                wmBgGo.transform.SetParent(wmContentGo.transform, false);
                var bgRect = wmBgGo.AddComponent<RectTransform>();
                bgRect.anchorMin = Vector2.zero;
                bgRect.anchorMax = Vector2.one;
                bgRect.sizeDelta = Vector2.zero;

                var bgImg = wmBgGo.AddComponent<Image>();
                Sprite seaSp = BuildMenuRowVisualFactory.LoadSprite("Assets/_Project/ImportedDecoded/Sprite/Sea.png");
                if (seaSp != null) { bgImg.sprite = seaSp; bgImg.color = Color.white; }
                else { bgImg.color = new Color(0.1f, 0.15f, 0.25f, 1f); }
            }
            else
            {
                wmBgGo = wmBgTransform.gameObject;
            }

            // Ensure LocationNodes exists under MapContent
            var wmNodesTransform = wmContentGo.transform.Find("LocationNodes");
            GameObject wmNodesGo;
            if (wmNodesTransform == null)
            {
                wmNodesGo = new GameObject("LocationNodes");
                wmNodesGo.transform.SetParent(wmContentGo.transform, false);
                var nRect = wmNodesGo.AddComponent<RectTransform>();
                nRect.anchorMin = Vector2.zero;
                nRect.anchorMax = Vector2.one;
                nRect.sizeDelta = Vector2.zero;
            }
            else
            {
                wmNodesGo = wmNodesTransform.gameObject;
            }

            wmpView.locationNodesRoot = wmNodesGo.transform;

            // Ensure DetailsPanel exists under Body
            var wmDetailsTransform = wmBodyGo.transform.Find("DetailsPanel");
            GameObject wmDetailsGo;
            if (wmDetailsTransform == null)
            {
                wmDetailsGo = new GameObject("DetailsPanel");
                wmDetailsGo.transform.SetParent(wmBodyGo.transform, false);
                var dRect = wmDetailsGo.AddComponent<RectTransform>();
                dRect.anchorMin = new Vector2(0, 0.5f);
                dRect.anchorMax = new Vector2(0, 0.5f);
                dRect.pivot = new Vector2(0f, 0.5f);
                dRect.sizeDelta = new Vector2(250, 480);
                dRect.anchoredPosition = new Vector2(540, 0);

                var dImg = wmDetailsGo.AddComponent<Image>();
                dImg.color = new Color(0.12f, 0.12f, 0.18f, 0.95f);

                var layout = wmDetailsGo.AddComponent<VerticalLayoutGroup>();
                layout.spacing = 8;
                layout.padding = new RectOffset(15, 15, 15, 15);
                layout.childControlWidth = true;
                layout.childControlHeight = true;
                layout.childForceExpandWidth = true;
                layout.childForceExpandHeight = false;

                CreateTextObject(wmDetailsGo.transform, "LocationNameText", "Select a Location", 20, Vector2.zero, Vector2.zero, font).GetComponent<Text>().fontStyle = FontStyle.Bold;
                CreateTextObject(wmDetailsGo.transform, "LocationTypeText", "Type: N/A", 14, Vector2.zero, Vector2.zero, font);
                CreateTextObject(wmDetailsGo.transform, "CoordinatesText", "Coords: N/A", 14, Vector2.zero, Vector2.zero, font);
                CreateTextObject(wmDetailsGo.transform, "DiscoveredStatusText", "Status: N/A", 16, Vector2.zero, Vector2.zero, font);
                CreateTextObject(wmDetailsGo.transform, "DangerText", "Danger Level: N/A", 16, Vector2.zero, Vector2.zero, font);
                CreateTextObject(wmDetailsGo.transform, "RewardText", "Reward: N/A", 16, Vector2.zero, Vector2.zero, font);
                CreateTextObject(wmDetailsGo.transform, "ExpeditionStatusText", "Expedition: N/A", 16, Vector2.zero, Vector2.zero, font);

                CreateButtonObject(wmDetailsGo.transform, "DiscoverButton", "DISCOVER", Vector2.zero, new Vector2(200, 40), font);
                CreateButtonObject(wmDetailsGo.transform, "DispatchButton", "DISPATCH EXPEDITION", Vector2.zero, new Vector2(200, 40), font);

                layoutRepaired = true;
            }
            else
            {
                wmDetailsGo = wmDetailsTransform.gameObject;
                var dRect = wmDetailsGo.GetComponent<RectTransform>();
                if (dRect != null)
                {
                    if (dRect.anchorMin != new Vector2(0, 0.5f) || dRect.anchorMax != new Vector2(0, 0.5f) ||
                        dRect.pivot != new Vector2(0f, 0.5f) || dRect.anchoredPosition.x != 540f || dRect.sizeDelta.x != 250f)
                    {
                        dRect.anchorMin = new Vector2(0, 0.5f);
                        dRect.anchorMax = new Vector2(0, 0.5f);
                        dRect.pivot = new Vector2(0f, 0.5f);
                        dRect.sizeDelta = new Vector2(250, 480);
                        dRect.anchoredPosition = new Vector2(540, 0);
                        layoutRepaired = true;
                    }
                }
            }

            // Assign details panel component references
            var dName = wmDetailsGo.transform.Find("LocationNameText")?.GetComponent<Text>();
            if (dName != null) wmpView.txtLocationName = dName;

            var dType = wmDetailsGo.transform.Find("LocationTypeText")?.GetComponent<Text>();
            if (dType != null) wmpView.txtLocationType = dType;

            var dCoords = wmDetailsGo.transform.Find("CoordinatesText")?.GetComponent<Text>();
            if (dCoords != null) wmpView.txtCoordinates = dCoords;

            var dStatus = wmDetailsGo.transform.Find("DiscoveredStatusText")?.GetComponent<Text>();
            if (dStatus != null) wmpView.txtDiscoveredStatus = dStatus;

            var dDanger = wmDetailsGo.transform.Find("DangerText")?.GetComponent<Text>();
            if (dDanger != null) wmpView.txtDanger = dDanger;

            var dReward = wmDetailsGo.transform.Find("RewardText")?.GetComponent<Text>();
            if (dReward != null) wmpView.txtReward = dReward;

            var dExp = wmDetailsGo.transform.Find("ExpeditionStatusText")?.GetComponent<Text>();
            if (dExp != null) wmpView.txtExpeditionStatus = dExp;

            // Ensure Footer exists under WorldMapPanel
            var wmFooterTransform = worldMapPanelGo.transform.Find("Footer");
            GameObject wmFooterGo;
            if (wmFooterTransform == null)
            {
                wmFooterGo = new GameObject("Footer");
                wmFooterGo.transform.SetParent(worldMapPanelGo.transform, false);
                var fRect = wmFooterGo.AddComponent<RectTransform>();
                fRect.anchorMin = new Vector2(0, 0);
                fRect.anchorMax = new Vector2(1, 0);
                fRect.pivot = new Vector2(0.5f, 0);
                fRect.sizeDelta = new Vector2(0, 50);
                fRect.anchoredPosition = Vector2.zero;

                var fImg = wmFooterGo.AddComponent<Image>();
                fImg.color = new Color(0.15f, 0.15f, 0.2f, 1f);

                var txtGo = CreateTextObject(wmFooterGo.transform, "ActiveExpeditionSummaryText", "Active Expeditions: 0", 16, new Vector2(300, 40), new Vector2(-230, 0), font);
                txtGo.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;

                CreateButtonObject(wmFooterGo.transform, "RefreshButton", "REFRESH", new Vector2(330, 0), new Vector2(120, 40), font);
            }
            else
            {
                wmFooterGo = wmFooterTransform.gameObject;
            }

            var fSummary = wmFooterGo.transform.Find("ActiveExpeditionSummaryText")?.GetComponent<Text>();
            if (fSummary != null) {
                fSummary.verticalOverflow = VerticalWrapMode.Overflow;
                fSummary.horizontalOverflow = HorizontalWrapMode.Wrap;
                wmpView.txtActiveExpeditionSummary = fSummary;
            }

            var fRefresh = wmFooterGo.transform.Find("RefreshButton")?.GetComponent<Button>();
            if (fRefresh != null) {
                wmpView.btnRefresh = fRefresh;
                ClearPersistentListeners(fRefresh, "RefreshButton");
            }

            // Ensure WorldMapQAStatusPanel exists under WorldMapPanel
            var qaPanelTransform = worldMapPanelGo.transform.Find("WorldMapQAStatusPanel");
            GameObject qaPanelGo;
            if (qaPanelTransform == null)
            {
                qaPanelGo = new GameObject("WorldMapQAStatusPanel");
                qaPanelGo.transform.SetParent(worldMapPanelGo.transform, false);
                var qaRect = qaPanelGo.AddComponent<RectTransform>();
                qaRect.anchorMin = new Vector2(0, 0.5f);
                qaRect.anchorMax = new Vector2(0, 0.5f);
                qaRect.pivot = new Vector2(0f, 0.5f);
                qaRect.sizeDelta = new Vector2(280, 480);
                qaRect.anchoredPosition = new Vector2(800, 0);

                var qaImg = qaPanelGo.AddComponent<Image>();
                qaImg.color = new Color(0.08f, 0.08f, 0.12f, 0.95f);

                layoutRepaired = true;
            }
            else
            {
                qaPanelGo = qaPanelTransform.gameObject;
                var qaRect = qaPanelGo.GetComponent<RectTransform>();
                if (qaRect != null)
                {
                    if (qaRect.anchorMin != new Vector2(0, 0.5f) || qaRect.anchorMax != new Vector2(0, 0.5f) ||
                        qaRect.pivot != new Vector2(0f, 0.5f) || qaRect.anchoredPosition.x != 800f || qaRect.sizeDelta.x != 280f)
                    {
                        qaRect.anchorMin = new Vector2(0, 0.5f);
                        qaRect.anchorMax = new Vector2(0, 0.5f);
                        qaRect.pivot = new Vector2(0f, 0.5f);
                        qaRect.sizeDelta = new Vector2(280, 480);
                        qaRect.anchoredPosition = new Vector2(800, 0);
                        layoutRepaired = true;
                    }
                }

                // Cleanup any old layout group component directly on qaPanelGo
                var oldLayoutGroup = qaPanelGo.GetComponent<VerticalLayoutGroup>();
                if (oldLayoutGroup != null)
                {
                    Object.DestroyImmediate(oldLayoutGroup);
                    layoutRepaired = true;
                }
            }

            wmpView.qaStatusPanel = qaPanelGo;

            // Cleanup any old direct-child text fields on qaPanelGo
            string[] oldTextNames = { "QAStatusTitle", "QAMapData", "QASelected", "QADiscovered", "QAReachable", "QADiscover", "QADispatch", "QAActiveExpeditions", "QALastAction", "QAVisualStatus" };
            foreach (var tName in oldTextNames)
            {
                var oldText = qaPanelGo.transform.Find(tName);
                if (oldText != null)
                {
                    Object.DestroyImmediate(oldText.gameObject);
                    layoutRepaired = true;
                }
            }

            // Ensure TextContainer exists under WorldMapQAStatusPanel
            var textContainerTransform = qaPanelGo.transform.Find("TextContainer");
            GameObject textContainerGo;
            if (textContainerTransform == null)
            {
                textContainerGo = new GameObject("TextContainer");
                textContainerGo.transform.SetParent(qaPanelGo.transform, false);
                var tcRect = textContainerGo.AddComponent<RectTransform>();
                tcRect.anchorMin = new Vector2(0, 1);
                tcRect.anchorMax = new Vector2(1, 1);
                tcRect.pivot = new Vector2(0.5f, 1f);
                tcRect.sizeDelta = new Vector2(0, 360);
                tcRect.anchoredPosition = new Vector2(0, -10);

                var tcLayout = textContainerGo.AddComponent<VerticalLayoutGroup>();
                tcLayout.spacing = 8;
                tcLayout.padding = new RectOffset(15, 15, 15, 15);
                tcLayout.childControlWidth = true;
                tcLayout.childControlHeight = true;
                tcLayout.childForceExpandWidth = true;
                tcLayout.childForceExpandHeight = false;

                // Title
                var qaTitle = CreateTextObject(textContainerGo.transform, "QAStatusTitle", "QA STATUS PANEL", 16, Vector2.zero, Vector2.zero, font);
                var titleText = qaTitle.GetComponent<Text>();
                titleText.fontStyle = FontStyle.Bold;
                titleText.color = Color.yellow;
                titleText.alignment = TextAnchor.MiddleLeft;

                // Text fields
                CreateTextObject(textContainerGo.transform, "QAMapData", "Map Data: 12/12 PASS", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QASelected", "Selected: None", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QADiscovered", "Discovered: No", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QAReachable", "Reachable: No", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QADiscover", "Discover: Blocked", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QADispatch", "Dispatch: Blocked", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QAActiveExpeditions", "Active Expeditions: 0", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QALastAction", "Last Action: None", 13, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;
                CreateTextObject(textContainerGo.transform, "QAVisualStatus", "15D Visual Status: PENDING", 14, Vector2.zero, Vector2.zero, font).GetComponent<Text>().alignment = TextAnchor.MiddleLeft;

                layoutRepaired = true;
            }
            else
            {
                textContainerGo = textContainerTransform.gameObject;
                var tcRect = textContainerGo.GetComponent<RectTransform>();
                if (tcRect != null)
                {
                    if (tcRect.anchorMin != new Vector2(0, 1) || tcRect.anchorMax != new Vector2(1, 1) ||
                        tcRect.pivot != new Vector2(0.5f, 1) || tcRect.sizeDelta.y != 360f || tcRect.anchoredPosition.y != -10f)
                    {
                        tcRect.anchorMin = new Vector2(0, 1);
                        tcRect.anchorMax = new Vector2(1, 1);
                        tcRect.pivot = new Vector2(0.5f, 1);
                        tcRect.sizeDelta = new Vector2(0, 360);
                        tcRect.anchoredPosition = new Vector2(0, -10);
                        layoutRepaired = true;
                    }
                }
            }

            // Verify and repair DiscoverButton and DispatchButton positioning under Option B (WorldMapQAStatusPanel children)
            bool buttonsRepaired = false;
            
            var discBtnTransform = qaPanelGo.transform.Find("DiscoverButton");
            GameObject discBtnGo;
            if (discBtnTransform == null)
            {
                // Clean up old ones in DetailsPanel if they exist
                var oldDisc = wmDetailsGo.transform.Find("DiscoverButton");
                if (oldDisc != null) { Object.DestroyImmediate(oldDisc.gameObject); buttonsRepaired = true; }

                discBtnGo = CreateButtonObject(qaPanelGo.transform, "DiscoverButton", "DISCOVER", new Vector2(0, 60), new Vector2(240, 42), font);
                buttonsRepaired = true;
            }
            else
            {
                discBtnGo = discBtnTransform.gameObject;
            }

            var dispBtnTransform = qaPanelGo.transform.Find("DispatchButton");
            GameObject dispBtnGo;
            if (dispBtnTransform == null)
            {
                // Clean up old ones in DetailsPanel if they exist
                var oldDisp = wmDetailsGo.transform.Find("DispatchButton");
                if (oldDisp != null) { Object.DestroyImmediate(oldDisp.gameObject); buttonsRepaired = true; }

                dispBtnGo = CreateButtonObject(qaPanelGo.transform, "DispatchButton", "DISPATCH", new Vector2(0, 10), new Vector2(240, 42), font);
                buttonsRepaired = true;
            }
            else
            {
                dispBtnGo = dispBtnTransform.gameObject;
            }

            // Verify active status, dimensions, positioning, and text content for DiscoverButton
            if (discBtnGo != null)
            {
                if (!discBtnGo.activeSelf)
                {
                    discBtnGo.SetActive(true);
                    buttonsRepaired = true;
                }
                var r = discBtnGo.GetComponent<RectTransform>();
                if (r != null)
                {
                    if (r.anchorMin != new Vector2(0.5f, 0) || r.anchorMax != new Vector2(0.5f, 0) || r.pivot != new Vector2(0.5f, 0) ||
                        System.Math.Abs(r.sizeDelta.x - 240f) > 1f || System.Math.Abs(r.sizeDelta.y - 42f) > 1f || r.anchoredPosition != new Vector2(0, 60))
                    {
                        r.anchorMin = new Vector2(0.5f, 0);
                        r.anchorMax = new Vector2(0.5f, 0);
                        r.pivot = new Vector2(0.5f, 0);
                        r.sizeDelta = new Vector2(240, 42);
                        r.anchoredPosition = new Vector2(0, 60);
                        buttonsRepaired = true;
                    }
                }
                var txt = discBtnGo.transform.Find("Text")?.GetComponent<Text>();
                if (txt != null && txt.text != "DISCOVER")
                {
                    txt.text = "DISCOVER";
                    buttonsRepaired = true;
                }
            }

            // Verify active status, dimensions, positioning, and text content for DispatchButton
            if (dispBtnGo != null)
            {
                if (!dispBtnGo.activeSelf)
                {
                    dispBtnGo.SetActive(true);
                    buttonsRepaired = true;
                }
                var r = dispBtnGo.GetComponent<RectTransform>();
                if (r != null)
                {
                    if (r.anchorMin != new Vector2(0.5f, 0) || r.anchorMax != new Vector2(0.5f, 0) || r.pivot != new Vector2(0.5f, 0) ||
                        System.Math.Abs(r.sizeDelta.x - 240f) > 1f || System.Math.Abs(r.sizeDelta.y - 42f) > 1f || r.anchoredPosition != new Vector2(0, 10))
                    {
                        r.anchorMin = new Vector2(0.5f, 0);
                        r.anchorMax = new Vector2(0.5f, 0);
                        r.pivot = new Vector2(0.5f, 0);
                        r.sizeDelta = new Vector2(240, 42);
                        r.anchoredPosition = new Vector2(0, 10);
                        buttonsRepaired = true;
                    }
                }
                var txt = dispBtnGo.transform.Find("Text")?.GetComponent<Text>();
                if (txt != null && txt.text != "DISPATCH")
                {
                    txt.text = "DISPATCH";
                    buttonsRepaired = true;
                }
            }

            if (buttonsRepaired)
            {
                UnityEngine.Debug.Log("[WorldMap UI] Repaired invisible WorldMap action buttons.");
            }

            var dDiscBtn = qaPanelGo.transform.Find("DiscoverButton")?.GetComponent<Button>();
            if (dDiscBtn != null) {
                wmpView.btnDiscover = dDiscBtn;
                ClearPersistentListeners(dDiscBtn, "DiscoverButton");
            }

            var dDispBtn = qaPanelGo.transform.Find("DispatchButton")?.GetComponent<Button>();
            if (dDispBtn != null) {
                wmpView.btnDispatch = dDispBtn;
                ClearPersistentListeners(dDispBtn, "DispatchButton");
            }

            var qaMapData = qaPanelGo.transform.Find("TextContainer/QAMapData")?.GetComponent<Text>();
            if (qaMapData != null) wmpView.txtQAMapData = qaMapData;

            var qaSelected = qaPanelGo.transform.Find("TextContainer/QASelected")?.GetComponent<Text>();
            if (qaSelected != null) wmpView.txtQASelected = qaSelected;

            var qaDiscovered = qaPanelGo.transform.Find("TextContainer/QADiscovered")?.GetComponent<Text>();
            if (qaDiscovered != null) wmpView.txtQADiscovered = qaDiscovered;

            var qaReachable = qaPanelGo.transform.Find("TextContainer/QAReachable")?.GetComponent<Text>();
            if (qaReachable != null) wmpView.txtQAReachable = qaReachable;

            var qaDiscover = qaPanelGo.transform.Find("TextContainer/QADiscover")?.GetComponent<Text>();
            if (qaDiscover != null) wmpView.txtQADiscover = qaDiscover;

            var qaDispatch = qaPanelGo.transform.Find("TextContainer/QADispatch")?.GetComponent<Text>();
            if (qaDispatch != null) wmpView.txtQADispatch = qaDispatch;

            var qaActiveExpeditions = qaPanelGo.transform.Find("TextContainer/QAActiveExpeditions")?.GetComponent<Text>();
            if (qaActiveExpeditions != null) wmpView.txtQAActiveExpeditions = qaActiveExpeditions;

            var qaLastAction = qaPanelGo.transform.Find("TextContainer/QALastAction")?.GetComponent<Text>();
            if (qaLastAction != null) wmpView.txtQALastAction = qaLastAction;

            var qaVisualStatus = qaPanelGo.transform.Find("TextContainer/QAVisualStatus")?.GetComponent<Text>();
            if (qaVisualStatus != null) wmpView.txtQAVisualStatus = qaVisualStatus;

            // Ensure WorldMapOpenButton exists inside BottomActionBar
            if (bottomBarGo != null)
            {
                var wmOpenBtnTransform = bottomBarGo.transform.Find("WorldMapOpenButton");
                GameObject wmOpenBtnGo;
                if (wmOpenBtnTransform == null)
                {
                    wmOpenBtnGo = new GameObject("WorldMapOpenButton");
                    wmOpenBtnGo.transform.SetParent(bottomBarGo.transform, false);
                    var openRect = wmOpenBtnGo.AddComponent<RectTransform>();
                    openRect.sizeDelta = new Vector2(80, 80);
                    openRect.anchoredPosition = new Vector2(-30, 0); // Positioned next to BtnOpenBuildMenu
                    
                    var openImg = wmOpenBtnGo.AddComponent<Image>();
                    Sprite expSp = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/_Project/ImportedDecoded/Sprite/expedition.png");
                    if (expSp != null) { openImg.sprite = expSp; openImg.color = Color.white; }
                    else { openImg.color = Color.gray; }

                    wmOpenBtnGo.AddComponent<Button>();

                    var openTxtGo = CreateTextObject(wmOpenBtnGo.transform, "Text", "Map", 20, Vector2.zero, Vector2.zero, font);
                    var openTxtRect = openTxtGo.GetComponent<RectTransform>();
                    openTxtRect.anchorMin = Vector2.zero;
                    openTxtRect.anchorMax = Vector2.one;
                    openTxtRect.sizeDelta = Vector2.zero;
                    openTxtGo.GetComponent<Text>().color = Color.black;
                }
                else
                {
                    wmOpenBtnGo = wmOpenBtnTransform.gameObject;
                    if (wmOpenBtnGo.GetComponent<Button>() == null)
                    {
                        wmOpenBtnGo.AddComponent<Button>();
                    }
                }

                var openBtnComp = wmOpenBtnGo.GetComponent<Button>();
                ClearPersistentListeners(openBtnComp, "WorldMapOpenButton");
            }

            if (layoutRepaired)
            {
                UnityEngine.Debug.Log("[WorldMap UI] Repaired invisible WorldMap visual QA layout.");
            }

            // Always make sure WorldMapPanel is active by default in Edit Mode (so player can edit layouts)
            if (!Application.isPlaying)
            {
                worldMapPanelGo.SetActive(true);
            }

            // Generate Edit Mode placeholder nodes under LocationNodes
            if (!Application.isPlaying && wmNodesGo != null)
            {
                // Clear old placeholders first
                var toDestroy = new System.Collections.Generic.List<GameObject>();
                foreach (Transform child in wmNodesGo.transform)
                {
                    if (child.name.StartsWith("EditorPreview_"))
                    {
                        toDestroy.Add(child.gameObject);
                    }
                }
                foreach (var childGo in toDestroy)
                {
                    Object.DestroyImmediate(childGo);
                }

                // Read definitions to position placeholders
                var repo = new TheBonwater.Rebuild.Data.DataRepository();
                repo.LoadAll();

                if (repo.WorldMapLocations != null)
                {
                    foreach (var loc in repo.WorldMapLocations)
                    {
                        var previewNodeGo = new GameObject($"EditorPreview_Loc_{loc.id}");
                        previewNodeGo.transform.SetParent(wmNodesGo.transform, false);

                        var rect = previewNodeGo.AddComponent<RectTransform>();
                        rect.anchorMin = Vector2.zero;
                        rect.anchorMax = Vector2.zero;
                        rect.pivot = new Vector2(0.5f, 0.5f);
                        rect.sizeDelta = new Vector2(40f, 40f);
                        float posX = loc.x * 45f + 40f;
                        float posY = loc.y * 45f + 40f;
                        rect.anchoredPosition = new Vector2(posX, posY);

                        var img = previewNodeGo.AddComponent<Image>();
                        previewNodeGo.AddComponent<Button>();

                        // Apply base colors depending on ID/discoveredAtStart
                        if (loc.id.Equals("home", System.StringComparison.OrdinalIgnoreCase))
                        {
                            img.color = new Color(0.2f, 0.8f, 0.2f, 1f); // Green for home
                        }
                        else if (loc.discoveredAtStart)
                        {
                            img.color = new Color(0.2f, 0.7f, 0.9f, 1f); // Cyan for starting discovered
                        }
                        else
                        {
                            img.color = new Color(0.3f, 0.3f, 0.3f, 0.8f); // Gray for starting locked
                        }

                        var txtGo = new GameObject("Text");
                        txtGo.transform.SetParent(previewNodeGo.transform, false);
                        var txtRect = txtGo.AddComponent<RectTransform>();
                        txtRect.anchorMin = Vector2.zero;
                        txtRect.anchorMax = Vector2.one;
                        txtRect.sizeDelta = Vector2.zero;

                        var txt = txtGo.AddComponent<Text>();
                        txt.font = font;
                        txt.text = loc.id.Equals("home", System.StringComparison.OrdinalIgnoreCase) ? "H" : "?";
                        txt.fontSize = 12;
                        txt.alignment = TextAnchor.MiddleCenter;
                        txt.color = Color.white;

                        // Try to load definition sprite if it exists
                        if (!string.IsNullOrEmpty(loc.spritePath))
                        {
                            Sprite sp = BuildMenuRowVisualFactory.LoadSprite(loc.spritePath);
                            if (sp != null)
                            {
                                img.sprite = sp;
                                img.color = Color.white;
                                txt.gameObject.SetActive(false);
                            }
                        }
                    }
                }
            }

            // Wire WorldMapPanelView reference to GameplayUIManager
            uiManager.worldMapPanel = wmpView;

            // --- 15. EXPEDITION RESULT PANEL ---
            var expResultGo = GameObject.Find("ExpeditionResultPanel");
            if (expResultGo == null)
            {
                expResultGo = new GameObject("ExpeditionResultPanel");
                expResultGo.transform.SetParent(hudRootGo.transform, false);
                var rect = expResultGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 0.5f);
                rect.anchorMax = new Vector2(0.5f, 0.5f);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(400, 250);
                rect.anchoredPosition = Vector2.zero;

                var img = expResultGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.1f, 0.15f, 0.98f);

                // TitleText
                var titleGo = CreateTextObject(expResultGo.transform, "TitleText", "EXPEDITION COMPLETED", 18, new Vector2(360, 40), new Vector2(0, 80), font);
                var titleText = titleGo.GetComponent<Text>();
                titleText.fontStyle = FontStyle.Bold;
                titleText.color = Color.yellow;
                titleText.alignment = TextAnchor.MiddleCenter;

                // ResultText
                var resultGo = CreateTextObject(expResultGo.transform, "ResultText", "Result details...", 14, new Vector2(360, 100), new Vector2(0, 0), font);
                var resultText = resultGo.GetComponent<Text>();
                resultText.color = Color.white;
                resultText.alignment = TextAnchor.UpperLeft;
                resultText.verticalOverflow = VerticalWrapMode.Overflow;
                resultText.horizontalOverflow = HorizontalWrapMode.Wrap;

                // OkButton
                var okBtnGo = CreateButtonObject(expResultGo.transform, "OkButton", "OK", new Vector2(0, -70), new Vector2(100, 40), font);

                createdCount++;
                layoutRepaired = true;
                UnityEngine.Debug.Log("[WorldMap UI] Created ExpeditionResultPanel.");
            }
            else
            {
                var rect = expResultGo.GetComponent<RectTransform>();
                if (rect != null)
                {
                    if (rect.anchorMin != new Vector2(0.5f, 0.5f) || rect.anchorMax != new Vector2(0.5f, 0.5f) ||
                        rect.pivot != new Vector2(0.5f, 0.5f) || rect.sizeDelta.x != 400f || rect.sizeDelta.y != 250f)
                    {
                        rect.anchorMin = new Vector2(0.5f, 0.5f);
                        rect.anchorMax = new Vector2(0.5f, 0.5f);
                        rect.pivot = new Vector2(0.5f, 0.5f);
                        rect.sizeDelta = new Vector2(400, 250);
                        rect.anchoredPosition = Vector2.zero;
                        layoutRepaired = true;
                    }
                }
                preservedCount++;
            }

            // Assign components to GameplayUIManager
            uiManager.panelExpeditionResult = expResultGo;
            var rTxt = expResultGo.transform.Find("ResultText")?.GetComponent<Text>();
            if (rTxt != null) uiManager.txtResultText = rTxt;
            var rOk = expResultGo.transform.Find("OkButton")?.GetComponent<Button>();
            if (rOk != null) {
                uiManager.btnResultOk = rOk;
                ClearPersistentListeners(rOk, "OkButton");
            }

            // Always make sure ExpeditionResultPanel is active by default in Edit Mode
            if (!Application.isPlaying)
            {
                expResultGo.SetActive(true);
            }

            if (expResultGo != null) EditorUtility.SetDirty(expResultGo);

            // --- 16. MERCHANT TRADE PANEL ---
            var tradePanelGo = GameObject.Find("TradePanel");
            bool tradeLayoutRepaired = false;
            if (tradePanelGo == null)
            {
                tradePanelGo = new GameObject("TradePanel");
                tradePanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = tradePanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 0.5f);
                rect.anchorMax = new Vector2(0.5f, 0.5f);
                rect.pivot = new Vector2(0.5f, 0.5f);
                rect.sizeDelta = new Vector2(600, 550);
                rect.anchoredPosition = Vector2.zero;

                var img = tradePanelGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.1f, 0.15f, 0.95f);

                createdCount++;
                tradeLayoutRepaired = true;
                UnityEngine.Debug.Log("[Trade UI] Restored missing TradePanel.");
            }
            else
            {
                var rect = tradePanelGo.GetComponent<RectTransform>();
                if (rect != null)
                {
                    bool invalidRect = rect.sizeDelta.x != 600f || rect.sizeDelta.y != 550f ||
                                       rect.anchorMin != new Vector2(0.5f, 0.5f) ||
                                       rect.anchorMax != new Vector2(0.5f, 0.5f) ||
                                       rect.pivot != new Vector2(0.5f, 0.5f);
                    if (invalidRect)
                    {
                        rect.anchorMin = new Vector2(0.5f, 0.5f);
                        rect.anchorMax = new Vector2(0.5f, 0.5f);
                        rect.pivot = new Vector2(0.5f, 0.5f);
                        rect.sizeDelta = new Vector2(600, 550);
                        rect.anchoredPosition = Vector2.zero;
                        tradeLayoutRepaired = true;
                    }
                }
                preservedCount++;
            }

            var tpView = tradePanelGo.GetComponent<TradePanelView>();
            if (tpView == null) tpView = tradePanelGo.AddComponent<TradePanelView>();

            // Ensure Header exists under TradePanel
            var trHeaderTransform = tradePanelGo.transform.Find("Header");
            GameObject trHeaderGo;
            if (trHeaderTransform == null)
            {
                trHeaderGo = new GameObject("Header");
                trHeaderGo.transform.SetParent(tradePanelGo.transform, false);
                var hRect = trHeaderGo.AddComponent<RectTransform>();
                hRect.anchorMin = new Vector2(0, 1);
                hRect.anchorMax = new Vector2(1, 1);
                hRect.pivot = new Vector2(0.5f, 1f);
                hRect.sizeDelta = new Vector2(0, 50);
                hRect.anchoredPosition = Vector2.zero;
                var hImg = trHeaderGo.AddComponent<Image>();
                hImg.color = new Color(0.15f, 0.15f, 0.2f, 1f);
                
                CreateTextObject(trHeaderGo.transform, "TitleText", "MERCHANT TRADE", 22, new Vector2(300, 40), Vector2.zero, font);
                CreateButtonObject(trHeaderGo.transform, "CloseButton", "X", new Vector2(-15, 0), new Vector2(40, 40), font);
            }
            else
            {
                trHeaderGo = trHeaderTransform.gameObject;
            }

            var trCloseBtn = trHeaderGo.transform.Find("CloseButton")?.GetComponent<Button>();
            if (trCloseBtn != null) {
                tpView.btnClose = trCloseBtn;
                ClearPersistentListeners(trCloseBtn, "CloseButton");
                var trCloseBtnRect = trCloseBtn.GetComponent<RectTransform>();
                if (trCloseBtnRect != null)
                {
                    trCloseBtnRect.anchorMin = new Vector2(1, 0.5f);
                    trCloseBtnRect.anchorMax = new Vector2(1, 0.5f);
                    trCloseBtnRect.pivot = new Vector2(1, 0.5f);
                    trCloseBtnRect.anchoredPosition = new Vector2(-15, 0);
                }
            }

            // Ensure StatusSection exists under TradePanel
            var statusSecTransform = tradePanelGo.transform.Find("StatusSection");
            GameObject statusSecGo;
            if (statusSecTransform == null)
            {
                statusSecGo = new GameObject("StatusSection");
                statusSecGo.transform.SetParent(tradePanelGo.transform, false);
                var sRect = statusSecGo.AddComponent<RectTransform>();
                sRect.anchorMin = new Vector2(0, 1);
                sRect.anchorMax = new Vector2(1, 1);
                sRect.pivot = new Vector2(0.5f, 1f);
                sRect.sizeDelta = new Vector2(-40, 60);
                sRect.anchoredPosition = new Vector2(0, -60);

                var layout = statusSecGo.AddComponent<VerticalLayoutGroup>();
                layout.spacing = 4;
                layout.childControlWidth = true;
                layout.childControlHeight = true;
                layout.childForceExpandWidth = true;
                layout.childForceExpandHeight = false;

                CreateTextObject(statusSecGo.transform, "MerchantStatusText", "Merchant: Not Present", 16, Vector2.zero, Vector2.zero, font);
                CreateTextObject(statusSecGo.transform, "DaysUntilNextMerchantText", "Next Arrival: N/A", 14, Vector2.zero, Vector2.zero, font);
            }
            else
            {
                statusSecGo = statusSecTransform.gameObject;
            }

            var mStatusText = statusSecGo.transform.Find("MerchantStatusText")?.GetComponent<Text>();
            if (mStatusText != null) tpView.txtMerchantStatus = mStatusText;
            var mDaysText = statusSecGo.transform.Find("DaysUntilNextMerchantText")?.GetComponent<Text>();
            if (mDaysText != null) tpView.txtDaysUntilNextMerchant = mDaysText;

            // Ensure InventorySection exists under TradePanel
            var invSecTransform = tradePanelGo.transform.Find("InventorySection");
            GameObject invSecGo;
            if (invSecTransform == null)
            {
                invSecGo = new GameObject("InventorySection");
                invSecGo.transform.SetParent(tradePanelGo.transform, false);
                var iRect = invSecGo.AddComponent<RectTransform>();
                iRect.anchorMin = new Vector2(0, 1);
                iRect.anchorMax = new Vector2(1, 1);
                iRect.pivot = new Vector2(0.5f, 1f);
                iRect.sizeDelta = new Vector2(-40, 60);
                iRect.anchoredPosition = new Vector2(0, -130);

                var layout = invSecGo.AddComponent<VerticalLayoutGroup>();
                layout.spacing = 2;
                layout.childControlWidth = true;
                layout.childControlHeight = true;
                layout.childForceExpandWidth = true;
                layout.childForceExpandHeight = false;

                CreateTextObject(invSecGo.transform, "InventoryTitleText", "CURRENT INVENTORY", 14, Vector2.zero, Vector2.zero, font).GetComponent<Text>().color = Color.yellow;
                
                var hGo = new GameObject("Horiz");
                hGo.transform.SetParent(invSecGo.transform, false);
                var hLayout = hGo.AddComponent<HorizontalLayoutGroup>();
                hLayout.spacing = 10;
                hLayout.childControlWidth = true;
                hLayout.childControlHeight = true;
                hLayout.childForceExpandWidth = true;
                hLayout.childForceExpandHeight = false;

                CreateTextObject(hGo.transform, "WoodText", "Wood: 0/250", 13, Vector2.zero, Vector2.zero, font);
                CreateTextObject(hGo.transform, "FoodText", "Food: 0/100", 13, Vector2.zero, Vector2.zero, font);
                CreateTextObject(hGo.transform, "IronText", "Iron: 0/100", 13, Vector2.zero, Vector2.zero, font);
                CreateTextObject(hGo.transform, "CoalText", "Coal: 0/50", 13, Vector2.zero, Vector2.zero, font);
                CreateTextObject(hGo.transform, "SteelText", "Steel: 0/50", 13, Vector2.zero, Vector2.zero, font);
            }
            else
            {
                invSecGo = invSecTransform.gameObject;
            }

            var invHoriz = invSecGo.transform.Find("Horiz");
            if (invHoriz != null) {
                var tW = invHoriz.Find("WoodText")?.GetComponent<Text>(); if (tW != null) tpView.txtWood = tW;
                var tF = invHoriz.Find("FoodText")?.GetComponent<Text>(); if (tF != null) tpView.txtFood = tF;
                var tI = invHoriz.Find("IronText")?.GetComponent<Text>(); if (tI != null) tpView.txtIron = tI;
                var tC = invHoriz.Find("CoalText")?.GetComponent<Text>(); if (tC != null) tpView.txtCoal = tC;
                var tS = invHoriz.Find("SteelText")?.GetComponent<Text>(); if (tS != null) tpView.txtSteel = tS;
            }

            // Ensure OffersSection exists under TradePanel
            var offSecTransform = tradePanelGo.transform.Find("OffersSection");
            GameObject offSecGo;
            if (offSecTransform == null)
            {
                offSecGo = new GameObject("OffersSection");
                offSecGo.transform.SetParent(tradePanelGo.transform, false);
                var oRect = offSecGo.AddComponent<RectTransform>();
                oRect.anchorMin = new Vector2(0, 1);
                oRect.anchorMax = new Vector2(1, 1);
                oRect.pivot = new Vector2(0.5f, 1f);
                oRect.sizeDelta = new Vector2(-40, 240);
                oRect.anchoredPosition = new Vector2(0, -200);

                var layout = offSecGo.AddComponent<VerticalLayoutGroup>();
                layout.spacing = 8;
                layout.childControlWidth = true;
                layout.childControlHeight = true;
                layout.childForceExpandWidth = true;
                layout.childForceExpandHeight = false;

                CreateTextObject(offSecGo.transform, "OffersTitleText", "AVAILABLE TRADE OFFERS", 14, Vector2.zero, Vector2.zero, font).GetComponent<Text>().color = Color.yellow;

                // 4 Offer Rows
                CreateOfferRow(offSecGo.transform, "OfferRow_WoodToIron", "50 Wood -> 10 Iron", font);
                CreateOfferRow(offSecGo.transform, "OfferRow_FoodToWood", "30 Food -> 10 Wood", font);
                CreateOfferRow(offSecGo.transform, "OfferRow_IronToSteel", "20 Iron -> 5 Steel", font);
                CreateOfferRow(offSecGo.transform, "OfferRow_WoodToCoal", "20 Wood -> 10 Coal", font);
            }
            else
            {
                offSecGo = offSecTransform.gameObject;
            }

            // Wire offers to TradePanelView
            WireOfferRowReferences(offSecGo.transform, "OfferRow_WoodToIron", out tpView.btnOfferWoodToIron, out tpView.txtOfferWoodToIronText);
            WireOfferRowReferences(offSecGo.transform, "OfferRow_FoodToWood", out tpView.btnOfferFoodToWood, out tpView.txtOfferFoodToWoodText);
            WireOfferRowReferences(offSecGo.transform, "OfferRow_IronToSteel", out tpView.btnOfferIronToSteel, out tpView.txtOfferIronToSteelText);
            WireOfferRowReferences(offSecGo.transform, "OfferRow_WoodToCoal", out tpView.btnOfferWoodToCoal, out tpView.txtOfferWoodToCoalText);

            // Ensure Footer exists under TradePanel
            var footerTransform = tradePanelGo.transform.Find("Footer");
            GameObject footerGo;
            if (footerTransform == null)
            {
                footerGo = new GameObject("Footer");
                footerGo.transform.SetParent(tradePanelGo.transform, false);
                var fRect = footerGo.AddComponent<RectTransform>();
                fRect.anchorMin = new Vector2(0, 0);
                fRect.anchorMax = new Vector2(1, 0);
                fRect.pivot = new Vector2(0.5f, 0);
                fRect.sizeDelta = new Vector2(0, 80);
                fRect.anchoredPosition = Vector2.zero;

                var fImg = footerGo.AddComponent<Image>();
                fImg.color = new Color(0.15f, 0.15f, 0.2f, 1f);

                var txtGo = CreateTextObject(footerGo.transform, "ResultText", "Merchant is not present.", 14, new Vector2(360, 40), new Vector2(-90, 0), font);
                txtGo.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;

                CreateButtonObject(footerGo.transform, "RefreshButton", "REFRESH", new Vector2(210, 0), new Vector2(120, 40), font);
            }
            else
            {
                footerGo = footerTransform.gameObject;
            }

            var fResultText = footerGo.transform.Find("ResultText")?.GetComponent<Text>();
            if (fResultText != null) tpView.txtResult = fResultText;
            var fRefreshBtn = footerGo.transform.Find("RefreshButton")?.GetComponent<Button>();
            if (fRefreshBtn != null) {
                tpView.btnRefresh = fRefreshBtn;
                ClearPersistentListeners(fRefreshBtn, "RefreshButton");
            }

            // Always active in Edit Mode
            if (!Application.isPlaying)
            {
                tradePanelGo.SetActive(true);
            }

            uiManager.tradePanel = tradePanelGo;
            uiManager.tradePanelView = tpView;

            // Ensure TradeOpenButton exists inside BottomActionBar
            if (bottomBarGo != null)
            {
                var trOpenBtnTransform = bottomBarGo.transform.Find("TradeOpenButton");
                GameObject trOpenBtnGo;
                if (trOpenBtnTransform == null)
                {
                    trOpenBtnGo = new GameObject("TradeOpenButton");
                    trOpenBtnGo.transform.SetParent(bottomBarGo.transform, false);
                    var openRect = trOpenBtnGo.AddComponent<RectTransform>();
                    openRect.sizeDelta = new Vector2(80, 50);
                    openRect.anchoredPosition = new Vector2(60, 0); // Positioned next to Next Phase

                    var openImg = trOpenBtnGo.AddComponent<Image>();
                    openImg.color = new Color(0.2f, 0.6f, 0.8f);

                    trOpenBtnGo.AddComponent<Button>();

                    var openTxtGo = CreateTextObject(trOpenBtnGo.transform, "Text", "Trade", 18, Vector2.zero, Vector2.zero, font);
                    var openTxtRect = openTxtGo.GetComponent<RectTransform>();
                    openTxtRect.anchorMin = Vector2.zero;
                    openTxtRect.anchorMax = Vector2.one;
                    openTxtRect.sizeDelta = Vector2.zero;
                    openTxtGo.GetComponent<Text>().color = Color.white;
                }
                else
                {
                    trOpenBtnGo = trOpenBtnTransform.gameObject;
                    if (trOpenBtnGo.GetComponent<Button>() == null)
                    {
                        trOpenBtnGo.AddComponent<Button>();
                    }
                }

                var openBtnComp = trOpenBtnGo.GetComponent<Button>();
                ClearPersistentListeners(openBtnComp, "TradeOpenButton");
                uiManager.tradeOpenButton = openBtnComp;
            }

            if (!Application.isPlaying)
            {
                EditorUtility.SetDirty(tradePanelGo);
                EditorUtility.SetDirty(tpView);
            }

            // Log that scene-owned panel is ready
            UnityEngine.Debug.Log("[Trade UI] Scene-owned TradePanel ready.");

            // --- 17. MERCHANT ARRIVAL NOTIFICATION PANEL ---
            var notifPanelGo = FindChildByNames(hudRootGo.transform, new[] { "MerchantNotificationPanel" });
            if (notifPanelGo == null)
            {
                notifPanelGo = new GameObject("MerchantNotificationPanel");
                notifPanelGo.transform.SetParent(hudRootGo.transform, false);
                var rect = notifPanelGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 1f);
                rect.anchorMax = new Vector2(0.5f, 1f);
                rect.pivot = new Vector2(0.5f, 1f);
                rect.sizeDelta = new Vector2(400, 50);
                rect.anchoredPosition = new Vector2(0, -80);

                var view = notifPanelGo.AddComponent<MerchantNotificationView>();
                view.panel = notifPanelGo;

                // Background
                var bgGo = new GameObject("Background");
                bgGo.transform.SetParent(notifPanelGo.transform, false);
                var bgRect = bgGo.AddComponent<RectTransform>();
                bgRect.anchorMin = Vector2.zero;
                bgRect.anchorMax = Vector2.one;
                bgRect.sizeDelta = Vector2.zero;
                bgRect.anchoredPosition = Vector2.zero;
                var bgImg = bgGo.AddComponent<Image>();
                bgImg.color = new Color(0.1f, 0.1f, 0.1f, 0.9f);

                // MessageText
                var txtGo = CreateTextObject(notifPanelGo.transform, "MessageText", "", 18, Vector2.zero, Vector2.zero, font);
                var txtRect = txtGo.GetComponent<RectTransform>();
                txtRect.anchorMin = Vector2.zero;
                txtRect.anchorMax = Vector2.one;
                txtRect.sizeDelta = Vector2.zero;
                txtRect.anchoredPosition = Vector2.zero;
                view.txtMessage = txtGo.GetComponent<Text>();

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing MerchantNotificationPanel");
            }
            else
            {
                var view = notifPanelGo.GetComponent<MerchantNotificationView>();
                if (view == null) view = notifPanelGo.AddComponent<MerchantNotificationView>();
                view.panel = notifPanelGo;

                var bgTransform = notifPanelGo.transform.Find("Background");
                if (bgTransform == null)
                {
                    var bgGo = new GameObject("Background");
                    bgGo.transform.SetParent(notifPanelGo.transform, false);
                    var bgRect = bgGo.AddComponent<RectTransform>();
                    bgRect.anchorMin = Vector2.zero;
                    bgRect.anchorMax = Vector2.one;
                    bgRect.sizeDelta = Vector2.zero;
                    bgRect.anchoredPosition = Vector2.zero;
                    var bgImg = bgGo.AddComponent<Image>();
                    bgImg.color = new Color(0.1f, 0.1f, 0.1f, 0.9f);
                }

                var txtTransform = notifPanelGo.transform.Find("MessageText");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(notifPanelGo.transform, "MessageText", "", 18, Vector2.zero, Vector2.zero, font);
                    var txtRect = txtGo.GetComponent<RectTransform>();
                    txtRect.anchorMin = Vector2.zero;
                    txtRect.anchorMax = Vector2.one;
                    txtRect.sizeDelta = Vector2.zero;
                    txtRect.anchoredPosition = Vector2.zero;
                    view.txtMessage = txtGo.GetComponent<Text>();
                }
                else
                {
                    view.txtMessage = txtTransform.GetComponent<Text>();
                }

                preservedCount++;
            }

            // Always make sure it is active in Edit Mode
            if (!Application.isPlaying)
            {
                notifPanelGo.SetActive(true);
                EditorUtility.SetDirty(notifPanelGo);
                var view = notifPanelGo.GetComponent<MerchantNotificationView>();
                if (view != null) EditorUtility.SetDirty(view);
            }

            uiManager.merchantNotificationView = notifPanelGo.GetComponent<MerchantNotificationView>();

            // --- 18. OBJECTIVE TRACKER PANEL ---
            var objTrackerGo = FindChildByNames(hudRootGo.transform, new[] { "ObjectiveTrackerPanel" });
            if (objTrackerGo == null)
            {
                objTrackerGo = new GameObject("ObjectiveTrackerPanel");
                objTrackerGo.transform.SetParent(hudRootGo.transform, false);
                var rect = objTrackerGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 1);
                rect.anchorMax = new Vector2(1, 1);
                rect.pivot = new Vector2(1, 1);
                rect.sizeDelta = new Vector2(300, 150);
                rect.anchoredPosition = new Vector2(-20, -100);

                var img = objTrackerGo.AddComponent<Image>();
                img.color = new Color(0, 0, 0, 0.4f);

                var view = objTrackerGo.AddComponent<ObjectiveTrackerView>();
                var txtGo = CreateTextObject(objTrackerGo.transform, "Text", "OBJECTIVES", 14, new Vector2(280, 130), new Vector2(0, -10), font);
                view.txtObjectives = txtGo.GetComponent<Text>();
                view.txtObjectives.alignment = TextAnchor.UpperRight;

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing ObjectiveTrackerPanel");
            }
            else
            {
                var view = objTrackerGo.GetComponent<ObjectiveTrackerView>();
                if (view == null) view = objTrackerGo.AddComponent<ObjectiveTrackerView>();

                var txtTransform = objTrackerGo.transform.Find("Text");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(objTrackerGo.transform, "Text", "OBJECTIVES", 14, new Vector2(280, 130), new Vector2(0, -10), font);
                    view.txtObjectives = txtGo.GetComponent<Text>();
                    view.txtObjectives.alignment = TextAnchor.UpperRight;
                }
                else if (view.txtObjectives == null)
                {
                    view.txtObjectives = txtTransform.GetComponent<Text>();
                }
                preservedCount++;
            }
            uiManager.objectiveTrackerView = objTrackerGo.GetComponent<ObjectiveTrackerView>();

            // --- 19. QUEST/ACHIEVEMENT NOTIFICATION PANEL ---
            var qaNotifGo = FindChildByNames(hudRootGo.transform, new[] { "QuestAchievementNotificationPanel" });
            if (qaNotifGo == null)
            {
                qaNotifGo = new GameObject("QuestAchievementNotificationPanel");
                qaNotifGo.transform.SetParent(hudRootGo.transform, false);
                var rect = qaNotifGo.AddComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 0);
                rect.anchorMax = new Vector2(0.5f, 0);
                rect.pivot = new Vector2(0.5f, 0);
                rect.sizeDelta = new Vector2(500, 80);
                rect.anchoredPosition = new Vector2(0, 150);

                var img = qaNotifGo.AddComponent<Image>();
                img.color = new Color(0.1f, 0.2f, 0.1f, 0.95f);

                var view = qaNotifGo.AddComponent<QuestAchievementNotificationView>();
                var txtGo = CreateTextObject(qaNotifGo.transform, "Text", "Notification", 18, new Vector2(380, 60), new Vector2(-40, 0), font);
                view.txtNotification = txtGo.GetComponent<Text>();

                var btnGo = CreateButtonObject(qaNotifGo.transform, "BtnDismiss", "X", new Vector2(200, 0), new Vector2(60, 40), font);
                view.btnDismiss = btnGo.GetComponent<Button>();

                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing QuestAchievementNotificationPanel");
            }
            else
            {
                var view = qaNotifGo.GetComponent<QuestAchievementNotificationView>();
                if (view == null) view = qaNotifGo.AddComponent<QuestAchievementNotificationView>();

                var txtTransform = qaNotifGo.transform.Find("Text");
                if (txtTransform == null)
                {
                    var txtGo = CreateTextObject(qaNotifGo.transform, "Text", "Notification", 18, new Vector2(380, 60), new Vector2(-40, 0), font);
                    view.txtNotification = txtGo.GetComponent<Text>();
                }
                else if (view.txtNotification == null)
                {
                    view.txtNotification = txtTransform.GetComponent<Text>();
                }

                var btnTransform = qaNotifGo.transform.Find("BtnDismiss");
                if (btnTransform == null)
                {
                    var btnGo = CreateButtonObject(qaNotifGo.transform, "BtnDismiss", "X", new Vector2(200, 0), new Vector2(60, 40), font);
                    view.btnDismiss = btnGo.GetComponent<Button>();
                }
                else if (view.btnDismiss == null)
                {
                    view.btnDismiss = btnTransform.GetComponent<Button>();
                }

                preservedCount++;
            }
            uiManager.questNotificationView = qaNotifGo.GetComponent<QuestAchievementNotificationView>();
            qaNotifGo.transform.SetAsLastSibling(); // Ensure it is on top of other elements to receive raycasts first!
            qaNotifGo.SetActive(false); // Default hidden

            // --- 20. TITAN BOSS PANEL ---
            var titanPanelGo = FindChildByNames(hudRootGo.transform, new[] { "TitanBossPanel" });
            TitanBossPanelView titanView = null;
            if (titanPanelGo == null)
            {
                titanPanelGo = new GameObject("TitanBossPanel");
                titanPanelGo.transform.SetParent(hudRootGo.transform, false);
                createdCount++;
                UnityEngine.Debug.Log("[RECOVERY] Recreated missing TitanBossPanel");
            }
            else
            {
                preservedCount++;
            }

            var titanRect = titanPanelGo.GetComponent<RectTransform>();
            if (titanRect == null) titanRect = titanPanelGo.AddComponent<RectTransform>();
            titanRect.anchorMin = new Vector2(0.5f, 0.5f);
            titanRect.anchorMax = new Vector2(0.5f, 0.5f);
            titanRect.pivot = new Vector2(0.5f, 0.5f);
            titanRect.sizeDelta = new Vector2(550, 260);
            titanRect.anchoredPosition = new Vector2(0, 240);

            var titanImg = titanPanelGo.GetComponent<Image>();
            if (titanImg == null) titanImg = titanPanelGo.AddComponent<Image>();
            titanImg.color = new Color(0.15f, 0.05f, 0.05f, 0.9f); // Dark red theme for boss fight

            titanView = titanPanelGo.GetComponent<TitanBossPanelView>();
            if (titanView == null) titanView = titanPanelGo.AddComponent<TitanBossPanelView>();

            // Create/Find TitleText
            var titleTransform = titanPanelGo.transform.Find("TitleText");
            GameObject titanTitleTxtGo;
            if (titleTransform == null) {
                titanTitleTxtGo = CreateTextObject(titanPanelGo.transform, "TitleText", "Fallen Titan", 20, new Vector2(300, 30), new Vector2(100, 100), font);
            } else {
                titanTitleTxtGo = titleTransform.gameObject;
                var r = titanTitleTxtGo.GetComponent<RectTransform>();
                r.sizeDelta = new Vector2(300, 30);
                r.anchoredPosition = new Vector2(100, 100);
            }
            titanView.titleText = titanTitleTxtGo.GetComponent<Text>();
            titanView.titleText.alignment = TextAnchor.MiddleCenter;

            // Create/Find ExplanationText
            var explanationTransform = titanPanelGo.transform.Find("ExplanationText");
            GameObject titanExplanationTxtGo;
            if (explanationTransform == null) {
                titanExplanationTxtGo = CreateTextObject(titanPanelGo.transform, "ExplanationText", "Each attack sends all ready Guards into one battle round.\nGuards damage the Titan. The Titan deals return damage.", 12, new Vector2(300, 40), new Vector2(100, 5), font);
            } else {
                titanExplanationTxtGo = explanationTransform.gameObject;
                var r = titanExplanationTxtGo.GetComponent<RectTransform>();
                r.sizeDelta = new Vector2(300, 40);
                r.anchoredPosition = new Vector2(100, 5);
            }
            titanView.explanationText = titanExplanationTxtGo.GetComponent<Text>();
            titanView.explanationText.alignment = TextAnchor.MiddleCenter;
            titanView.explanationText.color = new Color(0.8f, 0.8f, 0.8f, 1f);

            // Create/Find StatusText
            var statusTransform = titanPanelGo.transform.Find("StatusText");
            GameObject titanStatusTxtGo;
            if (statusTransform == null) {
                titanStatusTxtGo = CreateTextObject(titanPanelGo.transform, "StatusText", "No ready Guards. Assign villagers as Guards before attacking.", 14, new Vector2(300, 40), new Vector2(100, -85), font);
            } else {
                titanStatusTxtGo = statusTransform.gameObject;
                var r = titanStatusTxtGo.GetComponent<RectTransform>();
                r.sizeDelta = new Vector2(300, 40);
                r.anchoredPosition = new Vector2(100, -85);
            }
            titanView.statusText = titanStatusTxtGo.GetComponent<Text>();
            titanView.statusText.alignment = TextAnchor.MiddleCenter;

            // Create/Find HpText
            var hpTransform = titanPanelGo.transform.Find("HpText");
            GameObject titanHpTxtGo;
            if (hpTransform == null) {
                titanHpTxtGo = CreateTextObject(titanPanelGo.transform, "HpText", "HP: 500/500", 16, new Vector2(300, 20), new Vector2(100, 70), font);
            } else {
                titanHpTxtGo = hpTransform.gameObject;
                var r = titanHpTxtGo.GetComponent<RectTransform>();
                r.sizeDelta = new Vector2(300, 20);
                r.anchoredPosition = new Vector2(100, 70);
            }
            titanView.hpText = titanHpTxtGo.GetComponent<Text>();
            titanView.hpText.alignment = TextAnchor.MiddleCenter;

            // Create/Find HpSlider/HpBar
            var sliderTransform = titanPanelGo.transform.Find("HpSlider");
            GameObject titanSliderGo;
            if (sliderTransform == null) {
                titanSliderGo = new GameObject("HpSlider");
                titanSliderGo.transform.SetParent(titanPanelGo.transform, false);
                var sliderRect = titanSliderGo.AddComponent<RectTransform>();
                sliderRect.anchorMin = new Vector2(0.5f, 0.5f);
                sliderRect.anchorMax = new Vector2(0.5f, 0.5f);
                sliderRect.pivot = new Vector2(0.5f, 0.5f);
                sliderRect.sizeDelta = new Vector2(260, 18);
                sliderRect.anchoredPosition = new Vector2(100, 45);

                var sliderImg = titanSliderGo.AddComponent<Image>();
                sliderImg.color = Color.black;
                var sliderComp = titanSliderGo.AddComponent<Slider>();

                var fillAreaGo = new GameObject("Fill Area");
                fillAreaGo.transform.SetParent(titanSliderGo.transform, false);
                var fillAreaRect = fillAreaGo.AddComponent<RectTransform>();
                fillAreaRect.anchorMin = Vector2.zero;
                fillAreaRect.anchorMax = Vector2.one;
                fillAreaRect.sizeDelta = Vector2.zero;

                var fillGo = new GameObject("Fill");
                fillGo.transform.SetParent(fillAreaGo.transform, false);
                var fillRect = fillGo.AddComponent<RectTransform>();
                fillRect.anchorMin = Vector2.zero;
                fillRect.anchorMax = Vector2.one;
                fillRect.sizeDelta = Vector2.zero;
                var fillImg = fillGo.AddComponent<Image>();
                fillImg.color = Color.red;

                sliderComp.targetGraphic = sliderImg;
                sliderComp.fillRect = fillRect;
                titanView.hpSlider = sliderComp;
            } else {
                titanSliderGo = sliderTransform.gameObject;
                var sliderRect = titanSliderGo.GetComponent<RectTransform>();
                sliderRect.sizeDelta = new Vector2(260, 18);
                sliderRect.anchoredPosition = new Vector2(100, 45);
                titanView.hpSlider = titanSliderGo.GetComponent<Slider>();
            }

            // Create/Find BtnAttackTitan
            var titanBtnTransform = titanPanelGo.transform.Find("BtnAttackTitan");
            GameObject titanBtnGo;
            if (titanBtnTransform == null) {
                titanBtnGo = CreateButtonObject(titanPanelGo.transform, "BtnAttackTitan", "Attack Titan", new Vector2(100, -45), new Vector2(160, 35), font);
            } else {
                titanBtnGo = titanBtnTransform.gameObject;
                var r = titanBtnGo.GetComponent<RectTransform>();
                r.anchoredPosition = new Vector2(100, -45);
                r.sizeDelta = new Vector2(160, 35);
            }
            titanView.btnAttackTitan = titanBtnGo.GetComponent<Button>();

            // Create/Find TitanAvatar
            var avatarTransform = titanPanelGo.transform.Find("TitanAvatar");
            GameObject titanAvatarGo;
            Sprite bossSprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/_Project/ImportedDecoded/Sprite/BOSS.png");

            if (avatarTransform == null) {
                titanAvatarGo = new GameObject("TitanAvatar");
                titanAvatarGo.transform.SetParent(titanPanelGo.transform, false);
                var avatarRect = titanAvatarGo.AddComponent<RectTransform>();
                avatarRect.anchorMin = new Vector2(0.5f, 0.5f);
                avatarRect.anchorMax = new Vector2(0.5f, 0.5f);
                avatarRect.pivot = new Vector2(0.5f, 0.5f);
                avatarRect.sizeDelta = new Vector2(180, 200);
                avatarRect.anchoredPosition = new Vector2(-150, 0);
            } else {
                titanAvatarGo = avatarTransform.gameObject;
                var avatarRect = titanAvatarGo.GetComponent<RectTransform>();
                avatarRect.sizeDelta = new Vector2(180, 200);
                avatarRect.anchoredPosition = new Vector2(-150, 0);

                // If legacy Image component exists directly on TitanAvatar, destroy it to keep hierarchy clean
                var legacyImg = titanAvatarGo.GetComponent<Image>();
                if (legacyImg != null) {
                    UnityEngine.Object.DestroyImmediate(legacyImg);
                }

                // If legacy AvatarIcon exists under TitanAvatar, destroy it
                var legacyIcon = titanAvatarGo.transform.Find("AvatarIcon");
                if (legacyIcon != null) {
                    UnityEngine.Object.DestroyImmediate(legacyIcon.gameObject);
                }
            }
            titanView.titanAvatar = titanAvatarGo;

            // Create/Find TitanAvatarImage child
            var avatarImgTransform = titanAvatarGo.transform.Find("TitanAvatarImage");
            GameObject titanAvatarImgGo;
            if (avatarImgTransform == null) {
                titanAvatarImgGo = new GameObject("TitanAvatarImage");
                titanAvatarImgGo.transform.SetParent(titanAvatarGo.transform, false);
                var r = titanAvatarImgGo.AddComponent<RectTransform>();
                r.anchorMin = Vector2.zero;
                r.anchorMax = Vector2.one;
                r.sizeDelta = Vector2.zero;
                r.pivot = new Vector2(0.5f, 0.5f);
                r.anchoredPosition = Vector2.zero;
            } else {
                titanAvatarImgGo = avatarImgTransform.gameObject;
                var r = titanAvatarImgGo.GetComponent<RectTransform>();
                r.anchorMin = Vector2.zero;
                r.anchorMax = Vector2.one;
                r.sizeDelta = Vector2.zero;
                r.pivot = new Vector2(0.5f, 0.5f);
                r.anchoredPosition = Vector2.zero;
            }

            var avatarImg = titanAvatarImgGo.GetComponent<Image>();
            if (avatarImg == null) avatarImg = titanAvatarImgGo.AddComponent<Image>();
            avatarImg.sprite = bossSprite;
            avatarImg.color = Color.white;
            titanView.titanAvatarImage = avatarImg;

            // Create/Find AvatarLabel child under TitanAvatar
            var labelTransform = titanAvatarGo.transform.Find("AvatarLabel");
            GameObject labelGo;
            if (labelTransform == null) {
                labelGo = CreateTextObject(titanAvatarGo.transform, "AvatarLabel", "Fallen Titan", 16, new Vector2(160, 30), new Vector2(0, -70), font);
            } else {
                labelGo = labelTransform.gameObject;
                var r = labelGo.GetComponent<RectTransform>();
                r.sizeDelta = new Vector2(160, 30);
                r.anchoredPosition = new Vector2(0, -70);
            }
            var labelTxt = labelGo.GetComponent<Text>();
            labelTxt.alignment = TextAnchor.MiddleCenter;
            labelTxt.color = Color.red;

            uiManager.titanBossPanelView = titanView;
            titanPanelGo.transform.SetAsLastSibling();
            titanPanelGo.SetActive(false); // Default disabled in Edit Mode/Start

            // 14. Mark active scene dirty
            if (!Application.isPlaying)
            {
                if (uiManager != null) EditorUtility.SetDirty(uiManager);
                if (hudRootGo != null) EditorUtility.SetDirty(hudRootGo);
                if (titanView != null) EditorUtility.SetDirty(titanView);
                if (titanPanelGo != null) EditorUtility.SetDirty(titanPanelGo);
                if (selView != null) EditorUtility.SetDirty(selView);
                if (selPanelGo != null) EditorUtility.SetDirty(selPanelGo);
                if (blacksmithCraftGo != null) EditorUtility.SetDirty(blacksmithCraftGo);
                if (wmpView != null) EditorUtility.SetDirty(wmpView);
                if (worldMapPanelGo != null) EditorUtility.SetDirty(worldMapPanelGo);
                if (tradePanelGo != null) EditorUtility.SetDirty(tradePanelGo);
                if (tpView != null) EditorUtility.SetDirty(tpView);
                if (notifPanelGo != null) EditorUtility.SetDirty(notifPanelGo);
                EditorSceneManager.MarkSceneDirty(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
                EditorSceneManager.SaveScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene());
            }


            string msg = $"Recovery complete: {createdCount} UI panels recreated, {preservedCount} preserved.";
            UnityEngine.Debug.Log($"[RECOVERY] {msg}");
            if (!Application.isBatchMode)
            {
                EditorUtility.DisplayDialog("Ensure Scene-Owned UI Panels", msg, "OK");
            }
        }

        private static GameObject FindChildByNames(Transform parent, string[] names)
        {
            foreach (var name in names)
            {
                var t = parent.Find(name);
                if (t != null) return t.gameObject;
            }
            return null;
        }

        private static Font GetDefaultFont()
        {
            Font font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            if (font == null) font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            return font;
        }

        private static GameObject CreateCanvas(string name)
        {
            var go = new GameObject(name);
            var canvas = go.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            var scaler = go.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1080, 1920);
            scaler.matchWidthOrHeight = 0.5f;
            go.AddComponent<GraphicRaycaster>();
            if (Object.FindFirstObjectByType<UnityEngine.EventSystems.EventSystem>() == null)
            {
                var eventSystem = new GameObject("EventSystem");
                eventSystem.AddComponent<UnityEngine.EventSystems.EventSystem>();
                eventSystem.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
            }
            return go;
        }

        private static GameObject CreateTextObject(Transform parent, string name, string content, int fontSize, Vector2 size, Vector2 pos, Font font)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            if (size != Vector2.zero) rect.sizeDelta = size;
            
            var txt = go.AddComponent<Text>();
            txt.text = content;
            txt.color = Color.white;
            txt.fontSize = fontSize;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.font = font;
            return go;
        }

        private static GameObject CreateButtonObject(Transform parent, string name, string label, Vector2 pos, Vector2 size, Font font)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            if (size != Vector2.zero) rect.sizeDelta = size;

            var img = go.AddComponent<Image>();
            img.color = new Color(0.2f, 0.6f, 0.8f);
            go.AddComponent<Button>();

            // Add LayoutElement to prevent collapse inside LayoutGroups
            var le = go.AddComponent<LayoutElement>();
            le.minWidth = size.x > 0 ? size.x : 100;
            le.minHeight = size.y > 0 ? size.y : 40;
            le.preferredWidth = size.x > 0 ? size.x : 100;
            le.preferredHeight = size.y > 0 ? size.y : 40;

            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(go.transform, false);
            var txtRect = txtGo.AddComponent<RectTransform>();
            txtRect.anchorMin = Vector2.zero;
            txtRect.anchorMax = Vector2.one;
            txtRect.sizeDelta = Vector2.zero;

            var txt = txtGo.AddComponent<Text>();
            txt.text = label;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.color = Color.white;
            txt.fontSize = 24;
            txt.font = font;
            txt.resizeTextForBestFit = true;
            txt.resizeTextMinSize = 10;
            txt.resizeTextMaxSize = 24;
            txt.horizontalOverflow = HorizontalWrapMode.Wrap;
            txt.verticalOverflow = VerticalWrapMode.Truncate;

            return go;
        }

        private static string EditorFormatBuildingCost(TheBonwater.Rebuild.Data.DataRepository repo, string buildingId) {
            if (repo == null) return "(- COST)";
            var def = repo.GetBuilding(buildingId);
            if (def == null || def.costs == null || def.costs.Count == 0) return "(FREE)";
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("(-");
            bool first = true;
            foreach(var kvp in def.costs) {
                if (!first) sb.Append(", -");
                var resDef = repo.GetResource(kvp.Key);
                string resName = resDef?.displayName ?? kvp.Key;
                sb.Append($"{kvp.Value} {resName.ToUpper()}");
                first = false;
            }
            sb.Append(")");
            return sb.ToString();
        }

        private static Transform FindDeepChild(Transform parent, string name)
        {
            if (parent.name == name) return parent;
            foreach (Transform child in parent)
            {
                var result = FindDeepChild(child, name);
                if (result != null) return result;
            }
            return null;
        }

        private static void CreateEditModeSectionHeader(Transform parent, string title, Font font)
        {
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
            txt.font = font;
            txt.text = title.ToUpper();
            txt.alignment = TextAnchor.MiddleLeft;
            txt.color = Color.yellow;
            txt.fontSize = 14;
            txt.fontStyle = FontStyle.Bold;
        }

        private static GameObject CreateEditModeButton(Transform parent, string name, string label, Font font)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);

            var img = go.AddComponent<Image>();
            if (name == "Btn_Cancel")
            {
                img.color = new Color(0.8f, 0.2f, 0.2f); // Red close
            }
            else
            {
                img.color = new Color(0.25f, 0.5f, 0.85f); // Blue action
            }
            
            go.AddComponent<Button>();

            var le = go.AddComponent<LayoutElement>();
            le.minHeight = 42;

            var txtGo = new GameObject("Text");
            txtGo.transform.SetParent(go.transform, false);
            var txtRt = txtGo.AddComponent<RectTransform>();
            txtRt.anchorMin = Vector2.zero;
            txtRt.anchorMax = Vector2.one;
            txtRt.sizeDelta = Vector2.zero;

            var txt = txtGo.AddComponent<Text>();
            txt.font = font;
            txt.text = label;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.color = Color.white;
            txt.fontSize = 22;

            return go;
        }

        private static void CreateOfferRow(Transform parent, string name, string offerText, Font font)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            var rect = go.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(0, 42);

            var layout = go.AddComponent<HorizontalLayoutGroup>();
            layout.spacing = 15;
            layout.childControlWidth = true;
            layout.childControlHeight = true;
            layout.childForceExpandWidth = false;
            layout.childForceExpandHeight = false;

            var txtGo = CreateTextObject(go.transform, "OfferText", offerText, 14, new Vector2(300, 38), Vector2.zero, font);
            txtGo.GetComponent<Text>().alignment = TextAnchor.MiddleLeft;

            var btnGo = CreateButtonObject(go.transform, "TradeButton", "Trade", new Vector2(0, 0), new Vector2(100, 38), font);
            var btnTxt = btnGo.transform.Find("Text")?.GetComponent<Text>();
            if (btnTxt != null) btnTxt.fontSize = 14;
        }

        private static void WireOfferRowReferences(Transform parent, string rowName, out Button button, out Text text)
        {
            button = null;
            text = null;
            var row = parent.Find(rowName);
            if (row != null)
            {
                button = row.Find("TradeButton")?.GetComponent<Button>();
                text = row.Find("OfferText")?.GetComponent<Text>();
            }
        }

        private static void ClearPersistentListeners(Button button, string objectName)
        {
            if (button == null) return;
            int count = button.onClick.GetPersistentEventCount();
            if (count > 0)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    UnityEditor.Events.UnityEventTools.RemovePersistentListener(button.onClick, i);
                }
                UnityEngine.Debug.Log($"[WorldMap UI] Removed duplicate listener source={objectName}");
            }
        }
    }
}
#endif
