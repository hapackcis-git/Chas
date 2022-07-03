using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back.If the given string length is less than 3, use whatever characters are there.
    internal class B11
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("ab"));
            Console.WriteLine(test("amit"));
            Console.WriteLine(test("java"));
        }
        public static string test(string str)
        {
            return (str.Length<3)?str+str+str:str.Substring(0,3)+str+str.Substring(0,3);

        }
    }
}
