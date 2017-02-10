using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._6kyu
{
    public class ReversedWords
    {

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
