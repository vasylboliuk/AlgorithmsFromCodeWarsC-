using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    [TestFixture]
    class TestPlayingWithCubesIII
    {

        [Test]
        public static void TestGetAccessor()
        {
            PlayingWithCubesIII.Cube c = new PlayingWithCubesIII.Cube();
            Assert.AreEqual(0, c.Side, "The get-accessor should return 0");
        }

        [Test]
        public static void TestSetAccessor()
        {
            PlayingWithCubesIII.Cube c = new PlayingWithCubesIII.Cube();
            c.Side = 5;
            Assert.AreEqual(5, c.Side, "The set-accessor should have changed Side to 5");
        }

        [Test]
        public static void TestSetAccessor2()
        {
            PlayingWithCubesIII.Cube c = new PlayingWithCubesIII.Cube();
            c.Side = -8;
            Assert.AreEqual(8, c.Side, "The set-accessor should have changed Side to 5");
        }
    }
}
