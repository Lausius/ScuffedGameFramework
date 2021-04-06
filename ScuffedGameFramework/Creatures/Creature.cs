﻿using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework
{
    public abstract class Creature : ICreature
    {

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
            creature.HitPoints -= AttackPower;
            Console.WriteLine($"{Name} has hit {creature.Name} for {AttackPower} damage. {creature.Name} has {creature.HitPoints} HP left.");
        }

        public void ReceiveHit(ICreature creature)
        {
            HitPoints -= creature.AttackPower;
            Console.WriteLine($"{creature.Name} has hit {Name} for {creature.AttackPower} damage. Remaining health is {HitPoints}.");
        }

        public void EngageFight(ICreature enemyCreature)
        {
            while (!Dead && !enemyCreature.Dead)
            {
                Hit(enemyCreature);
                ReceiveHit(enemyCreature);
            }
        }

        #endregion

        public override string ToString()
        {
            return $"This creatures is at position {Position.X},{Position.Y}.";
        }
    }
}
