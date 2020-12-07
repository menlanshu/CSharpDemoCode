using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependency Inversion Principle
            IPerson person = DemoFactory.CreatePerson("men","lan","test@gmail.com", "123456");

            IChore chore = DemoFactory.CreateChore("Take out case", person);
            chore.PerformedWork(3);
            chore.PerformedWork(1);
            chore.CompleteChore();

            Console.ReadKey();
        }
    }
}
