namespace DIP
{
    public interface ILogger
    {
        void WriteLog(IPerson person, string logMessage);
    }
}