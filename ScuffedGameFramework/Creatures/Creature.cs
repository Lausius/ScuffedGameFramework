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
        private IArmor _armor = null;
        private IWeapon _weapon = null;

        #region Properties
        public int HitPoints { get; set; }
        public string BattleText { get; set; }
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
        public IWeapon CurrentWeapon
        {
            get { return _weapon; }
            set
            {
                _weapon = value;
                if (_weapon is not null)
                {
                    AttackPower += _weapon.Damage;
                }
            }
        }

        public IArmor CurrentArmor
        {
            get { return _armor; }
            set
            {
                _armor = value;
                if (_armor is not null)
                {
                    Defense += _armor.Defense;
                }
            }
        }
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

        public void LogBattleText(string battleText)
        {
            _logger.WriteLine(battleText);
            Console.WriteLine(battleText);
        }
        #region Behavior
        public abstract void FightingStyle(ICreature creature);

        public void Hit(ICreature creature)
        {
            FightingStyle(creature);

            LogBattleText(BattleText);
        }

        //public void ReceiveHit(ICreature creature)
        //{
        //    HitPoints -= creature.AttackPower - ((Defense / 100) * AttackPower);

        //}

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
                    enemyCreature.Hit(this);
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
