using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Parseltongue
{
    class Program
    {
        //Hermione has come up with a precise formula for determining whether or not a phrase was ssspoken by a parssseltongue(a reference from the Harry Potter universe; the language of ssserpents and those who can converse with them).
        //    Each word in a sssentence must contain either:
        //    Exactly two instances of the letter "s" (i.e.must be together ss), or...
        //    Zero instances of the letter "s" by itself.


        static void Main(string[] args)    
        {
            Console.WriteLine(IsParselTongue("Sshe ssselects to eat that apple. ")); //true
            Console.WriteLine(IsParselTongue("She ssselects to eat that apple. ")); //false
        }
        public static bool IsParselTongue(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach(var item in words)
            {
                string word = item.ToLower();
                if (word.Contains("s") && !word.Contains("ss"))
                    return false;
            }
            return true;
        }
    }
}
