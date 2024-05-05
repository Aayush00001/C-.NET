using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_1
{
    
        class Program
        {

            static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            static void Swap(ref float a, ref float b)
            {
                float temp = a;
                a = b;
                b = temp;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Before swapping:");
                int int1 = 5, int2 = 10;
                float float1 = 3.14f, float2 = 2.71f;

                Console.WriteLine("Before swapping:");
                Console.WriteLine("Integers: {0}, {1}", int1, int2);
                Console.WriteLine("Floats: {0}, {1}", float1, float2);

                Swap(ref int1, ref int2);
                Swap(ref float1, ref float2);

                Console.WriteLine("After swapping:");
                Console.WriteLine("Integers: {0}, {1}", int1, int2);
                Console.WriteLine("Floats: {0}, {1}", float1, float2);
            }
        }
    }


