using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class UC4SwitchStatement
    {
        public void SwitchDailyWage()
        {
            int EmpHrs = 0;
            int EmployeeWagePerHour = 20;
            int Dailywage=0;
            //int FullTime = 1;
            //int PartTime = 2;

            Random EmpCheck = new Random();
            int Check = EmpCheck.Next(0, 3);

            switch (Check)
            {
                case 1:
                    EmpHrs = 8;
                    break;
                case 2:
                    EmpHrs = 4;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            Dailywage = EmployeeWagePerHour * EmpHrs;
            Console.WriteLine("Employee Daily wage is : "+Dailywage);
        }
    }
}
