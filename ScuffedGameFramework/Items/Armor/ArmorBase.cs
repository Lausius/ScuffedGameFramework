using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor
{
    public abstract class ArmorBase : IArmor
    {
        public abstract string Name { get; }
        public abstract int Defense { get; }
    }
}
