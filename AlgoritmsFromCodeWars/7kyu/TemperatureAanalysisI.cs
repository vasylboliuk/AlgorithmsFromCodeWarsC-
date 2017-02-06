using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class TemperatureAanalysisI
    {

        public static int? LowestTemperature(string t)
        {
            if (t == "") return null;
           return t.Split(' ').Select(x => Int32.Parse(x)).ToList().Min();
        }
    }
}
