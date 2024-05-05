//20.Write a program to create a menu driven application.
//Menus are as given below.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_20
{

    class MenuDrivenApplication
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
                Console.WriteLine("1. Print Pattern 1");
                Console.WriteLine("2. Print Pattern 2");
                Console.WriteLine("3. Print Pattern 3");
                Console.WriteLine("4. Print Pattern 4");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintPattern1();
                        break;
                    case 2:
                        PrintPattern2();
                        break;
                    case 3:
                        PrintPattern3();
                        break;
                    case 4:
                        PrintPattern4();
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

        static void PrintPattern1()
        {
            Console.WriteLine("Pattern 1:");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void PrintPattern2()
        {
            Console.WriteLine("Pattern 2:");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintPattern3()
        {
            Console.WriteLine("Pattern 3:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == 5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void PrintPattern4()
        {
            Console.WriteLine("Pattern 4:");

            for (int i = 1; i <= 9; i++)
            {
                int num = i <= 5 ? i : 10 - i;

                for (int j = 1; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }



}
