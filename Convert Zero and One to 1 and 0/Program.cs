using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Zero_and_One_to_1_and_0
{

    //Create a function that takes a string as an argument.
    //The function must return a string containing 1s and 0s based on the string argument's words. 
    //If any word in the argument is not equal to "zero" or "one" (case insensitive), you should ignore it.
    //The returned string's length should be a multiple of 8, if the string is not a multiple of 8 you should remove the numbers in excess.



    //TextToNumberBinary("zero one zero one zero one zero one") ➞ "01010101"
    //TextToNumberBinary("Zero one zero ONE zero one zero one") ➞ "01010101"
    //TextToNumberBinary("zero one zero one zero one zero one one two") ➞ "01010101"
    //TextToNumberBinary("zero one zero one zero one zero three") ➞ ""
    //TextToNumberBinary("one one") ➞ ""
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero one one two"));
        }
        public static string TextToNumberBinary(string str)
        {
            string binary = "";
            string[] strArr = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach(var item in strArr)
            {
                if (item.ToLower() == "zero")
                    sb.Append("0");
                if (item.ToLower() == "one")
                    sb.Append("1");
            }
            if (sb.Length % 8 == 0)
                binary = sb.ToString();
            else
            {
                while(sb.Length % 8 != 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                binary = sb.ToString();
            }
            return binary;
        }
    }
}
