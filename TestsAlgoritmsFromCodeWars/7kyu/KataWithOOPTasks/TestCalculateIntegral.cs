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
    class TestCalculateIntegral
    {

        [Test]
        [TestCase(0, 1, 0, 1, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 10, ExpectedResult = 10)]
        [TestCase(1, 0, 0, 4, ExpectedResult = 8)]
        [TestCase(2, 0, 2, 4, ExpectedResult = 12)]
        public static double FixedTest(double m, double b, int from, int to)
        {
            CalculateIntegral.LinFunc f = new CalculateIntegral.LinFunc();
            f.M = m;
            f.B = b;
            return f.CalcIntegral(from, to);
        }
    }
}
