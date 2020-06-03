using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_the_Number_Symmetrical
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsSymmetrical(7227) ➞ true
            //IsSymmetrical(12567) ➞ false
            //IsSymmetrical(44444444) ➞ true
            //IsSymmetrical(9939) ➞ false
            //IsSymmetrical(1112111) ➞ true
            Console.WriteLine((IsSymmetrical(12567)));
        }
        public static bool IsSymmetrical(int num)
        {
            string charsNum = num.ToString();
            string firstPart = ""; string secondPart = "";
            if (charsNum.Length % 2 == 0)
            {
                
                for(int i = 0; i<charsNum.Length/2;i++)
                {
                    firstPart += charsNum[i];
                }
                for(int i=charsNum.Length-1; i>= charsNum.Length / 2; i--)
                {
                    secondPart += charsNum[i];
                }
                if (firstPart == secondPart) return true;
            }
            else
            {
                for (int i = 0; i < charsNum.Length / 2; i++)
                {
                    firstPart += charsNum[i];
                }
                for (int i = charsNum.Length - 1; i > charsNum.Length / 2; i--)
                {
                    secondPart += charsNum[i];
                }
                if (firstPart == secondPart) return true;

            }


            return false;
            
        }
    }
}
