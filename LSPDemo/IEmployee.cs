namespace LSPDemo
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        decimal CalcualatePayRate(int rank);
    }
}