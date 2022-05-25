// See https://aka.ms/new-console-template for more information

using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            {
                EmployeeWagecmp.EmpWageBuilder run = new EmployeeWagecmp.EmpWageBuilder();
                run.addtoArray("XYZ Company", 20, 100, 20);
                run.addtoArray("ABC Company", 30, 80, 15);
                run.computeEmpWage();
            }

        }
    }
}
