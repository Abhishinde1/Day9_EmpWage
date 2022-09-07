using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public  class UC8
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static void ComputeEmpWage  (string Company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHoursPerMonth) 
        {
            int dailywage;
            int dailywageFullTime = 0;
            int dailywagePartTime = 0;
            int fullTimePresentdays = 0;
            int partTimePresentDays = 0;
            int absentDays = 0; 
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MaxHoursPerMonth && totalWorkingDays < NumOfWorkingDays)
            {
                totalWorkingDays++;
                Console.WriteLine("DAY" +totalWorkingDays);
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        partTimePresentDays += 1;
                       dailywagePartTime = EmpRatePerHour * empHrs;
                        Console.WriteLine("Part Time EmpHrs " + empHrs);
                        Console.WriteLine("dailywage is " + dailywagePartTime);
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        fullTimePresentdays += 1;
                        dailywageFullTime = EmpRatePerHour * empHrs;
                        Console.WriteLine("Full Time EmpHrs " + empHrs);
                        Console.WriteLine("dailywage is " + dailywageFullTime);
                        break;

                    default:
                        empHrs = 0;
                        absentDays += 1;
                        Console.WriteLine(" EmpHrs " + empHrs);
                        break;
                }
                totalEmpHrs += empHrs;
               
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            Console.WriteLine("Full Present Days " + fullTimePresentdays + "Part Time Days " + partTimePresentDays + "absent days " + absentDays);
        }

    }
}
