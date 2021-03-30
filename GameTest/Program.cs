using ScuffedGameFramework;
using ScuffedGameFramework.Creatures.ConcreteCreatures;
using System;

namespace GameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature player = new PlayerHero("Lausius");
            Creature skeleton = new Skeleton();
            Console.WriteLine(player.AttackPower);
            Console.WriteLine(player.CurrentArmor.Name);
            Console.WriteLine(player.CurrentWeapon.Name);
            player.EngageFight(skeleton);
            Console.ReadLine();
        }
    }
}
