using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class JavascriptFilter1
    {
        /// <summary>
        /// While developing a website, you detect that some of the members have troubles logging in. 
        /// Searching through the code you find that all logins ending with a "_" make problems. 
        /// So you want to write a function that takes an array of pairs of login-names and e-mails, 
        /// and outputs an array of all login-name, e-mails-pairs from the login-names that end with "_".
        /// If you have the input-array:
        /// [ [ "foo", "foo@foo.com" ], [ "bar_", "bar@bar.com" ] ]
        /// it should output
        /// [["bar_", "bar@bar.com"] ]
        /// You have to use the filter-method of Python, which returns each element of the array for which the filter-method returns true.
        /// </summary>
        /// <param name="logins"></param>
        /// <returns></returns>
        public static string[][] search_names(string[][] logins)
        {
            for (int i=0; i< logins.Length; i++)
            {
                if (!logins[i].ElementAt(0).EndsWith("_"))
                {
                    logins = logins.Where(w => w != logins[i]).ToArray();
                    i--;
                }
            }
            return logins;
        }

        public static string[][] search_names2(string[][] logins)
        {
            return logins.Where(o => o.First().EndsWith("_")).ToArray();
        }
    }
}
