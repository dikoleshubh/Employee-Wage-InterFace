using System;
using System.Collections.Generic;﻿


namespace Empwage_Interface
    
    
{
    class EmployeeAttendence
    {/// <summary>
    /// 
    /// </summary>
        public static void employee()
        { 
            const int present = 1; 
            Random rnd = new Random();
            int num = rnd.Next(0,2);////Attendece function using Random Variable for Employee
            if (num == present)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Dailywage(num);
            
        }/// <summary>
        
        
        /// <param name="num"></param>
        private static void Dailywage(int num) /// /Part time & Daily Employee wage Calculation
        {
            int empwage;/// Local Varibles
            int partempwage; /// Local Variables
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
