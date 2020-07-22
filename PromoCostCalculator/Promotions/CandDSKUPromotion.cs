using PromoCostCalculator.Constants;
using PromoCostCalculator.Interfaces;
using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public class CandDSKUPromotion : PromotionBaseClass, ICandDCartItem
    {
        public int GetCandDSKUAmount(List<CartSKU> cartItem)
        {
            var cSKUCount = cartItem.AsEnumerable().Where(x => x.SKUName.Equals("C", StringComparison.OrdinalIgnoreCase))
                .Select(x => x.SKUQuantity).FirstOrDefault();
            var dSKUCount = cartItem.AsEnumerable().Where(x => x.SKUName.Equals("D", StringComparison.OrdinalIgnoreCase))
                .Select(x => x.SKUQuantity).FirstOrDefault();
            if (cSKUCount < 1 || dSKUCount < 1)
            {
                return (cSKUCount != 0 && dSKUCount == 0 ? PromotionsConstant.CSKUPrice * cSKUCount :
                    (cSKUCount == 0 && dSKUCount != 0) ? PromotionsConstant.DSKUPrice * dSKUCount : 0);
            }
            else if (cSKUCount >= 1 || dSKUCount >= 1)
            {
                return (cSKUCount > dSKUCount ? GetCandDTotValue(cSKUCount, dSKUCount, PromotionsConstant.CSKUPrice) : (cSKUCount < dSKUCount) ?
                    GetCandDTotValue(dSKUCount, cSKUCount, PromotionsConstant.DSKUPrice) : dSKUCount * PromotionsConstant.CandDPromoValue);
            }
            return 0;
        }

        private int GetCandDTotValue(int GreaterVal, int LessValue, int price)
        {
            var diffCount = GreaterVal - LessValue;
            var ksuCandDCount = GreaterVal - diffCount;
            return (ksuCandDCount * PromotionsConstant.CandDPromoValue) + (diffCount * price);
        }
    }
}
