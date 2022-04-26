using System;

namespace LearningAgorithm
{
    public class MergeSort
    {
        // Merges two subarrays of []arr.
        // First subarray is arr[l..m]
        // Second subarray is arr[m+1..r]
        private void merge(int[] arr, int l, int m, int r)
        {
            // l: from; r: to; m: middle
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public void sort(int[] arr, int l, int r)
        {
            // l: from
            // r: to
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                sort(arr, l, m);
                sort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }
    }

    public class MergSortList
    {
        public void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                var middle = start + (end - start) / 2;
                Sort(arr, start, middle);
                Sort(arr, middle + 1, end);
                Merge(arr, start, end, middle);
            }
        }

        public void Merge(int[] arr, int start, int end, int middle)
        {
            var leftcount = middle - start + 1;
            var rightcount = end - middle;
            int[] L = new int[leftcount];
            int[] R = new int[rightcount];

            for (int e = 0; e < leftcount; ++e)
                L[e] = arr[start + e];
            for (int q = 0; q < rightcount; ++q)
                R[q] = arr[middle + 1 + q];

            int i = 0, j = 0;
            int k = start;

            while (i < leftcount && j < rightcount)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < leftcount)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < rightcount)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
            printArray(arr);
        }

        private static void printArray(int[] arr)
        {
            int n = arr.Length;
            Console.WriteLine("Print arr ");
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}