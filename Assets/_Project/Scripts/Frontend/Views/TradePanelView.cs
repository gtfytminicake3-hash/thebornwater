using UnityEngine;
using UnityEngine.UI;

namespace TheBonwater.Rebuild {
    public class TradePanelView : MonoBehaviour {
        [Header("Header")]
        public Button btnClose;

        [Header("Status Section")]
        public Text txtMerchantStatus;
        public Text txtDaysUntilNextMerchant;

        [Header("Inventory Section")]
        public Text txtWood;
        public Text txtFood;
        public Text txtIron;
        public Text txtCoal;
        public Text txtSteel;

        [Header("Offers Section")]
        public Button btnOfferWoodToIron;
        public Text txtOfferWoodToIronText;

        public Button btnOfferFoodToWood;
        public Text txtOfferFoodToWoodText;

        public Button btnOfferIronToSteel;
        public Text txtOfferIronToSteelText;

        public Button btnOfferWoodToCoal;
        public Text txtOfferWoodToCoalText;

        [Header("Footer")]
        public Text txtResult;
        public Button btnRefresh;

        private bool wasMerchantPresent;

        public void OnEnable() {
            if (txtResult != null) {
                txtResult.text = "";
            }
            var backend = GameServiceLocator.Backend;
            if (backend != null) {
                var snap = backend.GetSnapshot();
                if (snap != null) {
                    wasMerchantPresent = snap.tradeState != null && snap.tradeState.isMerchantPresent;
                    UpdateView(snap);
                }
            }
        }

        private string GetOfferLabel(string offerId) {
            var offer = TradeOffers.GetOffer(offerId);
            if (offer == null) return "";
            string sellRes = Capitalize(offer.sellResource);
            string buyRes = Capitalize(offer.buyResource);
            return $"{offer.sellAmount} {sellRes} -> {offer.buyAmount} {buyRes}";
        }

        private string Capitalize(string s) {
            if (string.IsNullOrEmpty(s)) return "";
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }

        private void SetLabelAndBind(Button button, Text labelText, string offerId) {
            string label = GetOfferLabel(offerId);
            if (labelText != null) {
                labelText.text = label;
            }
            BindOfferButton(button, offerId, label);
        }

        public void Start() {
            if (btnClose != null) {
                btnClose.onClick.RemoveAllListeners();
                btnClose.onClick.AddListener(() => GameplayUIManager.Instance?.CloseTradePanel());
            }

            if (btnRefresh != null) {
                btnRefresh.onClick.RemoveAllListeners();
                btnRefresh.onClick.AddListener(() => {
                    var snap = GameServiceLocator.Backend?.GetSnapshot();
                    if (snap != null) {
                        UpdateView(snap);
                        txtResult.text = "Refreshed snapshot.";
                        txtResult.color = Color.white;
                    }
                });
            }

            SetLabelAndBind(btnOfferWoodToIron, txtOfferWoodToIronText, "trade_wood_to_iron_01");
            SetLabelAndBind(btnOfferFoodToWood, txtOfferFoodToWoodText, "trade_food_to_wood_01");
            SetLabelAndBind(btnOfferIronToSteel, txtOfferIronToSteelText, "trade_iron_to_steel_01");
            SetLabelAndBind(btnOfferWoodToCoal, txtOfferWoodToCoalText, "trade_wood_to_coal_01");
        }

        private void BindOfferButton(Button button, string offerId, string label) {
            if (button == null) return;
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() => {
                txtResult.text = "";
                var snapBefore = GameServiceLocator.Backend?.GetSnapshot();
                if (snapBefore == null) return;

                int sellBefore = GetResourceAmount(snapBefore, GetSellResource(offerId));
                int buyBefore = GetResourceAmount(snapBefore, GetBuyResource(offerId));

                if (TownInteractionController.Instance != null) {
                    TownInteractionController.Instance.ExecuteCommand(new TradeCommand { offerId = offerId });
                } else {
                    GameServiceLocator.Backend?.Execute(new TradeCommand { offerId = offerId });
                }

                var snapAfter = GameServiceLocator.Backend?.GetSnapshot();
                if (snapAfter != null) {
                    int sellAfter = GetResourceAmount(snapAfter, GetSellResource(offerId));
                    int buyAfter = GetResourceAmount(snapAfter, GetBuyResource(offerId));

                    if (sellAfter < sellBefore || buyAfter > buyBefore) {
                        txtResult.text = $"Trade successful: {label}";
                        txtResult.color = Color.green;
                    } else {
                        // Failed. Determine reason.
                        string reason = "unknown error";
                        var ts = snapAfter.tradeState;
                        if (ts == null || !ts.isMerchantPresent) {
                            reason = "merchant is not present";
                        } else {
                            var offer = TradeOffers.GetOffer(offerId);
                            if (offer != null) {
                                if (sellBefore < offer.sellAmount) {
                                    reason = $"not enough {Capitalize(offer.sellResource)}";
                                } else if (buyBefore + offer.buyAmount > GetResourceCapacity(snapBefore, offer.buyResource)) {
                                    reason = $"{Capitalize(offer.buyResource)} storage is full";
                                }
                            }
                        }
                        txtResult.text = $"Trade blocked: {reason}.";
                        txtResult.color = Color.red;
                    }

                    UpdateView(snapAfter);
                }
            });
        }

