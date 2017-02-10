using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._6kyu
{
    public class SplitString
    {

        /// <summary>
        /// Complete the solution so that it splits the string into pairs of two characters. 
        /// If the string contains an odd number of characters then it should replace the missing second character of
        ///  the final pair with an underscore ('_').
        /// Examples:
        /// SplitString.Solution("abc"); // should return ["ab", "c_"]
        /// SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"] 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string[] Solution(string str)
        {
            if (str.Length%2 != 0) str = str + "_";
            List<string> strList = new List<string>();
            int len = str.Length;

            for (int i = 2; i <= len; i=i+2)
            {
                strList.Add(str.Substring(i-2, 2));
            }

            return strList.ToArray();
        }

        public static string[] Solution2(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";
            return Enumerable.Range(0, str.Length)
              .Where(x => x % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();
        }
    }
}
