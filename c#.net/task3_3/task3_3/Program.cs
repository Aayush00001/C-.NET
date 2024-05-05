using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_3
{
    
        class Room
        {

            // Attributes
            private int roomNo;
            private string roomType;
            private double roomArea;
            private bool acMachine;

            // Member function to set data
            public void SetData(int number, string type, double area, bool hasAC)
            {
                roomNo = number;
                roomType = type;
                roomArea = area;
                acMachine = hasAC;
            }

            // Member function to display data
            public void DisplayData()
            {
                Console.WriteLine("Room Number: " + roomNo);
                Console.WriteLine("Room Type: " + roomType);
                Console.WriteLine("Room Area: " + roomArea + " sq. meters");
                Console.WriteLine("AC Machine: " + (acMachine ? "Yes" : "No"));
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                Room myRoom = new Room();
                myRoom.SetData(101, "Single", 25.5, true);

                Console.WriteLine("Room Details:");
                myRoom.DisplayData();
            }
        }
    }


