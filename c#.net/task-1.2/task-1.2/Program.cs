using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1._2
{
    //2.Write a C# Sharp program to read temperature in centigrade and display a suitable message
    //according to the temperature state below:
    //Temp < 0 then Freezing weather
    //Temp 0-10 then Very Cold weather
    //Temp 10-20 then Cold weather
    //Temp 20-30 then Normal in Temp
    //Temp 30-40 then Its Hot
    //Temp >=40 then Its Very Hot
    class Program
    {
        static void Main()
        {
            Console.WriteLine("210801258,radhanpara aayush");
            Console.WriteLine("Enter the temperature in Celsius:");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature >= 0 && temperature <= 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature > 10 && temperature <= 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature > 20 && temperature <= 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temperature > 30 && temperature <= 40)
            {
                Console.WriteLine("It's Hot");
            }
            else
            {
                Console.WriteLine("It's Very Hot");
            }
        }
    }

}
