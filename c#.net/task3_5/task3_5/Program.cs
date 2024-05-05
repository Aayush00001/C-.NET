using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_5
{
    
        class Rectangle
        {
            protected double length;
            protected double width;
            protected double area;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public virtual void FindArea()
            {
                area = length * width;
            }

            public void Display()
            {
                Console.WriteLine("Length: " + length);
                Console.WriteLine("Width: " + width);
                Console.WriteLine("Area: " + area);
            }
        }

        class Tabletop : Rectangle
        {
            public Tabletop(double length, double width)
                : base(length, width)
            {
            }

            public override void FindArea()
            {
                base.FindArea();
                Console.WriteLine("Area of Tabletop: " + area);
            }
        }

        class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);


                Tabletop tabletop = new Tabletop(5.0, 4.0);
                tabletop.FindArea();
                tabletop.Display();
            }
        }
    }


