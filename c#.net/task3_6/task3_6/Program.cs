using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_6
{

   
        class Person
        {
            protected int rollNo;
            protected string name;

            public void Get_Data()
            {
                Console.WriteLine("Enter Roll No.:");
                rollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                name = Console.ReadLine();
            }

            public virtual void Display_Data()
            {
                Console.WriteLine("Roll No.: " + rollNo);
                Console.WriteLine("Name: " + name);
            }
        }

        class Student : Person
        {
        }

        class Details : Student
        {
        }

        class Telephone
        {
            protected string phonetype;

            public virtual void Ring()
            {
                Console.WriteLine("Ringing the " + phonetype + " telephone.");
            }
        }

        class ElectronicPhone : Telephone
        {
            public ElectronicPhone()
            {
                phonetype = "Digital";
            }

            public override void Ring()
            {
                Console.WriteLine("Ringing the electronic " + phonetype + " telephone.");
            }

            public void Run()
            {
                Ring();
            }
        }

        class TestClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                Console.WriteLine("Testing the Inheritance and Polymorphism Example:");
                Console.WriteLine();

                // Testing the Phone Inheritance
                ElectronicPhone electronicPhone = new ElectronicPhone();
                electronicPhone.Run();
                Console.WriteLine();

                // Testing the Person, Student, and Details Inheritance
                Details details = new Details();
                details.Get_Data();
                Console.WriteLine("Displaying Details:");
                details.Display_Data();
            }
        }
    }



