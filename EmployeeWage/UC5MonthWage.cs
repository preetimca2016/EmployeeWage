using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class UC5MonthWage
    {
        public void MonthlyWage()
        {
            int EmpHrs = 0;
            int EmployeeWagePerHour = 20;
            int Dailywage = 0;
            //int FullTime = 1;
            //int PartTime = 2;
            int NumberOfWorkingDays = 20;
            int TotalSalary = 0;


            for (int i=0; i < NumberOfWorkingDays; i++ )
            {
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
                TotalSalary = TotalSalary + Dailywage;
            }
            Console.WriteLine("Employee total Monthly wage is "+TotalSalary);            
        }
    }
}
