using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons.ConcreteWeapons
{
    class BluntMace : WeaponBase
    {
        public override string Name
        {
            get { return "Blunt Mace"; }
        }

        public override int Damage
        {
            get { return 25; }
        }
    }
}
