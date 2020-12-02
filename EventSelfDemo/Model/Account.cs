using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSelfDemo.Model
{
    public delegate void TestDelegate(string testMessage);
    public class Account
    {
        public EventHandler<TransactionEventArgs> TransactionEvent;
        public EventHandler<string> OverDraftEvent;
        public event TestDelegate testEvent;
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        // we need a transaction list to record all transactions
        // and this transaction should be read only too
        private List<Transaction> _transactions = new List<Transaction>();

        public Account(string name)
        {
            Name = name;
        }

        public IReadOnlyList<Transaction> Transactions
        {
            // should use AsReadOnly to make sure the list will not be changed
            get => _transactions.AsReadOnly();
        }
        public bool AddDeposit(string source, decimal addAmount)
        {
            if (addAmount < 0)
            {
                _transactions.Add(new Transaction
                {
                    Purpose = "Add Deposit",
                    ConsumAmount = addAmount,
                    TransMessage = $"[Failed]Add Deposit with amount {addAmount} from {source}! Illegal amount."
                });
                TransactionEvent?.Invoke(this, new TransactionEventArgs(source, addAmount));
                return false;
            }
            else
            {
                _transactions.Add(new Transaction
                {
                    Purpose = "Add Deposit",
                    ConsumAmount = addAmount,
                    TransMessage = $"[Success]Add Deposit with amount {addAmount} from {source}."
                });
                Balance += addAmount;
                TransactionEvent?.Invoke(this, new TransactionEventArgs(source, addAmount));
                return true;
            }
        }


        public bool MakePayment(string payItemName, decimal amount, Account backupAccount = null)
        {
            if(Balance >= amount)
            {
                _transactions.Add(new Transaction
                {
                    Purpose = payItemName,
                    ConsumAmount = amount,
                    TransMessage = $"[Success]Make pay {amount} for {payItemName}"
                });

                Balance -= amount;
                TransactionEvent?.Invoke(this, new TransactionEventArgs(payItemName, amount));
                return true;
            }else
            {
                if(backupAccount is null)
                {
                    _transactions.Add(new Transaction
                    {
                        Purpose = payItemName,
                        ConsumAmount = amount,
                        TransMessage = $"[Fail]Try to make pay {amount} for {payItemName}, but overdraft!\nOnly have {Balance} in checking account"
                    });
                    OverDraftEvent?.Invoke(this, $"Overdraft for {amount}, current count only have {Balance}");
                    return false;
                }
                else
                {
                    if(backupAccount.Balance + Balance >= amount)
                    {
                        // Get money from backup account
                        decimal overdraftAmount = amount - Balance;
                        if(backupAccount.MakePayment($"Overdraft for {this.Name}", overdraftAmount))
                        {
                            this.AddDeposit($"BackupAccount {backupAccount.Name}",overdraftAmount);
                        }else
                        {
                            return false;
                        }

                        if (this.MakePayment(payItemName, amount))
                        {
                            return true;
                        }else
                        {
                            return false;
                        }


                    }else
                    {
                        _transactions.Add(new Transaction
                        {
                            Purpose = payItemName,
                            ConsumAmount = amount,
                            TransMessage = $"[Fail]Try to make pay {amount} for {payItemName}, but overdraft!\nOnly have {Balance} in checking account\nAnd {backupAccount.Balance} in backup account"
                        });
                        OverDraftEvent?.Invoke(this, $"Overdraft for {amount}, current/backup acount only have {Balance}/{backupAccount.Balance}");
                        return false;
                    }
                }
            }
        }
    }
}
