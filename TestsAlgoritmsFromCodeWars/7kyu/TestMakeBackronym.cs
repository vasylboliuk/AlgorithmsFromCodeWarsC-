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
    class TestMakeBackronym
    {
        MakeBackronymSolution Kata = new MakeBackronymSolution();

        [Test]
        public void TestExample1()
        {
            Assert.AreEqual("ingestable newtonian turn eager rant eager stylish turn ingestable newtonian gregarious",
              Kata.MakeBackronym("interesting"));
        }

        [Test]
        public void TestExample2()
        {

            Assert.AreEqual("confident oscillating disturbing eager weird awesome rant stylish",
              Kata.MakeBackronym("codewars"));
        }
    }
}
