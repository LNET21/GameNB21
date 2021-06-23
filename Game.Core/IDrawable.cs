using System;

namespace Game.Core
{
    internal interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}