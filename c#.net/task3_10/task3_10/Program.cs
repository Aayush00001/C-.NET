using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_10
{
   
        // Define the interface
        interface Test
        {
            int Square(int num);
        }

        // Implement the interface in Arithmetic class
        class Arithmetic : Test
        {
            public int Square(int num)
            {
                return num * num;
            }
        }

        // Use the object of Arithmetic class in ToTestInt class
        class ToTestInt
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                Arithmetic arithmetic = new Arithmetic();

                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int result = arithmetic.Square(number);
                Console.WriteLine("Square of " + number + " is: " + result);
            }
        }
    }


