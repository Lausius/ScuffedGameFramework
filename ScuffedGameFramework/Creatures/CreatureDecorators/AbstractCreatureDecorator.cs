using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.CreatureDecorators
{
    public abstract class AbstractCreatureDecorator : Monster
    {
        public Monster Monster { get; set; }
        public AbstractCreatureDecorator(Monster monster, Position spawnPoint) : base(spawnPoint)
        {
            Monster = monster;
            WorldMarker = monster.WorldMarker;
            Position = monster.Position;
            CurrentArmor = monster.CurrentArmor;
            CurrentWeapon = monster.CurrentWeapon;

        }
    }
}
