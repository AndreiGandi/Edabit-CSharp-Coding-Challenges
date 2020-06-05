using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smooth_Sentences
{
    class Program
    {
        //Carlos is a huge fan of something he calls smooth sentences.
        //A smooth sentence is one where the last letter of each word is identical to the first letter the following word.
        //To illustrate, the following would be a smooth sentence: "Carlos swam masterfully."
        static void Main(string[] args)
        {
            Console.WriteLine(IsSmooth("Rita asks Sam mean numbered dilemmas"));
        }
        public static bool IsSmooth(string sentence)
        {
            bool isSmooth = true;
            if (!(Char.IsLetterOrDigit(sentence[sentence.Length - 1])))
            {

                sentence = sentence.Trim(sentence[sentence.Length - 1]);
            }

            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (Char.ToLower(words[i][words[i].Length - 1]) != Char.ToLower(words[i + 1][0]))
                {
                    isSmooth = false;
                    break;
                }
            }
            return isSmooth;
        }

        //Using REGEX
        //public static bool IsSmooth(string sentence)
        //{
        //    return Regex.Matches(
        //      sentence,
        //        @"([a-z]) (?!\1)",
        //        RegexOptions.IgnoreCase
        //    ).Count == 0;
        //}
    }
}
