using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSelfDemo.Model
{
    public class TransactionEventArgs : EventArgs
    {
        public TransactionEventArgs(string payItem, decimal amount)
        {
            TransPayItem = payItem;
            Amount = amount;
        }

        public string TransPayItem { get; private set; }
        public decimal Amount { get; private set; }
        // we can use this function to decide wether current transaction need to be canceled
        public bool CancelTransaction { get; set; } = false;
    }
}
