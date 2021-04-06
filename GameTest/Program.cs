using ScuffedGameFramework;
using ScuffedGameFramework.Creatures;
using ScuffedGameFramework.Creatures.ConcreteCreatures;
using System;
using System.Collections.Generic;

namespace GameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World(20, 20);
            Creature player = new PlayerHero("Lausius");
            CreatureFactory creatureFactory = new CreatureFactory(world, player);
            //List<Creature> creatureList = new List<Creature>();
            for (int i = 0; i < 85; i++)
            {
                creatureFactory.CreateCreature(CreatureRace.Beast);
                creatureFactory.CreateCreature(CreatureRace.Humanoid);
                creatureFactory.CreateCreature(CreatureRace.Troll);
                creatureFactory.CreateCreature(CreatureRace.Undead);
            }

            //Creature skeleton = new Skeleton(new Position(5, 5));
            //Console.WriteLine(player.AttackPower);
            //Console.WriteLine(player.CurrentArmor.Name);
            //Console.WriteLine(player.CurrentWeapon.Name);
            //player.EngageFight(skeleton);
            world.DrawSquareWorld();
            player.DrawCreature();
            foreach (var creature in creatureFactory.MonsterList)
            {
                creature.DrawCreature();
            }

            Console.ReadLine();
        }
    }
}
