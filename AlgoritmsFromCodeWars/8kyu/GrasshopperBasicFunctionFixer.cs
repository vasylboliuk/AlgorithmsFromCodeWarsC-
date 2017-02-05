using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class GrasshopperBasicFunctionFixer
    {
        /// <summary>
        /// Fix the function
        /// I created this function to add five to any number that was passed in to it and return the new value.
        /// It doesn't throw any errors but it returns the wrong number.
        /// Can you help me fix the function?
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int AddFive(int num)
        {
            int total = num + 5;
            return total;
        }

    }
}
