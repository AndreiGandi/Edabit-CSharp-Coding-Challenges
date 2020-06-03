using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_E_Mail_Validation
{
    class Program
    {
        //Create a function that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.
        //The string must contain an @ character.
        //The string must contain a.character.
        //The @ must have at least one character in front of it.
        //        e.g. "e@edabit.com" is valid while "@edabit.com" is invalid.
        //The.and the @ must be in the appropriate places.
        //        e.g. "hello.email@com" is invalid while "john.smith@email.com" is valid.

        //ValidateEmail("@gmail.com") ➞ false
        //ValidateEmail("hello.gmail@com") ➞ false
        //ValidateEmail("gmail") ➞ false
        //ValidateEmail("hello@gmail") ➞ false
        //ValidateEmail("hello@edabit.com") ➞ true

        static void Main(string[] args)
        {
            Console.WriteLine(ValidateEmail("hello.andrei@edabit.com"));
        }
        //using REGEX
        public static bool ValidateEmail(string str)
        {
            string formatRgx = "^[a-zA-Z0-9.]{1,20}@[a-zA-Z]{1,20}.(com|ro)$";
            Regex rgx = new Regex(formatRgx);
            if (rgx.IsMatch(str)) return true;
            return false;
        }
        public static bool ValidateEmail_2(string str)
        {
            return Regex.IsMatch(str, @"\w+@\w+.com");
        }
        //without REGEX
        public static bool ValidateEmail_3(string str)
        {
            bool containsOneArond = false;
            bool containsDot = false;
            bool aRondNotFirst = false;
            bool dotAndARondRightPosition = false;
            if (str.Contains("@") && (str.Split('@').Length - 1) == 1)
                containsOneArond = true;
            else return false;
            if (str.Contains('.'))
                containsDot = true;
            if (str[0] != '@')
                aRondNotFirst = true;
            string[] strSub = str.Split('@');
            if (strSub[1].Contains('.') && (strSub[1].IndexOf('.') != 0 && strSub[1].IndexOf('.') != strSub[1].Length - 1))
                dotAndARondRightPosition = true;


            if (containsOneArond && containsDot && aRondNotFirst && dotAndARondRightPosition)
                return true;
            return false;

        }
    }
}
