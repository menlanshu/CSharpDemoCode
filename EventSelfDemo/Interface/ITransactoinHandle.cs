using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSelfDemo.Interface
{
    public interface ITransactionHandle
    {
        bool MakePayment(string payItemName, decimal amount);
        void AddOverdraftEvent(EventHandler<string> eventHandler);
    }
}
