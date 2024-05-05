//10.Write a C# Sharp program in to count duplicate elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_10
{
    class DuplicateCounter
{
    static void Main()
    {
        Console.WriteLine("Name: radhanpara aayush.");
        Console.WriteLine("Enrollment No: 210801258.");
        Console.WriteLine(DateTime.Now);

        Console.WriteLine("Enter the elements of the array (space-separated):");
        string[] input = Console.ReadLine().Split(' ');

        int[] array = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = Convert.ToInt32(input[i]);
        }

        Dictionary<int, int> duplicates = CountDuplicates(array);

        Console.WriteLine("Duplicate elements and their counts:");
        foreach (KeyValuePair<int, int> duplicate in duplicates)
        {
            Console.WriteLine("{duplicate.Key}: {duplicate.Value}");
        }

        Console.ReadLine();
    }

    static Dictionary<int, int> CountDuplicates(int[] array)
    {
        Dictionary<int, int> duplicates = new Dictionary<int, int>();

        foreach (int element in array)
        {
            if (duplicates.ContainsKey(element))
            {
                duplicates[element]++;
            }
            else
            {
                duplicates[element] = 1;
            }
        }

        return duplicates;
    }
}

        }
