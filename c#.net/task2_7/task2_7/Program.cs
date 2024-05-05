//7.Write a C# Sharp program that takes user id and password as input (string type). After 3
//unsuccessful attempts, the user will be rejected.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_7
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

        
        int maxAttempts = 3;
        int attempts = 0;
        string expectedUserId = "admin";
        string expectedPassword = "password";

        while (attempts < maxAttempts)
        {
            Console.WriteLine("Enter the user ID: ");
            string userId = Console.ReadLine();

            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();

            if (userId == expectedUserId && password == expectedPassword)
            {
                Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                attempts++;
                int remainingAttempts = maxAttempts - attempts;
                Console.WriteLine("Login failed! You have {remainingAttempts} attempt(s) remaining.");

                if (remainingAttempts == 0)
                {
                    Console.WriteLine("Login rejected. Maximum attempts reached.");
                }
            }
        }

        Console.ReadLine();
        }
    }
}
