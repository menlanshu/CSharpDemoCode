using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo.Models
{
    public class LogEntry
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime ErrorTime { get; set; } = DateTime.UtcNow;
    }
}
