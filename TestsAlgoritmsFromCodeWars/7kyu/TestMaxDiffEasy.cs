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
    class TestMaxDiffEasy
    {

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] { 0, 1, 2, 3, 4, 5, 6 }), 6);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] { -0, 1, 2, -3, 4, 5, -6 }), 11);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] { 0, 1, 2, 3, 4, 5, 16 }), 16);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new[] { 16 }), 0);
            Assert.AreEqual(MaxDiffEasy.maxDiff(new int[] { }), 0);
        }
    }
}
