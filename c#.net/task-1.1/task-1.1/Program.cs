using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1._1
{
    //1. Write a C# Sharp program to determine the eligibility for admission to a professional course
    //based on the following criteria:
    //Marks in Maths >=65
    //Marks in Phy >=55
    //Marks in Chem>=50
    //Total in all three subject >=180
    //or
    //Total in Math and Subjects >=140
    class Program
    {
        static void Main()
        {
            Console.WriteLine("210801258,radhanpara aayush");
            Console.WriteLine("Enter marks obtained in Mathematics:");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Physics:");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks obtained in Chemistry:");
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());

            int totalMarks = mathMarks + physicsMarks + chemistryMarks;

            if ((mathMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && totalMarks >= 180)||(mathMarks + physicsMarks >= 140))
            {
                Console.WriteLine("Congratulations! You are eligible for admission.");
            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for admission.");
            }
        }
    }

}
