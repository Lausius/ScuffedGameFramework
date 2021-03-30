using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items
{
    /// <summary>
    /// This class is used to create items.
    /// </summary>
    public class AbstractItemFactory : IItemAbstractFactory
    {
        private IWeaponFactory _weaponFactory;
        private IArmorFactory _armorFactory;

        public AbstractItemFactory()
        {
            _weaponFactory = new WeaponFactory();
            _armorFactory = new ArmorFactory();
        }

        public IArmor GenerateArmor()
        {
            return _armorFactory.Create();
        }

        public IWeapon GenerateWeapon()
        {
            return _weaponFactory.Create();
        }
    }
}
