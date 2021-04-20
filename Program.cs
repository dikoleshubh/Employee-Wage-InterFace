using System;

namespace Empwage_Interface
      

    class EmployeeAttendence
    {
        public static void employee() ////Employee Attendece Cases
        {
            const int present = 1;
            Random rnd = new Random();
            int num = rnd.Next(0,2);
            if (num == present)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Dailywage(num);
            
            
            
        }
         /// Emplloyee Wage System
        /// <param name="num"></param>
        private static void Dailywage(int num)  
        {
            int empwage;
            int partempwage;
            int hr = 8;
            if(num == 1)
            {
                empwage = hr * 20;
                Console.WriteLine("Daily Employee Wage-{0}", +empwage);
                
            }
            else
            {
                Console.WriteLine("No wage");
            }
            if (num == 1)
            {
                partempwage = hr * 20;
                Console.WriteLine("Part Employee Wage-{0}", +partempwage);

            }
            else
            {
                Console.WriteLine("No wage");
            }
           

        }

    
}
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
