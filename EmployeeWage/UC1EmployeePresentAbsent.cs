using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class UC1EmployeePresentAbsent
    {
        public void PresentAbsent()
        {
            Random EmpCheck = new Random();
            int Check = EmpCheck.Next(0, 2);
            int EmployeePresent = 1;
            if(Check == EmployeePresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
          
        
        }
        
    }
}
