using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class UC3PartTimeWage
    {
        public void EmployeePartTimeWage()
        {
            int EmployeeWagePerHour = 20;
        int Dailywage = 0;
        int EmpHrs = 0;
        Random EmpCheck = new Random();
        int Check = EmpCheck.Next(0, 3);
        int FullTime = 1;
        int PartTime = 2;

            if (Check == FullTime)
            {
                Console.WriteLine("Employee is present for Full time");
                EmpHrs = 8;
            }
            else if (Check == PartTime)
            {
                Console.WriteLine("Employee is Present for PartTime");
                EmpHrs = 4;
            }
            else
{
    Console.WriteLine("Employee Is Absent");
    EmpHrs = 0;
}
Dailywage = EmployeeWagePerHour * EmpHrs;
Console.WriteLine("Employee DailyWage is " + Dailywage);
            
        }
    }
}
