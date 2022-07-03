using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    internal class B6
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test("amit",1));
            Console.WriteLine(test("python",2));

        }
        public static string test(string str, int n)
        {
            return str.Remove(n, 1);

        }
    }
}
