﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem_1
{
    internal class EmployeeWadgeUC2
    {
        public static void EmployeeUC2(int empCheck)
        {
            int IS_FULL_TIME = 1, EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;

            if (empCheck == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWadge = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
