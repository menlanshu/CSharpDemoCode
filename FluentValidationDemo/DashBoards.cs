using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentValidationDemo
{
    public partial class DashBoards : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public DashBoards()
        {
            InitializeComponent();
            WireUp();
        }

        public void WireUp()
        {
            listErrorList.DataSource = errors;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // never trust the user
            // serveral ways to check the data?
            // add validation in model?
            // add validation in front end? where is better?

            errors.Clear();

            if(!decimal.TryParse(txAccountBalance.Text, out decimal accountBalance))
            {
                errors.Add("Account Balance: Invalid Amount");
                return;
            }

            PersonModel person = new PersonModel();
            person.FirstName = txFirstName.Text;
            person.LastName = txLastName.Text;
            person.AcountBalance = accountBalance;
            // not great than today, not older than 130 year ago
            person.DateOfBirth = dtpDataOfBirth.Value;

            // validate data
            PersonValidator validator = new PersonValidator();

            ValidationResult result = validator.Validate(person);

            if(result.IsValid == false)
            {
                foreach(ValidationFailure failure in result.Errors)
                {
                    errors.Add($"{failure.PropertyName}:{failure.ErrorMessage}");
                }
            }
            // insert into database

            MessageBox.Show("Opeartion Complete");
        }
    }
}
