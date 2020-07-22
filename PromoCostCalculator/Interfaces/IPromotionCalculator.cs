using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Promotions
{
    interface IPromotionCalculator
    {
        public int GetCartTotalAmount(List<CartSKU> cartItem);
    }
}
