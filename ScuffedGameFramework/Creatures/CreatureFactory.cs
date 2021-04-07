using ScuffedGameFramework.Creatures.ConcreteCreatures;
using ScuffedGameFramework.Creatures.CreatureDecorators;
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
        private readonly JsonTraceListener _logger;
        Random rnd = new Random();
        public List<Creature> CreatureList { get; set; }

        public CreatureFactory(World world, Creature player, JsonTraceListener logger)
        {
            _world = world;
            _logger = logger;
            CreatureList = new List<Creature>();
            CreatureList.Add(player);
        }

        public Creature CreateCreature()
        {
            Creature creature;
            switch (GenerateRace())
            {
                case CreatureRace.Beast:
                    creature = new Bear(GeneratePosition());
                    CreatureList.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");
                    return creature;
                case CreatureRace.Humanoid:
                    creature = new Kobold(GeneratePosition());
                    CreatureList.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");
                    return creature;
                case CreatureRace.Undead:
                    creature = new Skeleton(GeneratePosition());
                    CreatureList.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");
                    return creature;
                case CreatureRace.Troll:
                    creature = new Troll(GeneratePosition());
                    CreatureList.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");

                    return creature;
                default:
                    return null;
            }
        }

        public void GenerateRandomBoss()
        {
            Creature creature;
            int randomNumber = rnd.Next(CreatureList.Count);
            creature = CreatureList[randomNumber];
            creature = new EliteCreatureDecorator(creature);
            CreatureList[randomNumber] = creature;

        }

        private Position GeneratePosition()
        {
            Position pos = new Position(rnd.Next(1, _world.MaxX - 1), rnd.Next(1, _world.MaxY - 1));

            if (CreatureList.Exists(i => i.Position.Equals(pos)))
            {
                pos = GeneratePosition();
                if (CreatureList.Count > (_world.MaxX * _world.MaxY) / 2)
                {
                    throw new Exception("The world is too small for so many monsters.");
                }
            }

            return pos;
        }

        private CreatureRace GenerateRace()
        {
            var enums = Enum.GetValues(typeof(CreatureRace));
            return (CreatureRace)enums.GetValue(rnd.Next(enums.Length));
        }

    }
}
