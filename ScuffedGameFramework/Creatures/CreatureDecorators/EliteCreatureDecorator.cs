using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.CreatureDecorators
{
    public class EliteCreatureDecorator : AbstractCreatureDecorator
    {
        // TODO: Make this class take a monster type instead of creature. 
        public EliteCreatureDecorator(Monster monster, Position spawnPoint) : base(monster, spawnPoint)
        {
            Name = "Elite " + monster.Name;
            HitPoints = 100 + monster.HitPoints;
            AttackPower = 5 + monster.AttackPower;
            Color = ConsoleColor.Cyan;

        }

        public override void FightingStyle(ICreature player)
        {
            int totalDamage = CalculateResistedDamage(AttackPower, player.Defense);
            for (int i = 0; i < 2; i++)
            {
                // hits 2 times cuz boss?
                player.HitPoints -= totalDamage;
            }
            BattleText = $"{Name} has hit {player.Name} 2 times for a total of {totalDamage * 2} damage. Remaining health is now {player.HitPoints}.";
        }
    }
}
