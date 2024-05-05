//15.Write a program in C# Sharp to implement a structure named Square.
//Test Data :Input the dimensions of the Square(equal length and breadth ) :
//length: 20
//breadth: 40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_15
{

    struct Square
    {

        public double Length;
        public double Breadth;
    }

    class SquareImplementation
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            Square square;

            Console.WriteLine("Input the dimensions of the Square (equal length and breadth):");
            Console.Write("Length: ");
            square.Length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Breadth: ");
            square.Breadth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSquare Information:");
            Console.WriteLine("Length: " + square.Length);
            Console.WriteLine("Breadth: " + square.Breadth);
            Console.WriteLine("Area: " + CalculateArea(square));
            Console.WriteLine("Perimeter: " + CalculatePerimeter(square));

            Console.ReadLine();
        }

        static double CalculateArea(Square square)
        {
            return square.Length * square.Breadth;
        }

        static double CalculatePerimeter(Square square)
        {
            return 2 * (square.Length + square.Breadth);
        }
    }

}
