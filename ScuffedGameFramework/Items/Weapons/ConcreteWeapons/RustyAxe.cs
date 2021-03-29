using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons.ConcreteWeapons
{
    class RustyAxe : WeaponBase
    {
        public override string Name
        {
            get { return "Rusty Axe"; }
        }

        public override int Damage
        {
            get { return 25; }
        }
    }
}
