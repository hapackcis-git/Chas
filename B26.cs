using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_algorithm
{
    //Write a C# Sharp program to create a new string which contain the n (non-negative integer ) copies of the first 3 characters of a given string. If the length of the given string is less than 3 then return n copies of the string.
    internal class B26
    {
        public static void Main(String[] args)
        {


            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("Python", 3));
            Console.WriteLine(test("JS", 3));
            Console.ReadLine();
        }
        public static string test(string s,int n)
        {
            var result=string.Empty;
            var frontOfString = 3;
            if(frontOfString>s.Length)
                frontOfString = s.Length;   
            var front=s.Substring(0,frontOfString);
            for(var i = 0; i <n; i++)
            {
                result += front;

            }
            return result;
        }
       
    }
}
