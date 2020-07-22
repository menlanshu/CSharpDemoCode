using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.EventsDemo
{
    public class Account
    {
        // Define an event here
        // You need a place to trigger the event
        // You also need a place to listen to the event
        public EventHandler<string> TransactionApprovedEvent;
        public EventHandler<OverDraftEventArgs> OverDraftEvent;

        public string AccountName { get; set; }
        public decimal Balance { get; private set; }

        private List<string> _transactions = new List<string>();

        // return a readonly string list
        // We do not want user to change the list of transactions
        public IReadOnlyList<string> Transactions
        {
            get { return _transactions.AsReadOnly(); }
        }

        public bool AddDeposit(string depositName, decimal amount)
        {
            _transactions.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
            Balance += amount;

            // find a place to trigger event
            TransactionApprovedEvent?.Invoke(this, depositName);
            return true;
        }


        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            // Ensure we have enough money
            if(Balance > amount)
            {
                _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                Balance -= amount;
                // find a place to trigger event
                TransactionApprovedEvent?.Invoke(this, paymentName);
                return true;
            }else
            {
                if (backupAccount != null)
                {
                    // check to see if we have enough money in the backup account
                    if((backupAccount.Balance + Balance) > amount)
                    {

                        // we have entough backup funds so transfer the amount to this account
                        // and then complte the transaction.
                        decimal amountNeed = amount - Balance;

                        // a place to trigger over draft event
                        OverDraftEventArgs args = new OverDraftEventArgs(amountNeed, "Extra Info");
                        OverDraftEvent?.Invoke(this, args);

                        if(args.CancelTransaction == true)
                        {
                            return false;
                        }

                        // take out money from backup account
                        bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeed);

                        if(overdraftSucceeded == false)
                        {
                            // The overdraft failed so this transaction failed
                            return false;
                        }


                        // Add deposit for get money from the backup account
                        AddDeposit("Overdraft Protection Deposit", amountNeed);

                        _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                        Balance -= amount;

                        // find a place to trigger event
                        TransactionApprovedEvent?.Invoke(this, paymentName);

                        return true;

                    }else
                    {
                        // not enough backup funds to do anything
                        return false;
                    }
                }
                else
                {
                    // no backup account so we fail and do nothing
                    return false;
                }
            }
        }
    }
}
