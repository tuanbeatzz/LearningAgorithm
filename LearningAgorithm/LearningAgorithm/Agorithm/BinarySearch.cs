using System;

namespace LearningAgorithm.Agorithm
{
    internal class BinarySearch
    {
        public int Search(int[] arr, int start, int end, int x)
        {
            if (end > 1)
            {
                var middle = start + (end - start) / 2;
                if (arr[middle] > x)
                {
                    return Search(arr, start, middle, x);
                }
                if (arr[middle] < x)
                {
                    return Search(arr, middle + 1, end, x);
                }
                else
                    return middle;
            }

            return -1;
        }
    }
}