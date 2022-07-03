using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to remove the character in a given position of a given string. The given position will be in the range 0...string length -1 inclusive.
    internal class B2
    {
        public static void Main(String[] Args)
        {
            Console.WriteLine(test(56));
            Console.WriteLine(test(45));
            
        }
        public static int test(int n)
        {
            int x = 51;
            return (n > x) ? (n - x) * 3 : (x - n);

        }
    }
}
