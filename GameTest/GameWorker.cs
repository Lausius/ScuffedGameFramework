using ScuffedGameFramework;
using ScuffedGameFramework.Creatures;
using ScuffedGameFramework.Creatures.ConcreteCreatures;
using ScuffedGameFramework.Creatures.CreatureDecorators;
using ScuffedGameFramework.Creatures.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class GameWorker
    {
        private World _world;
        private Player _player;
        private readonly JsonTraceListener _logger;
        private CreatureFactory _creatureFactory;

        public GameWorker()
        {
            _world = new World();
            // WILL BE CLASS FACTORY
            _player = new Warrior("Lausius");

            _logger = new JsonTraceListener();
            _creatureFactory = new CreatureFactory(_world, _player, _logger);
            SpawnCreatures(10);
        }

        public void SpawnCreatures(int numberOfMonsters)
        {
            for (int i = 0; i < (_world.MaxX * _world.MaxY) / numberOfMonsters; i++)
            {
                _creatureFactory.CreateCreature();
            }
        }

        public void DrawWorldObjects()
        {

            foreach (var worldObject in _creatureFactory.WorldObjects)
            {
                worldObject.DrawWorldObject();
            }
        }

        public void UpdateWorld()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            _world.DrawSquareWorld();

            DrawWorldObjects();

        }

        public void HandleInput()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {

                case ConsoleKey.UpArrow:
                    if (_world.IsPositionWalkable(_player.Position.X, _player.Position.Y - 1))
                    {
                        _player.Position.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (_world.IsPositionWalkable(_player.Position.X, _player.Position.Y + 1))
                    {

                        _player.Position.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (_world.IsPositionWalkable(_player.Position.X - 1, _player.Position.Y))
                    {
                        _player.Position.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (_world.IsPositionWalkable(_player.Position.X + 1, _player.Position.Y))
                    {

                        _player.Position.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }

        public void RunGameLoop()
        {
            _creatureFactory.GenerateRandomBoss();

            while (!_player.Dead)
            {
                UpdateWorld();

                HandleInput();

                CheckForMonster();

                System.Threading.Thread.Sleep(20);
            }
        }

        public void CheckForMonster()
        {
            var playerVsMonster = _creatureFactory.WorldObjects.FindAll(i => i.Position.Equals(_player.Position));

            if (playerVsMonster.Count == 2)
            {
                Monster monster = (Monster)playerVsMonster.Find(i => i.Name != _player.Name);
                _player.EngageFight(monster);
                _creatureFactory.WorldObjects.Remove(monster);
            }
        }
    }
}
