namespace InterfaceDemo
{
    internal class DigitalProductModel : IDigitalProductModel
    {
        public int DownloadCount { get; private set; } = 5;

        public string Title { get; set; }

        public bool HasBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if(HasBeenCompleted == false)
            {
                System.Console.WriteLine($"Digital Product {Title} has been send to {customer.FirstName}'s email {customer.EmailAddress}");
                DownloadCount--;
                if(DownloadCount < 1)
                {
                    DownloadCount = 0;
                    HasBeenCompleted = true;
                }
            }
        }
    }
}