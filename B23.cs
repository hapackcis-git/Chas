using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B23
    {
        //Write a C# Sharp program to check whether two given non-negative integers have the same last digit.
        public static void Main(String[] args)
        {

            Console.WriteLine(test(123, 456));
            Console.WriteLine(test(12, 512));
            Console.WriteLine(test(7, 87));
            Console.WriteLine(test(12, 45));

            Console.ReadLine();

        }
        public static bool test(int x,int y)
        {
            return Math.Abs(x%10)==Math.Abs(y%10);  

        }
    }

}
