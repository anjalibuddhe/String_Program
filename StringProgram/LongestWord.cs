using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10. WAP to find longest word in the given sentence

namespace StringProgram
{
    internal class LongestWord
    {
        static void Main(string[] args)
        {
            string str = "find longest word in the given sentence";
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}
