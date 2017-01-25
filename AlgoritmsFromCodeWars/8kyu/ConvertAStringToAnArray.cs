using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class ConvertAStringToAnArray
    {
        /*
         * Description:
         * Write a function to split a string and convert it into an array of words.
         * e.g.
         * string_to_array("Robin Singh") => ["Robin", "Singh"]
         * string_to_array("I love arrays they are my favorite") => ["I", "love", "arrays", "they", "are", "my", "favorite"]
         * Note: in Javascript the function is written in camelCase as 'stringToArray'
         */
        public static string[] StringToArray(string str)
        {
            return str.Split().ToArray();
        }
    }
}
