using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class RemoveFirstAndLastCharacter
    {
        /*
         * Description:
         * It's pretty straightforward. Your goal is to create a function that removes the first and 
         * last characters of a string. You're given one parameter.
         */
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
