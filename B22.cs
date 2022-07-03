using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B22
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("frizz"));
            Console.WriteLine(test("zane"));
            Console.WriteLine(test("Zazz"));
            Console.WriteLine(test("false"));
            Console.WriteLine(test("zzzz"));
            Console.WriteLine(test("ZZZZ"));
            Console.ReadLine();
        }
        public static bool test(string str)
        {
            int ctr = 0;
            for(int i=0; i<str.Length; i++)
            {
                if(str[i]=='z')
                {
                    ctr++;
                }            
            }
            return ctr > 1 && ctr < 4; 

        }
    }
}
