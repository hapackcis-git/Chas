using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B17
    {
        //Write a C# Sharp program to check whether a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string
        public static void Main(String[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("ytade"));
            Console.WriteLine(test("jsues"));
            Console.ReadLine();

        }
        public static string test(string str)
        {
            return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
        }
    }
}
