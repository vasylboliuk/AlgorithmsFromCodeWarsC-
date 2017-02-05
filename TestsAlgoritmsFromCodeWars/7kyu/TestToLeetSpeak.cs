using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._7kyu;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestsAlgoritmsFromCodeWars._7kyu
{
    [TestFixture]
    class TestToLeetSpeak
    {

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1337", ToLeetSpeakClass.ToLeetSpeak("LEET"));
            Assert.AreEqual("(0D3W@R$", ToLeetSpeakClass.ToLeetSpeak("CODEWARS"));
            Assert.AreEqual("#3110 W0R1D", ToLeetSpeakClass.ToLeetSpeak("HELLO WORLD"));
            Assert.AreEqual("10R3M !P$UM D010R $!7 @M37", ToLeetSpeakClass.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"));
            Assert.AreEqual("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06", ToLeetSpeakClass.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
        }
    }
}
