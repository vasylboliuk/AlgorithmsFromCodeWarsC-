using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class GetInitialsFromPersonName
    {

        /// <summary> 
        /// Write function toInitials returs initials for a given person name. E.g: "Bill Gates" -> "B. G."
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ToInitials(string name)
        {
            string result = "";
            string[] names = name.Split();
            foreach (var str in names)
            {
                result = result + str.Substring(0, 1) + ". ";
            }
            return result.Trim();
        }


        public static string ToInitialsLinq(string name)
        {
            return  string.Join(". ", name.Split().Select(x => x.Substring(0,1)))+".";
        }

        public static string ToInitialsLinq2(string name)
        {
            return string.Join(" ", name.Split(' ').Select(n => n.First() + "."));
        }
    }
}
