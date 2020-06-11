using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_to_Hex
{
    class Program
    {
        //ConvertToHex("hello world") ➞ "68 65 6c 6c 6f 20 77 6f 72 6c 64"
        //ConvertToHex("Big Boi") ➞ "42 69 67 20 42 6f 69"
        //ConvertToHex("Marty Poppinson") ➞ "4d 61 72 74 79 20 50 6f 70 70 69 6e 73 6f 6e"
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToHex("25"));
        }
        //public static string ConvertToHex(string inputword)
        //{
        //    string hex = "";
        //    char[] chars = inputword.ToCharArray();
        //    foreach(var c in chars)
        //    {
        //        int value = Convert.ToInt32(c);
        //        hex += String.Format("{0:x}", value)+" ";
        //    }
        //    return hex.TrimEnd(' ');
        //}
        public static string ConvertToHex(string inputword)
        {
            byte[] ba = Encoding.Default.GetBytes(inputword);
            var hexString = BitConverter.ToString(ba).ToLower();
            return hexString.Replace("-", " ");
        }
    }
}
