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
    class TestTriangularTreasure
    {

        [Test]
        public static void TriangularTwoShouldBeThree()
        {
            Assert.AreEqual(3, TriangularTreasure.Triangular(2));
        }

        [Test]
        public static void TriangularFourShouldBeTen()
        {
            Assert.AreEqual(10, TriangularTreasure.Triangular(4));
        }
    }
}
