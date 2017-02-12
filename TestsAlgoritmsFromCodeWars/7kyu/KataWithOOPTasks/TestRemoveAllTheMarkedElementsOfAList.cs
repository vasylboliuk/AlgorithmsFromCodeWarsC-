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
    class TestRemoveAllTheMarkedElementsOfAList
    {
        RemoveAllTheMarkedElementsOfAList Kata = new RemoveAllTheMarkedElementsOfAList();

        [Test]
        [TestCase(new int[] { 1, 1, 2, 3, 1, 2, 3, 4 }, new int[] { 1, 3 }, ExpectedResult = new int[] { 2, 2, 4 })]
        [TestCase(new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 }, new int[] { 1, 3, 4, 2 }, ExpectedResult = new int[] { 5, 6, 7, 8 })]
        [TestCase(new int[] { }, new int[] { 2, 2, 4, 3 }, ExpectedResult = new int[] { })]
        public int[] FixedTest(int[] integerList, int[] valuesList)
        {
            return Kata.Remove(integerList, valuesList);
        }
    }
}
