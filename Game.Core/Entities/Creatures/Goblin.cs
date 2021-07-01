using Game.Core.GameWorld;
using System;

namespace Game.Core.Entities.Creatures
{
    class Goblin : Creature
    {
        public Goblin(Cell cell, int maxHealth) : base(cell, "G ", maxHealth)
        {
            Damage = 15;
            Color = ConsoleColor.DarkMagenta;
        }
    }
}
