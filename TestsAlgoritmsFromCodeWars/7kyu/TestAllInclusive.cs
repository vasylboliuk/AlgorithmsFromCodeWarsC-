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
    class TestAllInclusive
    {
        private static void testing(Boolean actual, Boolean expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Basic Tests ContainAllRots");
            List<string> a = new List<string>() { "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" };
            testing(AllInclusive.ContainAllRots("bsjq", a), true);

            a = new List<string>() { };
            testing(AllInclusive.ContainAllRots("", a), true);

            a = new List<string>() { "bsjq", "qbsj" };
            testing(AllInclusive.ContainAllRots("", a), true);

            a = new List<string>() { "TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY" };
            testing(AllInclusive.ContainAllRots("XjYABhR", a), false);
        }

    }
}
