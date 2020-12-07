namespace LSPDemo
{
    public interface IManaged
    {
        public IManager CurrManager { get; set; }
        void AssignManager(IManager manager);
    }
}