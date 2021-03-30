using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.CreatureDecorators
{
    class EliteCreatureDecorator : AbstractCreatureDecorator
    {
        public EliteCreatureDecorator(Creature creature) : base(creature)
        {
            Name = "Elite " + creature.Name;
            HitPoints += 100;
            AttackPower += 5;
        }
    }
}
