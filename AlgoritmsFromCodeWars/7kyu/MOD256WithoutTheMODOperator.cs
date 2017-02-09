using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class MOD256WithoutTheMODOperator
    {
        public static int Mod256WithoutMod(int number)
        {
            if (number < 0) return 0 - (byte)Math.Abs(number);

            return (byte)number;
        }

        public static int Mod256WithoutMod2(int number)
        {
            return number - (number / 256 * 256);
        }
    }
}
