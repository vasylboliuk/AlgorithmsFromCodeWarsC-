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
    class TestRevealSpyIdentity
    {
        [Test]
        public void test1()
        {
            Human person = new Police();
            person.Name = "John";
            Assert.AreEqual("John is a Police", RevealSpyIdentity.FindHisIdentity(person));
        }
    }
}
