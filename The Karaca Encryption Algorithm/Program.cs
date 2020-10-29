using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Karaca_Encryption_Algorithm
{
    //Make a function that encrypts a given input with these steps:
    //    Input: "apple"
    //    Step 1: Reverse the input: "elppa"
    //    Step 2: Replace all vowels using the following chart:
    //        a => 0
    //        e => 1
    //        i => 2
    //        o => 2
    //        u => 3
    //    Step 3: Add "aca" to the end of the word: "1lpp0aca"

    
    class Program
    {
        static void Main(string[] args)
        {
            // Encrypt("banana") ➞ "0n0n0baca"
            Console.WriteLine(Encrypt("banana"));
        }
        public static string Encrypt(string word)
        {
            char[] items = word.ToCharArray();
            Array.Reverse(items);
            string encryptionStr = new string(items);
            return encryptionStr.Replace("a", "0").Replace("e", "1").Replace("i", "2").Replace("o", "2").Replace("u", "3") + "aca";
        }
    }
}
