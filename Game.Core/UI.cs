using System;

namespace Game.Core
{
    internal class UI
    {
        internal static void Clear()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }
    }
}