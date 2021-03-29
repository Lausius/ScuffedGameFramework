using ScuffedGameFramework.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public abstract class Creature : ICreature
    {
        public int HitPoints { get; set; }
        public string Name { get; set; }
        //public IEnumerable<IItems> Inventory { get; set; }
        public bool Dead
        {
            get
            {
                return HitPoints <= 0;
            }
        }

        // Determines how hard the creature hits.
        public int AttackPower { get; set; }
        public int Defense { get; set; }


        /// <summary>
        /// Initialize creature from xml configuration file.
        /// </summary>
        public Creature()
        {

        }

        public Creature(string name, int hitPoints = 100, int attackPower = 10)
        {
            Name = name;
            HitPoints = hitPoints;
            AttackPower = attackPower;
        }

        /// <summary>
        /// Template method.
        /// </summary>
        /// <param name="creature"></param>
        public void Hit(ICreature creature)
        {
            creature.HitPoints -= AttackPower;
        }

        //public void Loot(ICreature creature)
        //{
        //    foreach (var item in creature.Inventory)
        //    {
        //        Inventory.Append(item);
        //    }
        //}

        /// <summary>
        /// Template method.
        /// </summary>
        /// <param name="creature"></param>
        public void ReceiveHit(ICreature creature)
        {
            HitPoints = HitPoints - creature.AttackPower;
        }
    }
}
