using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    /// <summary>
    /// Definition-
    /// back·ro·nym
    /// noun
    /// a fanciful expansion of an existing acronym or word, such as “port out, starboard home” for posh.
    /// You will create a function called makeBackronym.There will be a preloaded dictionary to use.
    /// The dictionary is an object where the the keys are letters A-Z and the values are a predetermined word.
    /// Use the variable name (its name is written in the code template) to reference the uppercase letters of the dictionary.
    /// EXAMPLE:
    /// dict['P']=="perfect"
    /// There will be a string(without spaces) passed into the function that you need to translate to a Backronym.
    /// The preloaded dictionary can only read uppercase letters, and the value you return will have to be a string.
    /// EXAMPLES:
    /// "dgm" -> "disturbing gregarious mustache"
    /// "lkj" -> "literal klingon joke" 
    /// </summary>
    public class MakeBackronymSolution
    {

        Dictionary<char, string> dict = new Dictionary<char, string>
        {
            {'A',"awesome"},
            {'B', "beautiful"},
            {'C', "confident"},
            {'D', "disturbing"},
            {'E', "eager"},
            {'F', "fantastic"},
            {'G', "gregarious"},
            {'H', "hippy"},
            {'I', "ingestable"},
            {'J', "joke"},
            {'K', "klingon"},
            {'L', "literal"},
            {'M', "mustache"},
            {'N', "newtonian"},
            {'O', "oscillating"},
            {'P', "perfect"},
            {'Q', "queen"},
            {'R', "rant"},
            {'S', "stylish"},
            {'T', "turn"},
            {'U', "underlying"},
            {'V', "volcano"},
            {'W', "weird"},
            {'X', "xylophone"},
            {'Y', "yogic"},
            {'Z', "zero"}
        };

        /// <summary>
        /// In Class description
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MakeBackronym(string s)
        {
            char[] charList = s.ToUpper().ToCharArray();
            string result = string.Empty;

            for (int i = 0; i < charList.Length; i++)
            {
                result = result + dict[charList[i]] + " ";
            }

            return result.Trim(); 
        }

        public string MakeBackronym2(string s)
        {
            return string.Join(" ", s.ToUpper().Select(c => dict[c]));
        }
    }
}
