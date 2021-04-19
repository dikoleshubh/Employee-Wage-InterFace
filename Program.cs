using System;

namespace Empwage_Interface
{
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
