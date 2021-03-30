using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.ConcreteCreatures
{
    public class Kobold : Creature
    {
        public Kobold()
        {
            Name = "Greedy Kobold";
            HitPoints = 40;
            AttackPower = 10;
        }
    }
}
