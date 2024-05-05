using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3_12
{

   
        // Define a class with an event
        class MyClass
        {
            public event EventHandler MyEvent;

            public void DoSomething()
            {
                Console.WriteLine("Doing something...");
                OnMyEvent();
            }

            protected virtual void OnMyEvent()
        {
            MyEvent.Invoke(this, EventArgs.Empty);
        }
        }

        // Define a class to subscribe to the event
        class EventSubscriber
        {
            public void HandleMyEvent(object sender, EventArgs e)
            {
                Console.WriteLine("Event handler in EventSubscriber is triggered.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("name:radhanpara aayush");
                Console.WriteLine("enroll:210801258");
                Console.WriteLine(DateTime.Now);

                MyClass myClass = new MyClass();
                EventSubscriber eventSubscriber = new EventSubscriber();

                // Subscribe to the event
                myClass.MyEvent += eventSubscriber.HandleMyEvent;

                // Call the method that raises the event
                myClass.DoSomething();  // <-- Make sure there's no semicolon here
            }
        }
    }
      


