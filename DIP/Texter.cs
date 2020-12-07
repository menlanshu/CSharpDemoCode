using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating texting message in {person.EmailAddress}");
        }
    }
}
