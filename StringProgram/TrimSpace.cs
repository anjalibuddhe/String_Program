using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram
{   //4. Write a program to trim leading white space characters in a string.

    internal class TrimSpace
    {
        static void Main(string[] args)
        {
            string str = "   .....Today is good day";
            Console.WriteLine(str.TrimStart());
        }
    }
}
