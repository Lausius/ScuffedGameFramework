using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor.ConcreteArmor
{
    public class Robe : ArmorBase
    {
        public override string Name { get { return "Old Robe"; } }

        public override int Defense { get { return 5; } }
    }
}
