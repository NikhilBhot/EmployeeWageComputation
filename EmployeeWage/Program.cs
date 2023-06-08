using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace EmployeeWage
{
    public class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            //Start with Displaying Welcome to Employee Wage Computation Program on Master Branch
            Console.WriteLine("Wel-come To Employee Wage Computation Problem");

            //UC-01-Check Employee is Present or Absent - Use((RANDOM)) for Attendance Check

            //UC-02-Calculate Daily Employee Wage -Assume Wage per Hour is 20 - Assume Full Day Hour is 8

            //UC-03 -Add Part time Employee & Wage - Assume Part time Hour is 4
            
            //variable
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);

           //UC-04- Calculating Employee Wage Using Switch
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee Is Full Time");
                       empHrs = 8;
                    break;
            case IS_PART_TIME:
                    Console.WriteLine("Employee is Part Time");
                       empHrs = 4;
                    break;
            default:
                    Console.WriteLine("Employee Absent");
                    empWage = 0;
                    break;
            
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage:" + empWage);
        }
    }
}