using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class ConvertNumberToReversedArrayOfDigits
    {
        /*
         * Description:
         * Convert number to reversed array of digits
         * Given a random number:
         * C#: long;
         * C++: unsigned long;
         * You have to return the digits of this number within an array in reverse order.
         * Example:
         * 348597 => [7,9,5,8,4,3]
         */
        public static long[] Digitize(long n)
        {
            char[] strArray = n.ToString().ToCharArray();
            List<long> result = new List<long>();
            for (int i= strArray.Length-1; i>=0; i--)
            {
                result.Add((long)Char.GetNumericValue(strArray[i]));
                
            }
            return result.ToArray();

            
            // return string.Join("***", s.OrderBy(a => , StringComparer.Ordinal).First().ToArray());


        }
    }
}
