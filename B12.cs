using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B12
    {
        //Write a C# Sharp program to check whether a given string starts with 'C#' or not.
        public static void Main(String[]  args)
        {
            Console.WriteLine(test("c#"));
            Console.WriteLine(test("c#java"));


        }
        public static bool test(string str)
        {
            return (str.StartsWith("c#"));
        }
    }
}
