//2. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
//Test Data :50 50 60
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Enter the lengths of the sides of the triangle:");

            Console.Write("Side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
