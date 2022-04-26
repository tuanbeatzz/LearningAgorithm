using System;

namespace LearningAgorithm.Agorithm
{
    public class QuickSort
    {
        private int Partition(int[] arr, int start, int end)
        {
            var pivot = arr[end];
            var i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[end]) = (arr[end], arr[i + 1]);
            Console.WriteLine("Partition: ");
            printArray(arr);
            return i + 1;
        }

        private static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public void quicksort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                var pi = Partition(arr, start, end);
                quicksort(arr, start, pi - 1);
                quicksort(arr, pi + 1, end);
            }
        }
    }
}