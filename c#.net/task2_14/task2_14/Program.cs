//14.Write a program in C# Sharp to insert two books' information.
//Test Data :Insert the information of two books :
//Information of book 1
//Input name of the book: BASIC
//Input the author: S.TROELSTRA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_14
{

    class Book
    {
        public string Name;
        public string Author;
    }

    class BookInformation
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);

            Book book1 = new Book();
            Book book2 = new Book();

            Console.WriteLine("Information of Book 1:");
            Console.Write("Input name of the book: ");
            book1.Name = Console.ReadLine();

            Console.Write("Input the author: ");
            book1.Author = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Information of Book 2:");
            Console.Write("Input name of the book: ");
            book2.Name = Console.ReadLine();

            Console.Write("Input the author: ");
            book2.Author = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Book 1 Information:");
            Console.WriteLine("Name: " + book1.Name);
            Console.WriteLine("Author: " + book1.Author);

            Console.WriteLine();

            Console.WriteLine("Book 2 Information:");
            Console.WriteLine("Name: " + book2.Name);
            Console.WriteLine("Author: " + book2.Author);

            Console.ReadLine();
        }
    }

}
