using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B9
    {
        //Write a C# Sharp program to create  a new string with the last char added at the front and back of a given string of length 1 or more.
        public static void Main(String[] args)
        {
            Console.WriteLine(test("red"));
        }
        public static string test(string str)
        {
            return str.Substring(str.Length - 1)+str+str.Substring(str.Length-1);
        }
    }
}
