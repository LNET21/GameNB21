using Game.Core.Entities.Items;
using Game.Core.GameWorld.Interfaces;
using System;
using System.Collections.Generic;

namespace Game.Core.GameWorld
{
    public class Cell : IDrawable
    {
        public Position Position { get; set; }
        public string Symbol => ". ";
        public ConsoleColor Color { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Cell(Position position)
        {
            Color = ConsoleColor.Red;
            Position = position;
        }
    }
}