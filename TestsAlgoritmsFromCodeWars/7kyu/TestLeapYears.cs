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
    public class TestLeapYears
    {
        static LeapYear leapYear = new LeapYear();

        [Test]
        public static void Year1234()
        {
            Assert.AreEqual(false, leapYear.IsLeapYear(1234), "Year 1234");
        }

        [Test]
        public static void Year1984()
        {
            Assert.AreEqual(true, leapYear.IsLeapYear(1984), "Year 1984");
        }

        [Test]
        public static void Year2000()
        {
            Assert.AreEqual(true, leapYear.IsLeapYear(2000), "Year 2000");
        }

        [Test]
        public static void Year2010()
        {
            Assert.AreEqual(false, leapYear.IsLeapYear(2010), "Year 2010");
        }

        [Test]
        public static void Year2013()
        {
            Assert.AreEqual(false, leapYear.IsLeapYear(2013), "Year 2013");
        }
    }
}
