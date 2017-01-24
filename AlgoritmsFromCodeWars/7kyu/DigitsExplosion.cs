using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars
{
    public class DigitsExplosion
    {
        /*
         * Description:
         * Given a string made of digits [0-9] returns a string where each digit is repeated a number of times equals to its value.
         * Examples
         * s = "312"
         * Digits.Explode(s) = "333122"
         * s = "102269"
         * Digits.Explode(s) = "12222666666999999999"
         */
        public static string Explode(string s)
        {
            string newStr = "";

            foreach (char str in s)
            {
                int num = (int)Char.GetNumericValue(str);
                for (int i = 1; i <= num; i++)
                {
                    newStr = newStr + num;
                }
            }
            return newStr;
        }

    }
}
