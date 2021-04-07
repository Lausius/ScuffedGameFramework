using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures
{
    public class Monster : Creature
    {
        public Monster(Position spawnPoint)
        {
            Position = spawnPoint;
            WorldMarker = "X";
            Color = ConsoleColor.Red;
        }

        public override void FightingStyle(ICreature creature)
        {
            HitPoints -= creature.AttackPower - ((Defense / 100) * AttackPower);
        }
    }
}
