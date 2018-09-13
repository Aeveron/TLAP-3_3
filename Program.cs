
using System;
using System.Runtime.CompilerServices;

namespace TLAP_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberArray();
        }

        private static void NumberArray()
        {
            int[] numbers = { 1, 2, 3, 4, 2, 5, 7, 8 };
            foreach (var number in numbers) Console.Write(number + " ");
            Console.WriteLine($"Sorted = {Sorting(numbers)}");
            numbers = new int[] { 1, 2, 2, 3, 4, 5, 7, 8 };
            foreach (var number in numbers) Console.Write(number + " ");
            Console.WriteLine($"Sorted = {Sorting(numbers)}");
        }

        private static bool Sorting(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }

            return true;
        }
    }
}
