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
    class TestBuildingBlocks
    {

        [Test]
        public static void ExampleTest()
        {
            BuildingBlocks.Block b = new BuildingBlocks.Block(new int[] { 2, 2, 2 });
            Assert.AreEqual(2, b.GetWidth());
            Assert.AreEqual(2, b.GetLength());
            Assert.AreEqual(2, b.GetHeight());
            Assert.AreEqual(8, b.GetVolume());
            Assert.AreEqual(24, b.GetSurfaceArea());
        }

        [Test]
        public static void ExampleTest2()
        {
            BuildingBlocks.Block b = new BuildingBlocks.Block(new int[] { 2, 4, 6 });
            Assert.AreEqual(2, b.GetWidth());
            Assert.AreEqual(4, b.GetLength());
            Assert.AreEqual(6, b.GetHeight());
            Assert.AreEqual(48, b.GetVolume());
            Assert.AreEqual(88, b.GetSurfaceArea());
        }
    }
}
