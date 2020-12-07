using System;
using System.Collections.Generic;
using System.Text;

namespace ISPDemo
{
    public interface IBorrowable
    {
        public bool BorrowOut { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CheckInData { get; set; }
        public int BorrowDays { get; set; }
    }
}
