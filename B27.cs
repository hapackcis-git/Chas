using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to count the number of times the string "aa" appears in a given string and assume that "aaa" contains two "aa".
    internal class B27
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("bbaaccaag"));
            Console.WriteLine(test("jjkiaaasew"));
            Console.WriteLine(test("JSaaakoiaa"));
            Console.ReadLine();
        }


        public static int test(string s)
        {
            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }

    }
}
