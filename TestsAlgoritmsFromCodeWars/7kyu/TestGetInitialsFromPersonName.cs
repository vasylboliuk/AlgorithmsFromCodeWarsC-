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
    class TestGetInitialsFromPersonName
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(GetInitialsFromPersonName.ToInitialsLinq("Kerry King"), "K. K.");
            Assert.AreEqual(GetInitialsFromPersonName.ToInitialsLinq("Tom Araya"), "T. A.");
            Assert.AreEqual(GetInitialsFromPersonName.ToInitialsLinq("Kerry King Kingrosovich"), "K. K. K.");
        }

    }
}
