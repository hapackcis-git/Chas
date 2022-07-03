using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to create a new string which is n (non-negative integer ) copies of a given string.
    internal class B25
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("JS", 2));
            Console.WriteLine(test("JS", 3));
            Console.WriteLine(test("JS", 1));
            Console.ReadLine();

            Console.ReadLine();
        }
        public static string test(string str,int n)
        {
            string result = string.Empty;
            for(int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;


        }
    }
}
