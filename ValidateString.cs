using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class ValidateString
    {
        static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean isPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower)
                && s.Any(char.IsDigit);
        }

        public static void executeAlgorithms()
        {
            string s = "Hello World";
            Console.WriteLine("IsUppercase: " + IsUppercase(s));
            Console.WriteLine("IsLowercase: " + IsLowercase(s));
            Console.WriteLine("isPasswordComplex: " + isPasswordComplex(s));

            // Console.WriteLine(IsUppercase("hello"));
            // Console.WriteLine(IsUppercase("HELLO"));

            // Console.WriteLine(IsLowercase("hello"));
            // Console.WriteLine(IsLowercase("HELLO"));

            Console.WriteLine(isPasswordComplex("Hell0"));
            Console.WriteLine(isPasswordComplex("Hello"));
            Console.WriteLine(isPasswordComplex("HellO"));
            Console.WriteLine(isPasswordComplex("HeLlo"));
            Console.WriteLine(isPasswordComplex("hello"));
            Console.WriteLine(isPasswordComplex(" "));
        }
    }
}
