using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTF_8_BOM_Text_Encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //string unicodeString = "This Unicode string has 2 characters outside the " +
            //                        "ASCII range:\n" +
            //                        "Pi (\u03a0), and Sigma (\u03a3).";
            //byte[] encoded = GetUTF8BOM(unicodeString);
        }
        //public static byte[] GetUTF8BOM(string unicodeString)
        //{
        //    UTF8Encoding utf8 = new UTF8Encoding();
        //    Byte[] encodedBytes = utf8.GetBytes(unicodeString);

        //    return encodedBytes;
        //}

        public static byte[] GetUTF8BOM()
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding(true);
            return uTF8Encoding.GetPreamble();
        }
    }
}
