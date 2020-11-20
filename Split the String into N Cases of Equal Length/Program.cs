using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_the_String_into_N_Cases_of_Equal_Length
{
    //Create a function that accepts string input and int cases as parameters where the string is split into N distinct cases of equal length as shown:
    //SplitNCases("Strengthened", 6) ➞ { "St", "re", "ng", "th", "en", "ed" }
    //SplitNCases("Unscrupulous", 2) ➞ { "Unscru", "pulous" }
    //SplitNCases("Flavorless", 1) ➞ { "Flavorless" }
class Program
    {
        static void Main(string[] args)
        {
            string[] arr = SplitNCases("Strengthened", 6);
        }
        public static string[] SplitNCases(string input, int cases)
        {
            List<string> result = new List<string>();
            if (input.Length % cases != 0) result.Add("Error");
            else
            {
                int n = input.Length / cases;
                while(input.Length != 0)
                {
                    string s = input.Substring(0, n);
                    result.Add(s);
                    input = input.Remove(0, n);
                }
            }



            return result.ToArray();
        }
    }
}
