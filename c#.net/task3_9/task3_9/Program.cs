using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_9
{
   
        class Product
        {
            private static int count = 0;
            private int Cust_Id;
            private string Cust_Name;
            private string Product_Name;
            private double Price;

            public int CustomerId
            {
                get { return Cust_Id; }
                set { Cust_Id = value; }
            }

            public string CustomerName
            {
                get { return Cust_Name; }
                set { Cust_Name = value; }
            }

            public string ProductName
            {
                get { return Product_Name; }
                set { Product_Name = value; }
            }

            public double ProductPrice
            {
                get { return Price; }
                set { Price = value; }
            }

            public string this[int index]
            {
                get
                {
                    if (index == 0) return Cust_Id.ToString();
                    if (index == 1) return Cust_Name;
                    if (index == 2) return Product_Name;
                    if (index == 3) return Price.ToString();
                    return "";
                }
                set
                {
                    if (index == 0) Cust_Id = int.Parse(value);
                    if (index == 1) Cust_Name = value;
                    if (index == 2) Product_Name = value;
                    if (index == 3) Price = double.Parse(value);
                }
            }

            public void ShowProducts()
            {
                Console.WriteLine("Customer ID: " + Cust_Id);
                Console.WriteLine("Customer Name: " + Cust_Name);
                Console.WriteLine("Product Name: " + Product_Name);
                Console.WriteLine("Price: " + Price);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                List<Product> productList = new List<Product>();

                while (true)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("a. Add Data");
                    Console.WriteLine("b. Display Data");
                    Console.WriteLine("x. Exit");

                    Console.Write("Enter your choice: ");
                    char choice = Console.ReadLine()[0];

                    switch (choice)
                    {
                        case 'a':
                            Product newProduct = new Product();

                            Console.Write("Enter Customer ID: ");
                            newProduct.CustomerId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Customer Name: ");
                            newProduct.CustomerName = Console.ReadLine();

                            Console.Write("Enter Product Name: ");
                            newProduct.ProductName = Console.ReadLine();

                            Console.Write("Enter Product Price: ");
                            newProduct.ProductPrice = double.Parse(Console.ReadLine());

                            productList.Add(newProduct);
                            break;

                        case 'b':
                            foreach (Product product in productList)
                            {
                                product.ShowProducts();
                                Console.WriteLine();
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


