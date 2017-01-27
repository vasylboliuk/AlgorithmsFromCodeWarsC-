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
    class TestLargestSquareInsideACircle
    {
        [Test]
        public void AreaLargestSquareTest()
        {
            LargestSquareInsideACircle source = new LargestSquareInsideACircle();

            Assert.AreEqual(50, source.AreaLargestSquare(5));
            Assert.AreEqual(98, source.AreaLargestSquare(7));
            Assert.AreEqual(450, source.AreaLargestSquare(15));
        }
    }
}
