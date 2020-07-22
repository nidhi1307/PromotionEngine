using PromoCostCalculator.Interfaces;
using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public class PromotionCalculator : IPromotionCalculator
    {
        private readonly IPromotionSKUObj _promoSKUObj;

        public PromotionCalculator(IPromotionSKUObj promoSKUObj)
        {
            _promoSKUObj = promoSKUObj;
        }

        public int GetCartTotalAmount(List<CartSKU> cartItem)
        {
            int ATotalCost, BTotalCost, CandDTotalCost = 0;
            List<CartSKU> ACartItems = cartItem.FindAll(x => x.SKUName.Equals("a", StringComparison.OrdinalIgnoreCase)).ToList();
            ATotalCost = ACartItems != null ? GetSKUItemTotalAmount(ACartItems) : 0;
            List<CartSKU> BCartItems = cartItem.FindAll(x => x.SKUName.Equals("b", StringComparison.OrdinalIgnoreCase)).ToList();
            BTotalCost = BCartItems != null ? GetSKUItemTotalAmount(BCartItems) : 0;
            List<CartSKU> CandDCartItems = cartItem.FindAll(x => x.SKUName.Equals("c", StringComparison.OrdinalIgnoreCase)
            || x.SKUName.Equals("d", StringComparison.OrdinalIgnoreCase)).ToList();
            CandDTotalCost = CandDCartItems != null ? GetSKUItemTotalAmount(CandDCartItems) : 0;
            return ATotalCost + BTotalCost + CandDTotalCost;
        }

        private int GetSKUItemTotalAmount(List<CartSKU> cartItems)
        {
            var SKUObj = _promoSKUObj.GetPromotionSKUObj(cartItems[0].SKUName);
            return SKUObj.GetSKUAmount(cartItems);
        }

    }
}
