using System;
using PromoCostCalculator.Promotions;
using PromoCostCalculator.Models;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            PromotionCalculator PromoCalObj = new PromotionCalculator(new PromotionSKUObj());
            List<CartSKU> cartItemList = new List<CartSKU>();
            int totalAmount = 0;
            Console.WriteLine("Enter number of SKUs in the cart");
            int i = Convert.ToInt32(Console.ReadLine());
            for(int j =0; j < i ; j++)
            {
                Console.WriteLine("Enter a SKU from A, B, C or D");
                CartSKU cartObj = new CartSKU();
                cartObj.SKUName = Console.ReadLine();
                Console.WriteLine("Enter the quantity of the entered SKU");
                cartObj.SKUQuantity = Convert.ToInt32(Console.ReadLine());
                cartItemList.Add(cartObj);
            }
            totalAmount = PromoCalObj.GetCartTotalAmount(cartItemList);
            Console.WriteLine("Total Amount {0}" ,totalAmount);
        }
    }
}
