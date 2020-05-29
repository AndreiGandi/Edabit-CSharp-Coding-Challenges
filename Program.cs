using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "What an easy task, right";
            Console.WriteLine(CountWords(Text));
        }
        public static int CountWords(string str)
        {
            int wordsNr = 0;
            string[] Str;
            Str = str.Split(' ');
            return Str.Length;
        }
    }
}
