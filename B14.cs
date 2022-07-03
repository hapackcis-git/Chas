using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
    internal class B14
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test(100, 199));
            Console.WriteLine(test(250, 300));
            Console.WriteLine(test(105, 190));
            Console.ReadLine();
        }
        public static bool test(int x,int y)
        {
            return (x >= 100 && x <= 200) || (y >= 100 && y <= 200);
        }
        
    }
}
