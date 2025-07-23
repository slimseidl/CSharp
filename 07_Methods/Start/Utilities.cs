using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static int calculateWage(int monthlyWage, int numberOfMonthsWorked)
        {
            // $ like an f string in python
            //Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;
            if (numberOfMonthsWorked == 12) // bonus! 
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }
            return monthlyWage * numberOfMonthsWorked;
        }

        // Method Overloading Below, same name, different functions
        public static int calculateWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            // $ like an f string in python
            //Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;
            
            return (monthlyWage * numberOfMonthsWorked) + bonus;
        }
    }
}
