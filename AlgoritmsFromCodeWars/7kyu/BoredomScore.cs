using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class BoredomScore
    {
        /// <summary>
        /// Every now and then people in the office moves teams or departments. 
        /// Depending what people are doing with their time they can become more or less boring. 
        /// Time to assess the current team.
        /// You will be provided with an object(staff) containing the staff names as keys, 
        /// and the department they work in as values.
        /// Each department has a different boredom assessment score, as  follows:
        /// accounts = 1
        /// finance = 2
        /// canteen = 10
        /// regulation = 3
        /// trading = 6
        /// change = 6
        /// IS = 8
        /// retail = 5
        /// cleaning = 4
        /// pissing about = 25
        /// Depending on the cumulative score of the team, return the appropriate sentiment:
        /// 
        /// <=80: 'kill me now'
        /// < 100 & > 80: 'i can handle this'
        /// 100 or over: 'party time!!'
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public static string Boredom(Dictionary<string, string> staff)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            values.Add("accounts", 1);
            values.Add("finance", 2);
            values.Add("canteen", 10);
            values.Add("regulation", 3);
            values.Add("trading", 6);
            values.Add("change", 6);
            values.Add("IS", 8);
            values.Add("retail", 5);
            values.Add("cleaning", 4);
            values.Add("pissing about", 25);

            int sum = 0;
            foreach (KeyValuePair<string, string> kvp in staff)
            {
                sum = sum + values[kvp.Value];
            }

            if (sum <= 80) return "kill me now";
            else if (sum > 80 && sum < 100) return "i can handle this";
            else return "party time!!";
         
        }
    }
}
