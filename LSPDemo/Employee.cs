namespace LSPDemo
{
    public class Employee : IEmployee, IManaged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IManager CurrManager { get; set; }

        public void AssignManager(IManager manager)
        {
            this.CurrManager = manager;
        }

        public decimal CalcualatePayRate(int rank)
        {
            decimal output = 12.5M;

            output = output * rank;

            return output;
        }
    }
}