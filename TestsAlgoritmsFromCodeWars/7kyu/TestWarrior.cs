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
    class TestWarrior
    {
        private Warrior ninja = new Warrior("Ninja");
        private Warrior samurai = new Warrior("Samurai");

        [Test]
        public void Tests()
        {
            samurai.Strike(ninja, 4);
            Assert.AreEqual(60, ninja.Health);
        }
    }
}
