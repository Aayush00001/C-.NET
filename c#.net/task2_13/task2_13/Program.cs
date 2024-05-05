//13.Write a C# Sharp program to create a structure that stores two data for an employee.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_13
{
   struct Employee
    {
        public string Name;
        public int DayOfBirth;
        public int MonthOfBirth;
        public int YearOfBirth;
    }

    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            Employee employee;

            Console.WriteLine("Name of the employee: ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Input day of birth: ");
            employee.DayOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input month of birth: ");
            employee.MonthOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input year for birth: ");
            employee.YearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEmployee Data:");
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Date of Birth: " + employee.DayOfBirth + "/" + employee.MonthOfBirth + "/" + employee.YearOfBirth);

            Console.ReadLine();
        }
    }

}
