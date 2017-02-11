using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    public class PlayingWithCubesIII
    {
        /// <summary>
        /// Hey Cube-Lovers!
        /// Now we want to provide some more information about cubes.
        /// First, we implement two new properties: Volume and Surface.
        /// Additional to this task we are going to refactor our code, so it will be bit more like professional C# code! 
        /// You change the variable Side to a public property and remove the 'Getter' and 'Setter'.
        /// The properties Volume and Surface should each have a public get-accessor and private set-accessor.
        /// Their correct mathematical values should be set in the cubes constructor and if Side's values is changed.
        /// This MSDN site should provide some help:
        /// https://msdn.microsoft.com/en-us/library/w86s7x04(v=VS.120).aspx
        /// </summary>
        public class Cube
        {
            private int side;

            public Cube(int s)
            {
                Side= s;
            }

            public Cube()
            {
            }

            public int Side
            {
                get { return side; }
                set { side = Math.Abs(value); }
            }

            public int Volume
            {
                get { return Side*Side*Side; }
            }

            public int Surface
            {
                get { return 6*Side*Side; }
            }

        }
    }
}
