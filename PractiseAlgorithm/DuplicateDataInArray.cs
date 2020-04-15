using System.Collections.Generic;

namespace PractiseAlgorithms
{
    public static class DuplicateDataInArray
    {

        public static bool ContainDuplicates(params int[] sampleData) {

            Dictionary<int, int> data = new Dictionary<int, int>();
            foreach (int i in sampleData)
            {
                if (data.ContainsKey(i))
                {
                    return true;
                }
                else
                {
                    data.Add(i, 1);
                }
            }
            return false;
        }

    }
}
