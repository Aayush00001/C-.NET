using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_2
{
   
        class Program
        {
            static void SwapRef(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            static void SwapOut(out int a, out int b)
            {
                a = 10;
                b = 20;
                int temp = a;
                a = b;
                b = temp;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                int num1 = 5, num2 = 7;
                Console.WriteLine("Before swapping: num1 = " + num1 + ", num2 = " + num2);

                // Using ref parameters to swap values
                SwapRef(ref num1, ref num2);
                Console.WriteLine("After swapping (using ref): num1 = " + num1 + ", num2 = " + num2);

                int num3, num4;
                // Using out parameters to swap values
                SwapOut(out num3, out num4);
                Console.WriteLine("After swapping (using out): num3 = " + num3 + ", num4 = " + num4);
            }
        }
    }

