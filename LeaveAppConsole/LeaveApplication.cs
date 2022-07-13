using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAppConsole
{
    public class LeaveApplication
    {
        public int NoOfLeaveDays { get; }
        public DateTime Date { get; }
        public string? Notes { get; }

        public LeaveApplication(int noOfLeaveDays, DateTime date, string? notes)
        {
            NoOfLeaveDays = noOfLeaveDays;
            Date = date;
            Notes = notes;
        }
    }
}
