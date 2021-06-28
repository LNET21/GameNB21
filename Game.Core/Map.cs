using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game.Core
{
    internal class Map
    {

        private Cell[,] cells;
        public int Width { get; }
        public int Height { get; }

        public List<Creature> Creatures { get; set; } = new List<Creature>();

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            cells = new Cell[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cells[y, x] = new Cell(y, x);
                }
            }
        }

        internal Cell GetCell(int y, int x)
        {
            //return x < 0 || x >= Width || y < 0 || y >= Height ? null : cells[y, x];

            if (x < 0 || x >= Width || y < 0 || y >= Height)
            {
                return null;
            }

            return cells[y, x];
        }
    }
}