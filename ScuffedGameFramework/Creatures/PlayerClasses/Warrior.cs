using ScuffedGameFramework.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.ConcreteCreatures
{
    public class Warrior : Player
    {

        public Warrior(string name) : base(name)
        {
            Name = name;
            HitPoints = 200;
            AttackPower += 10;
            Defense += 10;

        }



        public override void FightingStyle(ICreature creature)
        {
            // maybe implement critical strike :) 
            int totalDamage = CalculateResistedDamage(AttackPower, creature.Defense);
            creature.HitPoints -= totalDamage;
            BattleText = $"{Name} has hit {creature.Name} with a {CurrentWeapon} for a total of {totalDamage} damage. {creature.Name} has {creature.HitPoints} HP left.";
        }
    }
}
