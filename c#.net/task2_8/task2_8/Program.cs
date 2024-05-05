//Note : when you are creating matrix it should be of 3 x 3
//8. Write a program to create the menu driven application using c#. Menus are as given below
//1. Square of created matrix.
//2. Create another matrix and perform addition with the above matrix.
//3. Write a program to perform multiplication of the new matrix with the above matrix.
//4. Print transpose of matrix.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_8
{
class MatrixOperations
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        int choice;

        do
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Square of the created matrix");
            Console.WriteLine("2. Create another matrix and perform addition");
            Console.WriteLine("3. Multiply the new matrix with the original matrix");
            Console.WriteLine("4. Print transpose of matrix");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice (1-5): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateMatrix(matrix);
                    SquareMatrix(matrix);
                    break;
                case 2:
                    CreateMatrix(matrix);
                    int[,] matrix2 = new int[3, 3];
                    Console.WriteLine("Enter values for another matrix:");
                    CreateMatrix(matrix2);
                    AddMatrices(matrix, matrix2);
                    break;
                case 3:
                    CreateMatrix(matrix);
                    int[,] matrix3 = new int[3, 3];
                    Console.WriteLine("Enter values for another matrix:");
                    CreateMatrix(matrix3);
                    MultiplyMatrices(matrix, matrix3);
                    break;
                case 4:
                    CreateMatrix(matrix);
                    TransposeMatrix(matrix);
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
                Console.Write("Enter value at position [{i}, {j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void SquareMatrix(int[,] matrix)
    {
        Console.WriteLine("Square of the matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] * matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        Console.WriteLine("Addition of matrices:");

        int[,] resultMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        Console.WriteLine("Multiplication of matrices:");

        int[,] resultMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void TransposeMatrix(int[,] matrix)
    {
        Console.WriteLine("Transpose of the matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[j, i] + "\t");
            }
            Console.WriteLine();
        }
    }
}

}
