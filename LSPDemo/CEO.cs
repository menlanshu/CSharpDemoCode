using System;
using System.Collections.Generic;
using System.Text;

namespace LSPDemo
{
    class CEO : IManager
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal CalcualatePayRate(int rank)
        {
            decimal output = 12.5M;

            output = output * rank;

            return output;
        }

        public void GenerateManagerReport()
        {
            System.Console.WriteLine("Generate report of CEO");
        }
    }
}
