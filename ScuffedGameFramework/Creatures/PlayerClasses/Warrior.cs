using ScuffedGameFramework.Items;
using ScuffedGameFramework.Items.Armor;
using ScuffedGameFramework.Items.Armor.ConcreteArmor;
using ScuffedGameFramework.Items.Weapons;
using ScuffedGameFramework.Items.Weapons.ConcreteWeapons;
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

            CurrentWeapon.AddWeapon(WeaponFactory.GenerateWeapon());
            CurrentArmor.AddArmor(ArmorFactory.GenerateArmor());



        }



        public override void FightingStyle(ICreature creature)
        {
            // maybe implement critical strike :) 
            int totalDamage = CalculateResistedDamage(creature);
            creature.HitPoints -= totalDamage;
            BattleText = $"{Name} has hit {creature.Name} with a {CurrentWeapon.EquippedWeapons[0]} for a total of {totalDamage} damage. {creature.Name} has {creature.HitPoints} HP left.";
        }
    }
}
