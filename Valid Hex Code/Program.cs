using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Hex_Code
{
    class Program
    {
        //A hex code must begin with a pound key # and is exactly 6 characters in length.
        //Each character must be a digit from 0-9 or an alphabetic character from A-F. 
        //All alphabetic characters may be uppercase or lowercase.

        //IsValidHexCode("#CD5C5C") ➞ true
        //IsValidHexCode("#EAECEE") ➞ true
        //IsValidHexCode("#eaecee") ➞ true
        //IsValidHexCode("#CD5C58C") ➞ false
        //// Length exceeds 6
        //IsValidHexCode("#CD5C5Z") ➞ false
        //// Not all alphabetic characters in A-F
        //IsValidHexCode("#CD5C&C") ➞ false
        //// Contains unacceptable character
        //IsValidHexCode("CD5C5C") ➞ false
        // Missing #
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidHexCode("#CD5C5C"));
        }
        public static bool IsValidHexCode(string str)
        {
            char[] chars = str.ToCharArray();
            bool isValid = false;
            if (chars.Length == 7 && chars[0] == '#')
            {
                for (int i = 1; i < chars.Length; i++)
                {
                    isValid = false;
                    if (char.IsLetterOrDigit(char.ToLower(chars[i])) && (char.ToLower(chars[i]) >= 97 && char.ToLower(chars[i]) <=102 || char.ToLower(chars[i]) >= 48 && char.ToLower(chars[i]) <= 57))
                        isValid = true;
                    else { isValid = false; break; }

                }

            }
            return isValid;
        }
        //public static bool IsValidHexCode(string str)
        //{
        //    Regex rgx = new Regex("^#[0-9a-fA-F]{6}$");
        //    if(str.Length == 7)
        //    {
        //        if (rgx.IsMatch(str))
        //            return true;
        //    }
        //    return false;
        //}
    }
}
