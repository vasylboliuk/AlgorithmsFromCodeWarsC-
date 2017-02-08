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
    class TestSimpleExtensionMethods
    {

        [Test]
        public void ExampleTests()
        {
            const string name = "Alex";
            Assert.AreEqual("Hello, Alex!", name.SayHello());
            Assert.AreEqual("Goodbye, Alex. See you again soon!", name.SayGoodbye());
        }
    }
}
