//3.Write a C# Sharp program to calculate and print the electricity bill of a customer. From the
//keyboard, the customer's name, ID, and unit consumed should be taken and displayed along
//with the total amount due.
//The charge are as follow :
//Unit Charge/unit
//upto 199 1.20
//200 and above but less than 400 1.50
//400 and above but less than 600 1.80
//600 and above 2.00
//If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should
//be of Rs. 100/-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_3
{
    class ElectricityBill
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            string customerName, customerId;
            int unitConsumed;
            double unitCharge, totalAmount;

            // Input customer details
            Console.WriteLine("Enter customer name: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter customer ID: ");
            customerId = Console.ReadLine();

            Console.WriteLine("Enter unit consumed: ");
            unitConsumed = Convert.ToInt32(Console.ReadLine());

            // Calculate unit charge
            if (unitConsumed <= 199)
            {
                unitCharge = 1.20;
            }
            else if (unitConsumed >= 200 && unitConsumed < 400)
            {
                unitCharge = 1.50;
            }
            else if (unitConsumed >= 400 && unitConsumed < 600)
            {
                unitCharge = 1.80;
            }
            else
            {
                unitCharge = 2.00;
            }

            // Calculate total amount
            totalAmount = unitConsumed * unitCharge;

            // Add surcharge if bill exceeds Rs. 400
            if (totalAmount > 400)
            {
                totalAmount += totalAmount * 0.15;
            }

            // Ensure minimum bill of Rs. 100
            if (totalAmount < 100)
            {
                totalAmount = 100;
            }

            // Display customer details and total amount due
            Console.WriteLine("\nCustomer Name: " + customerName);
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Unit Consumed: " + unitConsumed);
            Console.WriteLine("Total Amount Due: Rs. " + totalAmount);

            Console.ReadLine();
        }
    }
}