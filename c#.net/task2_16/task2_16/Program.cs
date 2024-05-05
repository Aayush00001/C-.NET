//16. Write a program to create an enumeration of “Months” and print the same using for-each
//loop.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_16
{
    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class MonthEnumeration
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);


            Console.WriteLine("Months Enumeration:");

            foreach (string month in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine(month);
            }

            Console.ReadLine();
        }
    }

}
