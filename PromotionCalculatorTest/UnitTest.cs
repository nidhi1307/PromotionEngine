using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromoCostCalculator.Models;
using PromoCostCalculator.Promotions;
using System.Collections.Generic;

namespace PromotionCalculatorTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void NoDiscount()
        {
            List<CartSKU> cartItems = new List<CartSKU> {
                new CartSKU{SKUName="a",SKUQuantity=1},
                new CartSKU{SKUName="b",SKUQuantity=1},
                new CartSKU{SKUName="c",SKUQuantity=1}
                };
            PromotionCalculator PromoCalObj = new PromotionCalculator(new PromotionSKUObj());
            int Total = PromoCalObj.GetCartTotalAmount(cartItems);

            //Assert
            Assert.AreEqual(100, Total);

        }
    }
}
