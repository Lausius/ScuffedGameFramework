using ScuffedGameFramework.Creatures.ConcreteCreatures;
using ScuffedGameFramework.Creatures.CreatureDecorators;
using ScuffedGameFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuffedGameFramework.Creatures
{
    public class CreatureFactory
    {
        private readonly IWorld _world;
        private readonly JsonTraceListener _logger;
        Random rnd = new Random();
        public List<IWorldObject> WorldObjects { get; set; }

        public CreatureFactory(IWorld world, Player player, JsonTraceListener logger)
        {
            _world = world;
            _logger = logger;

            WorldObjects = new List<IWorldObject>();
            WorldObjects.Add(player);
        }

        // Maybe make an overloaded method to generate specific creature from creature race.
        /// <summary>
        /// Generates a random creature. 
        /// </summary>
        /// <returns>Creature</returns>
        public Creature CreateCreature()
        {
            Creature creature;
            switch (EnumValueGenerator.GenerateRace<CreatureRace>())
            {
                case CreatureRace.Beast:
                    creature = new Bear(GeneratePosition());
                    WorldObjects.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");
                    return creature;
                case CreatureRace.Humanoid:
                    creature = new Kobold(GeneratePosition());
                    WorldObjects.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");
                    return creature;
                case CreatureRace.Undead:
                    creature = new Skeleton(GeneratePosition());
                    WorldObjects.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");
                    return creature;
                case CreatureRace.Troll:
                    creature = new Troll(GeneratePosition());
                    WorldObjects.Add(creature);
                    _logger.WriteLine($"Created Creature {creature.Name} at position {creature.Position}");

                    return creature;
                default:
                    return null;
            }
        }

        public void GenerateRandomBoss()
        {
            Monster monster;
            int randomNumber = rnd.Next(1, WorldObjects.Count);
            monster = (Monster)WorldObjects[randomNumber];
            monster = new EliteCreatureDecorator(monster, monster.Position);
            WorldObjects[randomNumber] = monster;

        }

        private Position GeneratePosition()
        {
            Position pos = new Position(rnd.Next(1, _world.MaxX - 1), rnd.Next(1, _world.MaxY - 1));

            if (WorldObjects.Exists(i => i.Position.Equals(pos)))
            {
                pos = GeneratePosition();
                if (WorldObjects.Count > (_world.MaxX * _world.MaxY) / 2)
                {
                    throw new Exception("The world is too small for so many monsters.");
                }
            }

            return pos;
        }
    }
}
