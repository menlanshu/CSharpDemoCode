namespace InterfaceDemo
{
    internal interface IDigitalProductModel : IProductModel
    {
        public int DownloadCount { get; }
    }
}