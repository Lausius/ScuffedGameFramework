﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures
{
    public class Monster : Creature
    {
        public Monster(Position spawnPoint)
        {
            Position = spawnPoint;
            WorldMarker = "X";
            Color = ConsoleColor.Red;
        }

        public override void FightingStyle(ICreature player)
        {
            int totalDamage = CalculateResistedDamage(AttackPower, player.Defense);
            player.HitPoints -= totalDamage;
            BattleText = $"{Name} has hit {player.Name} for a total of {totalDamage} damage. Remaining health is now {player.HitPoints}.";
        }
    }
}
