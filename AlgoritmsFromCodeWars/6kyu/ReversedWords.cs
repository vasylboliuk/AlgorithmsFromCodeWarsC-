using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._6kyu
{
    public class ReversedWords
    {
        /// <summary>
        /// Complete the solution so that it reverses all of the words within the string passed in.
        /// Example:
        /// Kata.ReverseWords("The greatest victory is that which requires no battle");
        /// // should return "battle no requires which that is victory greatest The"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseWords(string str)
        {
            return String.Join(" ", str.Split().Reverse());
        }

        public string ReverseWords2(string str)
        {
            string sReturn = "";
            var split = str.Split(' ');
            for (int i = split.Length - 1; i >= 0; i--)
            {
                sReturn += split[i];
                if (i > 0)
                {
                    sReturn += " ";
                }
            }
            return sReturn;
        }

    }
}
