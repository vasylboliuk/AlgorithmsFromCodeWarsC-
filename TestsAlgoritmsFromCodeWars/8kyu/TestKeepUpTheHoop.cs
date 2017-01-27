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
    class TestKeepUpTheHoop
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("Keep at it until you get it", KeepUpTheHoop.HoopCount(6), "Should work for 6");
            Assert.AreEqual("Great, now move on to tricks", KeepUpTheHoop.HoopCount(22), "Should work for 22");
        }
    }
}
