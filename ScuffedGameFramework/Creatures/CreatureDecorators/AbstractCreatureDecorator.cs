using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.CreatureDecorators
{
    public abstract class AbstractCreatureDecorator : Creature
    {
        public Creature Creature { get; set; }
        public AbstractCreatureDecorator(Creature creature)
        {
            Creature = creature;
            WorldMarker = creature.WorldMarker;
            Position = creature.Position;
            CurrentArmor = creature.CurrentArmor;
            CurrentWeapon = creature.CurrentWeapon;

        }
    }
}
