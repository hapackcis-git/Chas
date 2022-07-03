using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B20
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(25, 35));
            Console.WriteLine(test(40, 50));
            Console.WriteLine(test(55, 60));
            Console.ReadLine();
        }
        public static bool test(int x,int y)
        {
            return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
        }
    }
}
