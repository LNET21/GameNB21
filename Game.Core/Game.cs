using System;

namespace Game.Core
{
    internal class Game
    {
        private Map map;
        private Hero hero;

        internal void Run()
        {
            Initailize();
            Play();
        }

        private void Play()
        {
            throw new NotImplementedException();
        }

        private void Initailize()
        {
            //Todo: Read from config
            map = new Map(width: 10, height: 10);
            hero = new Hero();
        }
    }
}