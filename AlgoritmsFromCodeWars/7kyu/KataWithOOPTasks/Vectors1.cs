﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    public class Vectors1
    {
        /// <summary>
        /// Let's make this short!
        /// Remember, this is a kata which focuses on object oriented programming
        /// Task: Create a class Vector3D
        /// Properties: X, Y, Z and Length as double and public scope and accessors
        /// X, Y and Z will be set by test methods
        /// Length should only have an get-accessor which calculates the vector's length
        /// Some references, to get into the topic
        /// The length or magnitude or norm of the vector a is denoted by ‖a‖ or, less commonly, 
        /// |a|, which is not to be confused with the absolute value(a scalar "norm").
        /// The length of the vector a can be computed with the Euclidean norm
        /// How to calculate a vector's length - Link created 2016/11/15
        /// Tests
        /// Final tests include 2 fixed and 125 random tests.They will look like this:
        /// double length = new Vector3D()
        /// {
        ///   X = 0,
        ///   Y = 0,
        ///   Z = 2
        /// }.Length;
        /// length == 2 // true
        /// PostScriptum
        /// 
        /// If this kata gets enough reputation, I will add some follow up katas!
        /// </summary>
        public class Vector3D
        {
            public double X { get; set;}
            public double Y { get; set; }
            public double Z { get; set; }
            public double Length {
                get
                {
                    return Math.Sqrt(X*X + Y*Y + Z*Z);
                }
            }

        }

        public class Vector3D2
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public double Length { get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)); } }
        }
    }
}
