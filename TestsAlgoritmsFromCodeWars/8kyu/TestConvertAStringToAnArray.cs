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
    class TestConvertAStringToAnArray
    {
        [Test]
        public void _1_Example()
        {
            Assert.AreEqual(new string[] { "Robin", "Singh" }, ConvertAStringToAnArray.StringToArray("Robin Singh"));
        }

        [Test]
        public void _2_Example()
        {
            Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, ConvertAStringToAnArray.StringToArray("I love arrays they are my favorite"));
        }
    }
}
