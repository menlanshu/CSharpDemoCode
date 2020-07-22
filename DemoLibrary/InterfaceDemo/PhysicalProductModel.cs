using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.InterfaceDemo
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; } = false;

        public void ShipItem(CustomerModel customer)
        {
            if(HasOrderBeenCompleted ==  false)
            {
                Console.WriteLine($"Simulatring shipping { Title } to {customer.FirstName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
