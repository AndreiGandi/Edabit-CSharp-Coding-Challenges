using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Number_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string text = "202044l990544l992255q7755q7755q775qx55q7755q7755q777CVr22O8855q77u55q7755q7755q775qx55q7755q7755q7720s55q7755q7755q7755q775qx55q7755q7755q7720vin55q7755q7755q775qx55q7755q7755q7720l55q7755q7755q7755q775qx55q7755q7755q7720birou.55q7755q7755q775qx55q7755q7755q777Cflorin.d55q77sc55q77l55q77ch22O8855q7755q7755q775qx55q7755q7755q7740dyn55q77mixrm.ro";
            Console.WriteLine(Decode(text));
        }
        //FormatPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]) ➞ "(123) 456-7890"
        public static string FormatPhoneNumber(int[] numbers)
        {
            string phoneNr = "";
            phoneNr = $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
            return phoneNr;
        }
        public static string Decode(string codedText)
        {

            string decodedText = "";
            decodedText = codedText.Replace("22O88", "e").Replace("44l99", "-").Replace("55q77", "a").Replace("aaa5qxaaa", "%");
            return decodedText;
        }
    }
}
