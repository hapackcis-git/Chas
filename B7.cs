using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B7
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("amit"));
            Console.WriteLine(test("xyz"));

        }
        public static string test(string str)
        {
            return (str.Length > 1) ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
