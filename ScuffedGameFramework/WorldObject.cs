using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public class WorldObject
    {
        public string Name { get; set; }

        public Position Position { get; set; }
        public ConsoleColor Color { get; set; }
        public string WorldMarker { get; set; }

        public void DrawWorldObject()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(WorldMarker);
            Console.ResetColor();
        }
    }
}
