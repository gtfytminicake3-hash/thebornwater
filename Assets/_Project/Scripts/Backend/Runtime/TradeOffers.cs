using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheBonwater.Rebuild {
    [Serializable]
    public class TradeOffer {
        public string id;
        public string sellResource;
        public int sellAmount;
        public string buyResource;
        public int buyAmount;
    }

    public static class TradeOffers {
        public static readonly List<TradeOffer> Offers = new List<TradeOffer> {
            new TradeOffer { id = "trade_wood_to_iron_01", sellResource = "wood", sellAmount = 40, buyResource = "iron", buyAmount = 10 },
            new TradeOffer { id = "trade_food_to_wood_01", sellResource = "food", sellAmount = 20, buyResource = "wood", buyAmount = 30 },
            new TradeOffer { id = "trade_iron_to_steel_01", sellResource = "iron", sellAmount = 20, buyResource = "steel", buyAmount = 5 },
            new TradeOffer { id = "trade_wood_to_coal_01", sellResource = "wood", sellAmount = 30, buyResource = "coal", buyAmount = 10 }
        };

        static TradeOffers() {
            foreach (var offer in Offers) {
                Debug.Log($"[Trade 16A] Offer loaded id={offer.id} sell={offer.sellResource}:{offer.sellAmount} buy={offer.buyResource}:{offer.buyAmount}");
            }
        }

        public static TradeOffer GetOffer(string id) {
            if (string.IsNullOrEmpty(id)) return null;
            return Offers.Find(o => string.Equals(o.id, id, StringComparison.OrdinalIgnoreCase));
        }
    }
}
