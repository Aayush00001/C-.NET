//19.Write a C# program that implements a method that divides two numbers. Handle the
//DivideByZeroException that occurs if the denominator is 0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_19
{
    using System;

class DivisionCalculator
{
    static void Main()
    {
        Console.WriteLine("Name: radhanpara aayush.");
        Console.WriteLine("Enrollment No: 210801258.");
        Console.WriteLine(DateTime.Now);


        Console.WriteLine("Enter the numerator: ");
        int numerator = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the denominator: ");
        int denominator = Convert.ToInt32(Console.ReadLine());

        try
        {
            int result = DivideNumbers(numerator, denominator);
            Console.WriteLine("$Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        Console.ReadLine();
    }

    static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }

        return numerator / denominator;
    }
}

}
