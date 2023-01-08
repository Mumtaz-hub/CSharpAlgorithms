using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class BinarySearch
    {
        static Boolean BinarySearchitem(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (item == inputArray[mid])
                {
                    return true;
                }
                else if (item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }

        public static void ExecuteAlgorithm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(BinarySearchitem(arr, 5));

            int item = Array.BinarySearch(arr, 5); // returns index of 5
            Console.WriteLine("5 found at index :" + item);
        }
    }
}
