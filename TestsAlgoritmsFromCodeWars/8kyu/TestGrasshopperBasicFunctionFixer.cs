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
    class TestGrasshopperBasicFunctionFixer
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(6, GrasshopperBasicFunctionFixer.AddFive(1));
            Assert.AreEqual(20, GrasshopperBasicFunctionFixer.AddFive(15));
            Assert.AreEqual(5, GrasshopperBasicFunctionFixer.AddFive(0));
           
        }
    }
}
