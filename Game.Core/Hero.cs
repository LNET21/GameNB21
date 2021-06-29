using Game.LimitedList;
using System;

namespace Game.Core
{
    internal class Hero : Creature
    {
        public LimitedList<Item> BackBack { get; }
        public Hero(Cell cell) : base(cell, "H ")
        {
            Color = ConsoleColor.Yellow;
            BackBack = new LimitedList<Item>(3); //ToDo read from config
        }
    }
}