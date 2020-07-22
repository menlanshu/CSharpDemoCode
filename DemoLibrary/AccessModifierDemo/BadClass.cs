using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BadClass
    {
        public string creditCardNumber;

        private string _ssc;

        public string SSN
        {
            get
            {
                return "*****_**-1234";
            }
            set { }
        }


    }
}