        private string GetSellResource(string offerId) {
            var offer = TradeOffers.GetOffer(offerId);
            return offer?.sellResource ?? "";
        }

        private string GetBuyResource(string offerId) {
            var offer = TradeOffers.GetOffer(offerId);
            return offer?.buyResource ?? "";
        }

        public void UpdateView(GameSnapshot snap) {
            if (snap == null) return;

            // 1. Status Section
            var ts = snap.tradeState;
            if (ts == null) {
                txtMerchantStatus.text = "Merchant: Not Present";
                txtMerchantStatus.color = Color.red;
                txtDaysUntilNextMerchant.text = "Next Arrival: N/A";
            } else {
                if (ts.isMerchantPresent) {
                    txtMerchantStatus.text = "Merchant: Present";
                    txtMerchantStatus.color = Color.green;
                    txtDaysUntilNextMerchant.text = $"Visit Remaining: {ts.merchantDaysRemaining} day(s)";
                } else {
                    txtMerchantStatus.text = "Merchant: Not Present";
                    txtMerchantStatus.color = Color.red;
                    txtDaysUntilNextMerchant.text = $"Next Arrival: {ts.daysUntilNextMerchant} day(s)";
                }
            }

            // 2. Inventory Section
            txtWood.text = $"Wood: {snap.wood}/{snap.woodCapacity}";
            txtFood.text = $"Food: {snap.food}/{snap.foodCapacity}";
            txtIron.text = $"Iron: {snap.iron}/{snap.ironCapacity}";
            txtCoal.text = $"Coal: {snap.coal}/{snap.coalCapacity}";
            txtSteel.text = $"Steel: {snap.steel}/{snap.steelCapacity}";

            // 3. Offers Gating & Display
            bool merchantPresent = ts != null && ts.isMerchantPresent;

            UpdateOfferGating(btnOfferWoodToIron, "trade_wood_to_iron_01", merchantPresent, snap);
            UpdateOfferGating(btnOfferFoodToWood, "trade_food_to_wood_01", merchantPresent, snap);
            UpdateOfferGating(btnOfferIronToSteel, "trade_iron_to_steel_01", merchantPresent, snap);
            UpdateOfferGating(btnOfferWoodToCoal, "trade_wood_to_coal_01", merchantPresent, snap);

            // 4. Default log text for merchant present / absent
            if (!merchantPresent) {
                if (wasMerchantPresent) {
                    txtResult.text = "Merchant has departed. Trade is unavailable.";
                } else {
                    int days = ts != null ? ts.daysUntilNextMerchant : 0;
                    txtResult.text = $"Merchant is not present. Next arrival: {days} day(s).";
                }
                txtResult.color = Color.white;
            } else if (string.IsNullOrEmpty(txtResult.text) || 
                txtResult.text.StartsWith("Merchant is not present. Next arrival:") || 
                txtResult.text == "Merchant has departed. Trade is unavailable." ||
                txtResult.text == "Merchant is available. Select a trade offer.") {
                txtResult.text = "Merchant is available. Select a trade offer.";
                txtResult.color = Color.white;
            }

            wasMerchantPresent = merchantPresent;
        }

        private void UpdateOfferGating(Button button, string offerId, bool merchantPresent, GameSnapshot snap) {
            if (button == null) return;

            var offer = TradeOffers.GetOffer(offerId);
            if (offer == null) {
                button.interactable = false;
                return;
            }

            // Gating conditions:
            // 1. Merchant must be present
            // 2. Player must have enough sell resource
            // 3. Player's buy resource must not exceed capacity
            bool canTrade = merchantPresent;

            if (canTrade) {
                // Check sell resource
                int currentSell = GetResourceAmount(snap, offer.sellResource);
                if (currentSell < offer.sellAmount) canTrade = false;
            }

            if (canTrade) {
                // Check buy resource capacity
                int currentBuy = GetResourceAmount(snap, offer.buyResource);
                int capBuy = GetResourceCapacity(snap, offer.buyResource);
                if (currentBuy + offer.buyAmount > capBuy) canTrade = false;
            }

            button.interactable = canTrade;
        }

        private int GetResourceAmount(GameSnapshot snap, string resource) {
            switch (resource.ToLower()) {
                case "wood": return snap.wood;
                case "food": return snap.food;
                case "iron": return snap.iron;
                case "coal": return snap.coal;
                case "steel": return snap.steel;
                default: return 0;
            }
        }

        private int GetResourceCapacity(GameSnapshot snap, string resource) {
            switch (resource.ToLower()) {
                case "wood": return snap.woodCapacity;
                case "food": return snap.foodCapacity;
                case "iron": return snap.ironCapacity;
                case "coal": return snap.coalCapacity;
                case "steel": return snap.steelCapacity;
                default: return 999999;
            }
        }
    }
}
