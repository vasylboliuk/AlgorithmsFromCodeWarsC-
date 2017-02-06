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
    class TestTemperatureAanalysisI
    {

        [Test]
        public void MyTest()
        {
            Assert.AreEqual(-8, TemperatureAanalysisI.LowestTemperature("-1 50 -4 20 22 -7 0 10 -8"));
            Assert.AreEqual(10, TemperatureAanalysisI.LowestTemperature("10 50 12 20 22 13 20 100 18"));
            Assert.AreEqual(-1, TemperatureAanalysisI.LowestTemperature("-1 50 16 20 22 1 0 10 34"));
            Assert.AreEqual(-2, TemperatureAanalysisI.LowestTemperature("-2 3 -1 12 45 14"));
            Assert.AreEqual(null, TemperatureAanalysisI.LowestTemperature(""));
        }
    }
}
