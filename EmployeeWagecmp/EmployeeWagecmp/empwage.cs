using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagecmp
{
    internal class empwage
    {
    public void Attendance()
        {
            Random value = new Random();
            int randomCheck = value.Next(2);

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
    }
}
