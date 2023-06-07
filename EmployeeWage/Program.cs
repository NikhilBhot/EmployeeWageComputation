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

            //UC-02-Calculate Daily Employee Wage -Assume Wage per Hour is 20 - Assume Full Day Hour is 8
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage:" + empWage);
        }
    }
}