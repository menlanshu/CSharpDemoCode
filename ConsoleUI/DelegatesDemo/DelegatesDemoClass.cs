using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.DelegatesDemo;

namespace ConsoleUI.DelegatesDemo
{
    public static class DelegatesDemoClass
    {
        static ShoppingCartModel cart = new ShoppingCartModel();

        public static void MainTest()
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, DiscountAlert):C2}");

            Console.WriteLine();

            // we can do the samething inline
            decimal total = cart.GenerateTotal(
                // just need a parameter name, no need specific the parameter type
                (subTotal) => Console.WriteLine($"The initial 2 subTotal is {subTotal:C2}"),
                //  but you also can specify the variable name
                (items, subTotal) => 
                {
                    if (subTotal > 100)
                    {
                        return subTotal * 0.80M;
                    }
                    else if (subTotal > 50)
                    {
                        return subTotal * 0.85M;
                    }
                    else if (subTotal > 10)
                    {
                        return subTotal * 0.90M;
                    }
                    else
                    {
                        return subTotal;
                    }
                },
                // the third function for discoutn alert
                (discountMessage) => Console.WriteLine($"Cart 2 {discountMessage}")
                );

            Console.WriteLine($"The total for cart 2 is {total:C2}");

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The initial subTotal is {subTotal:C2}");
        }

        private static void DiscountAlert(string discountMessage)
        {
            Console.WriteLine(discountMessage);
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });

        }
    }
}
