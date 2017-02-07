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
    class TestReplaceEveryNth
    {

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Vader soid: No, I am your fother!", ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 2, 'a', 'o'));
            Assert.AreEqual("Vader said: No, I am your fother!", ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 4, 'a', 'o'));
            Assert.AreEqual("Vader said: No, I am your father!", ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 6, 'a', 'o'));
            Assert.AreEqual("Vader said: No, I am your father!", ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 0, 'a', 'o'));
            Assert.AreEqual("Vader said: No, I am your father!", ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", -2, 'a', 'o'));
            Assert.AreEqual("Vader sayd: No, I am your father!", ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 1, 'i', 'y'));

            Assert.AreEqual("Luke cries: Noooooioooooioooo!", ReplaceEveryNth.ReplaceNth("Luke cries: Noooooooooooooooo!", 6, 'o', 'i'));
        }
    }
}
