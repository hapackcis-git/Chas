using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
    internal class B5
    {
        public static void Main(String[] args)
        {

            Console.WriteLine(test("if else"));
            Console.WriteLine(test("else"));
            Console.ReadLine();
        } 
        public static string test(string s)
        {
            return (s.Length > 2 && s.Substring(0, 2).Equals("if")) ? s :"if" + s;
        }
    }
}
