using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B10
    {
        //Write a C# Sharp program to check whether a given positive number is a multiple of 3 or a multiple of 7.
        public static void Main(String[] args)
        {

            Console.WriteLine(test(14));
            Console.WriteLine(test(5));
            Console.WriteLine(test(6)); 
        }
        public static bool test(int num)
        {
            return num % 3 == 0 || num % 7 == 0;
        }
    }

}
