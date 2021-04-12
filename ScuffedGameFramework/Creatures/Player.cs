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

        public Player(string name)
        {
            Name = name;


            Position = new Position(1, 1);
            Color = ConsoleColor.Green;
            WorldMarker = "O";
        }

    }
}
