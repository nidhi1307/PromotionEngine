using PromoCostCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public class PromotionSKUObj : IPromotionSKUObj
    {
        public ICartItemCalculator GetPromotionSKUObj(string skuName)
        {
            switch (skuName.ToUpper())
            {
                case "A":
                    return new ASKUPromotion();
                case "B":
                    return new BSKUPromotion();
                case "C":
                    return new CandDSKUPromotion();
                case "D":
                    return new CandDSKUPromotion();

                default:
                    throw new Exception();
            }
        }
    }
}
