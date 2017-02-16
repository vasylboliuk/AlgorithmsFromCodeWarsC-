using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsFromCodeWars._7kyu.KataWithOOPTasks
{
    public class TwoFightersOneWinner
    {
        /// <summary>
        /// Create a function that returns the name of the winner in a fight between two fighters.
        /// Each fighter takes turns attacking the other and whoever kills the other first is victorious.
        /// Death is defined as having <health <= 0>
        /// 
        /// Each fighter will be a Fighter object/instance.See the Fighter class below in your chosen language.
        /// Both health and damagePerAttack(damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.
        /// Example:
        /// declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew") => "Lew"
        ///  Python
        /// declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"
        /// 
        /// Lew attacks Harry; Harry now has 3 health.
        /// Harry attacks Lew; Lew now has 6 health.
        /// Lew attacks Harry; Harry now has 1 health.
        /// Harry attacks Lew; Lew now has 2 health.
        /// Lew attacks Harry: Harry now has -1 health and is dead.Lew wins.
        /// Technical note for Clojure programmers: The second fighter argument (f2) always attacks first.
        /// </summary>
        /// <param name="fighter1"></param>
        /// <param name="fighter2"></param>
        /// <param name="firstAttacker"></param>
        /// <returns></returns>
        public string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            string winner = string.Empty;
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                if (firstAttacker == fighter1.Name)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0) break;
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                }
                else
                {
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0) break;
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                }
            }
            winner = (fighter1.Health > fighter2.Health) ? fighter1.Name : fighter2.Name;

            return winner;
        }

        public static string DeclareWinner2(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            var fighters = new[] { fighter1, fighter2 };

            var Attacker = fighters.Single(f => f.Name == firstAttacker);
            var Defender = fighters.Single(f => f.Name != firstAttacker);
            Defender.Health -= Attacker.DamagePerAttack;
            if (Defender.Health <= 0)
            {
                return Attacker.Name;
            }
            return DeclareWinner2(fighter1, fighter2, Defender.Name);
        }
    }

    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}
