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
    class TestVectors1
    {

        [Test]
        [TestCase(0, 2, 0, ExpectedResult = 2)]
        [TestCase(1, 2, 2, ExpectedResult = 3)]
        public static double FixedTest(double x, double y, double z)
        {
            return new Vectors1.Vector3D()
            {
                X = x,
                Y = y,
                Z = z
            }.Length;
        }
    }
}
