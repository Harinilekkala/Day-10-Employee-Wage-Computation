using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagecmp
{
    internal class empwage
    {
        int empHours = 0;
        int empWagePerHour = 20;
        int dailyWage;
        public void Attendance()
        {
            Random value = new Random();
            int randomCheck = value.Next(2);
            Console.WriteLine("Check Statusof Employee");

            switch (randomCheck)
            {
                case 0:
                    {
                        Console.WriteLine("Employee is Absent");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Employee is Present");
                        break;
                    }
            }
        }

        public void DailyWage()
        {
            Random value = new Random();
            int randomCheck = value.Next(2);
            Console.WriteLine("Second Use case : Calculate the daily wage of employee");
            switch (randomCheck)
            {
                case 0:
                    {
                        Console.WriteLine("Employee is Absent");
                        empHours = 0;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee dailywage is:" + dailyWage);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Employee is Present");
                        empHours = 8;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee dailywage is:" + dailyWage);
                        break;
                    }
            }
        }
    }
}
