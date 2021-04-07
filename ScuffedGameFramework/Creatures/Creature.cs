using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public abstract class Creature : ICreature
    {
        private readonly JsonTraceListener _logger;

        #region Properties
        public int HitPoints { get; set; }
        public string Name { get; set; }

        #region WorldProperties
        public Position Position { get; set; }
        public ConsoleColor Color { get; set; }
        public string WorldMarker { get; set; }
        #endregion

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

        // Should maybe be a list?
        public IWeapon CurrentWeapon { get; set; } = null;
        public IArmor CurrentArmor { get; set; } = null;
        #endregion

        /// <summary>
        /// Initialize creature from xml configuration file.
        /// </summary>
        public Creature()
        {
            _logger = new JsonTraceListener("CombatLog.json");
        }

        public void DrawCreature()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(WorldMarker);
            Console.ResetColor();
        }

        #region Behavior

        public void Hit(ICreature creature)
        {
            creature.HitPoints -= AttackPower - ((Defense / 100) * AttackPower);
            string battleText = $"{Name} has hit {creature.Name} for {AttackPower} damage. {creature.Name} has {creature.HitPoints} HP left.";
            _logger.WriteLine(battleText);
            Console.WriteLine(battleText);
        }

        public void ReceiveHit(ICreature creature)
        {
            HitPoints -= creature.AttackPower - ((Defense / 100) * AttackPower);
            string battleText = $"{creature.Name} has hit {Name} for {creature.AttackPower} damage. Remaining health is {HitPoints}.";
            _logger.WriteLine(battleText);
            Console.WriteLine(battleText);
        }

        public void EngageFight(ICreature enemyCreature)
        {
            Console.Clear();
            while (!Dead && !enemyCreature.Dead)
            {
                Hit(enemyCreature);
                Thread.Sleep(1000);

                // Making sure enemy can't hit back if dead.
                if (!enemyCreature.Dead)
                {
                    ReceiveHit(enemyCreature);
                    Thread.Sleep(1000);
                }
            }

            if (Dead)
            {
                Console.WriteLine("Player has died :(");
            }
            else
            {
                Console.WriteLine(Name + " is victoriuous! Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        #endregion

        public override string ToString()
        {
            return $"This creatures is at position {Position.X},{Position.Y}.";
        }
    }
}
