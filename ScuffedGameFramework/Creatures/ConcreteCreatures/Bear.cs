using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.ConcreteCreatures
{
    public class Bear : Monster
    {
        public Bear(Position spawnPoint) : base(spawnPoint)
        {
            Name = "Black Bear";
            HitPoints = 60;
            AttackPower = 15;
            WorldMarker = "B";
        }
    }
}
