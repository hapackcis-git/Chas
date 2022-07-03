using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1,2));
            Console.WriteLine(test(2,3));
            Console.WriteLine(test(4,4));
        }
        public static int test(int x,int y)
        {
            return x==y?(x+y)*3:x + y;
        } 

    }
}
