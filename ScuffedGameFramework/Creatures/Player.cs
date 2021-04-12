using ScuffedGameFramework.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures
{
    public abstract class Player : Creature
    {
        private readonly IItemAbstractFactory _itemAbstractFactory;

        public Player(string name)
        {
            _itemAbstractFactory = new AbstractItemFactory();
            CurrentWeapon = _itemAbstractFactory.GenerateWeapon();
            CurrentArmor = _itemAbstractFactory.GenerateArmor();


            Position = new Position(1, 1);
            Color = ConsoleColor.Green;
            WorldMarker = "O";
        }

    }
}
