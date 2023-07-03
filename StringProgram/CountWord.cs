using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5 Write a program to count total number of words in a string.
namespace StringProgram
{
    internal class CountWord
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter String  : ");
            string str = Console.ReadLine();
            string[] count = str.Split(' ');
            Console.WriteLine("Count of words :" + count.Length);
        }
    }
}
