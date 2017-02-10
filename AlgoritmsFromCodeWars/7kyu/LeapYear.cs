using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class LeapYear
    {

        /// <summary>
        /// In this kata you should simply determine, whether a given year is a leap year or not. In case you don't know the rules, here they are:
        /// years divisible by 4 are leap years
        /// but years divisible by 100 are no leap years
        /// but years divisible by 400 are leap years
        /// Additional Notes:
        /// Only valid years(positive integers) will be tested, so you don't have to validate them
        /// Examples can be found in the test fixture.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public bool IsLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }
            else if (year % 4 == 0 || year % 400 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsLeapYear2(int year)
        {
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }
    }
}
