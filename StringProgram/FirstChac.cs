using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find the first occurrence of a character in a given string.

namespace StringProgram
{
    internal class FirstChac
    {
        static void Main(string[] args)
        {

            int count = 0;
            string str = "Hello, Today is Monday";


            Console.WriteLine(str);

            Console.WriteLine("Enter the charcter to search");
            char str2 = Convert.ToChar(Console.ReadLine());
            char[] chars = str.ToCharArray(); ;


            //Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
               if (str2 == chars[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);


        }
    }
}
