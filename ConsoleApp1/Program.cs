using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        // Generics challenge.
        // https://www.youtube.com/watch?v=_zrfUzHlHuM.

        static void Main(string[] args)
        {
            // Default lists that are passed through Generics() function.
            List<object> list1 = new List<object>() { 1, 9, 20, 4, 72, 18, 90, 11, 33, 12 };
            List<object> list2 = new List<object>() { 2, 5, 1, 8, 5, 2, 3, 5, 4, 3, 6, 4 };

            // List that holds Generics() result.
            List<object> printList = Generics(list1, list2);

            // Iterating through printList to print the values.
            foreach (var item in printList)
            {
                Console.Write(item + ", ");
            }
            Console.Read();
        }

        // Function that takes two lists as arguments.
        static List<object> Generics(List<object> a, List<object> b)
        {
            // Creating a list to hold the list with the longest length.
            List<object> longestList = new List<object>();
            // Creating a list to hold the list with the shortest length.
            List<object> shortestList = new List<object>();
            // Creating a list that will hold the values of each list.
            List<object> newList = new List<object>();

            // Checking which list has the most items.
            if (a.Count > b.Count)
            {
                longestList = a;
                shortestList = b;
            }
            else
            {
                longestList = b;
                shortestList = a;
            }

            // For loop, adds items from each list to the new list while i is less than the length of the longest list.
            for (int i = 0; i < longestList.Count; i++)
            {
                // Add item from longest list onto new list
                newList.Add(longestList[i]);

                // If i is larger than the length of the shortest list then skip adding from shortest list.
                if (i >= shortestList.Count)
                {
                    continue;
                }
                // If i is less than the length of shortest list then add item from shortest list to the new list.
                else
                {
                    newList.Add(shortestList[i]);
                }
            }

            // Return the new list.
            return newList;
        }
    }
}
