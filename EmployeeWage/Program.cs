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
            int Answer = Convert.to
            UC1EmployeePresentAbsent employee = new UC1EmployeePresentAbsent();
            employee.PresentAbsent();

            UC2DailyWage wage = new UC2DailyWage();
            wage.DailyWage();

            UC3PartTimeWage PartTimeWage = new UC3PartTimeWage();
            PartTimeWage.EmployeePartTimeWage();

            UC4SwitchStatement switchwage = new UC4SwitchStatement();
            switchwage.SwitchDailyWage();

            Console.WriteLine("Total Monthly wage is :- ");
            UC5MonthWage monthWage = new UC5MonthWage();
            monthWage.MonthlyWage();

            EmployeeWageBuilderArray empWageBuilder = new EmployeeWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.addcomputeEmpWage();


        }
    }
}