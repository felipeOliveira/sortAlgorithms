using System;
using System.Collections.Generic;
using SortAlgorithms.Sorts;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var rand = new System.Random();


            var unsortedList = new List<int>(40);
            for (var i = 0; i < 40; i++)
            {
                unsortedList.Add(rand.Next(0, 300));
            }
            Console.WriteLine("Generated list:\n{0}", string.Join(",", unsortedList));
            
            var mergeSort = new MergeSort();
            Console.WriteLine("\nProcessed result [Merge Sort]:");
            Console.WriteLine(string.Join(",", mergeSort.Sort(unsortedList)));
            
            var bubbleSort = new BubbleSort();
            Console.WriteLine("\nProcessed result [Bubble Sort]:");
            Console.WriteLine(string.Join(",", bubbleSort.Sort(unsortedList)));
            
            var selectionSort = new SelectionSort();
            Console.WriteLine("\nProcessed result [Selection Sort]:");
            Console.WriteLine(string.Join(",", selectionSort.Sort(unsortedList)));
            
            var insertionSort = new InsertionSort();
            Console.WriteLine("\nProcessed result [Insertion Sort]:");
            Console.WriteLine(string.Join(",", insertionSort.Sort(unsortedList)));
            Console.ReadKey();
        }
    }
}