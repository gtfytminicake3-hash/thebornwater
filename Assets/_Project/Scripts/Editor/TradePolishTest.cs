#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

namespace TheBonwater.Rebuild.Editor
{
    public static class TradePolishTest
    {
        [MenuItem("Tools/Rebuild/Tests/Run Trade Polish Test")]
        public static void Run()
        {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Trade Polish Test Report");
            report.AppendLine();

            void Check(string name, bool condition) {
                if (condition) {
                    pass++;
                    report.AppendLine($"- [PASS] {name}");
                    Debug.Log($"[Trade Polish Test] PASS: {name}");
                } else {
                    fail++;
                    report.AppendLine($"- [FAIL] {name}");
                    Debug.LogError($"[Trade Polish Test] FAIL: {name}");
                }
            }

            // --- Ensure UI is generated/ready in the scene ---
            EnsureSceneOwnedUIPanels.Execute();

            var hudRootGo = GameObject.Find("HUDRoot");
            var uiManager = hudRootGo != null ? hudRootGo.GetComponent<GameplayUIManager>() : null;
            var notifTransform = hudRootGo != null ? hudRootGo.transform.Find("MerchantNotificationPanel") : null;
            var notifGo = notifTransform != null ? notifTransform.gameObject : null;
            var notifView = notifGo != null ? notifGo.GetComponent<MerchantNotificationView>() : null;
            var tpTransform = hudRootGo != null ? hudRootGo.transform.Find("TradePanel") : null;
            var tpGo = tpTransform != null ? tpTransform.gameObject : null;
            var tpView = tpGo != null ? tpGo.GetComponent<TradePanelView>() : null;

            // ==========================================
            // Test 1 — Scene-owned notification UI exists
            // ==========================================
            {
                bool exists = notifGo != null;
                bool viewBound = uiManager != null && uiManager.merchantNotificationView == notifView;
                bool startsHidden = false;

                if (notifView != null) {
                    // Simulate Awake to check if it hides itself
                    var method = typeof(MerchantNotificationView).GetMethod("Awake", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                    if (method != null) method.Invoke(notifView, null);
                    startsHidden = notifGo.activeSelf == false;
                }

                var msgTextTransform = notifGo != null ? notifGo.transform.Find("MessageText") : null;
                bool textExists = msgTextTransform != null && msgTextTransform.GetComponent<Text>() != null;

                Check("Test 1 — Scene-owned notification UI exists", exists && viewBound && startsHidden && textExists);
            }

            // ==========================================
            // Test 2 — First snapshot does not trigger notification
            // ==========================================
            {
                bool baselineOk = false;
                if (notifView != null) {
                    notifView.ResetState();
                    
                    var snap = new GameSnapshot {
                        tradeState = new TradeState {
                            isMerchantPresent = true,
                            merchantDaysRemaining = 1,
                            daysUntilNextMerchant = 0
                        }
                    };

                    notifView.UpdateView(snap);
                    // On first update, since it's the baseline, the notification panel should remain hidden (inactive)
                    baselineOk = notifGo.activeSelf == false;
                }
                Check("Test 2 — First snapshot does not trigger notification", baselineOk);
            }

            // ==========================================
            // Test 3 — Arrival transition shows notification
            // ==========================================
            {
                bool arrivalOk = false;
                if (notifView != null) {
                    notifView.ResetState();

                    var snap1 = new GameSnapshot {
                        tradeState = new TradeState {
                            isMerchantPresent = false,
                            daysUntilNextMerchant = 2
                        }
                    };
                    notifView.UpdateView(snap1); // Set baseline: absent

                    var snap2 = new GameSnapshot {
                        tradeState = new TradeState {
                            isMerchantPresent = true,
                            merchantDaysRemaining = 1
                        }
                    };
                    notifView.UpdateView(snap2); // Transition: present

                    bool visible = notifGo.activeSelf;
                    string msg = notifView.txtMessage != null ? notifView.txtMessage.text : "";
                    arrivalOk = visible && msg == "Merchant has arrived!";
                }
                Check("Test 3 — Arrival transition shows notification", arrivalOk);
            }

            // ==========================================
            // Test 4 — Departure transition shows notification
            // ==========================================
            {
                bool departureOk = false;
                if (notifView != null) {
                    notifView.ResetState();

                    var snap1 = new GameSnapshot {
                        tradeState = new TradeState {
                            isMerchantPresent = true,
                            merchantDaysRemaining = 1
                        }
                    };
                    notifView.UpdateView(snap1); // Set baseline: present

                    var snap2 = new GameSnapshot {
                        tradeState = new TradeState {
                            isMerchantPresent = false,
                            daysUntilNextMerchant = 3
                        }
                    };
                    notifView.UpdateView(snap2); // Transition: absent

                    bool visible = notifGo.activeSelf;
                    string msg = notifView.txtMessage != null ? notifView.txtMessage.text : "";
                    departureOk = visible && msg == "Merchant has departed.";
                }
                Check("Test 4 — Departure transition shows notification", departureOk);
            }

            // ==========================================
            // Test 5 — TradeOpenButton indicator
            // ==========================================
            {
                bool indicatorOk = false;
                if (uiManager != null && uiManager.tradeOpenButton != null) {
                    var btnText = uiManager.tradeOpenButton.GetComponentInChildren<Text>();

                    // Scenario A: merchant absent
                    var snapAbsent = new GameSnapshot {
                        tradeState = new TradeState { isMerchantPresent = false, daysUntilNextMerchant = 2 }
                    };
                    uiManager.HandleStateChanged(snapAbsent);
                    bool textAbsentOk = btnText != null && btnText.text == "Trade";
                    bool interactableAbsentOk = uiManager.tradeOpenButton.interactable == true;

                    // Scenario B: merchant present
                    var snapPresent = new GameSnapshot {
                        tradeState = new TradeState { isMerchantPresent = true, merchantDaysRemaining = 1 }
                    };
                    uiManager.HandleStateChanged(snapPresent);
                    bool textPresentOk = btnText != null && btnText.text == "Trade!";
                    bool interactablePresentOk = uiManager.tradeOpenButton.interactable == true;

                    indicatorOk = textAbsentOk && interactableAbsentOk && textPresentOk && interactablePresentOk;
                }
                Check("Test 5 — TradeOpenButton indicator", indicatorOk);
            }

            // ==========================================
            // Test 6 — TradePanel absent result text
            // ==========================================
            {
                bool resultAbsentOk = false;
                if (tpView != null) {
                    var snap = new GameSnapshot {
                        tradeState = new TradeState { isMerchantPresent = false, daysUntilNextMerchant = 3 }
                    };
                    tpView.txtResult.text = "";
                    tpView.UpdateView(snap);
                    resultAbsentOk = tpView.txtResult.text == "Merchant is not present. Next arrival: 3 day(s).";
                }
                Check("Test 6 — TradePanel absent result text", resultAbsentOk);
            }

            // ==========================================
            // Test 7 — TradePanel present result text
            // ==========================================
            {
                bool resultPresentOk = false;
                if (tpView != null) {
                    var snap = new GameSnapshot {
                        tradeState = new TradeState { isMerchantPresent = true, merchantDaysRemaining = 1 }
                    };
                    tpView.txtResult.text = "";
                    tpView.UpdateView(snap);
                    resultPresentOk = tpView.txtResult.text == "Merchant is available. Select a trade offer.";
                }
                Check("Test 7 — TradePanel present result text", resultPresentOk);
            }

            // ==========================================
            // Test 8 — Trade success/failure text remains correct
            // ==========================================
            {
                bool errorsOk = false;
                if (tpView != null && uiManager != null) {
                    var backend = new LocalGameBackend();
                    GameServiceLocator.RegisterBackend(backend);
                    
                    var snap = backend.GetSnapshot();
                    snap.tradeState.isMerchantPresent = true;
                    snap.wood = 100;
                    snap.iron = 0;
                    snap.ironCapacity = 100;

                    tpView.Start();
                    tpView.OnEnable();

                    // Case A: Insufficient wood
                    snap.wood = 5;
                    tpView.btnOfferWoodToIron.onClick.Invoke();
                    bool failInsuf = tpView.txtResult.text == "Trade blocked: not enough Wood.";
                    Debug.Log($"[Trade Polish Test DEBUG] Case A: failInsuf={failInsuf}, text='{tpView.txtResult.text}'");

                    // Case B: Capacity exceeded
                    snap.wood = 100;
                    snap.iron = 100; // already full
                    tpView.btnOfferWoodToIron.onClick.Invoke();
                    bool failCap = tpView.txtResult.text == "Trade blocked: Iron storage is full.";
                    Debug.Log($"[Trade Polish Test DEBUG] Case B: failCap={failCap}, text='{tpView.txtResult.text}'");

                    // Case C: Merchant absent trade blocked
                    snap.wood = 100;
                    snap.iron = 0;
                    snap.tradeState.isMerchantPresent = false;
                    tpView.btnOfferWoodToIron.onClick.Invoke();
                    bool failAbsent = tpView.txtResult.text == "Merchant has departed. Trade is unavailable.";
                    Debug.Log($"[Trade Polish Test DEBUG] Case C: failAbsent={failAbsent}, text='{tpView.txtResult.text}'");

                    // Case D: Success Wood -> Iron
                    snap.tradeState.isMerchantPresent = true;
                    snap.wood = 100;
                    snap.iron = 0;
                    tpView.btnOfferWoodToIron.onClick.Invoke();
                    bool successOk = tpView.txtResult.text == "Trade successful: 40 Wood -> 10 Iron";
                    Debug.Log($"[Trade Polish Test DEBUG] Case D: successOk={successOk}, text='{tpView.txtResult.text}'");

                    // Case E: Refresh after merchant departure
                    snap.tradeState.isMerchantPresent = false;
                    snap.tradeState.daysUntilNextMerchant = 2;
                    tpView.UpdateView(snap);
                    bool departureRefreshOk = tpView.txtResult.text == "Merchant has departed. Trade is unavailable.";
                    Debug.Log($"[Trade Polish Test DEBUG] Case E: departureRefreshOk={departureRefreshOk}, text='{tpView.txtResult.text}'");

                    // Case F: Subsequent update shows countdown
                    tpView.UpdateView(snap);
                    bool finalAbsentOk = tpView.txtResult.text == "Merchant is not present. Next arrival: 2 day(s).";
                    Debug.Log($"[Trade Polish Test DEBUG] Case F: finalAbsentOk={finalAbsentOk}, text='{tpView.txtResult.text}'");

                    errorsOk = failInsuf && failCap && failAbsent && successOk && departureRefreshOk && finalAbsentOk;
                }
                Check("Test 8 — Trade success/failure text remains correct", errorsOk);
            }

            // ==========================================
            // Test 9 — Save/load baseline behavior
            // ==========================================
            {
                bool saveLoadOk = false;
                if (uiManager != null && notifView != null) {
                    notifView.ResetState();
                    
                    // Simulate Loading save with merchant already present
                    var snapLoaded = new GameSnapshot {
                        tradeState = new TradeState { isMerchantPresent = true, merchantDaysRemaining = 1 }
                    };
                    
                    // Trigger StateChanged as if load completes
                    uiManager.HandleStateChanged(snapLoaded);

                    // Notification should not show (Baseline logic should capture the first snap after load as null baseline)
                    bool noArrivedPopup = notifGo.activeSelf == false;

                    // Button text should still say "Trade!"
                    var btnText = uiManager.tradeOpenButton.GetComponentInChildren<Text>();
                    bool buttonTextOk = btnText != null && btnText.text == "Trade!";

                    saveLoadOk = noArrivedPopup && buttonTextOk;
                }
                Check("Test 9 — Save/load baseline behavior", saveLoadOk);
            }

            // ==========================================
            // Test 10 — Regression safety
            // ==========================================
            {
                var hudRoot = GameObject.Find("HUDRoot");
                bool worldMapPanelExists = hudRoot != null && hudRoot.transform.Find("WorldMapPanel") != null;
                bool expeditionResultPanelExists = hudRoot != null && hudRoot.transform.Find("ExpeditionResultPanel") != null;
                bool selectedVillagerPanelExists = hudRoot != null && hudRoot.transform.Find("SelectedVillagerPanel") != null;
                bool optionsScrollAreaExists = hudRoot != null && hudRoot.transform.Find("SelectedVillagerPanel/OptionsScrollArea") != null;
                bool blacksmithCraftPanelExists = hudRoot != null && hudRoot.transform.Find("BlacksmithCraftPanel") != null;
                bool buildMenuPanelExists = hudRoot != null && hudRoot.transform.Find("BuildMenuPanel") != null;
                bool tradePanelExists = hudRoot != null && hudRoot.transform.Find("TradePanel") != null;

                Debug.Log($"[Trade Polish Test DEBUG] worldMapPanelExists={worldMapPanelExists}, expeditionResultPanelExists={expeditionResultPanelExists}, selectedVillagerPanelExists={selectedVillagerPanelExists}, optionsScrollAreaExists={optionsScrollAreaExists}, blacksmithCraftPanelExists={blacksmithCraftPanelExists}, buildMenuPanelExists={buildMenuPanelExists}, tradePanelExists={tradePanelExists}");

                bool panelsOk = worldMapPanelExists && expeditionResultPanelExists && selectedVillagerPanelExists &&
                               optionsScrollAreaExists && blacksmithCraftPanelExists && buildMenuPanelExists && tradePanelExists;

                bool forbiddenAbsent = !File.Exists("Assets/_Project/Scripts/Editor/MainCanvasSetupTool.cs") &&
                                       !File.Exists("Assets/_Project/Scripts/Editor/ForceRunSetup.cs") &&
                                       !File.Exists("Assets/Prefabs/MainCanvas.prefab");

                Check("Test 10 — Regression safety", panelsOk && forbiddenAbsent);
            }

            // Write report
            report.AppendLine();
            report.AppendLine($"Total PASS: {pass}");
            report.AppendLine($"Total FAIL: {fail}");
            
            Directory.CreateDirectory("Assets/_Project/Docs");
            File.WriteAllText("Assets/_Project/Docs/TradePolishTestReport.md", report.ToString());
            Debug.Log($"[Trade Polish Test] Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) {
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
