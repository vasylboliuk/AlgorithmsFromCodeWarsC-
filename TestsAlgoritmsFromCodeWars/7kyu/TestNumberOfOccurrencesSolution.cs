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
    class TestNumberOfOccurrencesSolution
    {
        NumberOfOccurrencesSolution OccurrencesKata = new NumberOfOccurrencesSolution();

        [Test]
        public void Should_Work_On_Examples()
        {
            var example = new int[] { 4, 0, 4 };

            Assert.AreEqual(2, OccurrencesKata.NumberOfOccurrences(4, example));

            Assert.AreEqual(0, OccurrencesKata.NumberOfOccurrences(1, example));

            Assert.AreEqual(1, OccurrencesKata.NumberOfOccurrences(0, example));
        }
    }
}
