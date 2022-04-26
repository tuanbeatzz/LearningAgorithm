using LearningAgorithm.Agorithm;
using System;

namespace LearningAgorithm
{
    internal class Program
    {
        // A utility function to
        // print array of size n */
        private static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10, 21, 33, 44, 56, 13, 43, 11, 4, 5, 6, 22, 45 };
            Console.WriteLine("Given Array");
            printArray(arr);
            QuickSort ob = new QuickSort();
            ob.quicksort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            printArray(arr);
        }
    }
}