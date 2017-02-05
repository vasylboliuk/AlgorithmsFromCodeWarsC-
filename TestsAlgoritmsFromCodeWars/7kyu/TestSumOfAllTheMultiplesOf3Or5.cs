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
    class TestSumOfAllTheMultiplesOf3Or5
    {

        [Test]
        public void MyTest()
        {
            Assert.AreEqual(8, SumOfAllTheMultiplesOf3Or5.FindSum(5));
            Assert.AreEqual(33, SumOfAllTheMultiplesOf3Or5.FindSum(10));
        }
    }
}
