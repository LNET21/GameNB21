using System;

namespace Game.Core.GameWorld.Interfaces
{
    public interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}