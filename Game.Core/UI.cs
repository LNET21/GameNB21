using Game.Core.Entities;
using Game.Core.ExtensionMethods;
using Game.Core.GameWorld;
using Game.Core.GameWorld.Interfaces;
using Game.LimitedList;
using System;
using System.Linq;

namespace Game.Core
{
    public class UI
    {
        private static MessageLog<string> messageLog = new MessageLog<string>(6);
        public static void Clear()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }

        public static ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: true).Key;
        }

        public static void Draw(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);

                    IDrawable drawable = (map.CreatureAt(cell) ?? cell.Items.FirstOrDefault()) ??
                      cell;

                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AddMessage(string message) => messageLog.Add(message);

        public static void PrintLog()
        {
            messageLog.ActionOutputAll(m => Console.WriteLine(m + new string(' ', Console.WindowWidth - m.Length)));
        }

        public static void PrintStats(string stats)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(stats + new string(' ', Console.WindowWidth - stats.Length));
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}