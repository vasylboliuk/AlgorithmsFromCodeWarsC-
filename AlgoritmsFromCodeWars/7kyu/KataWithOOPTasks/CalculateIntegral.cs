using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    public class CalculateIntegral
    {
        /// <summary>
        /// What are you dealing with...
        /// You're a clever programmer and too lazy to calculate integrals by your own!
        /// So you decide to write a method which will do your calculations.
        /// You got a linear function y = m * x + b and this is the code that is already existing:
        /// public class LinFunc
        /// {
        /// public double M { get; set; }
        /// public double B { get; set; }
        /// 
        /// public double GetY(double x)
        /// {
        /// // not implemented
        /// }
        /// 
        /// public double CalcIntegral(int a, int b)
        /// {
        /// // not implemented
        /// }
        /// }
        /// TODO
        /// Here it is up to you! Implement the missing code for these two methods GetY(double x) and 
        /// CalcIntegral(int from, int to).
        /// </summary>
        public class LinFunc
        {
            public double M { get; set; }
            public double B { get; set; }

            public double GetY(double x)
            {
                return M * x + B;
            }

            public double GetIntegral(double x)
            {
                return B * x + ((M * x * x) / 2);
            }

            public double CalcIntegral(int from, int to)
            {
                return GetIntegral(to) - GetIntegral(from);
            }
        }

        public class LinFunc2Sol
        {
            public double M { get; set; }
            public double B { get; set; }
            public double GetY(double x)
            {
                return M * x + B;
            }
            public double CalcIntegral(int from, int to)
            {
                //This is what happens when you forget how to integrate, so geometry it.
                return 0.5 * M * (to * to - from * from) + B * (to - from);
            }
        }
    }
}
