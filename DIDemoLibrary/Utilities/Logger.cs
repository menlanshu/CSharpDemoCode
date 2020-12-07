using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemoLibrary.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string logMessage)
        {
            Console.WriteLine($"Logging {DateTime.Now.ToShortTimeString()}: {logMessage}");
        }
    }
}
