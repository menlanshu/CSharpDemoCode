using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> productList = LoadProductModelData();
            CustomerModel customer = LoadCustomerData();

            foreach(var product in productList)
            {
                product.ShipItem(customer);
                if(product is IDigitalProductModel digit)
                {
                    Console.WriteLine($"it's a digital product {digit.Title} and total download counts is {digit.DownloadCount}");
                }
            }

            Console.ReadKey();
        }

        private static CustomerModel LoadCustomerData()
        {
            return new CustomerModel
            {
                FirstName = "Fu",
                LastName = "Tian",
                City = "Shanghai",
                StreetAddress ="TestAddress",
                EmailAddress = "123456@gmail.com",
                Phone="123456"
            };
        }

        private static List<IProductModel> LoadProductModelData()
        {
            return new List<IProductModel>
            {
                new ProductModel {Title = "Produt"},
                new DigitalProductModel {Title = "Digital Produt"},
            };
        }
    }
}
