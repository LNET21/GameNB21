using System;

namespace Game.Core.GameWorld.Interfaces
{
    internal interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}