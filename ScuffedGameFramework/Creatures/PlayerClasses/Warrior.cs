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

        public override void CombatText(ICreature creature)
        {
            BattleText = $"{Name} has hit {creature.Name} with a {CurrentWeapon} for {AttackPower} damage. {creature.Name} has {creature.HitPoints} HP left.";
        }

        public override void FightingStyle(ICreature creature)
        {
            // maybe implement critical strike :) 
            creature.HitPoints -= AttackPower - ((Defense / 100) * AttackPower);
            CombatText(creature);
        }
    }
}
