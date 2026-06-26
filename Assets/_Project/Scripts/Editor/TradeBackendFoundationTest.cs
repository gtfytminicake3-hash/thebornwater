#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using TheBonwater.Rebuild.Data;

namespace TheBonwater.Rebuild.Editor {
    public static class TradeBackendFoundationTest {
        [MenuItem("Tools/Rebuild/Tests/Run Trade Backend Foundation Test")]
        public static void Run() {
            int pass = 0; int fail = 0;
            var report = new System.Text.StringBuilder();
            report.AppendLine("# Trade Backend Foundation Test Report");

            void Check(string name, bool condition) {
                if (condition) {
                    pass++;
                    report.AppendLine($"- [PASS] {name}");
                } else {
                    fail++;
                    report.AppendLine($"- [FAIL] {name}");
                    UnityEngine.Debug.LogError($"[Trade Test Fail] {name}");
                }
            }

            string runtimeSavePath = Path.Combine(Application.persistentDataPath, "local_runtime_save.json");

            // --- Test A. Valid trade succeeds ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                state.wood = 100;
                state.iron = 0;
                state.woodCapacity = 250;
                state.ironCapacity = 250;
                state.tradeState.isMerchantPresent = true;

                var cmd = new TradeCommand { offerId = "trade_wood_to_iron_01" }; // sell 50 wood -> buy 10 iron
                var res = backend.Execute(cmd);

                Check("Valid trade wood to iron reports success", res.success);
                Check("Valid trade wood decreased", state.wood == 60);
                Check("Valid trade iron increased", state.iron == 10);
            }

            // --- Test B. Not enough resource fails ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                state.wood = 30; // Needs 40
                state.iron = 0;
                state.woodCapacity = 250;
                state.ironCapacity = 250;
                state.tradeState.isMerchantPresent = true;

                var cmd = new TradeCommand { offerId = "trade_wood_to_iron_01" };
                var res = backend.Execute(cmd);

                Check("Trade with insufficient resources reports failure", !res.success);
                Check("Trade with insufficient resources leaves wood unchanged", state.wood == 30);
                Check("Trade with insufficient resources leaves iron unchanged", state.iron == 0);
            }

            // --- Test C. Capacity exceeded fails ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                state.wood = 100;
                state.iron = 245; // cap is 250, buying 10 would make it 255
                state.woodCapacity = 250;
                state.ironCapacity = 250;
                state.tradeState.isMerchantPresent = true;

                var cmd = new TradeCommand { offerId = "trade_wood_to_iron_01" };
                var res = backend.Execute(cmd);

