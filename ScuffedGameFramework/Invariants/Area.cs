using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public class Area
    {
        public int Value
        {
            get; set;
        }

        public Area()
        {
        }


        public Area(int value)
        {
            if (value >= 0 || value <= 40)
            {
                Value = value;
            }
            else
            {

                throw new Exception("Max X and Y values needs to be between 0 and 40.");
            }
        }

        public static int operator +(Area aA, int value)
        {
            return aA.Value + value;
        }

        public static int operator +(int value, Area aA)
        {
            return value + aA;
        }

        public static int operator -(Area aA, int value)
        {
            return aA.Value - value;
        }

        public static int operator *(Area aA, Area aB)
        {
            return aA.Value * aB.Value;
        }

        public static bool operator >=(Area aA, Area aB)
        {
            return (aA.Value >= aB.Value);
        }

        public static bool operator <=(Area aA, Area aB)
        {
            return (aA.Value <= aB.Value);
        }

        public static bool operator <=(int value, Area aA)
        {
            return (value <= aA.Value);
        }

        public static bool operator >=(int value, Area aA)
        {
            return (value >= aA.Value);
        }

        public static bool operator <(int value, Area aA)
        {
            return (value < aA.Value);
        }

        public static bool operator >(int value, Area aA)
        {
            return (value > aA.Value);
        }
    }
}
