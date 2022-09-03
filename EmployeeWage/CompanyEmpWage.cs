using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class CompanyEmpWage
    {
        //Varibales
        public string companyName;
        public int wagePerHour;
        public int maxWorkingDays;
        public int maxWorkingHours;
        int wagesPerMonth = 0;

        public CompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setWagesPerMonth(int wagesPerMonth)
        {
            this.wagesPerMonth = wagesPerMonth;
        }
        public void printMonthlyWage()
        {
            Console.WriteLine($"Wages for the company {companyName} for the month : {wagesPerMonth}");
        }
    }
}
