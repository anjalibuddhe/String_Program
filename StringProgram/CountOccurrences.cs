using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StringProgram
{
    internal class CountOccurrences
    {

        //3 Write a program to count occurrences of a character in given string.

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter String");
            //string str=Console.ReadLine();

            string str = "today is good day";
            Console.WriteLine("String: " + str);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }

        }

    }
}
