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
    class TestEvenOrOdd
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", EvenOrOddSolution.EvenOrOdd(2));
            Assert.AreEqual("Odd", EvenOrOddSolution.EvenOrOdd(1));
            Assert.AreEqual("Even", EvenOrOddSolution.EvenOrOdd(0));
            Assert.AreEqual("Odd", EvenOrOddSolution.EvenOrOdd(7));
        }

    }
}
