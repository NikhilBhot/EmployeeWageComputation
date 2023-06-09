using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Security.Claims;

namespace EmployeeWage
{
    public class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        
        //UC-07-Compute Employee Wage Using Class Methods
        public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkinfDays,int maxHourPerMonth)
        {
            //Start with Displaying Welcome to Employee Wage Computation Program on Master Branch
            Console.WriteLine("Wel-come To Employee Wage Computation Problem");

            //UC-01-Check Employee is Present or Absent - Use((RANDOM)) for Attendance Check

            //UC-02-Calculate Daily Employee Wage -Assume Wage per Hour is 20 - Assume Full Day Hour is 8

            //UC-03 -Add Part time Employee & Wage - Assume Part time Hour is 4
            
            //variable
            int empHrs = 0;
            int totalEmpHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWokingsDays = 0;
            Random random = new Random();
            //UC-05-Calculating Wages for a Month
            while(totalEmpHrs<=maxHourPerMonth && totalWokingsDays < numOfWorkinfDays)
            {
                totalWokingsDays++;
                int empCheck = random.Next(0, 3);

                //UC-04- Calculating Employee Wage Using Switch
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        //Console.WriteLine("Employee Is Full Time");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        //Console.WriteLine("Employee is Part Time");
                        empHrs = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee Absent");
                        empWage = 0;
                        break;

                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:"+totalWokingsDays+"Emp Hrs :"+empHrs);

                
            }
            int totalEmpWages = totalEmpHrs *empRatePerHour;
            Console.WriteLine("Total Employee Wage for comapny:="+ company + "is"+ totalEmpWages);
            return totalEmpWage;
        }

        public static void Main(string[] args)
        {
            //UC-08Compute Employee Wage for Multiple Company in Procedural Way Using Class Methods
            
            computeEmpWage("Dmart",20,20,100);
            computeEmpWage("Reliance", 10, 14, 90);
        }
    }
}