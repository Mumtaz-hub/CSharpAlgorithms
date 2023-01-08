using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public static class NormalizeString
    {
        public static string NormalizeStr(String input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }

        public static void executeAlgorithm()
        {
            Console.WriteLine(NormalizeStr(" Hello There, BUDDY      "));
        }
    }
}
