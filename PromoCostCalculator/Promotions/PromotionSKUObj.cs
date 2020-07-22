﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public class PromotionSKUObj : IPromotionSKUObj
    {
        public PromotionBaseClass GetPromotionSKUObj(string skuName)
        {
            switch (skuName.ToUpper())
            {
                case "A":
                    return new ASKUPromotion();
                case "B":
                    return new BSKUPromotion();
                case "C":
                case "D":
                    return new CandDSKUPromotion();

                default:
                    throw new Exception();
            }
        }
    }
}
