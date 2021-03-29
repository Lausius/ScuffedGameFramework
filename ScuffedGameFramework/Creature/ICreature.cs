using ScuffedGameFramework.Items;
using System.Collections.Generic;

namespace ScuffedGameFramework
{
    public interface ICreature
    {
        int AttackPower { get; set; }
        int HitPoints { get; set; }
        string Name { get; set; }
        //IEnumerable<IItems> Inventory { get; set; }
        bool Dead { get; }

        void Hit(ICreature creature);
        // void Loot(ICreature creature);
        void ReceiveHit(ICreature creature);
    }
}