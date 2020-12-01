namespace InterfaceDemo
{
    internal interface IProductModel
    {
        string Title { get; set; }
        bool HasBeenCompleted { get; }

        void ShipItem(CustomerModel customer);
    }
}