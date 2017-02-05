using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class SumOfAllTheMultiplesOf3Or5
    {

        // Sum of all the multiples of 3 or 5
        /// <summary>
        /// Sum of all the multiples of 3 or 5
        /// Your task is to write function findSum.
        /// Upto and including n, this function will return the sum of all multiples of 3 and 5.
        /// For example:
        /// indSum(5) should return 8 (3 + 5)
        /// findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FindSum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public static int FindSum2(int n)
        {
            return Enumerable.Range(1, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }

    }
}
