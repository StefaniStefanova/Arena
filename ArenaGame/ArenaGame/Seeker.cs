using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Seeker : Hero
    {
        private const int FireballChance = 20;
        private const int HealChance = 15;

        public Seeker(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(FireballChance))
            {
                attack = attack * 200 / 100; // Fireball doubles the damage
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(HealChance)) Heal(StartingHealth * 40 / 100); // Heals 40% of starting health
            base.TakeDamage(incomingDamage);

        }
    }
}
