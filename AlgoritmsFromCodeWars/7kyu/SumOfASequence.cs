using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class SumOfASequence
    {
        /// <summary>
        /// Your task is to make function, which returns the sum of a sequence of integers.
        /// The sequence is defined by 3 non-negative values: begin, end, step.
        /// If begin value is greater than the end, function should returns 0
        /// Examples
        /// This is the first kata in the series:
        /// 1) Sum of a sequence(this kata)
        /// 2) Sum of a Sequence[Hard - Core Version]
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static int SequenceSum(int start, int end, int step)
        {
            int sum = 0;
            if (start > end) return 0;

            for (int i = start; i <= end; i=i+step)
            {
                sum = sum + i;
            }
            return sum;
        }
        
    }
}
