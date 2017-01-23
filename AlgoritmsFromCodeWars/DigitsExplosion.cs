using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars
{
    class DigitsExplosion
    {
        static void Main(string[] args)
        {
        }

        
        /*
         * 
         * 
         */
        public static string Explode(string s)
        {
            string newStr = "";
            foreach (char str in s)
            {
                int num = (int)Char.GetNumericValue(str);
                for (int i = 1; i <= num; i++)
                {
                    newStr = newStr + num;
                }
            }
            return newStr;
        }

    }
}
