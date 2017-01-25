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
    class TestConvertNumberToReversedArrayOfDigits
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, ConvertNumberToReversedArrayOfDigits.Digitize(35231));
        }
    }
}
