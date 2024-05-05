//12. Write a program to create the menu driven application using different types of looping
//statements. Menus are as given below.
//1. Get the even natural number from the user print the sum of even natural numbers.
//2.Get the number from user and print the table of given number, Example: 5 X 1 = 5
//3.Write a program to find the given number is perfect or not
//4. Write a program to find if the given number is strong or not.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_12
{
    using System;

class LoopingMenu
{
    static void Main()
    {
        Console.WriteLine("Name: radhanpara aayush.");
        Console.WriteLine("Enrollment No: 210801258.");
        Console.WriteLine(DateTime.Now);


        int choice;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Sum of even natural numbers");
            Console.WriteLine("2. Print the table of a given number");
            Console.WriteLine("3. Check if a number is perfect");
            Console.WriteLine("4. Check if a number is strong");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice (1-5): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SumOfEvenNaturalNumbers();
                    break;
                case 2:
                    PrintTableOfNumber();
                    break;
                case 3:
                    CheckPerfectNumber();
                    break;
                case 4:
                    CheckStrongNumber();
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid choice (1-5).");
                    break;
            }
        } while (choice != 5);

        Console.ReadLine();
    }

    static void SumOfEvenNaturalNumbers()
    {
        Console.WriteLine("Enter the even natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 2; i <= number; i += 2)
        {
            sum += i;
        }

        Console.WriteLine("$Sum of even natural numbers up to {number}: {sum}");
    }

    static void PrintTableOfNumber()
    {
        Console.WriteLine("Enter the number to print its table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("$Table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("${number} x {i} = {number * i}");
        }
    }

    static void CheckPerfectNumber()
    {
        Console.WriteLine("Enter the number to check if it is perfect: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        if (sum == number)
        {
            Console.WriteLine("${number} is a perfect number.");
        }
        else
        {
            Console.WriteLine("${number} is not a perfect number.");
        }
    }

    static void CheckStrongNumber()
    {
        Console.WriteLine("Enter the number to check if it is strong: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }

        if (sum == number)
        {
            Console.WriteLine("${number} is a strong number.");
        }
        else
        {
            Console.WriteLine("${number} is not a strong number.");
        }
    }

    static int Factorial(int number)
    {
        int fact = 1;

        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }

        return fact;
    }
}

}
