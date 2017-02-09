using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._7kyu
{
    public class PaddedNumbers
    {

        /// <summary>
        /// Complete the solution so that it returns a formatted string. The return value should equal 
        /// "Value is VALUE" where value is a 5 digit padded number. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Solution(int value)
        {
            string str = value.ToString();

            while (str.Length < 5)
            {
                str = 0 + str;
            }
            return "Value is " + str;
        }

        public static string Solution2(int value)
        {
            return "Value is " + value.ToString().PadLeft(5, '0');
        }

        public static string Solution3(int value)
        {
            return "Value is " + value.ToString("00000");
        }
    }
}
