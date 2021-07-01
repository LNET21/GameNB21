using Game.Core.GameWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core.Entities.Creatures
{
    class Troll : Creature
    {
        public Troll(Cell cell, int maxHealth) : base(cell, "T ", maxHealth)
        {
            Damage = 30;
        }
    }
}
