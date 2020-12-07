using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public static class DemoFactory
    {
        public static IPerson CreatePerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            return new Person
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber
            };
        }
        public static IChore CreateChore(string choreName, IPerson person)
        {
            return new Chore(choreName, person, CreateLogger(), CreateEmailer());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IMessageSender CreateEmailer()
        {
            return new Emailer();
            //return new Texter();
        }
    }
}
