using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons.ConcreteWeapons;
using System;
using ScuffedGameFramework.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons
{
    public class WeaponFactory
    {

        public static IWeapon GenerateWeapon()
        {
            switch (EnumValueGenerator.GenerateRace<WeaponType>())
            {
                case WeaponType.Sword:
                    return new LongSword();
                case WeaponType.Axe:
                    return new RustyAxe();
                case WeaponType.Mace:
                    return new BluntMace();
                default:
                    return null;
            }
        }
    }
}
