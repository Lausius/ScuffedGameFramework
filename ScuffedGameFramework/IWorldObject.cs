using System;

namespace ScuffedGameFramework
{
    public interface IWorldObject
    {
        ConsoleColor Color { get; set; }
        string Name { get; set; }
        Position Position { get; set; }
        string WorldMarker { get; set; }

        void DrawWorldObject();
    }
}