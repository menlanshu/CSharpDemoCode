namespace DIP
{
    public interface IChore
    {
        string ChoreName { get; }
        IPerson Owner { get; }

        void CompleteChore();
        void PerformedWork(int hour);
    }
}