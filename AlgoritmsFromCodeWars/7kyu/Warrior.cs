using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu
{
    /// <summary>
    /// Something is wrong with our Warrior class. The strike method does not work correctly. 
    /// The following shows an example of this code being used:
    /// var ninja = new Warrior("Ninja");
    /// var samurai = new Warrior("Samurai");
    /// samurai.Strike(ninja, 3);
    /// // ninja.Health should == 70Can you figure out what is wrong?

    /// </summary>
    public class Warrior
    {

        private string name;

        public Warrior(string name)
        {
            this.name = name;
        }

        public int Health { get; set; } = 100;

        public void Strike(Warrior enemy, int swings)
        {
            enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
        }
    }
}
