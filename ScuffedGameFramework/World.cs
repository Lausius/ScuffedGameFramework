using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public class World
    {
        private char[,] _grid;
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        private readonly string _horizontalLine;


        public World(int maxX, int maxY)
        {
            _grid = new char[MaxX, MaxY];
            MaxX = maxX;
            MaxY = maxY;
            for (int x = 0; x < MaxX + 2; x++)
            {
                _horizontalLine += "-";
            }
        }

        public void DrawSquareWorld()
        {
            Console.WriteLine(_horizontalLine);
            for (int y = 0; y < MaxY; y++)
            {
                Console.Write("|");
                for (int x = 0; x < MaxX; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.Write(_horizontalLine);
        }

        public bool IsPositionWalkable(Position pos)
        {
            if (pos.X >= MaxX || pos.X <= 0 || pos.Y >= MaxY || pos.Y <= 0)
            {
                return false;
            }
            return true;
        }

    }
}
