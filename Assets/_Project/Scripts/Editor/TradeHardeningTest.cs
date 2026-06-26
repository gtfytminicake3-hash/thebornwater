#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TheBonwater.Rebuild.Editor
{
    public static class TradeHardeningTest
    {
        [MenuItem("Tools/Rebuild/Tests/Run Trade Hardening Test")]
        public static void Run()
        {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Trade Hardening Test Report");
            report.AppendLine();

            void Check(string name, bool condition) {
                if (condition) {
                    pass++;
                    report.AppendLine($"- [PASS] {name}");
                    Debug.Log($"[Trade Hardening Test] PASS: {name}");
                } else {
                    fail++;
                    report.AppendLine($"- [FAIL] {name}");
                    Debug.LogError($"[Trade Hardening Test] FAIL: {name}");
                }
            }

            string runtimeSavePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");

            // --- Ensure UI is generated/ready in the scene ---
            EnsureSceneOwnedUIPanels.Execute();

            // ==========================================
            // Test 1 — Balance updated values
            // ==========================================
            {
                var woodToIron = TradeOffers.GetOffer("trade_wood_to_iron_01");
                var foodToWood = TradeOffers.GetOffer("trade_food_to_wood_01");
                var ironToSteel = TradeOffers.GetOffer("trade_iron_to_steel_01");
                var woodToCoal = TradeOffers.GetOffer("trade_wood_to_coal_01");

                bool t1 = woodToIron != null && woodToIron.sellResource == "wood" && woodToIron.sellAmount == 40 && woodToIron.buyResource == "iron" && woodToIron.buyAmount == 10;
                bool t2 = foodToWood != null && foodToWood.sellResource == "food" && foodToWood.sellAmount == 20 && foodToWood.buyResource == "wood" && foodToWood.buyAmount == 30;
                bool t3 = ironToSteel != null && ironToSteel.sellResource == "iron" && ironToSteel.sellAmount == 20 && ironToSteel.buyResource == "steel" && ironToSteel.buyAmount == 5;
                bool t4 = woodToCoal != null && woodToCoal.sellResource == "wood" && woodToCoal.sellAmount == 30 && woodToCoal.buyResource == "coal" && woodToCoal.buyAmount == 10;

                Check("Test 1 - Balance updated values", t1 && t2 && t3 && t4);
            }

            // ==========================================
            // Test 2 — UI labels match backend offers
            // ==========================================
            {
                var tpGo = GameObject.Find("TradePanel");
                var tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;
                bool labelsMatch = false;

                if (tpView != null) {
                    tpView.Start(); // initialize UI bindings
                    string woodToIronLabel = tpView.txtOfferWoodToIronText != null ? tpView.txtOfferWoodToIronText.text : "";
                    string foodToWoodLabel = tpView.txtOfferFoodToWoodText != null ? tpView.txtOfferFoodToWoodText.text : "";
                    string ironToSteelLabel = tpView.txtOfferIronToSteelText != null ? tpView.txtOfferIronToSteelText.text : "";
                    string woodToCoalLabel = tpView.txtOfferWoodToCoalText != null ? tpView.txtOfferWoodToCoalText.text : "";

                    labelsMatch = (woodToIronLabel == "40 Wood -> 10 Iron") &&
                                  (foodToWoodLabel == "20 Food -> 30 Wood") &&
                                  (ironToSteelLabel == "20 Iron -> 5 Steel") &&
                                  (woodToCoalLabel == "30 Wood -> 10 Coal");
                }
                Check("Test 2 - UI labels match backend offers", labelsMatch);
            }

            // ==========================================
            // Test 3 — ResultText clears on panel open
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var tpGo = GameObject.Find("TradePanel");
                var tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;
                bool clearBehaviorOk = false;

                if (tpGo != null && tpView != null) {
                    var backend = new LocalGameBackend();
                    GameServiceLocator.RegisterBackend(backend);
                    var snap = backend.GetSnapshot();
                    snap.tradeState.isMerchantPresent = true;

                    // Set stale text
                    tpView.txtResult.text = "Stale success text";

                    // Simulate open
                    tpView.OnEnable();

                    // For merchant present, result text should show available prompt
                    clearBehaviorOk = (tpView.txtResult.text == "Merchant is available. Select a trade offer.");

                    // Test with merchant absent
                    snap.tradeState.isMerchantPresent = false;
                    tpView.txtResult.text = "Stale failure text";
                    
                    // Simulate open
                    tpView.OnEnable();

                    // Result text should show "Merchant is not present. Next arrival: 2 day(s)."
                    clearBehaviorOk = clearBehaviorOk && (tpView.txtResult.text == "Merchant is not present. Next arrival: 2 day(s).");
                }
                Check("Test 3 - ResultText clears on panel open", clearBehaviorOk);
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 4 — Merchant absent invalid trade
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                GameServiceLocator.RegisterBackend(backend);
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = false;
                snap.wood = 100;
                snap.iron = 0;

                var tpGo = GameObject.Find("TradePanel");
                var tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;

                if (tpView != null) {
                    tpView.OnEnable(); // cleans result text and loads view
                }

                // Execute manually on backend
                var res = backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });

                bool commandFailed = !res.success && res.message == "Merchant is not present";
                bool resourcesUnchanged = backend.GetSnapshot().wood == 100 && backend.GetSnapshot().iron == 0;
                bool uiResultCorrect = tpView != null && tpView.txtResult.text == "Merchant is not present. Next arrival: 2 day(s).";
                bool buttonDisabled = tpView != null && !tpView.btnOfferWoodToIron.interactable;

                Check("Test 4 - Merchant absent invalid trade", commandFailed && resourcesUnchanged && uiResultCorrect && buttonDisabled);
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 5 — Insufficient resources
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                GameServiceLocator.RegisterBackend(backend);
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = true;
                snap.wood = 10; // wood to iron needs 40
                snap.iron = 0;

                var tpGo = GameObject.Find("TradePanel");
                var tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;

                if (tpView != null) {
                    tpView.OnEnable();
                }

                // Execute manually on backend
                var res = backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });

                bool commandFailed = !res.success && res.message.Contains("Not enough wood");
                bool resourcesUnchanged = backend.GetSnapshot().wood == 10 && backend.GetSnapshot().iron == 0;
                bool buttonDisabled = tpView != null && !tpView.btnOfferWoodToIron.interactable;

                Check("Test 5 - Insufficient resources", commandFailed && resourcesUnchanged && buttonDisabled);
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 6 — Capacity exceeded
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                GameServiceLocator.RegisterBackend(backend);
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = true;
                snap.wood = 100;
                snap.iron = snap.ironCapacity; // at capacity cap

                var tpGo = GameObject.Find("TradePanel");
                var tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;

                if (tpView != null) {
                    tpView.OnEnable();
                }

                // Execute manually on backend
                var res = backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });

                bool commandFailed = !res.success && res.message.Contains("Exceeds capacity");
                bool resourcesUnchanged = backend.GetSnapshot().wood == 100 && backend.GetSnapshot().iron == snap.ironCapacity;
                bool buttonDisabled = tpView != null && !tpView.btnOfferWoodToIron.interactable;

                Check("Test 6 - Capacity exceeded", commandFailed && resourcesUnchanged && buttonDisabled);
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 7 — Unknown offerId
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = true;
                snap.wood = 100;

                var res = backend.Execute(new TradeCommand { offerId = "unknown_offer_id" });

                bool commandFailed = !res.success && res.message.Contains("Offer not found");
                bool resourcesUnchanged = backend.GetSnapshot().wood == 100;

                Check("Test 7 - Unknown offerId", commandFailed && resourcesUnchanged);
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 8 — Save/load no duplication after trade
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                GameServiceLocator.RegisterBackend(backend);
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = true;
                snap.tradeState.merchantDaysRemaining = 1;
                snap.wood = 100;
                snap.iron = 0;
                snap.woodCapacity = 250;
                snap.ironCapacity = 250;

                // Execute trade once
                var res = backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });
                bool tradePassed = res.success && backend.GetSnapshot().wood == 60 && backend.GetSnapshot().iron == 10;

                // Save game
                backend.Execute(new SaveGameCommand());

                // Instantiate fresh backend and load
                var freshBackend = new LocalGameBackend();
                freshBackend.Execute(new LoadGameCommand());
                var loadedSnap = freshBackend.GetSnapshot();

                bool saveLoadIntegrity = loadedSnap.wood == 60 && loadedSnap.iron == 10;

                Check("Test 8 - Save/load no duplication after trade", tradePassed && saveLoadIntegrity);

                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 9 — Save/load after blocked trade
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                GameServiceLocator.RegisterBackend(backend);
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = true;
                snap.wood = 10; // insufficient
                snap.iron = 0;

                // Attempt trade (should fail)
                backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });

                // Save game
                backend.Execute(new SaveGameCommand());

                // Instantiate fresh backend and load
                var freshBackend = new LocalGameBackend();
                freshBackend.Execute(new LoadGameCommand());
                var loadedSnap = freshBackend.GetSnapshot();

                bool resourcesStillUnchanged = loadedSnap.wood == 10 && loadedSnap.iron == 0;

                Check("Test 9 - Save/load after blocked trade", resourcesStillUnchanged);

                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // ==========================================
            // Test 10 — Repeated trade spam
            // ==========================================
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                var backend = new LocalGameBackend();
                GameServiceLocator.RegisterBackend(backend);
                var snap = backend.GetSnapshot();
                snap.tradeState.isMerchantPresent = true;
                snap.wood = 100;
                snap.iron = 0;
                snap.woodCapacity = 250;
                snap.ironCapacity = 250;

                // Spam trade wood to iron (costs 40 wood per trade)
                // First trade: wood = 60, iron = 10
                // Second trade: wood = 20, iron = 20
                // Third trade: should fail due to wood (20 < 40)
                int successCount = 0;
                int failCount = 0;

                for (int i = 0; i < 5; i++) {
                    var res = backend.Execute(new TradeCommand { offerId = "trade_wood_to_iron_01" });
                    if (res.success) successCount++;
                    else failCount++;
                }

                bool spamIntegrity = (successCount == 2) && (failCount == 3) &&
                                      (backend.GetSnapshot().wood == 20) && (backend.GetSnapshot().iron == 20);

                Check("Test 10 — Repeated trade spam", spamIntegrity);
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // Write report
            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            Directory.CreateDirectory("Assets/_Project/Docs");
            File.WriteAllText("Assets/_Project/Docs/TradeHardeningTestReport.md", report.ToString());
            Debug.Log($"[Trade Hardening Test] Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) {
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
