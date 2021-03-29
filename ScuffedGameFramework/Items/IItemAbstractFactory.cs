using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items
{
    interface IItemAbstractFactory
    {
        IWeapon GenerateWeapon();
        IArmor GenerateArmor();
    }
}
