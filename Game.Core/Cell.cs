using System;
using System.Collections.Generic;

namespace Game.Core
{
    internal class Cell : IDrawable
    {
        public string Symbol => ". ";
        public ConsoleColor Color { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Cell()
        {
            Color = ConsoleColor.Red;
        }
    }
}