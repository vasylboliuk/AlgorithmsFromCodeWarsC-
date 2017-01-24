using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._8kyu
{
    public class JennysSecretMessage
    {
        /*
         * Description:
         * Jenny has written a function that returns a greeting for a user.
         *  However, she's in love with Johnny, and would like to greet him slightly different. 
         *  She added a special case to her function, but she made a mistake.
         *  Can you help her?
         */
        public static string greet(string name)
        {
            if (name == "Johnny")
                return "Hello, my love!";
            return "Hello, " + name + "!";
           
        }
    }
}
