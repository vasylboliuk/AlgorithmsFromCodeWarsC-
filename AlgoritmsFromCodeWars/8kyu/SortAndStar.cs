using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class SortAndStar
    {
        /*
         * Description:
         * You will be given an vector of string(s). 
         * You must sort it alphabetically (case-sensitive!!) and then return the first value.
         * The returned value must be a string, and have '***' between each of its letters.
         */
        public static string TwoSort(string[] s)
        {
            Array.Sort(s, StringComparer.Ordinal);
            char[] strArr = s[0].ToCharArray();
            string result = "";
            for (int i = 0; i < strArr.Length; i++)
            {
                if (i != strArr.Length - 1)
                    result = result + strArr[i] + "***";
                else
                    result = result + strArr[i];
            }
            return result;
        }

        //Other Solutions
        public static string TwoSort2(string[] s)
        {
            return string.Join("***", s.OrderBy(a => a, StringComparer.Ordinal).First().ToArray());
        }
    }
}
