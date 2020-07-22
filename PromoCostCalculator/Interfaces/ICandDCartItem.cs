using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Interfaces
{
    interface ICandDCartItem
    {
        public int GetCandDSKUAmount(List<CartSKU> cartItem);
    }
}
