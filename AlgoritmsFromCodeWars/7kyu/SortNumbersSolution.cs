using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class SortNumbersSolution
    {
        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null || nums.Length < 1) return new int[] {};
            Array.Sort(nums);

            return nums;
        }
    }
}
