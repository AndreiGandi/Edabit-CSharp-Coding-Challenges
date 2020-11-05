using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finding_Nemo
{
    class Program
    {
        //You're given a string of words. You need to find the word "Nemo", and return a string like this: "I found Nemo at [the order of the word you find nemo]!".
        //If you can't find Nemo, return "I can't find Nemo :(".
        static void Main(string[] args)
        {
            Console.WriteLine(FindNemo("I am finding Nemo !"));
        }
        public static string FindNemo(string sentence)
        {
            string s = "I can't find Nemo :(";
            string[] words = sentence.Split();
            for(int i=0; i<words.Length-1; i++)
            {
                if(words[i] == "Nemo")
                {
                    s = $"I found Nemo at {i + 1}!";
                    break;
                }
            }



            return s;
        }
    }
}
