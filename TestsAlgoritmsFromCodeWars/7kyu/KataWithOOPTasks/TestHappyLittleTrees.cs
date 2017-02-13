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
    class TestHappyLittleTrees
    {

        [Test]
        public static void EmptyTree()
        {
            Tree happy = new Tree();
            Console.WriteLine(happy.Description());
            Assert.AreEqual("The tree trunk is 1 unit(s) tall! There are 0 branch(es)!", happy.Description());
        }
        [Test]
        public static void BadTree()
        {
            Tree happy = new Tree();
            happy.GrowBranches();
            happy.Ouch(1);
            happy.GrowTrunk();
            Console.WriteLine(happy.Description());
            Assert.AreEqual("The tree trunk is 2 unit(s) tall! There are 0 branch(es)!", happy.Description());
        }

        [Test]
        public static void GrownTree()
        {
            Tree happy = new Tree();
            happy.NewBranch();
            happy.GrowTrunk();
            happy.GrowBranches();
            happy.GrowTrunk();
            happy.NewBranch();
            happy.NewBranch();
            happy.NewBranch();
            happy.NewBranch();
            happy.GrowBranches();
            happy.Ouch(3);
            happy.GrowTrunk();
            happy.GrowTrunk();
            happy.NewBranch();
            happy.GrowBranches();
            Console.WriteLine(happy.Description());
            Assert.AreEqual("The tree trunk is 5 unit(s) tall! There are 5 branch(es) that have position(s): 1,3,3,3,5 and length(s): 4,3,3,3,2!", happy.Description());
        }


        [Test]
        public static void MyTree()
        {
            Tree happy = new Tree();
            happy.NewBranch();
            happy.NewBranch();
            happy.GrowTrunk();
            Console.WriteLine(happy.Description());
            Assert.AreEqual("The tree trunk is 2 unit(s) tall! There are 2 branch(es) that have position(s): 1,1 and length(s): 1,1!", happy.Description());
        }

        [Test]
        public static void BadTree2()
        {
            Tree happy = new Tree();
            happy.GrowBranches();
            happy.Ouch(-200);
            happy.GrowTrunk();
            Console.WriteLine(happy.Description());
            Assert.AreEqual("The tree trunk is 2 unit(s) tall! There are 0 branch(es)!", happy.Description());
        }
    }
}
