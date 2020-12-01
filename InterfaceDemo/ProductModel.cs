namespace InterfaceDemo
{
    internal class ProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasBeenCompleted { get; private set; }
        public void ShipItem(CustomerModel customer)
        {
            if(HasBeenCompleted == false)
            {
                System.Console.WriteLine($"Product {Title} has been shipped to {customer.FirstName} at {customer.StreetAddress}");
                HasBeenCompleted = true;
            }
        }
    }
}