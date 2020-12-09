using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDemo
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            // create one rule for validation
            //RuleFor(p => p.FirstName)
            //    .Cascade(CascadeMode.Stop)
            //    .NotEmpty().WithMessage("First Name is Empty")
            //    .Length(2, 50).WithMessage("Length of First Name invalid");

            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 50) // .WithMessage("Length {TotalLength} {MinLength}, {MaxLength}"), cool!!!! total length
                .Must(BeValidName).WithMessage("{PropertyName} Contains invalid Charactor");
            // a built-in function to get PropertyName and fill it, it's cool!!!!

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 50) // .WithMessage("Length {TotalLength} {MinLength}, {MaxLength}"), cool!!!! total length
                .Must(BeValidName).WithMessage("{PropertyName} Contains invalid Charactor");
            // a built-in function to get PropertyName and fill it, it's cool!!!!


            RuleFor(p => p.DateOfBirth)
                .Must(BeValidAge).WithMessage("Invalid {PropertyName}");

            RuleFor(p => p.AcountBalance)
                .LessThan(100);
        }


        protected bool BeValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if(date > DateTime.Now || dobYear < currentYear - 125)
            {
                return false;
            }

            return true;
        }

        protected bool BeValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");

            return name.All(Char.IsLetter);
        }
    }
}
