using DelegateSelfDemo_Lib;
using System;

namespace DelegateSelfDemo_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // just some temprary test for intermediate interfactive command window!!
            //Foo testFoo = new Foo();
            //testFoo.Add(1,2);
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.MockCartData();

            decimal subTotal = shoppingCart.GenerateTotal(
                x => Console.WriteLine($"Acutal SubTotal is: {x}"),
                x => Console.WriteLine(x));

            Console.WriteLine($"You should pay {subTotal:C1} for all those products");
            Console.WriteLine(String.Format("You should pay {0:C2}", subTotal));
            Console.WriteLine(String.Format("You should pay {0:$#,##0.00}", subTotal));
        }

        public class Foo
        {
            public int Add(int a, int b)
            {
                int output = 0;
                output = a + b;
                return output;
            }
        }
    }
}
