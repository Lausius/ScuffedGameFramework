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
            for (int i = 0; i < 80; i++)
            {
                creatureFactory.CreateCreature(CreatureRace.Beast);
                creatureFactory.CreateCreature(CreatureRace.Humanoid);
                creatureFactory.CreateCreature(CreatureRace.Troll);
                creatureFactory.CreateCreature(CreatureRace.Undead);
            }

            world.DrawSquareWorld();
            player.DrawCreature();
            foreach (var creature in creatureFactory.MonsterList)
            {
                creature.DrawCreature();
            }

            //var list = creatureFactory.MonsterList.FindAll(i => i.Position.X == 1);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}
