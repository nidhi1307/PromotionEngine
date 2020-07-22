using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    public interface IPromotionSKUObj
    {
        public PromotionBaseClass GetPromotionSKUObj(string skuName);
    }
}
