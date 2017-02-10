using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._6kyu;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._6kyu
{
    [TestFixture]
    class TestSumMultiplesOf3and5
    {
       SumMultiplesOf3and5 SumMultiplesOf3and5 = new SumMultiplesOf3and5();


        [Test]
        public void Test()
        {
            Assert.AreEqual(23, SumMultiplesOf3and5.Solution(10));
        }
    }
}
