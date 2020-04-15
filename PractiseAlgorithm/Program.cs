using System;

namespace PractiseAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice 1 :this Array has Duplicate Data");
            int[] sampleArray = WriteSampleArray();
            ExecuteDuplicateDataInArray(sampleArray);
            Console.ReadLine();

        }

        private static int[] WriteSampleArray()
        {
            Console.Write("Input 8 elements in the array :\n");
            int[] arr = new int[8];

            for (int i = 0; i < arr.Length; i++)

            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            return arr;
        }

        public static void ExecuteDuplicateDataInArray(int[] testArray)
        {
            Console.WriteLine(DuplicateDataInArray.ContainDuplicates(testArray));
            Console.Write("\n");
        }
    }
}
