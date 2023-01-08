using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class ReverseArray
    {
        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        static void ReverseInPlace(int[] input)
        {

            for (int i = 0; i < input.Length / 2; i++)
            {
                // Swap index(i) with index(input.Length - i - 1)
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        public static void ExecuteAlgorithm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            // Array.ForEach(Reverse(arr), Console.WriteLine);
            ReverseInPlace(arr);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
