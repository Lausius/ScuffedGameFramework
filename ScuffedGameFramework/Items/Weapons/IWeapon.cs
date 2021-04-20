using ScuffedGameFramework.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Items.Weapons
{
    public interface IWeapon : IItem
    {
        public int Damage { get; }
    }
}
