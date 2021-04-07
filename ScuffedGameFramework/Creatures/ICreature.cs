using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons;
using System.Collections.Generic;

namespace ScuffedGameFramework
{
    public interface ICreature
    {
        int AttackPower { get; set; }
        int Defense { get; set; }
        int HitPoints { get; set; }
        string Name { get; set; }
        bool Dead { get; }
        IWeapon CurrentWeapon { get; set; }
        IArmor CurrentArmor { get; set; }

        void Hit(ICreature creature);
        //void ReceiveHit(ICreature creature);
    }
}