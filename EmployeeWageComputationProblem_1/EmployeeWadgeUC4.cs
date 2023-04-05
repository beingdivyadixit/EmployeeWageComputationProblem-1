using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem_1
{
    internal class EmployeeWadgeUC4
    {
        public static void EmployeeUC4(int empCheck4)
        {
            int  EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;

            switch (empCheck4)
            {
                case 1:
                    empHr = 8;
                    Console.WriteLine("Employe is present & doing full-time");
                    break;
                case 2:
                    empHr = 4;
                    Console.WriteLine("Employe is present & doing part-time");
                    break;
                default:
                    empHr = 0;
                    Console.WriteLine("Employe is not present");
                    break;
            }
            empWadge = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
