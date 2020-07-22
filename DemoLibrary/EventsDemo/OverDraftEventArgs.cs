using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.EventsDemo
{
    public class OverDraftEventArgs : EventArgs
    {
        public decimal AmountOverDrafted { get; private set; }
        public string MoreInfo { get; private set; }
        // if you need this value to decide the next action, you can make is set public
        public bool CancelTransaction { get; set; } = false;

        // For even args, better to use contructor to initial value
        // And set property to get only
        public OverDraftEventArgs(decimal amountOverDrafted, string moreInfo)
        {
            AmountOverDrafted = amountOverDrafted;
            MoreInfo = moreInfo;
        }
    }
}
