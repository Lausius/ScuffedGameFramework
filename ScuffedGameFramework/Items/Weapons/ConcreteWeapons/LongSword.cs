using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons.ConcreteWeapons
{
    class LongSword : WeaponBase
    {
        public override string Name
        {
            get { return "Long Sword"; }
        }

        public override int Damage
        {
            get { return 40; }
        }
    }
}
