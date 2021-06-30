using Game.Core.Entities;
using Game.Core.ExtensionMethods;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using System;
using System.Linq;

namespace Game.Core
{
    internal class UI
    {
        internal static void Clear()
        {
            //Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }

        internal static ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: true).Key;
        }

        internal static void Draw(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);

                    IDrawable drawable = (map.Creatures.CreatureAtExtension(cell) ?? cell.Items.FirstOrDefault()) ??
                      cell;

                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}