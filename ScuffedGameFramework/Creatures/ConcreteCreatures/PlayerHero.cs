using ScuffedGameFramework.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures.ConcreteCreatures
{
    public class PlayerHero : Creature
    {
        private readonly IItemAbstractFactory _itemAbstractFactory;

        public PlayerHero(string name)
        {
            Name = name;
            _itemAbstractFactory = new AbstractItemFactory();
            HitPoints = 200;
            CurrentWeapon = _itemAbstractFactory.GenerateWeapon();
            CurrentArmor = _itemAbstractFactory.GenerateArmor();
            AttackPower += CurrentWeapon.Damage;
            Defense += CurrentArmor.Defense;
        }
    }
}
