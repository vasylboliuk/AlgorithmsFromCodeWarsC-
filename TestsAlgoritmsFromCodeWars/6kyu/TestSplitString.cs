using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._6kyu;
using NUnit.Framework;

namespace TestsAlgoritmsFromCodeWars._6kyu
{
    [TestFixture]
    class TestSplitString
    {
        SplitString SplitString = new SplitString();

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}
