using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Logger : ILogger
    {
        public void WriteLog(IPerson person, string logMessage)
        {
            Console.WriteLine($"{person.FirstName} log message: {logMessage}");
        }
    }
}
