using System;

namespace PractiseAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice 1 :this Array has Duplicate Data?");
            int[] sampleArray = WriteSampleArray();
            Console.WriteLine(DuplicateDataInArray.ContainDuplicates(sampleArray));
            Console.Write("\n");
            Console.ReadLine();


            Console.WriteLine("Practice 2 :this Array Sort Decending");

            SortArray.DescendingOrder(sampleArray);
            ReadArrayItems(sampleArray);
            Console.Write("\n");
            Console.ReadLine();

            Console.WriteLine("Practice 3: how to find sum of digits of a number");


            int num, result;
            Console.WriteLine("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            result = SumDigitsOfNumber.SumDigit(num);
            Console.WriteLine("Sum of Digits in {0} is {1}", num, result);
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

            ReadArrayItems(arr);
            return arr;
        }

        private static void ReadArrayItems(int[] arr)
        {
            Console.Write("\nElements in array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }



    }
}
