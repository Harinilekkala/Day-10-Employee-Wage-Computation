// See https://aka.ms/new-console-template for more information

using System;

namespace Employee
{
    internal class Employee
    {
        
        public static void Main(String[] args)
        {
            EmployeeWagecmp.empwage getMethod = new EmployeeWagecmp.empwage();
            getMethod.WageForMonth();
        }
    }
}
