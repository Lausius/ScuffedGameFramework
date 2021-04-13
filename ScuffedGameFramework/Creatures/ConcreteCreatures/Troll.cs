using ScuffedGameFramework.Items.Weapons.ConcreteWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.ConcreteCreatures
{
    public class Troll : Monster
    {
        public Troll(Position spawnPoint) : base(spawnPoint)
        {
            Name = "Green Troll";
            HitPoints = 80;
            AttackPower = 20;
            CurrentWeapon.AddWeapon(new BluntMace());
            WorldMarker = "T";
        }
    }
}
