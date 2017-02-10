using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class TriangularTreasure
    {
        /// <summary>
        /// Triangular numbers are so called because of the equilateral triangular shape that they occupy when laid out as dots. i.e.
        /// 1st(1)   2nd(3)    3rd(6)
        /// *          **        ***
        ///             *         **
        ///                        *
        /// You need to return the nth triangular number.You should return 0 for out of range values:
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Triangular(int n)
        {
            int k=0;

            for (int j = 1; j <= n; j++)
            {
                k = k + j;
            }
            return k;
        }

        // Variant 2
        public static int Triangular2(int n)
        {
            return n < 0 ? 0 : n * (n + 1) / 2;
        }

        // Varian 3
        public static int Triangular3(int n)
        {
            return (n > 0) ? Enumerable.Range(1, n).Sum() : 0;
        }
    }
}
