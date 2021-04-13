using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor.ConcreteArmor
{
    class LeatherHelmet : ArmorBase
    {
        public override string Name
        {
            get { return "Sturdy Leather Helmet"; }
        }

        public override int Defense
        {
            get { return 10; }
        }
    }
}
