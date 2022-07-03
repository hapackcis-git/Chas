using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range.
    internal class B21
    {
        public static void Main(String[] args)
        {
             Console.WriteLine(test(78, 95));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(21, 25));
            Console.WriteLine(test(28, 28));
            Console.ReadLine();



        }
        public static int test(int x,int y)
        {

            return ((x >= 20 && x <= 30) || (y >= 20 && y <= 30)) ? (x > y) ? x : y : 0;
        }
    }
}
