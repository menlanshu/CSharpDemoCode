using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.InterfaceDemo
{
    //public class DigitalProductModel : ProductModelBase, IProductModel
    //Each child class only can inherit from one and only one base class
    //Inherited base class should be put before any other interface that class want to inherit
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; } = false;
        public int TotalDownloadsLeft { get; set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating email {Title} to {customer.EmailAddress}");

                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }

            }
        }
    }
}
