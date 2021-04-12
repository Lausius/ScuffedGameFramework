using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons.ConcreteWeapons
{
    public class Staff : WeaponBase
    {
        public override string Name { get { return "Long Staff"; } }

        public override int Damage { get { return 10; } }
    }
}
