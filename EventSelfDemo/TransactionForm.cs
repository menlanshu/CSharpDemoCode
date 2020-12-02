using EventSelfDemo.Interface;
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
    public partial class TransactionForm : Form
    {
        ITransactionHandle _transactionHandle;
        public TransactionForm(ITransactionHandle transactionHandle)
        {
            _transactionHandle = transactionHandle;
            _transactionHandle.AddOverdraftEvent(EventUpdateOverDraftAlarm);

            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            _transactionHandle.MakePayment(this.txTransactionName.Text, this.nudAmmount.Value);
        }
        private void EventUpdateOverDraftAlarm(object sender, string message)
        {
            this.lbOverDraftWarning.Text = message;
            this.lbOverDraftWarning.Visible = true;
        }

        private void lbOverDraftWarning_Click(object sender, EventArgs e)
        {
            this.lbOverDraftWarning.Visible = false;
        }
    }
}
