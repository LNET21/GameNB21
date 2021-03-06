using Game.Core.Entities.Creatures;
using Game.Core.ExtensionMethods;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using Game.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace Game.Core.Entities
{
    public class ConsoleMap : IMap
    {

        private Cell[,] cells;
        public int Width { get; }
        public int Height { get; }

        public List<Creature> Creatures { get; set; } = new List<Creature>();

        public ConsoleMap(IConfiguration config/* Mapsettings mapsettings*/ /*IOptions<Mapsettings> options*/ /*IMapService mapService*/)
        {
            Width = config.GetMapSizeFor("x");
            Height = config.GetMapSizeFor("y");

            //Width = options.Value.X;
            //Height = options.Value.Y;

            //(Width, Height) = mapService.GetMap();

            cells = new Cell[Height, Width];

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    cells[y, x] = new Cell(new Position(y, x));
                }
            }
        }

        public Cell GetCell(int y, int x)
        {
            //return x < 0 || x >= Width || y < 0 || y >= Height ? null : cells[y, x];

            if (x < 0 || x >= Width || y < 0 || y >= Height)
            {
                return null;
            }

            return cells[y, x];
        }

        //See Extensions
        public IDrawable CreatureAt(Cell cell)
        {
            return Creatures.FirstOrDefault(creature => creature.Cell == cell);
        }

        public Cell GetCell(Position newPosition)
        {
            return GetCell(newPosition.Y, newPosition.X);
        }

        public void Place(Creature creature)
        {
            if (Creatures.Where(c => c.Cell == creature?.Cell).Any())
                creature = null;
            else
                Creatures.Add(creature);
        }
    }
}