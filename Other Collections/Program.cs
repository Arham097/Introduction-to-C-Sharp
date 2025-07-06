// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {

        // 1. Stack
        Stack<string> nameStack = new Stack<string>();
        nameStack.Push("Arham");
        nameStack.Push("Akhzer");
        nameStack.Push("Bilal");

        Console.WriteLine(nameStack.Pop()); // Bilal

        // 2. Queue
        Queue<string> nameQueue = new Queue<string>();
        nameQueue.Enqueue("Arham");
        nameQueue.Enqueue("Akhzer");
        nameQueue.Enqueue("Bilal");

        Console.WriteLine(nameQueue.Dequeue()); // Arham

        // 3. Hashset (for storing unique elements)
        HashSet<string> nameHashSet = new HashSet<string>();
        nameHashSet.Add("Arham");
        nameHashSet.Add("Arham");
        nameHashSet.Add("Akhzer");

        Console.WriteLine(nameHashSet.Count); // Will print 2 (unique elements only)

        // 4. SortedSet (for sorted unique elements)
        SortedSet<int> numSS = new SortedSet<int> { 1, 4, 2, 5, 3 };
        foreach (int num in numSS)
        {
            Console.WriteLine(num); // Will print: 1, 2, 3, 4, 5
        }

        // 5. SortedList (key-value pairs, sorted by key)
        SortedList<int, string> numSL = new SortedList<int, string>();
        numSL.Add(3, "Three");
        numSL.Add(1, "One");
        numSL.Add(2, "Two");

        foreach (KeyValuePair<int, string> kvp in numSL)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); // Sorted by key: 1, 2, 3
        }

    }
}