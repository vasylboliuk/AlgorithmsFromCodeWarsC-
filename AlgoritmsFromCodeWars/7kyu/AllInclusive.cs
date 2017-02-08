using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class AllInclusive
    {

        /// <summary>
        /// Input:
        /// a string strng
        /// an array of strings arr
        /// Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):
        /// a boolean true if all rotations of strng are included in arr(C returns 1)
        /// false otherwise(C returns 0)
        /// Examples:
        /// contain_all_rots("bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true
        /// contain_all_rots(
        /// "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)
        /// Note:
        /// Though not correct in a mathematical sense
        /// we will consider that there are no rotations of strng == ""
        /// and for any array arr: contain_all_rots("", arr) --> true
        /// </summary>
        /// <param name="strng"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static Boolean ContainAllRots(string strng, List<string> arr)
        {
            if (arr.Count < 1 || strng.Equals(string.Empty)) return true;
            List<string> listReverseStr = new List<string>();
            string newStr = ChangeString(strng);
            listReverseStr.Add(newStr);

            while (strng != newStr)
            {
                newStr = ChangeString(newStr);
                listReverseStr.Add(newStr);
            }

            List<string> result = listReverseStr.Except(arr).ToList(); //result list should contains 0 items
            
            return result.Count<1 ;
        }

        public static string ChangeString(string s)
        {
            return s.Substring(1, s.Length-1) + s.Substring(0, 1);
        }


        public static Boolean ContainAllRots2(string s, List<string> arr)
        {
            var all = s + s;
            for (int i = 0, len = s.Length; i < len; i++)
                if (!arr.Contains(all.Substring(i, len))) return false;
            return true;
        }

        public static bool ContainAllRots3(string strng, List<string> arr)
        {
            var n = strng.Length;
            var s = strng + strng;
            return Enumerable.Range(0, n).All(i => arr.Contains(s.Substring(i, n)));
        }
    }
}
