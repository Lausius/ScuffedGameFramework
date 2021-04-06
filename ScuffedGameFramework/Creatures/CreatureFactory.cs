﻿using ScuffedGameFramework.Creatures.ConcreteCreatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures
{
    public class CreatureFactory
    {
        private readonly World _world;
        Random rnd = new Random();
        public List<Position> FixedCreaturePositions { get; set; }
        public List<Creature> MonsterList { get; set; }

        public CreatureFactory(World world, Creature player)
        {
            _world = world;
            FixedCreaturePositions = new List<Position>();
            MonsterList = new List<Creature>();
            MonsterList.Add(player);
        }

        public Creature CreateCreature(CreatureRace race)
        {
            switch (race)
            {
                case CreatureRace.Beast:
                    Creature bear = new Bear(GeneratePosition());
                    MonsterList.Add(bear);
                    return bear;
                case CreatureRace.Humanoid:
                    Creature kobold = new Kobold(GeneratePosition());
                    MonsterList.Add(kobold);
                    return kobold;
                case CreatureRace.Undead:
                    Creature skeleton = new Skeleton(GeneratePosition());
                    MonsterList.Add(skeleton);
                    return skeleton;
                case CreatureRace.Troll:
                    Creature troll = new Troll(GeneratePosition());
                    MonsterList.Add(troll);
                    return troll;
                default:
                    return null;
            }
        }

        private Position GeneratePosition()
        {
            Position pos = new Position(rnd.Next(1, _world.MaxX - 1), rnd.Next(1, _world.MaxY - 1));

            if (MonsterList.Contains(MonsterList.Find(i => i.Position.Equals(pos))))
            {
                //throw new Exception("FUCK MIG");
                // MonsterList.Count ... count må ikke være over worldmaxX * worldmaxy 
                if (MonsterList.Count > (_world.MaxX - 1) * (_world.MaxY - 1))
                {
                    throw new Exception("The world is too small for so many monsters.");
                }
                GeneratePosition();
            }

            return pos;
        }

    }
}