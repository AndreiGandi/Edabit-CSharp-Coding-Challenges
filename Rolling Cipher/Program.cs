using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rolling_Cipher
{
    class Program
    {
        //RollingCipher("abcd", 1) ➞ "bcde"
        //RollingCipher("abcd", -1) ➞ "zabc"
        //RollingCipher("abcd", 3) ➞ "defg"
        //RollingCipher("abcd", 26) ➞ "abcd"

        //Notes:
        //        All letters are lower cased.
        //        No spacing.
        //        Each character is rotated the same number of times.

        static void Main(string[] args)
        {
            Console.WriteLine(RollingCipher("abcd", 1));
            Console.WriteLine(RollingCipher("abcd", -1));
            Console.WriteLine(RollingCipher("abcd", 3));
            Console.WriteLine(RollingCipher("abcd", 26));
        }

        public static string RollingCipher(string input, int key)
        {
            char[] buffer = input.ToCharArray();
            for(int i = 0; i<input.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter+key);
                if (letter > 'z')
                    letter = (char)(letter - 26);
                else if (letter < 'a')
                    letter = (char)(letter + 26);
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
