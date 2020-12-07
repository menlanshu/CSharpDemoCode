using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemoLibrary.Models
{
    public class PersonModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
