using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class ReversingWordsInAString
    {
        /*
         *  Description:
         *  You need to write a function that reverses the words in a given string. 
         *  A word can also fit an empty string. If this is not clear enough, here are some examples:
         *  Kata.Reverse("Hello World"); // -> "World Hello"
         *  Kata.Reverse("Hi There."); // -> "There. Hi"
         *  
         */
        public static string Reverse(string text)
        {
            string[] list = text.Split(' ');
            string result = "";
            for (int i = list.Length-1; i >= 0; i--)
            {
                result = result + list[i] + " ";
            }
            return result.Trim();
        }

        //Other solutions
        public static string Reverse2(string text)
        {

            return string.Join(" ", text.Split(' ').Reverse().ToArray());
        }
    }
}
