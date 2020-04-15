using System;

namespace PractiseAlgorithms
{
    public static class SortArray
    {
        public static int[] DescendingOrder(int[] sampleArray)
        {
            Array.Sort(sampleArray);
            Array.Reverse(sampleArray);

            return sampleArray;
        }
    }
}
