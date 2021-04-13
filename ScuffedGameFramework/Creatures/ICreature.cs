using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.CompositeItems;
using ScuffedGameFramework.Items.Weapons;
using System.Collections.Generic;

namespace ScuffedGameFramework
{
    // Should probably add some restrictions...
    public interface ICreature
    {
        int AttackPower { get; set; }
        int Defense { get; set; }
        int HitPoints { get; set; }
        string Name { get; set; }
        bool Dead { get; }
        CompositeArmor CurrentArmor { get; set; }
        CompositeWeapon CurrentWeapon { get; set; }

        void Hit(ICreature creature);
        //void ReceiveHit(ICreature creature);
    }
}