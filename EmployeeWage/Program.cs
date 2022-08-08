namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
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

        }
    }
}