//18. Write a C# program to implement a method that takes an integer as input and throws an
//exception if the number is negative.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_18
{

    class NumberChecker
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                CheckNumber(number);
                Console.WriteLine("Number is positive.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }

        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number is negative.");
            }
        }
    }

}
