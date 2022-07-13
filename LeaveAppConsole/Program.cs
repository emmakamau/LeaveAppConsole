// See https://aka.ms/new-console-template for more information
using LeaveAppConsole;

var staffAccount = new Staff("Emma", "Tech", 10, 10);
Console.WriteLine($"Staff account for {staffAccount.Name} of the {staffAccount.Department} department has been created. Leave Days:{staffAccount.LeaveDays}, SickOffs:{staffAccount.SickLeave}.");

staffAccount.UtilizeLeave(9, DateTime.Now, "Annual Leave Application");
Console.WriteLine($"Leave application for {staffAccount.Name} has been approved. No of Days remaining: {staffAccount.LeaveDays}");

staffAccount.UtilizeSickLeave(3, DateTime.Now, "Sick off");
Console.WriteLine($"Sick off application for {staffAccount.Name} has been approved. No of Days remaining: {staffAccount.SickLeave}");