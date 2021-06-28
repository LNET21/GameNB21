using System;

namespace Game.Core
{
    abstract class Creature : IDrawable
    {
        public string Symbol { get; set; }
        public ConsoleColor Color { get; set; } = ConsoleColor.Green;
        public Cell Cell { get; set; }

        public Creature(Cell cell, string symbol)
        {
            Cell = cell;
            Symbol = symbol;
        }
    }
}