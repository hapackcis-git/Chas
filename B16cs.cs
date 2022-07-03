using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B16cs
    {
        //Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the said range otherwise false.
        public static void Main(String[] args)
        {
            Console.WriteLine(test(100, 199));
            Console.WriteLine(test(250, 300));
            Console.WriteLine(test(105, 190));
            Console.ReadLine();
        }
        public static bool test(int x, int y)
        {
            return (x >= 20 && x <= 50) || (y >= 20 && y <= 50);
        }

    }
}
