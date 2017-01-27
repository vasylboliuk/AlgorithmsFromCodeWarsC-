using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmsFromCodeWars._8kyu;
using NUnit.Framework;


namespace TestsAlgoritmsFromCodeWars._8kyu
{
    [TestFixture]
    class TestRemoveFirstAndLastCharacter
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstAndLastCharacter.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstAndLastCharacter.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstAndLastCharacter.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstAndLastCharacter.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstAndLastCharacter.Remove_char("ok"));
        }
    }
}
