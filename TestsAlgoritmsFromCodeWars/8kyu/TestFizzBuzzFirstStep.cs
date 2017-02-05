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
    class TestFizzBuzzFirstStep
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1 }, FizzBuzzFirstStep.PreFizz(1), "Array should be from 1 to 1");
            Assert.AreEqual(new int[] { 1, 2 }, FizzBuzzFirstStep.PreFizz(2), "Array should be from 1 to 2");
            Assert.AreEqual(new int[] { 1, 2, 3 }, FizzBuzzFirstStep.PreFizz(3), "Array should be from 1 to 3");
            Assert.AreEqual(new int[] { 1, 2, 3, 4 }, FizzBuzzFirstStep.PreFizz(4), "Array should be from 1 to 4");
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, FizzBuzzFirstStep.PreFizz(5), "Array should be from 1 to 5");
        }
    }
   
}
