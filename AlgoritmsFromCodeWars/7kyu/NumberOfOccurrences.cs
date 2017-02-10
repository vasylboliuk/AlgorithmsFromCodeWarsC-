using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class NumberOfOccurrencesSolution
    {
        /// <summary>
        /// The numberOfOccurrences function must return the number of occurrences of an element in an array.
        /// var sample = { 1, 0, 2, 2, 3 };
        /// NumberOfOccurrences(0, sample) == 1;
        /// NumberOfOccurrences(4, sample) == 0;
        /// NumberOfOccurrences(2, sample) == 2;
        /// NumberOfOccurrences(3, sample) == 1;
        /// </summary>
        /// <param name="x"></param>
        /// <param name="xs"></param>
        /// <returns></returns>
        public int NumberOfOccurrences(int x, int[] xs)
        {
            if (xs.Length < 1) return 0;
            int count = 0;
            foreach (var i in xs)
            {
                if (i == x)
                {
                    count++;
                }
            }

            return count;
        }


        public int NumberOfOccurrences2(int x, int[] xs)
        {
            if (xs.Length < 1) return 0;
            return xs.Count(el => el == x);
        }

        public static int NumberOfOccurrences3(int x, int[] xs)
        {
            return xs.Where(i => i.Equals(x)).Count();
        }
    }
}
