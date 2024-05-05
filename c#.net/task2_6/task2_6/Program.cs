//6.Write a program in C# Sharp to check the username and password.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            string expectedUsername = "user";
            string expectedPassword = "pass";

            Console.WriteLine("Input a username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Input a password: ");
            string password = Console.ReadLine();

            if (username == expectedUsername && password == expectedPassword)
            {
                Console.WriteLine("Password entered successfully!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }

            Console.ReadLine();
        }
    }
}
