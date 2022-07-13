using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAppConsole
{
    public class SickOff
    {
        public int NoOfSickOffDays { get; }
        public DateTime date { get; }
        public string? note { get; }
        public SickOff(int noOfSickOffDays, DateTime date, string? note)
        {
            NoOfSickOffDays = noOfSickOffDays;
            this.date = date;
            this.note = note;
        }
    }
}
