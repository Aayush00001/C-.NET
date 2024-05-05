using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_8
{
    
        class Employee
        {
            private static int count = 0;
            private int Emp_Id;
            private string Emp_Name;
            private double Basic_Salary;
            private double Gross_Salary;

            public int EmployeeId
            {
                get { return Emp_Id; }
                set { Emp_Id = value; }
            }

            public string EmployeeName
            {
                get { return Emp_Name; }
                set { Emp_Name = value; }
            }

            public double BasicSalary
            {
                get { return Basic_Salary; }
                set { Basic_Salary = value; }
            }

            public double GrossSalary
            {
                get { return Gross_Salary; }
            }

            public void CalculateGrossSalary()
            {
                Gross_Salary = Basic_Salary + (Basic_Salary * 0.15);
            }

            public void DisplayData()
            {
                Console.WriteLine("Employee ID: " + Emp_Id);
                Console.WriteLine("Employee Name: " + Emp_Name);
                Console.WriteLine("Basic Salary: " + Basic_Salary);
                Console.WriteLine("Gross Salary: " + Gross_Salary);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                List<Employee> employeeList = new List<Employee>();

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("a. Add Data");
                    Console.WriteLine("b. Display Data");
                    Console.WriteLine("c. Search By Id");
                    Console.WriteLine("d. Search By Name");
                    Console.WriteLine("e. Update By Id");
                    Console.WriteLine("f. Delete By Id");
                    Console.WriteLine("x. Exit");

                    Console.Write("Enter your choice: ");
                    char choice = Console.ReadLine()[0];

                    switch (choice)
                    {
                        case 'a':
                            Employee newEmployee = new Employee();

                            Console.Write("Enter Employee ID: ");
                            newEmployee.EmployeeId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Employee Name: ");
                            newEmployee.EmployeeName = Console.ReadLine();

                            Console.Write("Enter Basic Salary: ");
                            newEmployee.BasicSalary = double.Parse(Console.ReadLine());

                            newEmployee.CalculateGrossSalary();
                            employeeList.Add(newEmployee);
                            break;

                        case 'b':
                            foreach (Employee employee in employeeList)
                            {
                                employee.DisplayData();
                                Console.WriteLine();
                            }
                            break;

                        case 'c':
                            Console.Write("Enter Employee ID to search: ");
                            int searchId = int.Parse(Console.ReadLine());
                            Employee foundById = employeeList.Find(emp => emp.EmployeeId == searchId);
                            if (foundById != null)
                            {
                                foundById.DisplayData();
                            }
                            else
                            {
                                Console.WriteLine("Employee not found with ID: " + searchId);
                            }
                            break;

                        case 'd':
                            Console.Write("Enter Employee Name to search: ");
                            string searchName = Console.ReadLine();
                            List<Employee> foundByName = employeeList.FindAll(emp => emp.EmployeeName == searchName);
                            if (foundByName.Count > 0)
                            {
                                foreach (Employee emp in foundByName)
                                {
                                    emp.DisplayData();
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No employees found with the name: " + searchName);
                            }
                            break;

                        case 'e':
                            Console.Write("Enter Employee ID to update: ");
                            int updateId = int.Parse(Console.ReadLine());
                            Employee employeeToUpdate = employeeList.Find(emp => emp.EmployeeId == updateId);
                            if (employeeToUpdate != null)
                            {
                                Console.Write("Enter new Basic Salary: ");
                                double newSalary = double.Parse(Console.ReadLine());
                                employeeToUpdate.BasicSalary = newSalary;
                                employeeToUpdate.CalculateGrossSalary();
                                Console.WriteLine("Employee updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Employee not found with ID: " + updateId);
                            }
                            break;

                        case 'f':
                            Console.Write("Enter Employee ID to delete: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            Employee employeeToDelete = employeeList.Find(emp => emp.EmployeeId == deleteId);
                            if (employeeToDelete != null)
                            {
                                employeeList.Remove(employeeToDelete);
                                Console.WriteLine("Employee deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Employee not found with ID: " + deleteId);
                            }
                            break;

                        case 'x':
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }
    }


