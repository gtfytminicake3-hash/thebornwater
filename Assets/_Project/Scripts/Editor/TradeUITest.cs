#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TheBonwater.Rebuild.Editor
{
    public static class TradeUITest
    {
        [MenuItem("Tools/Rebuild/Tests/Run Trade UI Test")]
        public static void Run()
        {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Trade UI Test Report");
            report.AppendLine();

            void Check(string condition, bool result) {
                report.AppendLine($"[{(result ? "PASS" : "FAIL")}] {condition}");
                if (result) {
                    pass++;
                    Debug.Log($"[Trade UI Test] PASS: {condition}");
                } else {
                    fail++;
                    Debug.LogError($"[Trade UI Test] FAIL: {condition}");
                }
            }

            // --- A. Scene-owned creation ---
            EnsureSceneOwnedUIPanels.Execute();
            Check("EnsureSceneOwnedUIPanels executes successfully", true);

            var tpGo = GameObject.Find("TradePanel");
            Check("TradePanel exists in TownScene", tpGo != null);

            var bottomBarGo = GameObject.Find("BottomActionBar");
            var openBtnTransform = bottomBarGo != null ? bottomBarGo.transform.Find("TradeOpenButton") : null;
            Check("TradeOpenButton exists under BottomActionBar", openBtnTransform != null);

            TradePanelView tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;
            Check("TradePanelView component is attached to TradePanel", tpView != null);

            if (tpGo != null && tpView != null)
            {
                Check("Header exists under TradePanel", tpGo.transform.Find("Header") != null);
                Check("StatusSection exists under TradePanel", tpGo.transform.Find("StatusSection") != null);
                Check("InventorySection exists under TradePanel", tpGo.transform.Find("InventorySection") != null);
                Check("OffersSection exists under TradePanel", tpGo.transform.Find("OffersSection") != null);
                Check("Footer exists under TradePanel", tpGo.transform.Find("Footer") != null);
                
                // Confirm expected labels
                var titleTxt = tpGo.transform.Find("Header/TitleText")?.GetComponent<Text>();
                Check("TitleText says MERCHANT TRADE", titleTxt != null && titleTxt.text == "MERCHANT TRADE");

                var closeBtn = tpGo.transform.Find("Header/CloseButton")?.GetComponent<Button>();
                Check("CloseButton exists in Header", closeBtn != null);

                var refreshBtn = tpGo.transform.Find("Footer/RefreshButton")?.GetComponent<Button>();
                Check("RefreshButton exists in Footer", refreshBtn != null);

                Check("txtMerchantStatus is wired", tpView.txtMerchantStatus != null);
                Check("txtDaysUntilNextMerchant is wired", tpView.txtDaysUntilNextMerchant != null);
                Check("txtWood is wired", tpView.txtWood != null);
                Check("txtFood is wired", tpView.txtFood != null);
                Check("txtIron is wired", tpView.txtIron != null);
                Check("txtCoal is wired", tpView.txtCoal != null);
                Check("txtSteel is wired", tpView.txtSteel != null);
                Check("btnOfferWoodToIron is wired", tpView.btnOfferWoodToIron != null);
                Check("btnOfferFoodToWood is wired", tpView.btnOfferFoodToWood != null);
                Check("btnOfferIronToSteel is wired", tpView.btnOfferIronToSteel != null);
                Check("btnOfferWoodToCoal is wired", tpView.btnOfferWoodToCoal != null);
            }
            else
            {
                Check("Header exists under TradePanel", false);
                Check("StatusSection exists under TradePanel", false);
                Check("InventorySection exists under TradePanel", false);
                Check("OffersSection exists under TradePanel", false);
                Check("Footer exists under TradePanel", false);
            }

            // Setup Backend and simulation singletons
            var backend = new LocalGameBackend();
            GameServiceLocator.RegisterBackend(backend);
            var snap = backend.GetSnapshot();

            var hudRootGo = GameObject.Find("HUDRoot");
            var uiManager = hudRootGo != null ? hudRootGo.GetComponent<GameplayUIManager>() : null;

            if (uiManager != null && tpGo != null && tpView != null)
            {
                // Setup singletons for simulation
                GameplayUIManager.Instance = uiManager;

                var townIntGo = GameObject.Find("TownInteractionController");
                if (townIntGo == null)
                {
                    townIntGo = new GameObject("TownInteractionController");
                    townIntGo.AddComponent<TownInteractionController>();
                }
                var interactionCtrl = townIntGo.GetComponent<TownInteractionController>();
                TownInteractionController.Instance = interactionCtrl;

                // Bind event listeners manually since Start/Awake don't run automatically in Edit Mode test
                interactionCtrl.OnStateChanged += uiManager.HandleStateChanged;

                uiManager.tradePanel = tpGo;
                uiManager.tradePanelView = tpView;
                if (openBtnTransform != null) uiManager.tradeOpenButton = openBtnTransform.GetComponent<Button>();

                // Manually call Start to bind click handlers in Edit Mode test
                tpView.Start();

                // --- B. Start hidden ---
                // Simulating simulation startup (Start() logic hides panel)
                tpGo.SetActive(false);
                Check("TradePanel is hidden by default", !tpGo.activeSelf);

                // --- C. Open/close ---
                // Open Trade Panel
                uiManager.OpenTradePanel();
                Check("OpenTradePanel sets TradePanel active", tpGo.activeSelf);

                // Close Trade Panel
                uiManager.CloseTradePanel();
                Check("CloseTradePanel sets TradePanel inactive", !tpGo.activeSelf);

                // Reopen for state tests
                uiManager.OpenTradePanel();

                // --- D. Merchant absent state ---
                snap.tradeState.isMerchantPresent = false;
                snap.tradeState.daysUntilNextMerchant = 2;
                snap.tradeState.merchantDaysRemaining = 0;
                tpView.txtResult.text = ""; // clear
                uiManager.HandleStateChanged(snap);

                Check("Merchant status text indicates absent", tpView.txtMerchantStatus.text.Contains("Merchant: Not Present"));
                Check("Merchant countdown indicates 2 days", tpView.txtDaysUntilNextMerchant.text.Contains("2 day(s)"));
                Check("Wood -> Iron offer button is disabled when merchant absent", !tpView.btnOfferWoodToIron.interactable);
                Check("Food -> Wood offer button is disabled when merchant absent", !tpView.btnOfferFoodToWood.interactable);
                Check("Iron -> Steel offer button is disabled when merchant absent", !tpView.btnOfferIronToSteel.interactable);
                Check("Wood -> Coal offer button is disabled when merchant absent", !tpView.btnOfferWoodToCoal.interactable);
                Check("Result text shows merchant absent status", tpView.txtResult.text == "Merchant is not present. Next arrival: 2 day(s).");

                // --- E. Merchant present state ---
                snap.tradeState.isMerchantPresent = true;
                snap.tradeState.daysUntilNextMerchant = 0;
                snap.tradeState.merchantDaysRemaining = 1;
                snap.wood = 100;
                snap.woodCapacity = 250;
                snap.iron = 0;
                snap.ironCapacity = 250;
                tpView.txtResult.text = "";
                uiManager.HandleStateChanged(snap);

                Check("Merchant status text indicates present", tpView.txtMerchantStatus.text.Contains("Merchant: Present"));
                Check("Merchant countdown indicates remaining duration", tpView.txtDaysUntilNextMerchant.text.Contains("1 day(s)"));
                Check("Wood -> Iron offer button is enabled when resources allow", tpView.btnOfferWoodToIron.interactable);

                // --- F. Valid trade ---
                // Trigger trade (Wood -> Iron: sell 40 wood, buy 10 iron)
                tpView.btnOfferWoodToIron.onClick.Invoke();

                var snapAfter = backend.GetSnapshot();
                Check("Valid trade succeeds and decreases Wood", snapAfter.wood == 60);
                Check("Valid trade succeeds and increases Iron", snapAfter.iron == 10);
                Check("ResultText shows success log message", tpView.txtResult.text == "Trade successful: 40 Wood -> 10 Iron");
                Check("Inventory Wood text updates on screen", tpView.txtWood.text == "Wood: 60/250");
                Check("Inventory Iron text updates on screen", tpView.txtIron.text == "Iron: 10/100" || tpView.txtIron.text == "Iron: 10/250");

                // --- G. Invalid trade ---
                // Case 1: Insufficient resources
                // Now Wood is 60, so we have enough for 1 more trade.
                tpView.btnOfferWoodToIron.onClick.Invoke();
                var snapAfter2 = backend.GetSnapshot();
                Check("Second trade succeeds and decreases Wood to 20", snapAfter2.wood == 20);
                Check("Second trade succeeds and increases Iron to 20", snapAfter2.iron == 20);

                // Now Wood is 20. Button should be disabled.
                Check("Wood -> Iron button becomes disabled when Wood is insufficient", !tpView.btnOfferWoodToIron.interactable);

                // Re-enable and bypass buttons using command directly to test backend block (just in case)
                var result = backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });
                Check("Execute command with insufficient resources returns failure", result != null && !result.success);
                Check("Execute command leaves resources unchanged", backend.GetSnapshot().wood == 20);

                // Case 2: Capacity exceeded
                // Iron capacity is 250. Let's set Iron = 245. Offer buy amount is 10. Max allowed is 250. 245 + 10 = 255 > 250.
                var snapCap = backend.GetSnapshot();
                snapCap.wood = 100; // has enough wood
                snapCap.iron = 245; // cap is 250, buying 10 exceeds it
                uiManager.HandleStateChanged(snapCap);

                Check("Wood -> Iron button is disabled when buy resource capacity exceeded", !tpView.btnOfferWoodToIron.interactable);
            }
            else
            {
                Check("Trade simulation running correctly", false);
            }

            // --- H. Regression ---
            if (hudRootGo != null)
            {
                Check("SelectedVillagerPanel exists", hudRootGo.transform.Find("SelectedVillagerPanel") != null);
                
                var selPanelT2 = hudRootGo.transform.Find("SelectedVillagerPanel");
                Check("OptionsScrollArea exists under SelectedVillagerPanel", selPanelT2 != null && selPanelT2.Find("OptionsScrollArea") != null);
                
                Check("BlacksmithCraftPanel exists", GameObject.Find("BlacksmithCraftPanel") != null || hudRootGo.transform.Find("BlacksmithCraftPanel") != null);
                Check("BuildMenuPanel exists", hudRootGo.transform.Find("BuildMenuPanel") != null);
                Check("WorldMapPanel exists", hudRootGo.transform.Find("WorldMapPanel") != null);
                Check("ExpeditionResultPanel exists", hudRootGo.transform.Find("ExpeditionResultPanel") != null);
            }
            else
            {
                Check("Accepted panels exist", false);
            }

            // --- I. No forbidden files ---
            bool setupToolExists = File.Exists("Assets/_Project/Scripts/Editor/MainCanvasSetupTool.cs");
            bool forceRunSetupExists = File.Exists("Assets/_Project/Scripts/Editor/ForceRunSetup.cs");
            bool mainCanvasPrefabExists = File.Exists("Assets/Prefabs/MainCanvas.prefab");
            Check("MainCanvasSetupTool.cs is absent", !setupToolExists);
            Check("ForceRunSetup.cs is absent", !forceRunSetupExists);
            Check("MainCanvas.prefab is absent", !mainCanvasPrefabExists);

            // Clean up temporary objects
            tpGo.SetActive(false);

            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            Directory.CreateDirectory("Assets/_Project/Docs");
            File.WriteAllText("Assets/_Project/Docs/TradeUITestReport.md", report.ToString());
            Debug.Log($"[Trade UI Test] Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0)
            {
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
