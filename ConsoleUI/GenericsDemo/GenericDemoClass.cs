using DemoLibrary.GenericsDemo.Models;
using DemoLibrary.GenericsDemo.WithGenerics;
using DemoLibrary.GenericsDemo.WithoutGenerics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.GenericsDemo
{
    public static class GenericDemoClass
    {
        public static void MainTest()
        {
            //!!! DO NOT use array list
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(213);
            //arrayList.Add("Hello");

            //List<int> ages = new List<int>();

            //ages.Add(1);

            DemoStrateTextFileStorage();

            Console.WriteLine();
            Console.WriteLine("Press Enter to shut down ...");
            Console.ReadLine();
        }

        private static void DemoStrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Users\lfu163986\Documents\2-Dev\Test\Csharp\CSharpDemoCode\Data\people.csv";
            string logFile = @"C:\Users\lfu163986\Documents\2-Dev\Test\Csharp\CSharpDemoCode\Data\logs.csv";

            PopulateLists(people, logs);

            // New way with generic
            GenericTextFileProcessor.SaveToTextFile(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);
            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName} { p.LastName } (IsAlive = { p.IsAlive })");
            }

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{log.ErrorCode}:{log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            }

            /* Old way of doing things - non-generics */

            //OriginalTextFileProcessor.SaveLogs(logs, logFile);

            //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

            //foreach (var log in newLogs)
            //{
            //    Console.WriteLine($"{log.ErrorCode}:{log.Message} at {log.TimeOfEvent.ToShortTimeString()}");
            //}

            //OriginalTextFileProcessor.SavePeople(people, peopleFile);

            //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($"{ p.FirstName} { p.LastName } (IsAlive = { p.IsAlive })");
            //}
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Fu", LastName = "Long" });
            people.Add(new Person { FirstName = "Kuang", LastName = "Dali" });
            people.Add(new Person { FirstName = "Hua", LastName = "Tingting" });

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 9999 });
            logs.Add(new LogEntry { Message = "I'm too awesome", ErrorCode = 1227 });
            logs.Add(new LogEntry { Message = "I was tired", ErrorCode = 2222 });

        }
    }
}
