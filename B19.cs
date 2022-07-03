using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to check which number is nearest to the value 100 among two given integers. Return 0 if the two numbers are equal.
    internal class B19
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(95, 95));
            Console.WriteLine(test(99, 70));
            Console.ReadLine();
        }
        public static int test(int x,int y)
        {
            int n = 100;
            var val1 = Math.Abs(n - x);
            var val2=Math.Abs(n - y);   
            return val1==val2?0:val1<val2?x:y;

        }
    }
}
