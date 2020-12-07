namespace DIP
{
    public class Chore : IChore
    {
        public Chore(string choreName, IPerson owner, ILogger logger, IMessageSender messageSender)
        {
            ChoreName = choreName;
            Owner = owner;
            _logger = logger;
            _messageSender = messageSender;
        }

        public string ChoreName { get; private set; }
        public int WorkedHour { get; private set; }
        public IPerson Owner { get; private set; }
        public ILogger _logger;
        public IMessageSender _messageSender;

        public void PerformedWork(int hour)
        {
            this.WorkedHour += hour;
            _logger.WriteLog(Owner, $"Perform {hour} hours work for {ChoreName}");
        }
        public void CompleteChore()
        {
            _logger.WriteLog(Owner, $"Complete all works within {WorkedHour} hours for {ChoreName}");
            _messageSender.SendMessage(Owner, $"Chore {ChoreName} completed!");
        }
    }
}