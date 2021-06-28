using System;
using System.Collections.Generic;

namespace Game.Core
{
    internal class Cell : IDrawable
    {
        public int X { get; }
        public int Y { get; }
        public string Symbol => ". ";
        public ConsoleColor Color { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Cell(int y, int x)
        {
            Color = ConsoleColor.Red;
            Y = y;
            X = x;
        }
    }
}