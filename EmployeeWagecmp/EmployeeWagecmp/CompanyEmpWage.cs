using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagecmp
{
    internal class CompanyEmpWage
    {

        public interface ICompanyEmployeeWage
        {
            public void AddCompanyEmpWageDetails(string company, int noOfWorkingDays, int maxWorkingHours, int empRatePerHour);
            public void CalculateWageOfCompany();
            
        }
        public class CompanyEmployeeWage
        {
            public string company;
            public int maxWorkingHours, noOfWorkingDays, empRatePerHour, totalEmpWage, empWorkDaysPerMonth;

            public CompanyEmployeeWage(string company, int noOfWorkingDays, int maxWorkHours, int empRatePerHour)
            {
                this.company = company;
                this.noOfWorkingDays = noOfWorkingDays;
                this.maxWorkingHours = maxWorkHours;
                this.empRatePerHour = empRatePerHour;

            }

            public void setEmployeeWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
        }







    }
}
