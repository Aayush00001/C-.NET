using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1._4
{
    //Write c# sharp program to create menu driven application as below
    //Menu: 1. Palindrome number.
    //2. Armstrong number.
    //3. Write a program that converts Centigrade to Fahrenheit.
    //4. Write a program that converts kilometers per hour to miles per hour.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Palindrome Number.");
            Console.WriteLine("2. Armstong Number.");
            Console.WriteLine("3. Convert Centigrade to Fahrenheit.");
            Console.WriteLine("4. Convert Km/hr to M/hr.");
            Console.WriteLine("Enter your Choice:");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 0:
                    break;
                case 1:
                    {
                        int n, r, sum = 0, temp;
                        Console.WriteLine("Enter The Number:");
                        n = int.Parse(Console.ReadLine());
                        temp = n;
                        while (n > 0)
                        {
                            r = n % 10;
                            sum = (sum * 10) + r;
                            n = n / 10;
                        }
                        if (temp == sum)
                            Console.WriteLine("The Number is Palindrome.");
                        else
                            Console.WriteLine("The Number is not Palindrome.");
                        break;
                    }
                case 2:
                    {
                        int n, r, sum = 0, temp;
                        Console.Write("Enter the Number= ");
                        n = Convert.ToInt32(Console.ReadLine());
                        temp = n;
                        while (n > 0)
                        {
                            r = n % 10;
                            sum = sum + (r * r * r);
                            n = n / 10;
                        }
                        if (temp == sum)
                            Console.Write("The Number is Armstrong Number.");
                        else
                            Console.Write("The Number is Not Armstrong Number.");
                        break;
                    }
                case 3:
                    {
                        double fahrenheit;
                        Console.WriteLine("Enter Centigrade or Celsius");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Celsius: " + celsius);
                        fahrenheit = (celsius * 9) / 5 + 32;
                        Console.WriteLine("Fahrenheit: " + fahrenheit);
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter kilometers:");
                        double kilometers = Convert.ToDouble(Console.ReadLine());
                        double miles = kilometers / 1.6;
                        Console.WriteLine(miles + " Miles");
                        break;
                    }
            }
        }
    }
}
