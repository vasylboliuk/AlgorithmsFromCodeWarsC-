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
    class TestsEvenOrOdd
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", EvanOrOddSolution.EvenOrOdd(2));
            Assert.AreEqual("Odd", EvanOrOddSolution.EvenOrOdd(1));
            Assert.AreEqual("Even", EvanOrOddSolution.EvenOrOdd(0));
            Assert.AreEqual("Odd", EvanOrOddSolution.EvenOrOdd(7));
        }

    }
}
