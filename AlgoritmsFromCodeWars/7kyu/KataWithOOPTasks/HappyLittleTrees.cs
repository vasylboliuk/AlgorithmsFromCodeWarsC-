using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    // /Create a Tree class so I can grow a happy little tree. The tree has a trunk and branches which grow
    /// in unit sizes. Branches can start at the current trunk height. All branches grow simultaneously,
    /// Functions to include:
    /// Tree() - Object constructor(trunk starts with size 1)
    /// GrowTrunk() - Trunk height increases by 1
    /// GrowBranches() - All branches increase in length by 1
    /// NewBranch() - A new branch is made at the current trunk height
    /// Ouch(int n) - The nth oldest branch is removed
    /// Description() - Returns a string describing all the properties of the tree as seen 
    /// below(replace the _ with appropiate values)
    /// "The tree trunk is _ unit(s) tall! There are _ branch(es) that have 
    /// position(s): _,_,_ and length(s): _,_,_!"
    /// When there are no branches:
    /// "The tree trunk is _ unit(s) tall! There are _ branch(es)!"
    /// preloaded code for class structure :
    /// public interface ITree
    /// {
    /// void GrowTrunk();
    /// void GrowBranches();
    /// void NewBranch();
    /// void Ouch(int n);
    /// string Description();
    /// }
    public class HappyLittleTrees{}

    public class Tree : ITree
    {
        private int defaultBrancheSize = 1;
        private int trunkHeight = 0;
        private int lengthBranches = 0;
        private int positionNewBranch;
        private List<int> branches = new List<int>();
        private List<int> branchesPosition = new List<int>();

        public Tree()
        {
            trunkHeight = 1;
        }

        public void GrowTrunk()
        {
            trunkHeight = trunkHeight + 1;
        }

        public void GrowBranches()
        {
            branches = branches.Select(x => x=x+1).ToList();
        }

        public void NewBranch()
        {
            branches.Add(defaultBrancheSize);
            branchesPosition.Add(trunkHeight);
        }

        public void Ouch(int n)
        {
            if (branches.Count > n - 1 && n > 0)
            {
                branches.RemoveAt(n - 1);
                branchesPosition.RemoveAt(n - 1);
            }

        }

        public string GetBranchesLenght()
        {
            return string.Join(",", branches.Select(x => x));
        }

        public string GetBranchesPositions()
        {
            return string.Join(",", branchesPosition.Select(x => x));
        }


        public string Description()
        {
            string result = string.Empty;
            if (branches.Count > 0)
            {
                result = result + string.Format(
                          "The tree trunk is {0} unit(s) tall! There are {1} branch(es) that have position(s): {2} and length(s): {3}!",
                           trunkHeight, branches.Count, GetBranchesPositions(), GetBranchesLenght());
            }
            else
            {
                result = result + string.Format("The tree trunk is {0} unit(s) tall! There are {1} branch(es)!", trunkHeight, branches.Count);
            }

            return result;
        }
    }

    public interface ITree
    {
        void GrowTrunk();
        void GrowBranches();
        void NewBranch();
        void Ouch(int n);
        string Description();
    }
}
