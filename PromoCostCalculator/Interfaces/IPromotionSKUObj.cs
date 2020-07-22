using PromoCostCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public interface IPromotionSKUObj
    {
        public ICartItemCalculator GetPromotionSKUObj(string skuName);
    }
}
