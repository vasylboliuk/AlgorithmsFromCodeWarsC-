using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    public class LargestSquareInsideACircle
    {
        /// <summary>
        /// Description:
        /// Determine the area of the largest square that can fit inside a circle with radius r.
        /// </summary>
        public double AreaLargestSquare(int r)
        {
            // When given the radius of the circle r we are given enough information to deduce the solution:
            // 1) The square will touch the circle at 4 points with its verticies which have a distance "r" from the center
            // 2) Taking half the square away, we know that the area is 0.5 * base * height
            // Since our base is r + r, and our heigh is just r, we get the formula 0.5(2r)r
            // We focused on half the square, now to multiply the above equation by 2 we get the solution.
            // 2 * r * r
            return r *r*2;
        }


    }
}
