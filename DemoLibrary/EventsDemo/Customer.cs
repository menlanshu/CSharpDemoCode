using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.EventsDemo
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public Account CheckingAccount { get; set; }
        public Account SavingAccount { get; set; }
    }
}
