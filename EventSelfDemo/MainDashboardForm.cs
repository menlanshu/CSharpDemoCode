using EventSelfDemo.Interface;
using EventSelfDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSelfDemo
{
    public partial class MainDashboardForm : Form, ITransactionHandle
    {
        Account _checkingAccount;
        Account _backupAccount;
        public MainDashboardForm()
        {
            InitializeComponent();

            InitialAccount();
            WireupForm();
        }

        private void InitialEvent()
        {
            _checkingAccount.OverDraftEvent += OverDraftHappenEvent;
            _checkingAccount.TransactionEvent += TransactionHandleEvent;
            _backupAccount.TransactionEvent += TransactionHandleEvent;
        }

        private void WireupForm()
        {
            this.txAccountName.Text = _checkingAccount.Name;
        }

        private void UpdateDataSource()
        {
            this.txCheckAccountDeposit.Text =  _checkingAccount.Balance.ToString();
            this.txBackupAccountDeposit.Text =  _backupAccount.Balance.ToString();

            this.lbCATransactions.DataSource = _checkingAccount.Transactions;
            this.lbCATransactions.DisplayMember = "TransMessage";
            this.lbBATransactions.DataSource = _backupAccount.Transactions;
            this.lbBATransactions.DisplayMember = "TransMessage";
        }

        private void InitialAccount()
        {
            _checkingAccount = new Account ( "Menlan");
            _backupAccount = new Account ( "Dali"); 

            InitialEvent();

            _checkingAccount.AddDeposit("Initial", 156.78M);
            _backupAccount.AddDeposit("Initial", 90.12M);
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(this);
            transactionForm.Show();
        }

        public bool MakePayment(string payItemName, decimal amount)
        {
            return _checkingAccount.MakePayment(payItemName, amount, _backupAccount);
        }

        public void AddOverdraftEvent(EventHandler<string> eventHandler)
        {
            _checkingAccount.OverDraftEvent += eventHandler;
        }

        private void lbOverDraftRemind_Click(object sender, EventArgs e)
        {
            this.lbOverDraftRemind.Visible = false;
        }
        private void OverDraftHappenEvent(object sender, string message)
        {
            this.lbOverDraftRemind.Text = message;
            this.lbOverDraftRemind.Visible = true;
        }
        private void TransactionHandleEvent(object sender, TransactionEventArgs e)
        {
            UpdateDataSource();
        }
    }
}
