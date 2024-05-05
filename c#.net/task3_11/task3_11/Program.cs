using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_11
{
    
        // Step 1: Create a class named Delegate_Demo
        class Delegate_Demo
        {
            // Step 2: Declare static variable 'num'
            public static int num = 10;
        }

        // Step 3: Declare a delegate named 'NumberChanger'
        delegate int NumberChanger(int n);

        class Program
        {
            // Step 4: Define methods to add and multiply numbers
            static int AddNum(int num)
            {
                Delegate_Demo.num += num;
                return Delegate_Demo.num;
            }

            static int MultNum(int num)
            {
                Delegate_Demo.num *= num;
                return Delegate_Demo.num;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                // Step 5: Create delegate objects
                NumberChanger nc1 = new NumberChanger(AddNum);
                NumberChanger nc2 = new NumberChanger(MultNum);

                // Step 6: Use delegate objects to perform operations
                nc1(5); // Add 5
                Console.WriteLine("Value after addition: " + Delegate_Demo.num);

                nc2(2); // Multiply by 2
                Console.WriteLine("Value after multiplication: " + Delegate_Demo.num);
            }
        }
    }

