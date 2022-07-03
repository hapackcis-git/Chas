using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B24
    {
        //Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters.
        public static void Main(String[] args)
        {

            Console.WriteLine(test("Python"));
            Console.WriteLine(test("Javascript"));
            Console.WriteLine(test("js"));
            Console.WriteLine(test("php"));
            Console.ReadLine();

        }
        public  static string test(string str)
        {
          return str.Length<3?str.ToUpper():str.Remove(0,3)+str.Substring(0,3).ToUpper();

        }
    }
}
