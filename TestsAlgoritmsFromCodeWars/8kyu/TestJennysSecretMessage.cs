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
    class TestJennysSecretMessage
    {
        [Test]
        public static void ShouldGreetJimNormally()
        {
            Assert.AreEqual("Hello, Jim!", JennysSecretMessage.greet("Jim"));
        }
        [Test]
        public static void ShouldGreetJaneNormally()
        {
            Assert.AreEqual("Hello, Jane!", JennysSecretMessage.greet("Jane"));
        }
        [Test]
        public static void ShouldGreetSimonNormally()
        {
            Assert.AreEqual("Hello, Simon!", JennysSecretMessage.greet("Simon"));
        }

        [Test]
        public static void ShouldGreetJohnnySpecially()
        {
            Assert.AreEqual("Hello, my love!", JennysSecretMessage.greet("Johnny"));
        }
    }
}
