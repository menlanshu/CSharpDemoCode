using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSelfDemo.Model
{
    public class Transaction
    {
        public string Purpose { get; set; }
        public decimal ConsumAmount { get; set; }
        public string TransMessage { get; set; }
    }
}
