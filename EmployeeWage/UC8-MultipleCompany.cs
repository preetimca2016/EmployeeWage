using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Company
    {
        public string Company_Name;
        public int Wage_Per_Hr;
        public int Full_Hr_Per_Day;
        public int Part_Hr_Per_Day;
        public int Max_Working_Days;
        public int Max_Working_Hrs;
        private string v1;
        private int v2;
        private int v3;
        private int v4;

        public Company(string v1, int v2, int v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public Company(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)
        {
            this.Company_Name = Company_Name;
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Full_Hr_Per_Day = Full_Hr_Per_Day;
            this.Part_Hr_Per_Day = Part_Hr_Per_Day;
            this.Max_Working_Days = Max_Working_Days;
            this.Max_Working_Hrs = Max_Working_Hrs;
        }

        internal void Calculations()
        {
            throw new NotImplementedException();
        }

        internal bool Present_Check()
        {
            throw new NotImplementedException();
        }
    }
    class Wage_Computation
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        private Dictionary<string, Company> Companies_Dict = new Dictionary<string, Company>();

        private void AddCompany(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)
        {
            Company comp_Obj = new Company(Company_Name.ToLower(), Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs);
            Companies_Dict.Add(Company_Name.ToLower(), comp_Obj);
        }

        public int Present_Check()
        {
            return new Random().Next(0, 3);
        }

        public void Calculations(string Company_Name)
        {
            int Hr_Per_Day = 0;
            int Wage_Per_Day = 0;
            int Total_Working_Hrs = 0;
            int Present_Days = 0;
            int Monthly_Wage = 0;

            if (!Companies_Dict.ContainsKey(Company_Name.ToLower()))
                throw new ArgumentNullException("Company doesn't Exist!");
            Companies_Dict.TryGetValue(Company_Name.ToLower(), out Company comp_Obj);

            while (Total_Working_Hrs < comp_Obj.Max_Working_Hrs && Present_Days < comp_Obj.Max_Working_Days)
            {
                switch (Present_Check())
                {
                    case Full_Time:
                        Hr_Per_Day = comp_Obj.Full_Hr_Per_Day;
                        Present_Days++;
                        break;
                    case Part_Time:
                        Present_Days++;
                        break;
                    default:
                        Hr_Per_Day = 0;
                        break;
                }
                Total_Working_Hrs += Hr_Per_Day;
                Wage_Per_Day = (comp_Obj.Wage_Per_Hr * Hr_Per_Day);
                Monthly_Wage += Wage_Per_Day;
            }
            Console.WriteLine("For " + Company_Name);
            Console.WriteLine("Total Hrs Worked " + Total_Working_Hrs);
            Console.WriteLine("total Days Present" + Present_Days);
            Console.WriteLine("Monthly Wage " + Monthly_Wage + "\n");

        }
    }
}
