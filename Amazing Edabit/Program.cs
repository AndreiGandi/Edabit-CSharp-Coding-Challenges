using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazing_Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a string and changes the word amazing to not amazing. Return the string without any change if the word edabit is part of the string.
            Console.WriteLine(AmazingEdabit("edabit is amazing.")); //"edabit is amazing."
            Console.WriteLine(AmazingEdabit("Infinity is amazing.")); //"Infinity is not amazing."
        }
        public static string AmazingEdabit(string str)
        {
            string s = "";
            if (str.Contains("edabit")) return str;
            else
            {

                string[] sStr = str.Split(' ');
                sStr[sStr.Length - 1] = "not " + sStr[sStr.Length - 1];
                
                foreach (var item in sStr)
                {
                    s += item+ " ";
                }
            }
            return s.TrimEnd();
            
        }
    }
}
