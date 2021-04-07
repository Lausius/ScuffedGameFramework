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
            GameWorker game = new GameWorker();
            game.RunGameLoop();

            Console.ReadLine();
        }
    }
}
