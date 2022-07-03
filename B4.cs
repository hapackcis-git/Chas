using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
    internal class B4
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(test(100));
            Console.WriteLine(test(139));
            Console.WriteLine(test(34));
        }

        public static bool test(int x){
            return ((Math.Abs(x-100)<=10)|| (Math.Abs(x - 200) <= 10))?true:false;
}
    }
}

