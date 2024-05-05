using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_7
{
   
        abstract class Telephone
        {
            protected string phonetype;

            public abstract void Ring();

            public void DisplayType()
            {
                Console.WriteLine("Phone type: " + phonetype);
            }
        }

        class DigitalPhone : Telephone
        {
            public DigitalPhone()
            {
                phonetype = "Digital";
            }

            public override void Ring()
            {
                Console.WriteLine("Ringing the " + phonetype + " phone.");
            }
        }

        class TalkingPhone : Telephone
        {
            public TalkingPhone()
            {
                phonetype = "Talking";
            }

            public override void Ring()
            {
                Console.WriteLine("Ringing the " + phonetype + " phone.");
            }
        }

        class TestClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                Console.WriteLine("Testing the Abstract Class and Method Example:");
                Console.WriteLine();

                Telephone digitalPhone = new DigitalPhone();
                digitalPhone.Ring();
                digitalPhone.DisplayType();
                Console.WriteLine();

                Telephone talkingPhone = new TalkingPhone();
                talkingPhone.Ring();
                talkingPhone.DisplayType();
            }
        }
    }


