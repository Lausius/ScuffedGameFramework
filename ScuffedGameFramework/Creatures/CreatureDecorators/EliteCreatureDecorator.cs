using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.CreatureDecorators
{
    public class EliteCreatureDecorator : AbstractCreatureDecorator
    {
        public EliteCreatureDecorator(Creature creature) : base(creature)
        {
            Name = "Elite " + creature.Name;
            HitPoints += 100;
            AttackPower += 5;
            Color = ConsoleColor.Cyan;

        }

        public override void FightingStyle(ICreature creature)
        {
            for (int i = 0; i == 2; i++)
            {
                // hits 2 times cuz boss?
                HitPoints -= creature.AttackPower - ((Defense / 100) * AttackPower);
            }
        }
    }
}