                Check("Trade exceeding capacity reports failure", !res.success);
                Check("Trade exceeding capacity leaves wood unchanged", state.wood == 100);
                Check("Trade exceeding capacity leaves iron unchanged", state.iron == 245);
            }

            // --- Test D. Unknown offer/resource fails ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                state.wood = 100;
                state.woodCapacity = 250;
                state.tradeState.isMerchantPresent = true;

                var cmd = new TradeCommand { offerId = "invalid_offer_id" };
                var res = backend.Execute(cmd);

                Check("Trade with invalid offer ID reports failure", !res.success);
                Check("Trade with invalid offer ID leaves resources unchanged", state.wood == 100);
            }

            // --- Test E. Invalid amount fails ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                state.wood = 100;
                state.iron = 0;
                state.woodCapacity = 250;
                state.ironCapacity = 250;
                state.tradeState.isMerchantPresent = true;

                // Dynamically add a bad offer with non-positive amounts
                var badOffer = new TradeOffer {
                    id = "trade_bad_amounts",
                    sellResource = "wood",
                    sellAmount = -10,
                    buyResource = "iron",
                    buyAmount = 10
                };
                TradeOffers.Offers.Add(badOffer);

                var cmd = new TradeCommand { offerId = "trade_bad_amounts" };
                var res = backend.Execute(cmd);

                Check("Trade with negative sell amount reports failure", !res.success);
                Check("Trade with negative sell amount leaves wood unchanged", state.wood == 100);
                Check("Trade with negative sell amount leaves iron unchanged", state.iron == 0);

                // Clean up bad offer
                TradeOffers.Offers.Remove(badOffer);
            }

            // --- Test F. Save/load backward compatibility ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                
                // Write a save file that does NOT contain tradeState (emulating old saves)
                var oldJson = "{\"day\":2,\"timeOfDay\":\"Morning\",\"wood\":80,\"villagers\":[{\"id\":\"v1\",\"name\":\"Bryn\",\"job\":\"Builder\",\"hp\":100}]}";
                File.WriteAllText(runtimeSavePath, oldJson);

                var backend = new LocalGameBackend();
                // Execute load
                backend.Execute(new LoadGameCommand());
                var state = backend.GetSnapshot();

                Check("Old save without tradeState loads successfully", state != null && state.wood == 80);
                Check("tradeState is automatically initialized/sanitized from old save", state != null && state.tradeState != null);
                Check("tradeState default isMerchantPresent is false", state != null && state.tradeState.isMerchantPresent == false);

                // Write new state with tradeState
                state.tradeState.isMerchantPresent = true;
                state.tradeState.daysUntilNextMerchant = 3;
                state.tradeState.merchantDaysRemaining = 1;
                backend.Execute(new SaveGameCommand());

                if (File.Exists(runtimeSavePath)) {
                    string savedJson = File.ReadAllText(runtimeSavePath);
                    UnityEngine.Debug.Log($"[Trade Save Test JSON] {savedJson}");
                }

                var backendNew = new LocalGameBackend();
                backendNew.Execute(new LoadGameCommand());
                var stateNew = backendNew.GetSnapshot();

                Check("New save with tradeState loads successfully", stateNew != null && stateNew.tradeState != null);
                Check("New tradeState values are preserved on reload", stateNew != null && stateNew.tradeState.isMerchantPresent && stateNew.tradeState.daysUntilNextMerchant == 3);

                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // --- Test G. Accepted systems unaffected ---
            {
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                Check("WorldMap locations count is preserved", state.worldMapState != null && state.worldMapState.locations.Count > 0);
                var home = state.worldMapState?.locations?.FirstOrDefault(l => l.id == "home");
                Check("Home location remains discovered", home != null && home.isDiscovered);
            }

            // --- Test H. New Game merchant state ---
            {
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();
                Check("NewGame starts with merchant absent", state.tradeState.isMerchantPresent == false);
                Check("NewGame starts with daysUntilNextMerchant = 2", state.tradeState.daysUntilNextMerchant == 2);
                Check("NewGame starts with merchantDaysRemaining = 0", state.tradeState.merchantDaysRemaining == 0);
            }

            // --- Test I. Countdown and arrival ---
            {
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                // Day 1 Morning -> Afternoon -> Evening -> Night -> Day 2 Morning
                backend.Execute(new AdvanceTimeCommand()); // Morning -> Afternoon
                backend.Execute(new AdvanceTimeCommand()); // Afternoon -> Evening
                backend.Execute(new AdvanceTimeCommand()); // Evening -> Night
                backend.Execute(new AdvanceTimeCommand()); // Night -> Day 2 Morning
                Check("Day 2 Morning: merchant absent", state.tradeState.isMerchantPresent == false);
                Check("Day 2 Morning: daysUntilNextMerchant = 1", state.tradeState.daysUntilNextMerchant == 1);

                // Day 2 Morning -> Afternoon -> Evening -> Night -> Day 3 Morning
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                Check("Day 3 Morning: merchant present", state.tradeState.isMerchantPresent == true);
                Check("Day 3 Morning: daysUntilNextMerchant = 0", state.tradeState.daysUntilNextMerchant == 0);
                Check("Day 3 Morning: merchantDaysRemaining = 1", state.tradeState.merchantDaysRemaining == 1);
            }

            // --- Test J. Departure and reset ---
            {
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                // Advance to Day 3 Morning (arrival)
                for (int i = 0; i < 8; i++) backend.Execute(new AdvanceTimeCommand());
                Check("Day 3 Morning: arrived", state.tradeState.isMerchantPresent == true);

                // Day 3 Morning -> Day 4 Morning
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                backend.Execute(new AdvanceTimeCommand());
                Check("Day 4 Morning: merchant departed", state.tradeState.isMerchantPresent == false);
                Check("Day 4 Morning: daysUntilNextMerchant = 3", state.tradeState.daysUntilNextMerchant == 3);
                Check("Day 4 Morning: merchantDaysRemaining = 0", state.tradeState.merchantDaysRemaining == 0);
            }

            // --- Test K. TradeCommand gating ---
            {
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();
                state.wood = 100;
                state.iron = 0;
                state.woodCapacity = 250;
                state.ironCapacity = 250;

                // Case 1: Merchant absent
                state.tradeState.isMerchantPresent = false;
                var cmd = new TradeCommand { offerId = "trade_wood_to_iron_01" };
                var res = backend.Execute(cmd);
                Check("Trade fails when merchant is absent", res.success == false);
                Check("Absent trade failure message", res.message == "Merchant is not present");
                Check("Absent trade leaves resources unchanged (wood)", state.wood == 100);
                Check("Absent trade leaves resources unchanged (iron)", state.iron == 0);

                // Case 2: Merchant present
                state.tradeState.isMerchantPresent = true;
                var res2 = backend.Execute(cmd);
                Check("Trade succeeds when merchant is present", res2.success == true);
                Check("Present trade wood decreased", state.wood == 60);
                Check("Present trade iron increased", state.iron == 10);
            }

            // --- Test L. Save/load persistence ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
                var backend = new LocalGameBackend();
                var state = backend.GetSnapshot();

                // Case 1: Present state
                state.tradeState.isMerchantPresent = true;
                state.tradeState.daysUntilNextMerchant = 0;
                state.tradeState.merchantDaysRemaining = 1;
                backend.Execute(new SaveGameCommand());

                var backendL1 = new LocalGameBackend();
                backendL1.Execute(new LoadGameCommand());
                var stateL1 = backendL1.GetSnapshot();
                Check("Loaded merchant present state: isMerchantPresent", stateL1.tradeState.isMerchantPresent == true);
                Check("Loaded merchant present state: daysUntilNextMerchant", stateL1.tradeState.daysUntilNextMerchant == 0);
                Check("Loaded merchant present state: merchantDaysRemaining", stateL1.tradeState.merchantDaysRemaining == 1);

                // Case 2: Absent state
                stateL1.tradeState.isMerchantPresent = false;
                stateL1.tradeState.daysUntilNextMerchant = 3;
                stateL1.tradeState.merchantDaysRemaining = 0;
                backendL1.Execute(new SaveGameCommand());

                var backendL2 = new LocalGameBackend();
                backendL2.Execute(new LoadGameCommand());
                var stateL2 = backendL2.GetSnapshot();
                Check("Loaded merchant absent state: isMerchantPresent", stateL2.tradeState.isMerchantPresent == false);
                Check("Loaded merchant absent state: daysUntilNextMerchant", stateL2.tradeState.daysUntilNextMerchant == 3);
                Check("Loaded merchant absent state: merchantDaysRemaining", stateL2.tradeState.merchantDaysRemaining == 0);

                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            // --- Test M. Sanitization ---
            {
                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);

                // Subcase 1: Null tradeState
                var oldJsonNull = "{\"day\":2,\"timeOfDay\":\"Morning\",\"wood\":80,\"villagers\":[{\"id\":\"v1\",\"name\":\"Bryn\",\"job\":\"Builder\",\"hp\":100}]}";
                File.WriteAllText(runtimeSavePath, oldJsonNull);
                var backendM1 = new LocalGameBackend();
                backendM1.Execute(new LoadGameCommand());
                var stateM1 = backendM1.GetSnapshot();
                Check("Sanitize null tradeState: isMerchantPresent", stateM1.tradeState.isMerchantPresent == false);
                Check("Sanitize null tradeState: daysUntilNextMerchant", stateM1.tradeState.daysUntilNextMerchant == 2);
                Check("Sanitize null tradeState: merchantDaysRemaining", stateM1.tradeState.merchantDaysRemaining == 0);

                // Subcase 2: Negative values
                var jsonNegative = "{\"day\":2,\"timeOfDay\":\"Morning\",\"tradeState\":{\"isMerchantPresent\":false,\"daysUntilNextMerchant\":-5,\"merchantDaysRemaining\":-3},\"villagers\":[{\"id\":\"v1\",\"name\":\"Bryn\",\"job\":\"Builder\",\"hp\":100}]}";
                File.WriteAllText(runtimeSavePath, jsonNegative);
                var backendM2 = new LocalGameBackend();
                backendM2.Execute(new LoadGameCommand());
                var stateM2 = backendM2.GetSnapshot();
                Check("Sanitize negative daysUntilNextMerchant", stateM2.tradeState.daysUntilNextMerchant == 2);
                Check("Sanitize negative merchantDaysRemaining", stateM2.tradeState.merchantDaysRemaining == 0);

                // Subcase 3: Present but remaining <= 0
                var jsonPresentZero = "{\"day\":2,\"timeOfDay\":\"Morning\",\"tradeState\":{\"isMerchantPresent\":true,\"daysUntilNextMerchant\":0,\"merchantDaysRemaining\":0},\"villagers\":[{\"id\":\"v1\",\"name\":\"Bryn\",\"job\":\"Builder\",\"hp\":100}]}";
                File.WriteAllText(runtimeSavePath, jsonPresentZero);
                var backendM3 = new LocalGameBackend();
                backendM3.Execute(new LoadGameCommand());
                var stateM3 = backendM3.GetSnapshot();
                Check("Sanitize present with zero remaining: isMerchantPresent", stateM3.tradeState.isMerchantPresent == false);
                Check("Sanitize present with zero remaining: daysUntilNextMerchant", stateM3.tradeState.daysUntilNextMerchant == 2);

                // Subcase 4: Absent but daysUntilNextMerchant <= 0
                var jsonAbsentZero = "{\"day\":2,\"timeOfDay\":\"Morning\",\"tradeState\":{\"isMerchantPresent\":false,\"daysUntilNextMerchant\":0,\"merchantDaysRemaining\":0},\"villagers\":[{\"id\":\"v1\",\"name\":\"Bryn\",\"job\":\"Builder\",\"hp\":100}]}";
                File.WriteAllText(runtimeSavePath, jsonAbsentZero);
                var backendM4 = new LocalGameBackend();
                backendM4.Execute(new LoadGameCommand());
                var stateM4 = backendM4.GetSnapshot();
                Check("Sanitize absent with zero count: daysUntilNextMerchant", stateM4.tradeState.daysUntilNextMerchant == 2);

                if (File.Exists(runtimeSavePath)) File.Delete(runtimeSavePath);
            }

            File.WriteAllText("Assets/_Project/Docs/TradeBackendFoundationReport.md", report.ToString());
            UnityEngine.Debug.Log($"Trade Backend Foundation Test Complete! PASS: {pass}, FAIL: {fail}.");
            if (fail > 0) {
                EditorApplication.Exit(1);
            }
        }
    }
}
#endif
