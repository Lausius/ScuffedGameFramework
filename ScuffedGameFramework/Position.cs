using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new Exception("Coordinates must not be negative.");
            }
            else
            {
                X = x;
                Y = y;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return X == (obj as Position).X && Y == (obj as Position).Y;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
