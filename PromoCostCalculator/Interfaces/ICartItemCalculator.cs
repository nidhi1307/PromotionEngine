using PromoCostCalculator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCostCalculator.Interfaces
{
    public interface ICartItemCalculator
    {
        public int GetSKUAmount(List<CartSKU> cartItem);
    }
}
