using Game.Core.GameWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core.Entities.Creatures
{
    class Orc : Creature
    {
        public Orc(Cell cell, int maxHealth) : base(cell, "O ", maxHealth)
        {
            Damage = 40;
            Color = ConsoleColor.Green;
        }
    }
}
