using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    class HappyLittleTrees2Solution
    {
    }

    public class Tree2 : ITree
    {

        int treeHeight = 1;
        List<Branch> branches = new List<Branch>();

        private class Branch
        {
            public int Position { get; set; }
            public int BranchLength { get; set; }

            public Branch(int position, int branchLength = 1)
            {
                Position = position;
                BranchLength = branchLength;
            }

        }

        public void GrowTrunk()
        {
            treeHeight++;
        }

        public void NewBranch()
        {
            branches.Add(new Branch(treeHeight));
        }

        public void GrowBranches()
        {
            foreach (var branch in branches)
            {
                branch.BranchLength++;
            }
        }

        public void Ouch(int index)
        {
            if (branches.Count > 0 && index < branches.Count && index > 0)
            {
                branches.RemoveAt(index - 1);
            }
        }

        public string Description()
        {
            if (branches.Count > 0)
            {
                var positions = string.Join(",", branches.Select(b => b.Position));
                var lengths = string.Join(",", branches.Select(b => b.BranchLength));

                var description = "The tree trunk is "
                                    + treeHeight.ToString()
                                    + " unit(s) tall! There are " + branches.Count + " branch(es) that have position(s): "
                                    + positions
                                    + " and length(s): "
                                    + lengths + "!";
                return description;
            }
            return "The tree trunk is " + treeHeight.ToString() + " unit(s) tall! There are " + branches.Count.ToString() + " branch(es)!";
        }

    }

    public interface ITree2
    {
        void GrowTrunk();
        void GrowBranches();
        void NewBranch();
        void Ouch(int n);
        string Description();
    }
}
