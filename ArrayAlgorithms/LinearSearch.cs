using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public static class LinearSearch
    {
        static Boolean LinearSearchitem(int[] input, int n)
        {
            foreach (int current in input)
            {
                if (n == current)
                {
                    return true;
                }
            }

            return false;
        }

        public static void ExecuteAlgorithm()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            // Console.WriteLine(LinearSearchitem(arr, 4));
            // Console.WriteLine(LinearSearchitem(arr, 8));

            int item = Array.Find(arr, element => element == 3);
            Console.WriteLine(item);
            int[] items = Array.FindAll(arr, element => element >= 5);
            Array.ForEach(items, Console.WriteLine);
        }

    }
}
