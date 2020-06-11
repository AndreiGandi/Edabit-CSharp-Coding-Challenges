using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phone_Number_Word_Decoder
{
    class Program
    {
        //TextToNum("123-647-EYES") ➞ "123-647-3937"
        //TextToNum("(325)444-TEST") ➞ "(325)444-8378"
        //TextToNum("653-TRY-THIS") ➞ "653-879-8447"
        //TextToNum("435-224-7613") ➞ "435-224-7613"
        static void Main(string[] args)
        {
            Console.WriteLine(TextToNum("123-647-EYES"));
        }
        public static string TextToNum(string phone)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = phone.ToCharArray();
            foreach(var c in chars)
            {
                if (char.IsLetter(c))
                {
                    if (char.ToUpper(c) == 'A' || char.ToUpper(c) == 'B' || char.ToUpper(c) == 'C')
                        sb.Append(2);
                    if (char.ToUpper(c) == 'D' || char.ToUpper(c) == 'E' || char.ToUpper(c) == 'F')
                        sb.Append(3);
                    if (char.ToUpper(c) == 'G' || char.ToUpper(c) == 'H' || char.ToUpper(c) == 'I')
                        sb.Append(4);
                    if (char.ToUpper(c) == 'J' || char.ToUpper(c) == 'K' || char.ToUpper(c) == 'L')
                        sb.Append(5);
                    if (char.ToUpper(c) == 'M' || char.ToUpper(c) == 'N' || char.ToUpper(c) == 'O')
                        sb.Append(6);
                    if (char.ToUpper(c) == 'P' || char.ToUpper(c) == 'Q' || char.ToUpper(c) == 'R' || char.ToUpper(c) == 'S')
                        sb.Append(7);
                    if (char.ToUpper(c) == 'T' || char.ToUpper(c) == 'U' || char.ToUpper(c) == 'V')
                        sb.Append(8);
                    if (char.ToUpper(c) == 'W' || char.ToUpper(c) == 'X' || char.ToUpper(c) == 'Y' || char.ToUpper(c) == 'Z')
                        sb.Append(9);
                }
                else sb.Append(c);
            }
            return sb.ToString();
        }

        //Using REGEX
        public static string TextToNum_Regex(string phone)
        {
            phone = Regex.Replace(phone, "[ABC]", "2");
            phone = Regex.Replace(phone, "[DEF]", "3");
            phone = Regex.Replace(phone, "[GHI]", "4");
            phone = Regex.Replace(phone, "[JKL]", "5");
            phone = Regex.Replace(phone, "[MNO]", "6");
            phone = Regex.Replace(phone, "[PQRS]", "7");
            phone = Regex.Replace(phone, "[TUV]", "8");
            phone = Regex.Replace(phone, "[WXYZ]", "9");

            return phone;
        }

    }
}
