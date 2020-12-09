using System;

namespace FluentValidationDemo
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AcountBalance { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}