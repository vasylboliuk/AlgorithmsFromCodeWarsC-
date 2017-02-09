using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public static class SimpleExtensionMethods
    {
        public static string SayHello(this string str)
        {
            return "Hello, " + str + "!";
        }

        public static string SayGoodbye(this string str)
        {
            return "Goodbye, " + str + ". See you again soon!";
        }
    }
}
