using ScuffedGameFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        private readonly string _horizontalLine;
        private XMLReader.XmlLog _conf;


        public World()
        {
            _conf = XMLReader.ReadWorldConfiguration<XMLReader.XmlLog>();
            MaxX = _conf.MaxX;
            MaxY = _conf.MaxY;
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

        public bool IsPositionWalkable(int x, int y)
        {
            if (x >= MaxX || x < 1 || y >= MaxY + 1 || y < 1)
            {
                return false;
            }
            return true;
        }

    }
}
