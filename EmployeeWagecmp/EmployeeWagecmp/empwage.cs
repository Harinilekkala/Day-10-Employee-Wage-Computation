using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagecmp
{
    internal class empwage
    {
        
            int empHours, dailyWage, empWagePerHour = 20, empWorkDaysPerMonth = 20, salaryForDay;
            int totalWorkingDays = 0, totalSalary = 0, totalWorkingHours = 0, empWorkDaysMonth = 20;


            public void Attendance()
            {
                Console.WriteLine("-------------------------------------------------------");
                Random value = new Random();
                int randomCheck = value.Next(2);
                Console.WriteLine("First Use Case Check Statusof Employee");

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
                Console.WriteLine("-------------------------------------------------------");
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
            public void AddPartTimeWage()
            {
                Console.WriteLine("-------------------------------------------------------");
                Random value = new Random();
                int randomCheck = value.Next(3);
                Console.WriteLine("Third Use Case Adding Part Time");

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

            public void switchcase()
            {

                Console.WriteLine("-------------------------------------------------------");

                Random value = new Random();

                Console.WriteLine("Forth Use Case Using Switch Case");
                for (int i = totalWorkingDays; i < empWorkDaysPerMonth; i++)
                {
                    if (i < empWorkDaysPerMonth && totalWorkingHours < 100)
                    {
                        int randomCheck = value.Next(3);
                        //Console.WriteLine("Generated random value is:" + randomCheck);

                        switch (randomCheck)
                        {
                            case 1:
                                {
                                    empHours = 4;
                                    break;
                                }
                            case 2:
                                {
                                    empHours = 8;
                                    break;
                                }
                            default:
                                {
                                    empHours = 0;
                                    break;
                                }
                        }
                        totalWorkingDays = i + 1;
                        salaryForDay = empHours * empWagePerHour;
                        totalSalary = totalSalary + salaryForDay;
                        totalWorkingHours = totalWorkingHours + empHours;
                    }
                }
                Console.WriteLine("Total Working Days of an Employee is:" + totalWorkingDays);

                Console.WriteLine("Total Working Hours of an Employee is:" + totalWorkingHours);
                Console.WriteLine("Monthly salary of an Employee is:" + totalSalary);

            }

            public void CalWagePerMnth()
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine(" Fifth Use Case ------------- Calculating Calculating Wages for a Month");
                Random value = new Random();

                for (int days = 1; days < empWorkDaysMonth; days++)
                {
                    int randomCheck = value.Next(3);
                    // Console.WriteLine("Generated random value is:" + randomCheck);

                    switch (randomCheck)
                    {
                        case 1:// For Part Time
                            {
                                empHours = 4;
                                break;
                            }
                        case 2: // For Full Time
                            {
                                empHours = 8;
                                break;
                            }
                        default: // For Absent
                            {
                                empHours = 0;
                                break;
                            }
                    }
                    salaryForDay = empHours * empWagePerHour;
                    totalSalary = totalSalary + salaryForDay;
                }
                Console.WriteLine("Monthly salary of an Employee is:" + totalSalary);
            }

            public void sixthusecase()
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine(" Sixth  Use Case  ------------- Calculate wages tii a condition reaches working hrs or month");
                Random value = new Random();
                for (int i = totalWorkingDays; i < empWorkDaysPerMonth; i++)
                {
                    if (i < empWorkDaysPerMonth && totalWorkingHours < 100)
                    {
                        int randomCheck = value.Next(3);
                        //Console.WriteLine("Generated random value is:" + randomCheck);

                        switch (randomCheck)
                        {
                            case 1:// For Part Time
                                {
                                    empHours = 4;
                                    break;
                                }
                            case 2: // For Full Time
                                {
                                    empHours = 8;
                                    break;
                                }
                            default: // For Absent
                                {
                                    empHours = 0;
                                    break;
                                }
                        }
                        totalWorkingDays = i + 1;
                        salaryForDay = empHours * empWagePerHour;
                        totalSalary = totalSalary + salaryForDay;
                        totalWorkingHours = totalWorkingHours + empHours;
                    }
                }
                Console.WriteLine("Total Working Days of an Employee is:" + totalWorkingDays);
                Console.WriteLine("Total Working Hours of an Employee is:" + totalWorkingHours);
                Console.WriteLine("Monthly salary of an Employee is:" + totalSalary);
            }
              public void wageforth(int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("use case 8 Adding Multiple companies and Wages");

            Random value = new Random();
            for (int i = totalWorkingDays; i < empWorkDaysPerMonth; i++)
            {
                if (i < empWorkDaysPerMonth && totalWorkingHours < 100)
                {
                    int randomCheck = value.Next(3);
                    //Console.WriteLine("Generated random value is:" + randomCheck);

                    switch (randomCheck)
                    {
                        case 1:// For Part Time
                            {
                                empHours = 4;
                                break;
                            }
                        case 2: // For Full Time
                            {
                                empHours = 8;
                                break;
                            }
                        default: // For Absent
                            {
                                empHours = 0;
                                break;
                            }
                    }
                    totalWorkingDays = i + 1;
                    salaryForDay = empHours * empWagePerHour;
                    totalSalary = totalSalary + salaryForDay;
                    totalWorkingHours = totalWorkingHours + empHours;
                }
            }
            Console.WriteLine("Total Working Days of an Employee is:" + totalWorkingDays);
            Console.WriteLine("Total Working Hours of an Employee is:" + totalWorkingHours);
            Console.WriteLine("Monthly salary of an Employee is:" + totalSalary);
        }
             

        }
    }

