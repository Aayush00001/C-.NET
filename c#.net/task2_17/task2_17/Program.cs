//17. Write a program to create an enumeration of “Status” and print using switch case.
//Status are like: open, inProgress, resolved, closed, reopened
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_17
{

    enum Status
    {
        Open,
        InProgress,
        Resolved,
        Closed,
        Reopened
    }

    class StatusEnumeration
    {
        static void Main()
        {
            Console.WriteLine("Name: radhanpara aayush.");
            Console.WriteLine("Enrollment No: 210801258.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Status Enumeration:");

            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine(GetStatusString(status));
            }

            Console.ReadLine();
        }

        static string GetStatusString(Status status)
        {
            switch (status)
            {
                case Status.Open:
                    return "Open";
                case Status.InProgress:
                    return "In Progress";
                case Status.Resolved:
                    return "Resolved";
                case Status.Closed:
                    return "Closed";
                case Status.Reopened:
                    return "Reopened";
                default:
                    return "Unknown";
            }
        }
    }

}
