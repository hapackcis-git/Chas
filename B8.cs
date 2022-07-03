using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B8
    {
        //Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.If the given string length is less than 2 return the original string.
        public static void Main(String[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("Java"));

        }
        public static string test(string str)
        {
            return (str.Length<2)?str:str.Substring(0,2)+str.Substring(0,2)+str.Substring(0,2)+ str.Substring(0, 2);
        }
    }
}
