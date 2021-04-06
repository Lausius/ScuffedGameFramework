using ScuffedGameFramework.Items.Armor.ConcreteArmor;
using ScuffedGameFramework.Items.Weapons.ConcreteWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.ConcreteCreatures
{
    public class Skeleton : Monster
    {
        public Skeleton(Position spawnPoint) : base(spawnPoint)
        {
            Name = "Old Skeleton";
            HitPoints = 50;
            CurrentArmor = new WornShield();
            CurrentWeapon = new LongSword();
            AttackPower = 10 + CurrentWeapon.Damage;
            Defense = 5 + CurrentArmor.Defense;
        }
    }
}
