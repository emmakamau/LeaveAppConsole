using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveAppConsole
{
    public class Staff
    {
        public string? Name { get; set; }
        public string? Department { get; set; }

        public int LeaveDays
        {
            get
            {
                int NoOfLeaveDays = 10;
                foreach(var leave in allLeaveApplications)
                {
                    NoOfLeaveDays -= leave.NoOfLeaveDays;
                }
                return NoOfLeaveDays;
            }
        }
        
        public int SickLeave
        {
            get
            {
                int NoOfSickOffDays = 10;
                foreach (var sickoof in allSickOffApplications)
                {
                    NoOfSickOffDays -= sickoof.NoOfSickOffDays;
                }

                return NoOfSickOffDays;
            }
        }

        public Staff(string StaffName, string department ,int initialLeaveDays, int allowedSickDays)
        {
            Name = StaffName;
            Department = department;
        }

        private List<LeaveApplication> allLeaveApplications = new List<LeaveApplication>();
        private List<SickOff> allSickOffApplications = new List<SickOff>();
        public void UtilizeLeave(int NoOfLeaveDays, DateTime date, string note) 
        { 
            if (NoOfLeaveDays <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(NoOfLeaveDays), "No of Leave days should be one or greater than one");
            }
            else if( NoOfLeaveDays > LeaveDays)
            {
                throw new ArgumentOutOfRangeException(nameof(NoOfLeaveDays), $"You can only apply for {LeaveDays} leave days or less ");
            }
            var newLeaveApplication = new LeaveApplication(NoOfLeaveDays,date, note);
            allLeaveApplications.Add(newLeaveApplication);
        }

        public void UtilizeSickLeave(int NoOfSickOffDays, DateTime date, string note)
        {
            if (NoOfSickOffDays <= 0)
            {
                throw new ArgumentException(nameof(NoOfSickOffDays), "No of Sick off days can only be one or greter than one");
            }
            else if (NoOfSickOffDays > SickLeave)
            {
                throw new ArgumentOutOfRangeException(nameof(NoOfSickOffDays), $"You can only apply for {SickLeave} sick off days or less ");
            }
            var newSickOffApplication = new SickOff(NoOfSickOffDays,date, note);
            allSickOffApplications.Add(newSickOffApplication);
        }
    }
}
