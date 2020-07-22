using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.InterfaceDemo;

namespace ConsoleUI.InterfaceDemo
{
    public static class AbstractDemo
    {
        public static void MainTest()
        {
            List<IProductModel> cart = AddSampleData();

            CustomerModel customer = GetCustomer();

            foreach (var prod in cart)
            {
                prod.ShipAllItems(customer);
            }

            Console.ReadLine();
        }
        private static void ShipAllItems(this IProductModel prod, CustomerModel customer)
        {
            prod.ShipItem(customer);

            if (prod is IDigitalProductModel digital)
            {
                while (digital.TotalDownloadsLeft > 0)
                {
                    Console.WriteLine($"DIgital prod {digital.Title} still has something left to download {digital.TotalDownloadsLeft}");
                    prod.ShipItem(customer);
                }
            }
        }
        public static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Fu",
                LastName = "Long",
                City = "ShangHai",
                EmailAddress = "menlanshu@gmail.com",
                PhoneNumebr = "555-1212"
            };
        }

        public static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            // Add serverl physical product objects
            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmFuLong T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });


            // Add an object for digital product model
            output.Add(new DigitalProductModel { Title = "Lesson Csharp" });

            // Add a course product object
            output.Add(new CourseProductModel { Title = ".Net Core" });

            return output;

        }
    }
}
