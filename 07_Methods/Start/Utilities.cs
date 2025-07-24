using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static void SimpleStrings()
        {
            string firstname = "John";
            string lastname = "Seidl";

            string userName = string.Concat(firstname.Substring(0, 1), lastname);

            Console.WriteLine(userName);
        }
        public static void UsingSimpleString()
        {
            var username = "JohnS";
            username = username.ToLower();
        }
        public static void UsingOptParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWage = CalculateWageWithOptional(monthlyWage1, months1);
            Console.WriteLine($"Yearly wage for employee 1: {yearlyWage}");
        }
        public static int CalculateWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {

            // $ like an f string in python
            //Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;

            return (monthlyWage * numberOfMonthsWorked) + bonus;
        }

        public static int CalculateWage(int monthlyWage, int numberOfMonthsWorked)
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
        public static int CalculateWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
           
            // $ like an f string in python
            //Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;
            
            return (monthlyWage * numberOfMonthsWorked) + bonus;
        }
    }
}
