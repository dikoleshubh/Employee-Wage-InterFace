using System;
using System.Collections.Generic;

namespace EmpWage
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int getTotalWage(string company);

    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHours;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHours = empRatePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
    public class EmployeeBuilder : IComputeEmpWage  //
    {
        public const int FullTime = 1;                                        //creating a local variable
        public const int PartTime = 2;

        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

       // private int numOfCompany = 0;
        //private CompanyEmpWage[] CompanyEmpWageArray;

        public EmployeeBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHrsPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHours, numOfWorkingDays, maxHrsPerMonth);
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }


        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());

            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);                      // assigning Random value to the variable 

                //USING SWITCH STATEMENT
                switch (empCheck)
                {
                    case FullTime:
                        empHrs = 8;
                        break;

                    case PartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs; //calculting emp hours
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hours: " + empHrs);

            } //END of WHILE LOOP

            return totalEmpHrs * companyEmpWage.empRatePerHours;
        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            EmployeeBuilder employeeBuilder = new EmployeeBuilder();   //Create object of class
            employeeBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);  //call method
            employeeBuilder.addCompanyEmpWage("Reliance", 10, 4, 20); //call method
            employeeBuilder.ComputeEmpWage();  //call method
            Console.WriteLine("Totsl Wage For Dmart Comapny :- " + employeeBuilder.getTotalWage("Dmart"));
        }
    }
}

