using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class ReplaceEveryNth
    {
        /// <summary>
        /// Replace every nth
        /// Write a method, that replaces every nth char oldValue with char newValue.
        /// Method:
        /// ReplaceNth(string text, int n, char oldValue, char newValue)
        /// Example:
        /// n:         2
        /// ldValue: 'a'
        /// newValue: 'o'
        /// "Vader said: No, I am your father!" -> "Vader soid: No, I am your fother!"
        /// 1     2          3        4       -> 2nd and 4th occurence are replaced
        /// Your method has to be case sensitive!
        /// As you can see in the example: The first changed is the 2nd 'a'. 
        /// So the start is always at the nth suitable char and not at the first!
        /// If n is 0 or negative or if it is larger than the count of the oldValue, 
        /// return the original text without a change.
        /// The text and the chars will never be null.
        /// Have fun coding it and please don't forget to vote and rank this kata! :-)
        /// I have created other katas.Have a look if you like coding and challenges.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="n"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceNth(string text, int n, char oldValue, char newValue)
        {
            if (n < 1) return text;

            var list = text.ToCharArray();
            int count = 0;
            for (var i = 0; i < list.Length; i++)
            {
                if (list[i] == oldValue)
                {
                    count++;
                }
                if (list[i] == oldValue && count % n == 0)
                {
                    list[i] = newValue;
                }
                
            }
           
            return String.Join("", list);
        }

        public static string ReplaceNth2(string text, int n, char oldValue, char newValue)
        {
            if (n < 1) return text;
            int cnt = 1;
            return string.Join("", text.Select(c => (c == oldValue && cnt++ % n == 0) ? newValue : c));
        }
    }
}
