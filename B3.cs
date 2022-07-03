using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B3
    {
        /*
         * Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
         */

        public static void Main(String[] args)
        {
            Console.WriteLine(test(25,5));
            Console.WriteLine(test(30,0));
            Console.WriteLine(test(25,25));
        }
        public static bool test(int x ,int y)
        {
            return (x == 30 || y == 30 || (x + y) == 30) ? true : false;
        }
    }
   
}
