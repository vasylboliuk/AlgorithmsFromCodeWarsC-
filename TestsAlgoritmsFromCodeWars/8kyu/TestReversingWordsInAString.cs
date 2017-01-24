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
    class TestReversingWordsInAString
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("World Hello", ReversingWordsInAString.Reverse("Hello World"));
            Assert.AreEqual("There. Hi", ReversingWordsInAString.Reverse("Hi There."));
            Assert.AreEqual("this at expert an am I", ReversingWordsInAString.Reverse("I am an expert at this"));
        }
    }
}
