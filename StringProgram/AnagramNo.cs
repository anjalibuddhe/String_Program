﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check whether two strings are anagram or not?

//For anagram, another string would have the same characters present in the first string,
//but the order of characters can be different.

namespace StringProgram
{
    internal class AnagramNo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word:");
            string str1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string str2 = Console.ReadLine();




            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }

        }
    }
}
