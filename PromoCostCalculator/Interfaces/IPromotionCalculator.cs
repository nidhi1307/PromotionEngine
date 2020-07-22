using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    interface IPromotionCalculator
    {
        public int GetSKUAmount(CartSKU cartItem);
    }
}
