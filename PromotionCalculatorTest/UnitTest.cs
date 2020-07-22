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
        [TestMethod]
        public void OneDiscount()
        {
            List<CartSKU> cartItems = new List<CartSKU> {
                new CartSKU{SKUName="a",SKUQuantity=5},
                new CartSKU{SKUName="b",SKUQuantity=5},
                new CartSKU{SKUName="c",SKUQuantity=1}
                };
            PromotionCalculator PromoCalObj = new PromotionCalculator(new PromotionSKUObj());
            int Total = PromoCalObj.GetCartTotalAmount(cartItems);

            //Assert
            Assert.AreEqual(370, Total);

        }
        [TestMethod]
        public void AllDiscount()
        {
            List<CartSKU> cartItems = new List<CartSKU> {
                new CartSKU{SKUName="a",SKUQuantity=3},
                new CartSKU{SKUName="b",SKUQuantity=5},
                new CartSKU{SKUName="c",SKUQuantity=1},
                new CartSKU{SKUName="d",SKUQuantity=1}
                };
            PromotionCalculator PromoCalObj = new PromotionCalculator(new PromotionSKUObj());
            int Total = PromoCalObj.GetCartTotalAmount(cartItems);

            //Assert
            Assert.AreEqual(280, Total);

        }
        [TestMethod]
        public void NullValueEntry()
        {
            List<CartSKU> cartItems = new List<CartSKU> {
                new CartSKU{SKUName="a",SKUQuantity=3},
                new CartSKU{SKUName="b",SKUQuantity=5},
                new CartSKU{SKUName="c",SKUQuantity=0},
                new CartSKU{SKUName="d",SKUQuantity=1}
                };
            PromotionCalculator PromoCalObj = new PromotionCalculator(new PromotionSKUObj());
            int Total = PromoCalObj.GetCartTotalAmount(cartItems);

            //Assert
            Assert.AreEqual(265, Total);
        }
    }
}
