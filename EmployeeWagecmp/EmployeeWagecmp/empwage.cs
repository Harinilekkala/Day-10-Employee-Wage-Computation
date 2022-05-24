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
            Console.WriteLine("First Use Case Check Statusof Employee");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Generated random value is:" + randomCheck);

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
            Console.WriteLine("-------------------------------------------------------");
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
        public void AddPartTimeWage()
        {
            Random value = new Random();
            int randomCheck = value.Next(3);
            Console.WriteLine("Third Use Case Adding Part Time");
            Console.WriteLine("-------------------------------------------------------");
            switch (randomCheck)
            {
                case 1:
                    {
                        Console.WriteLine("Employee is working Part Time");
                        empHours = 4;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee wage is:" + dailyWage);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Employee is working Full Time");
                        empHours = 8;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee wage is:" + dailyWage);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Employee is Absent");
                        empHours = 0;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee wage is:" + dailyWage);
                        break;
                    }
            }
        }


    }
}
