using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._8kyu;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._8kyu
{
    [TestFixture]
    class TestSortAndStar
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("b***i***t***c***o***i***n", SortAndStar.TwoSort(new[] { "bitcoin", "take", "over", "the", "world", "maybe", "who", "knows", "perhaps" }));
            Assert.AreEqual("a***r***e", SortAndStar.TwoSort(new[] { "turns", "out", "random", "test", "cases", "are", "easier", "than", "writing", "out", "basic", "ones" }));
        }
    }
}
