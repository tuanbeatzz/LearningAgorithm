using LearningAgorithm.Agorithm;
using LearningAgorithm.Hackerrank;
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
            int[] arrSort = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            Console.WriteLine("Given Array");
            printArray(arrSort);
            BinarySearch ob = new BinarySearch();
            var output = ob.Search(arrSort, 0, arrSort.Length - 1, 110);
            Console.WriteLine(output);
            //Console.WriteLine("\nSorted array");
            //printArray(arr);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hackerrank");
            ExtraLongFactorial ob2 = new ExtraLongFactorial();
            var outputhackerrank = ob2.extraLongFactorials(25);
            Console.WriteLine(outputhackerrank);

            khaican khaican = new khaican();
            khaican.Khaican(12);
        }
    }
}