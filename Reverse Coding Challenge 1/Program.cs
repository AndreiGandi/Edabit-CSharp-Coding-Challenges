using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Coding_Challenge_1
{
    class Program
    {

        //"A4B5C2" ➞ "AAAABBBBBCC"
        //"C2F1E5" ➞ "CCFEEEEE"
        //"T4S2V2" ➞ "TTTTSSVV"
        //"A1B2C3D4" ➞ "ABBCCCDDDD"
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc("C2F1E5"));
        }
        public static string MysteryFunc(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i<str.Length; i+=2)
            {
                int k = Convert.ToInt32(str[i].ToString());
                for (int j=1; j<=k; j++)
                {
                    sb.Append(str[i - 1]);
                }
            }
            return sb.ToString();
        }
    }
}
