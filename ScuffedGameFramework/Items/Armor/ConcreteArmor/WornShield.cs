using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor.ConcreteArmor
{
    class WornShield : ArmorBase
    {
        public override string Name
        {
            get { return "Old Worn Shield"; }
        }

        public override int Defense
        {
            get { return 15; }
        }
    }
}
