using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Write a program to check whether given string is palindrome or not.

namespace StringProgram
{
    internal class StringFuction
    {
        static void Main(string[] args)
        {
            string str1 = "Learning C#";
            string str2 = "Angular Html Css";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str1.Concat(str2));


            Console.WriteLine(str1.Replace("C#", "React"));

            Console.WriteLine(str2.Trim());

            Console.WriteLine(str1.Length);

            Boolean res = str1.Equals(str2);
            Console.WriteLine(res);

            string[] st = str1.Split(' ');

            foreach (var str in str1)
            {
                Console.WriteLine($"{str}");
            }

            Console.WriteLine(str2.Contains("hello"));

            Console.WriteLine(string.Join("---", str2));

            Console.WriteLine(str1.EndsWith(" "));
            Console.WriteLine(str1.StartsWith("Learning"));

            Console.WriteLine(str1.IndexOf("C#"));


        }
    }
}
