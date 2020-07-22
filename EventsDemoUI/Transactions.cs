using DemoLibrary.EventsDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsDemoUI
{
    public partial class Transactions : Form
    {
        private Customer _customer = new Customer();
        public Transactions(Customer customer)
        {
            InitializeComponent();

            _customer = customer;

            customerValue.Text = _customer.CustomerName;
            _customer.CheckingAccount.OverDraftEvent += CheckingAccount_OverDraftEvent;
        }
        private void CheckingAccount_OverDraftEvent(object sender, OverDraftEventArgs e)
        {
            summaryLabel.Visible = true;
        }

        private void makePurchaseButon_Click(object sender, EventArgs e)
        {
            bool paymentResult = _customer.CheckingAccount
                .MakePayment("Credit Card Purchase", amountDU.Value, _customer.SavingAccount);

            amountDU.Value = 0;
        }

        private void summaryLabel_Click(object sender, EventArgs e)
        {
            this.summaryLabel.Visible = false;
        }
    }
}
