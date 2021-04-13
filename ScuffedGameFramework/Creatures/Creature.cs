using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.CompositeItems;
using ScuffedGameFramework.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public abstract class Creature : WorldObject, ICreature
    {
        private readonly JsonTraceListener _logger;
        private int _defense;
        private int _attackPower;

        #region Properties
        public int HitPoints { get; set; }
        public string BattleText { get; set; }

        public bool Dead
        {
            get
            {
                return HitPoints <= 0;
            }
        }

        // Determines how hard the creature hits.
        public int AttackPower
        {
            get
            {
                return _attackPower + CurrentWeapon.Damage;
            }
            set
            {
                _attackPower = value;
            }
        }
        public int Defense
        {
            get
            {
                return _defense + CurrentArmor.Defense;
            }
            set
            {
                _defense = value;
            }
        }

        public CompositeWeapon CurrentWeapon { get; set; }
        public CompositeArmor CurrentArmor { get; set; }
        #endregion

        /// <summary>
        /// Initialize creature from xml configuration file.
        /// </summary>
        public Creature()
        {
            _logger = new JsonTraceListener("CombatLog.json");
            CurrentArmor = new CompositeArmor();
            CurrentWeapon = new CompositeWeapon();

        }

        public void LogBattleText(string battleText)
        {
            _logger.WriteLine(battleText);
            Console.WriteLine(battleText);
        }
        #region Behavior
        public abstract void FightingStyle(ICreature creature);

        public int CalculateResistedDamage(double damage, double defense)
        {
            //Bad practice i know :(
            double defenseModifier = defense != 0 ? defense / 100 : 0;
            double totalDamage = damage - (defenseModifier * damage);
            return (int)totalDamage;
        }

        public void Hit(ICreature creature)
        {
            FightingStyle(creature);

            LogBattleText(BattleText);
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
