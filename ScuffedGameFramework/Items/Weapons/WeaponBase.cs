using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons
{
    public abstract class WeaponBase : IWeapon
    {
        public abstract string Name { get; }
        public abstract int Damage { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
