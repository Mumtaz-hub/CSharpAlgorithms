using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class RotateArray
    {
        static void RotateArrayLeft(int[] input)
        {
            int temp = input[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }

            // [2, 3, 4, 5, 6, 6]

            input[input.Length - 1] = temp;
        }

        static void RotateArrayRight(int[] input)
        {

            int temp = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }

            // [1, 1, 2, 3, 4, 5]
            input[0] = temp;
        }

       public static void ExecuteAlgorithm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RotateArrayLeft(arr);
            RotateArrayRight(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
