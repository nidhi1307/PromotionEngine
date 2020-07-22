using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    class PromotionCalculator : IPromotionCalculator
    {
        private readonly IPromotionSKUObj _promoSKUObj;

        public PromotionCalculator(IPromotionSKUObj promoSKUObj)
        {
            _promoSKUObj = promoSKUObj;
        }

        public int GetSKUAmount(CartSKU cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
