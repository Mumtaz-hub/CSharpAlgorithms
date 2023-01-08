﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public static class ReverseEachWordOfSentence
    {
        static String ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                if (i != arr.Length - 1)
                {
                    result.Append(" ");
                }
            }

            return result.ToString();
        }

        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        public static void ExecuteAlgorithm()
        {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}
