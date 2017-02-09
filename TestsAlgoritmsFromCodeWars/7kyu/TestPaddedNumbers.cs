using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._7kyu
{
    [TestFixture]
    public class TestSubstitutingVariablesIntoStringsPaddedNumbers
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Value is 00005", PaddedNumbers.Solution(5));
            Assert.AreEqual("Value is 05000", PaddedNumbers.Solution(5000));
        }
    }
}
