using PromoCostCalculator.Constants;
using PromoCostCalculator.Interfaces;
using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public class BSKUPromotion : PromotionBaseClass, ICartItemCalculator
    {
        public int GetSKUAmount(List<CartSKU> cartItem)
        {
            //Calculation of B SKUs Total price
            int discount = Math.DivRem(cartItem[0].SKUQuantity, PromotionsConstant.BPromoQuantity, out int restQuantity);
            return (discount * PromotionsConstant.BPromoValue) + (restQuantity * PromotionsConstant.BSKUPrice);
        }
    }
}
