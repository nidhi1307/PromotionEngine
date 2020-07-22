using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Interfaces
{
    interface ICartItemCalculator
    {
        public int GetSKUAmount(CartSKU cartItem);
    }
}
