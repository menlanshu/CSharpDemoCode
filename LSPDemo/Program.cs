using System;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager ceo = new CEO
            {
                FirstName = "C",
                LastName = "EO"
            };
            IManager manager = new Manager
            {
                FirstName = "kuang",
                LastName = "dali",
                CurrManager = ceo
            };
            IEmployee employee = new Employee
            {
                FirstName = "men",
                LastName = "lan",
                CurrManager = manager
            };

            ceo.GenerateManagerReport();
            manager.GenerateManagerReport();
            Console.WriteLine($"Current pay rate of employee:{employee.CalcualatePayRate(3)}");

            Console.ReadKey();
        }
    }
}
