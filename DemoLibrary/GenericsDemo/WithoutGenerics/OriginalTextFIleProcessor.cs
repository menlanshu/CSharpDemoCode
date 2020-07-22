using DemoLibrary.GenericsDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.GenericsDemo.WithoutGenerics
{
    public static class OriginalTextFileProcessor
    {
        private static char[] SPLIT_STR = (",").ToCharArray();
        public static List<Person> LoadPeople(string peopleFile)
        {
            List<Person> output = new List<Person>();
            List<string> lines = File.ReadAllLines(peopleFile).ToList();

            for (int i = 1; i < lines.Count; i++)
            {
                // get current line
                var currLine= lines[i].Split(SPLIT_STR);

                // Create new person
                Person newPerson = new Person();

                newPerson.FirstName = currLine[0];
                newPerson.IsAlive = bool.Parse(currLine[1]);
                newPerson.LastName = currLine[2];

                // Add new person to current people list
                output.Add(newPerson);
            }

            return output;
        }

        public static List<LogEntry> LoadLogs(string fileEntryPath)
        {
            List<LogEntry> output = new List<LogEntry>();
            List<string> lines = File.ReadAllLines(fileEntryPath).ToList();

            for (int i = 1; i < lines.Count; i++)
            {
                // get current line
                var currLine = lines[i].Split(SPLIT_STR);

                // Create new person
                LogEntry newLogEntry = new LogEntry();

                newLogEntry.ErrorCode = int.Parse(currLine[0]);
                newLogEntry.Message = currLine[1];
                newLogEntry.TimeOfEvent = DateTime.Parse(currLine[2]);

                // Add new person to current people list
                output.Add(newLogEntry);
            }

            return output;
        }

        public static void SavePeople(List<Person> people, string peopleFile)
        {
            List<string> lines = new List<string>();

            // Add a header row
            lines.Add("FirstName,IsAlive,LastName");

            foreach (var p in people)
            {
                lines.Add($"{p.FirstName},{p.IsAlive},{p.LastName}");
            }

            File.WriteAllLines(peopleFile, lines);
        }

        public static void SaveLogs(List<LogEntry> logs, string logFilePath)
        {
            List<string> lines = new List<string>();

            // Add a header row
            lines.Add("ErrorCode,Message,TimeOfEvent");

            foreach (var l in logs)
            {
                lines.Add($"{l.ErrorCode},{l.Message},{l.TimeOfEvent.ToString()}");
            }

            File.WriteAllLines(logFilePath, lines);
        }
    }
}
