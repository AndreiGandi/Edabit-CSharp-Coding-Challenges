using System;
using System.Text;

namespace No_Yelling
{
    class Program
    {

        //NoYelling("What went wrong?????????") ➞ "What went wrong?"
        //NoYelling("Oh my goodness!!!") ➞ "Oh my goodness!"
        //NoYelling("I just!!! can!!! not!!! believe!!! it!!!") ➞ "I just!!! can!!! not!!! believe!!! it!"
        //// Only change repeating punctuation at the end of the sentence.
        //NoYelling("Oh my goodness!") ➞ "Oh my goodness!"
        //// Do not change sentences where there exists only one or zero exclamation marks/question marks.
        //NoYelling("I just cannot believe it.") ➞ "I just cannot believe it."
        static void Main(string[] args)
        {
            Console.WriteLine(NoYelling("Oh my goodness!!!"));
        }
        public static string NoYelling(string phrase)
        {
            StringBuilder sb = new StringBuilder(phrase);
            while ((sb[sb.Length - 1] == '!' || sb[sb.Length - 1] == '?') && sb[sb.Length - 1] == sb[sb.Length - 2])
                sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        public static string NoYelling_v2(string phrase)
        {
            if (phrase.EndsWith("!"))
            {
                return phrase.TrimEnd('!') + "!";
            }

            if (phrase.EndsWith("?"))
            {
                return phrase.TrimEnd('?') + "?";
            }

            return phrase;
        }
    }
}
