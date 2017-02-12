using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    public  class RemoveAllTheMarkedElementsOfAList
    {
        public int[] Remove(int[] integerList, int[] valuesList)
        {
            if (integerList.Length<1) return new int[] {};
            List<int> integers = integerList.ToList();
            List<int> values = valuesList.ToList();

            integers.RemoveAll(i => values.Contains(i));

            return integers.ToArray();
        }

        //Works only for non duplicates items in value list
        public int[] Remove4Variant(int[] integerList, int[] valuesList)
        {
            return integerList.ToList().Except(valuesList).ToArray();

        }

        public int[] Remove2Variant(int[] integerList, int[] valuesList)
        {
            return integerList.Where(x => !valuesList.Contains(x)).ToArray();
        }

        public int[] Remove3Variant(int[] integerList, int[] valuesList)
        {
            var list = integerList.ToList();
            foreach (var n in valuesList)
            {
                list.RemoveAll(i => i == n);
            }
            return list.ToArray();
        }
    }
}
