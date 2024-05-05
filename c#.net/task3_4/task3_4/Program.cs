using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_4
{
    
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a generic shape.");
            }

            public virtual void Erase()
            {
                Console.WriteLine("Erasing a generic shape.");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }

            public override void Erase()
            {
                Console.WriteLine("Erasing a circle.");
            }
        }

        class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a triangle.");
            }

            public override void Erase()
            {
                Console.WriteLine("Erasing a triangle.");
            }
        }

        class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a square.");
            }

            public override void Erase()
            {
                Console.WriteLine("Erasing a square.");
            }
        }

        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);


                Shape[] shapes = new Shape[]
            {
                new Circle(),
                new Triangle(),
                new Square()
            };

                foreach (Shape shape in shapes)
                {
                    shape.Draw();
                    shape.Erase();
                    Console.WriteLine();
                }
            }
        }
    }

