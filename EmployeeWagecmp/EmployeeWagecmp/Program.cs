// See https://aka.ms/new-console-template for more information

using System;

namespace Employee
{
    internal class Employee
    {
        
        public static void Main(String[] args)
        {
            EmployeeWagecmp.empwage getMethod = new EmployeeWagecmp.empwage();
            getMethod.Attendance();
            getMethod.DailyWage();
            getMethod.AddPartTimeWage();
            getMethod.switchcase();
            getMethod.CalWagePerMnth();
            getMethod.sixthusecase();
            Console.WriteLine("Employee Wage for Company A:");
            getMethod.wageforth(20, 20, 100);
            Console.WriteLine();
            Console.WriteLine("Employee Wage for Company B:");
            getMethod.wageforth(40, 25, 80);
            Console.WriteLine();
            Console.WriteLine("Employee Wage for Company C:");
            getMethod.wageforth(60, 15, 90);
        }
    }
}
