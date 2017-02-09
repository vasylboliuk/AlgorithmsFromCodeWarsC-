using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._7kyu;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._7kyu
{
    [TestFixture]
    class TestSortNumbers
    {
        [Test]
        public void BasicTests()
        {
            checkNums(new int[] { 1, 2, 3, 10, 5 }, new int[] { 1, 2, 3, 5, 10 });
            checkNums(null, new int[] { });
            checkNums(new int[] { }, new int[] { });
            checkNums(new int[] { 20, 2, 10 }, new int[] { 2, 10, 20 });
            checkNums(new int[] { 2, 20, 10 }, new int[] { 2, 10, 20 });
            checkNums(new int[] { 2, 10, 20 }, new int[] { 2, 10, 20 });
        }

        private void checkNums(int[] nums, int[] expected)
        {
            var actual = SortNumbersSolution.SortNumbers(nums);

            Assert.AreEqual(expected, actual, nums != null ? "{" + string.Join(",", nums) + "}" : "null");
        }
    }
}
