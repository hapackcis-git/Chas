using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to check whether the first appearance of "a" in a given string is immediately followed by another "a".
    internal class B28
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("caabb"));
            Console.WriteLine(test("babaaba"));
            Console.WriteLine(test("aaaaa"));
            Console.ReadLine();
        }
        public static bool test(string s)
        {
            var ctr = 0;
            for(int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals('a')) ctr++;
                if (s.Substring(i, 2).Equals("aa") && ctr < 2)

                        return true;
            }
            return false;   

        }
    }
}
