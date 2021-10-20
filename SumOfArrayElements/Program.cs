using System;

namespace SumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 125, 8541, 1000, 852145, 785412, 1, 2, 23 };
            Console.WriteLine($"Sum of all elements: {SumOfElements(numbers)}");
        }

        private static int SumOfElements(int[] someArray)
        {
            int sum = 0;

            for(int i = 0; i < someArray.Length; i++)
            {
                sum = sum + someArray[i];
            }

            return sum;
        }

    }
}
