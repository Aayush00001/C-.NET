//4.Write a C# Sharp program that takes three letters and displays them in reverse order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter three letters: ");
            string input = Console.ReadLine();

            if (input.Length != 3)
            {
                Console.WriteLine("Invalid input. Please enter exactly three letters.");
            }
            else
            {
                char[] letters = input.ToCharArray();
                Array.Reverse(letters);

                Console.WriteLine("Letters in reverse order: ");
                foreach (char letter in letters)
                {
                    Console.Write(letter);
                }
            }

            Console.ReadLine();
        }
    }
}
