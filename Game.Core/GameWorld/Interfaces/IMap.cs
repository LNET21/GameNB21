using Game.Core.Entities.Creatures;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using System.Collections.Generic;

namespace Game.Core.GameWorld.Interfaces
{
    public interface IMap
    {
        List<Creature> Creatures { get; set; }
        int Height { get; }
        int Width { get; }

        IDrawable CreatureAt(Cell cell);
        Cell GetCell(int y, int x);
        Cell GetCell(Position newPosition);
        void Place(Creature creature);
    }
}