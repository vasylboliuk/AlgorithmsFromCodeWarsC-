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
    class TestSumOfASequence
    {

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(SumOfASequence.SequenceSum(2, 6, 2), 12);
            Assert.AreEqual(SumOfASequence.SequenceSum(1, 5, 1), 15);
            Assert.AreEqual(SumOfASequence.SequenceSum(1, 5, 3), 5);
            Assert.AreEqual(SumOfASequence.SequenceSum(0, 15, 3), 45);
            Assert.AreEqual(SumOfASequence.SequenceSum(16, 15, 3), 0);
            Assert.AreEqual(SumOfASequence.SequenceSum(2, 24, 22), 26);
            Assert.AreEqual(SumOfASequence.SequenceSum(2, 2, 2), 2);
            Assert.AreEqual(SumOfASequence.SequenceSum(2, 2, 1), 2);
            Assert.AreEqual(SumOfASequence.SequenceSum(1, 15, 3), 35);
            Assert.AreEqual(SumOfASequence.SequenceSum(15, 1, 3), 0);
        }
    }
}
