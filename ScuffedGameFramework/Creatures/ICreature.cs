using ScuffedGameFramework.Items;
using System.Collections.Generic;

namespace ScuffedGameFramework
{
    public interface ICreature
    {
        int AttackPower { get; set; }
        int Defense { get; set; }
        int HitPoints { get; set; }
        string Name { get; set; }
        bool Dead { get; }

        void Hit(ICreature creature);
        void ReceiveHit(ICreature creature);
    }
}