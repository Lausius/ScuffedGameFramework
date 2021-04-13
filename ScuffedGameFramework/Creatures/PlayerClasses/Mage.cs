using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor.ConcreteArmor;
using ScuffedGameFramework.Items.Weapons.ConcreteWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.PlayerClasses
{
    public class Mage : Player
    {

        public int SpellPower { get; set; }
        public Mage(string name) : base(name)
        {
            Name = name;
            HitPoints = 130;
            CurrentArmor.AddArmor(new Robe());
            CurrentWeapon.AddWeapon(new Staff());
            SpellPower = AttackPower;
            SpellPower += 40;
        }

        // Ignores defense, but is more fragile than the warrior.
        public override void FightingStyle(ICreature creature)
        {
            creature.HitPoints -= SpellPower;
            BattleText = $"{Name} has hit {creature.Name} with a fireball for {SpellPower} spell damage. {creature.Name} has {creature.HitPoints} HP left.";

        }
    }
}
