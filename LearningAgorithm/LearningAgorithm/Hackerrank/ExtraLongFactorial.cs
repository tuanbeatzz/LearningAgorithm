using System;

namespace LearningAgorithm.Hackerrank
{
    internal class ExtraLongFactorial
    {
        public long extraLongFactorials(int n)
        {
            long a = 1;
            for (int i = n; i > 0; i--)
            {
                n = n * i;
            }
            return n;
        }
    }
}