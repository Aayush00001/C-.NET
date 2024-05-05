//1 Write a C# Sharp program to find out whether a given year is a leap year or not.Test Data: 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
        }
    static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}
