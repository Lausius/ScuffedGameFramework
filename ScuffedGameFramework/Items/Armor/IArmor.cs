using ScuffedGameFramework.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Armor
{
    public interface IArmor : IItem
    {
        int Defense { get; }
    }
}
