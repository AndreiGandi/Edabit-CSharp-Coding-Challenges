using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_One_String_in_the_Other
{
    class Program
    {

        //Overlap("ABC", "Ican'tsingmyABC") ➞ true
        //Overlap("abc", "Ican'tsingmyABC") ➞ true
        //Overlap("Ican'tsingmyABC", "abc") ➞ true
        //Overlap("hello world", "hello") ➞ false
        //Overlap("+=", "this should work too +=") ➞ true
        //Overlap("hey", "*********") ➞ true
        static void Main(string[] args)
        {
            Console.WriteLine(Overlap("ab", "Ican'tsingmy**c"));
        }
        public static bool Overlap(string str1, string str2)
        {
            if (
                (str2.ToLower()).EndsWith(str1.ToLower()) || (str1.ToLower()).EndsWith(str2.ToLower())
                )
                return true;
            return false;
        }
    }
}
