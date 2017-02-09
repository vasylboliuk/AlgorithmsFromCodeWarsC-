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
    class TestMOD256WithoutTheMODOperator
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(254, MOD256WithoutTheMODOperator.Mod256WithoutMod(254));
            Assert.AreEqual(0, MOD256WithoutTheMODOperator.Mod256WithoutMod(256));
            Assert.AreEqual(2, MOD256WithoutTheMODOperator.Mod256WithoutMod(258));

            Assert.AreEqual(-254, MOD256WithoutTheMODOperator.Mod256WithoutMod(-254));
            Assert.AreEqual(0, MOD256WithoutTheMODOperator.Mod256WithoutMod(-256));
            Assert.AreEqual(-2, MOD256WithoutTheMODOperator.Mod256WithoutMod(-258));
        }
    }
}
