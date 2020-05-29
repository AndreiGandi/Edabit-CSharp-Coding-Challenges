using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PIN_Code_Validation
{
    class Program
    {
        //ValidatePIN("1234") ➞ true
        //ValidatePIN("12345") ➞ false
        //ValidatePIN("a234") ➞ false
        //ValidatePIN("") ➞ false
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePIN(""));
        }
        public static bool ValidatePIN(string pin)
        {
            bool onlyDigits = true;
            for(int i = 0; i<pin.Length; i++)
            {
                if (!Char.IsDigit(pin[i]))
                    onlyDigits = false;
            }
            if (onlyDigits && (pin.Length == 4 || pin.Length == 6))
                return true;
            return false;
        }
    }
}
