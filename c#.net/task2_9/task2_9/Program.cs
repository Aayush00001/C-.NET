//Write a program to create the menu driven application using c#.Menus are as given below :
//1. Print diagonals of matrix
//2. Print upper triangular matrix
//3. Print lower triangular matrix
//4. Print determinant of matrix
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
        int choice;

        do
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Print diagonals of matrix");
            Console.WriteLine("2. Print upper triangular matrix");
            Console.WriteLine("3. Print lower triangular matrix");
            Console.WriteLine("4. Print determinant of matrix");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice (1-5): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateMatrix(matrix);
                    PrintDiagonals(matrix);
                    break;
                case 2:
                    CreateMatrix(matrix);
                    PrintUpperTriangular(matrix);
                    break;
                case 3:
                    CreateMatrix(matrix);
                    PrintLowerTriangular(matrix);
                    break;
                case 4:
                    CreateMatrix(matrix);
                    CalculateDeterminant(matrix);
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

    static void CreateMatrix(int[,] matrix)
    {
        Console.WriteLine("Enter values for a 3x3 matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("$Enter value at position [{i}, {j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void PrintDiagonals(int[,] matrix)
    {
        Console.WriteLine("Diagonals of the matrix:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(matrix[i, i]);
        }

        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(matrix[i, 2 - i]);
        }
    }

    static void PrintUpperTriangular(int[,] matrix)
    {
        Console.WriteLine("Upper triangular matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (j >= i)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                else
                {
                    Console.Write("0\t");
                }
            }
            Console.WriteLine();
        }
    }

    static void PrintLowerTriangular(int[,] matrix)
    {
        Console.WriteLine("Lower triangular matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (j <= i)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                else
                {
                    Console.Write("0\t");
                }
            }
            Console.WriteLine();
        }
    }

    static void CalculateDeterminant(int[,] matrix)
    {
        int determinant = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))
            - matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))
            + matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));

        Console.WriteLine("Determinant of the matrix: " + determinant);
        }
    }
}
