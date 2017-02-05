using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class FizzBuzzFirstStep
    {
        /// <summary>
        /// Description:
        /// This is the first step to understanding FizzBuzz.
        /// Your inputs: a positive integer, n, greater than or equal to one. n is provided, you have NO CONTROL over its value.
        /// Your expected outputs: an array of positive integers from 1 to n
        /// Your job is to write an algorithm that gets you from the input to the output.
        /// </summary>
        public static int[] PreFizz(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}
