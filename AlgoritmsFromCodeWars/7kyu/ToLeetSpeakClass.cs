using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class ToLeetSpeakClass
    {
        /// <summary>
        /// Your task is to write function toLeetSpeak that converts a regular english sentence to Leetspeak.
        /// More about LeetSpeak You can read at wiki -> https://en.wikipedia.org/wiki/Leet
        /// Consider only uppercase letters(no lowercase letters, no numbers) and spaces.
        /// For example:
        /// toLeetSpeak("LEET") returns "1337"
        /// In this kata we use a simple LeetSpeak dialect.Use this alphabet:
        /// {
        /// A : '@',
        /// B : '8',
        /// C : '(',
        /// D : 'D',
        /// E : '3',
        /// F : 'F',
        /// G : '6',
        /// H : '#',
        /// I : '!',
        /// J : 'J',
        /// K : 'K',
        /// L : '1',
        /// M : 'M',
        /// N : 'N',
        /// O : '0',
        /// P : 'P',
        /// Q : 'Q',
        /// R : 'R',
        /// S : '$',
        /// T : '7',
        /// U : 'U',
        /// V : 'V',
        /// W : 'W',
        /// X : 'X',
        /// Y : 'Y',
        /// Z : '2'
        /// }
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToLeetSpeak(string str)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', '@');
            dict.Add('B', '8');
            dict.Add('C', '(');
            dict.Add('D', 'D');
            dict.Add('E', '3');
            dict.Add('F', 'F');
            dict.Add('G', '6');
            dict.Add('H', '#');
            dict.Add('I', '!');
            dict.Add('J', 'J');
            dict.Add('K', 'K');
            dict.Add('L', '1');
            dict.Add('M', 'M');
            dict.Add('N', 'N');
            dict.Add('O', '0');
            dict.Add('P', 'P');
            dict.Add('Q', 'Q');
            dict.Add('R', 'R');
            dict.Add('S', '$');
            dict.Add('T', '7');
            dict.Add('U', 'U');
            dict.Add('V', 'V');
            dict.Add('W', 'W');
            dict.Add('X', 'X');
            dict.Add('Y', 'Y');
            dict.Add('Z', '2');

            string result = str;
            foreach (char ch in str)
            {
                if(!ch.Equals(' '))
                {
                    result = result.Replace(ch, dict[ch]);
                }
            }
            
            return result;
        }

        public static string ToLeetSpeak2(string str)
        {
            Dictionary<char, char> leetChars = new Dictionary<char, char>
            {
                ['A'] = '@',
                ['B'] = '8',
                ['C'] = '(',
                ['D'] = 'D',
                ['E'] = '3',
                ['F'] = 'F',
                ['G'] = '6',
                ['H'] = '#',
                ['I'] = '!',
                ['J'] = 'J',
                ['K'] = 'K',
                ['L'] = '1',
                ['M'] = 'M',
                ['N'] = 'N',
                ['O'] = '0',
                ['P'] = 'P',
                ['Q'] = 'Q',
                ['R'] = 'R',
                ['S'] = '$',
                ['T'] = '7',
                ['U'] = 'U',
                ['V'] = 'V',
                ['W'] = 'W',
                ['X'] = 'X',
                ['Y'] = 'Y',
                ['Z'] = '2'
            };

            return string.Concat(str.Select(c => leetChars.ContainsKey(c) ? leetChars[c] : c));
        }
    }
}
