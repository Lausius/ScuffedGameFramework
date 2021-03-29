using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons.ConcreteWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons
{
    public class WeaponFactory : IWeaponFactory
    {
        private static Random _rng = new Random(Guid.NewGuid().GetHashCode());

        public IWeapon Create()
        {
            switch (GenerateWeaponType())
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

        private WeaponType GenerateWeaponType()
        {
            var enums = Enum.GetValues(typeof(WeaponType));
            return (WeaponType)enums.GetValue(_rng.Next(enums.Length));
        }
    }
}
