using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons
{
    public abstract class WeaponBase : IWeapon
    {
        public virtual string Name { get; }
        public virtual int Damage { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
