using PromoCostCalculator.Constants;
using PromoCostCalculator.Interfaces;
using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public class ASKUPromotion: PromotionBaseClass, ICartItemCalculator
    {
        public int GetSKUAmount(CartSKU cartItem)
        {
            int discount = Math.DivRem(cartItem.SKUQuantity, PromotionsConstant.APromoQuantity, out int restQuantity);
            return (discount * PromotionsConstant.APromoValue) + (restQuantity * PromotionsConstant.ASKUPrice);
        }
    }
}