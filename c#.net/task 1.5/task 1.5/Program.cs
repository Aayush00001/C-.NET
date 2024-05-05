using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1._5
{
        //Write c# sharp program to create menu driven application as below
        //Menu:
        //1. Write a program that takes hours and minutes as input, and calculates the total number of minutes.
        //2.Write a program in that takes minutes as input, and display the total number of hours and minutes. 
        //3.Write a program that accepts three integers from the user and finds the second largest number among
        //them.
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name: radhanpara aayush.");
                Console.WriteLine("Enrollment No: 210801258.");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("0. Exit!");
                Console.WriteLine("1. Input Hours and get Minutes.");
                Console.WriteLine("2. Input Minutes andget Hours and Minutes.");
                Console.WriteLine("3. For Second Largest Number from the Input.");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            Console.WriteLine("Enter hours:");
                            int hours = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter minutes:");
                            int minutes = Convert.ToInt32(Console.ReadLine());
                            int totalMinutes = (hours * 60) + minutes;
                            Console.WriteLine("Total number of minutes: " + totalMinutes);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter minutes:");
                            int minutes = Convert.ToInt32(Console.ReadLine());
                            int hours = minutes / 60;
                            int remainingMinutes = minutes % 60;
                            Console.WriteLine("Total hours: " + hours);
                            Console.WriteLine("Total minutes: " + remainingMinutes);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter three integers:");
                            int num1 = int.Parse(Console.ReadLine());
                            int num2 = int.Parse(Console.ReadLine());
                            int num3 = int.Parse(Console.ReadLine());
                            int secondLargest;
                            if (num1 >= num2 && num1 >= num3)
                            {
                                if (num2 >= num3)
                                {
                                    secondLargest = num2;
                                }
                                else
                                {
                                    secondLargest = num3;
                                }
                            }
                            else if (num2 >= num1 && num2 >= num3)
                            {
                                if (num1 >= num3)
                                {
                                    secondLargest = num1;
                                }
                                else
                                {
                                    secondLargest = num3;
                                }
                            }
                            else
                            {
                                if (num1 >= num2)
                                {
                                    secondLargest = num1;
                                }
                                else
                                {
                                    secondLargest = num2;
                                }
                            }
                            Console.WriteLine("The second largest number is: " +
                           secondLargest);
                            break;
                        }
                }
            }
        }
    }

