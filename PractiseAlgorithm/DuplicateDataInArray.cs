using System.Collections.Generic;
using System.Linq;

namespace PractiseAlgorithms
{
    public static class DuplicateDataInArray
    {

        public static bool ContainDuplicates(params int[] sampleData)
        {
            return sampleData.GroupBy(x => x).Any(x => x.Count() > 1);
        }

    }
}
