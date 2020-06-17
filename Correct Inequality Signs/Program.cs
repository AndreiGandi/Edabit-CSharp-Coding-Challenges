using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Inequality_Signs
{
    //Create a function that returns true if a given inequality expression is correct and false otherwise.
    //CorrectSigns("3 < 7 < 11") ➞ true
    //CorrectSigns("13 > 44 > 33 > 1") ➞ false
    //CorrectSigns("1 < 2 < 6 < 9 > 3") ➞ true
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CorrectSigns("3 < 7 < 11"));
        }
        public static bool CorrectSigns(string str)
        {
            string trimmedString = str.Replace(" ", "");
            bool result = true;
            for(int i=0; i< trimmedString.Length-2; i+=2)
            {
                result = result && CheckEquality(trimmedString[i+1].ToString(), Convert.ToInt32(trimmedString[i].ToString()), Convert.ToInt32(trimmedString[i+2].ToString()));
            }
            return result;
        }
        public static bool CheckEquality(string _operator, int x, int y)
        {
            switch(_operator)
            {
                case ">": return x > y;
                case "<": return x < y;
                default: throw new Exception("invalid logic");
            }
        }
    }
}
