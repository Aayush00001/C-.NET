//5.Write a program in C# Sharp to compare two strings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine();

            // Case-sensitive string comparison
            bool areEqual = String.Equals(str1, str2);

            // Case-insensitive string comparison
            // bool areEqual = String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);

            if (areEqual)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }

            Console.ReadLine();
        }
    }
}
