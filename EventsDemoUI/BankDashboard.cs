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
    public partial class BankDashboard : Form
    {
        Customer _customer = new Customer();
        public BankDashboard()
        {
            InitializeComponent();

            InitializeForm();

            LoadTestingData();

            WireUpForm();
        }

        private void InitializeForm()
        {
            this.summaryLabel.Visible = false;
        }

        private void WireUpForm()
        {
            customerValue.Text = _customer.CustomerName;
            checkingTransactions.DataSource = _customer.CheckingAccount.Transactions;
            savingsTransactions.DataSource = _customer.SavingAccount.Transactions;

            checkBalanceValue.Text = string.Format("{0:C2}", _customer.CheckingAccount.Balance);
            savingBalanceValue.Text = string.Format("{0:C2}", _customer.SavingAccount.Balance);

            // find a place to listen to event
            _customer.CheckingAccount.TransactionApprovedEvent += CheckingAccount_TransactionApprovedEvent;
            _customer.SavingAccount.TransactionApprovedEvent += SavingAccount_TransactionApprovedEvent;

            _customer.CheckingAccount.OverDraftEvent += CheckingAccount_OverDraftEvent;
        }

        private void CheckingAccount_OverDraftEvent(object sender, OverDraftEventArgs e)
        {
            summaryLabel.Text = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e.AmountOverDrafted)}";
            summaryLabel.Visible = true;

            e.CancelTransaction = !allowOverDraftCB.Checked;
        }

        private void CheckingAccount_TransactionApprovedEvent(object sender, string e)
        {
            checkingTransactions.DataSource = null;
            checkingTransactions.DataSource = _customer.CheckingAccount.Transactions;
            checkBalanceValue.Text = string.Format("{0:C2}", _customer.CheckingAccount.Balance);
        }

        private void SavingAccount_TransactionApprovedEvent(object sender, string e)
        {
            savingsTransactions.DataSource = null;
            savingsTransactions.DataSource = _customer.SavingAccount.Transactions;
            savingBalanceValue.Text = string.Format("{0:C2}", _customer.SavingAccount.Balance);

        }

        private void LoadTestingData()
        {
            _customer.CustomerName = "Fu Long";
            _customer.CheckingAccount = new Account();
            _customer.SavingAccount = new Account();

            _customer.CheckingAccount.AccountName = "Long's Checking Account";
            _customer.SavingAccount.AccountName = "Long's Checking Account";

            _customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M);
            _customer.SavingAccount.AddDeposit("Initial Balance", 98.45M);
        }

        private void recordTransactionButton_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(_customer);
            transactions.Show();
        }

        private void summaryLabel_Click(object sender, EventArgs e)
        {
            summaryLabel.Visible = false;
        }
    }
}
