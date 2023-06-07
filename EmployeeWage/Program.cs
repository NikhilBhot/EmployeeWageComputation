using System;
using System.Diagnostics.Metrics;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Start with Displaying Welcome to Employee Wage Computation Program on Master Branch
            Console.WriteLine("Wel-come To Employee Wage Computation Problem");

            //UC-01-Check Employee is Present or Absent - Use((RANDOM)) for Attendance Check
            
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}