using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Gladiator : Hero
    {
        private const int RageChance = 25;
        private const int StunChance = 10;

        public Gladiator(string name) : base(name)
        {
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(RageChance))
            {
                attack = attack * 250 / 100; // Rage increases damage by 150%
            }
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(StunChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }
    }
}
