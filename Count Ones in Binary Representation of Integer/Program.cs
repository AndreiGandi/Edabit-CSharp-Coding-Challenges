using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Ones_in_Binary_Representation_of_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountOnes(999) ➞ 8
            Console.WriteLine(CountOnes(999));
        }
        public static int CountOnes(int i)
        {
            int count = 0;
            string binaryNr = Convert.ToString(i, 2);
            for(int k=0; k<binaryNr.Length; k++)
            {
                if (binaryNr[k] == '1')
                    count++;
            }
            return count;
        }



        ////Algoritm
        //public static int ConvertFromBase10inBaseB(int i, int @base)
        //{
        //    string result = "";
        //    while (i != 0)
        //    {
        //        result += (i % @base).ToString();
        //        i /= @base;

        //    }
        //    return Convert.ToInt32(Reverse(result));
        //}
        //public static string Reverse(string s)
        //{
        //    char[] charArray = s.ToCharArray();
        //    Array.Reverse(charArray);
        //    return new string(charArray);
        //}

        public static int ConvertFromBase10inBaseB(int i, int @base)
        {
            return Convert.ToInt32(Convert.ToString(i, @base));
        }
    }
}
