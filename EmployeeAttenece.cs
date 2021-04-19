using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
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
}
