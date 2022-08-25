﻿using EmployeeWage1;

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
                    EmployeeWageBuilderArray empWageBuilder = new EmployeeWageBuilderArray();
                    empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
                    empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                    empWageBuilder.addcomputeEmpWage();
                    break;
                case 11:
                    AddNewCompany company = new AddNewCompany();
                    for (int i = 0; i < 3; i++)
                    {

                        company.AddCompanyByArray();

                        if (i == 2)
                        {
                            company.DisplayByArray();
                        }
                    }
                    break;
                case 12:
                    AddNewCompany company = new AddNewCompany();
                    Console.WriteLine("Enter y to add company");
                    string input = Console.ReadLine();
                    while (input == "y")
                    {
                        company.AddCompanyBylist();
                        Console.WriteLine("Company Data Stored again enter y to add company");
                        input = Console.ReadLine();

                    }
                    company.DisplayByList();

                    break;
            }











        }
    }
}