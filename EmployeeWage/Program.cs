using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("UC1-EmployeePresentAbsent");
            Console.WriteLine("UC2-DailyWage");
            Console.WriteLine("UC3-PartTimeWage");
            Console.WriteLine("UC4-SwitchStatement");
            Console.WriteLine("UC5-MonthlyWage");
            Console.WriteLine("UC6-MonthDayEnd");
            Console.WriteLine("UC7-Re-FactorEmpWage");
            Console.WriteLine("UC8-MultipleCompany");
            Console.WriteLine("UC9-EmptotalWage");
            Console.WriteLine("UC10-Multiple companies");
            Console.WriteLine("UC12-Multiple companies using Arraylist");
            Console.WriteLine("UC13-total Wage");
            int Answer = Convert.ToInt32(Console.ReadLine());
            
            switch (Answer)
            {
                case 1:
                    UC1EmployeePresentAbsent employee = new UC1EmployeePresentAbsent();
                    employee.PresentAbsent();
                    break;
                case 2:
                    UC2DailyWage wage = new UC2DailyWage();
                    wage.DailyWage();
                    break;
                case 3:
                    UC3PartTimeWage PartTimeWage = new UC3PartTimeWage();
                    PartTimeWage.EmployeePartTimeWage();
                    break;
                case 4:
                    UC4SwitchStatement Switchwage = new UC4SwitchStatement();
                    Switchwage.SwitchDailyWage();
                    break;
                case 5:
                    UC5MonthWage monthWageObj = new UC5MonthWage();
                    monthWageObj.MonthlyWage();
                    break;
                case 6:
                    UC6MonthDayEnd monthDayendObj = new UC6MonthDayEnd();
                    monthDayendObj.TotalDailyWage();
                    break;
                case 7:
                    UC7_RefactorEmpWage.computeEmpWage();
                    break;
                case 8:
                    Company companyObj1 = new Company("DMart", 20, 2, 10);
                    companyObj1.Calculations();
                    Console.WriteLine(companyObj1.Present_Check());
                    Company companyObj2 = new Company("Reliance", 10, 4, 20);
                    companyObj2.Calculations();
                    Console.WriteLine(companyObj2.Present_Check());
                    break;
                case 9:
                    EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
                    EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
                    dMart.ComputeEmpWage();
                    Console.WriteLine(dMart.toString());
                    reliance.ComputeEmpWage();
                    Console.WriteLine(reliance.toString());
                    break;
                case 10:
                    //EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                    //empWageBuilder.AddCompany("Relaince", 4000, 84, 258);
                    //empWageBuilder.AddCompany("Godrej", 940, 80, 240);
                    //empWageBuilder.AddCompany("Google", 250, 90, 850);
                    //empWageBuilder.AddCompany("TATA", 8000, 50, 200);
                    //empWageBuilder.DisplayCompanyWages();
                    break;
                case 12:
                    EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                    empWageBuilder.AddCompany("Relaince", 4000, 84, 258);
                    empWageBuilder.AddCompany("Godrej", 940, 80, 240);
                    empWageBuilder.AddCompany("Google", 250, 90, 850);
                    empWageBuilder.AddCompany("TATA", 8000, 50, 200);
                    empWageBuilder.DisplayCompanyWages();
                    break;
                case 13:
                    Console.WriteLine("Store Daily Wage");
                    break;
                
            }











        }
    }
}