using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7 Write a program to check whether given string is palindrome or not.

namespace StringProgram
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            string rev = "";
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--) //Reverse
            {
                rev = rev + str[i].ToString();
            }
            if(rev == str)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome");

            }




        }
    }
}
