// See https://aka.ms/new-console-template for more information

using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            EmployeeWagecmp.empwage companyA = new EmployeeWagecmp.empwage("CompanyA", 20, 20, 100);
            EmployeeWagecmp.empwage companyB = new EmployeeWagecmp.empwage("CompanyB", 40, 22, 95);
        
            companyA.WageForMonth();
            Console.WriteLine(companyA.toString());
            Console.WriteLine();
            companyB.WageForMonth();
            Console.WriteLine(companyB.toString());

        }
    }
}
