using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1._3
{
        //Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven
        //approach.
        //Menu: 1. Are of circle
        //2. Area of triangle
        //3. Area of Rectangle
   
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Name: radhanpara aayush.");
                Console.WriteLine("Enrollment No: 210801258.");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("0. Exit!");
                Console.WriteLine("1. Area of Circle");
                Console.WriteLine("2. Area of Triangle");
                Console.WriteLine("3. Area of Rectangle");
                Console.WriteLine("Enter your Coice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            Console.WriteLine("Enter Radius:");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            double circle = 3.14 * radius * radius;
                            Console.WriteLine("Area of Circle is:" + circle);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Base:");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Height:");
                            double h = Convert.ToDouble(Console.ReadLine());
                            double triangle = 0.5 * b * h;
                            Console.WriteLine("Area of Triangle:" + triangle);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Length:");
                            double length = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Width:");
                            double width = Convert.ToDouble(Console.ReadLine());
                            double rectangle = length * width;
                            Console.WriteLine("Area of Rectangle is:" + rectangle);
                            break;
                        }
                    default:
                        Console.Write("Invalid Coice");
                        break;
                }
            }
        }
    }    
