namespace DemoLibrary.InterfaceDemo
{
    // When you create a Interface based on an existing class
    // You can press ctrl+. and chosse extract interface, then you can get an interface
    // Interface can inherit from other interface
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; set; }
    }
}