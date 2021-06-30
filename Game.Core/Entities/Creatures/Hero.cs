using Game.Core.Entities.Items;
using Game.Core.GameWorld;
using Game.LimitedList;
using System;

namespace Game.Core.Entities.Creatures
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