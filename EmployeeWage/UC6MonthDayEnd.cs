using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage1
{
    internal class UC6MonthDayEnd
    {
        public int EmployeeWagePerHour = 20;
        public int DailyWage = 0;
        public int EmpHrs = 0;
        public const int EmployeeFullTime = 1;
        public const int EmployeePartTime = 2;
        public int FullTimeWorkingHrs = 8;
        public int PartTimeWorkingHrs = 4;
        public int WorkingDayPerMonth = 20;
        public int MonthlyWage = 0;
        public const int EmployeeAbsent = 0;
        public int AbsentHrs = 4;

        private int IsemployeePresentAbsent()

        {
            return new Random().Next() % 3;
        }
        public void TotalDailyWage()
        {
            int DayNumber = 1;

            while (DayNumber <= WorkingDayPerMonth)
            {
                switch (IsemployeePresentAbsent())
                {
                    case EmployeeFullTime:
                        DailyWage = FullTimeWorkingHrs * EmployeeWagePerHour;
                        break;
                    case EmployeePartTime:
                        DailyWage = PartTimeWorkingHrs * EmployeeWagePerHour;
                        break;
                    case EmployeeAbsent:
                        DailyWage = AbsentHrs * EmployeeWagePerHour;
                        break;

                }
                MonthlyWage = +DailyWage;
            }
            Console.WriteLine("Employee Monthly Wage" + MonthlyWage);
        }








    }
}
