using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor.ConcreteArmor
{
    class LeatherBoots : ArmorBase
    {
        public override string Name
        {
            get { return "Worn Leather Boots"; }
        }

        public override int Defense
        {
            get { return 5; }
        }
    }
}
