using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to check whether one of the given temperatures is less than 0 and the other is greater than 100.
    internal class B13
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test(120, -1));
            Console.WriteLine(test(-1, 120));
            Console.WriteLine(test(2, 120));
            Console.ReadLine();
        }
        public static bool test(int temp1,int temp2)
        {
            return (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0);
        }
    }
}
