using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram
{

    //Write a program to find first occurrence of a word in a given string.

    internal class firstword
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter String");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter word to find");
            String s2 = Console.ReadLine();

            string[] word = s1.Split(' ');
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == s2)
                {

                    count++;
                }
            }
            Console.WriteLine(count);
        }



    
    }
}
