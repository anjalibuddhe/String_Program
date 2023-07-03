using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9. Write a program to count the number of words in a string

namespace StringProgram
{
    internal class NumberWord
    {
        static void Main(string[] args)
        {
            string str;
            int i, wrd, l;
            StringBuilder sb = new StringBuilder();

    
           
    
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            foreach (var a in str)
            {
                sb.Append(a);
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }
                l++;
            }

            Console.WriteLine(sb.Replace(' ', '\n'));
            Console.Write(wrd);
            Console.ReadLine();





        }
    }
}
